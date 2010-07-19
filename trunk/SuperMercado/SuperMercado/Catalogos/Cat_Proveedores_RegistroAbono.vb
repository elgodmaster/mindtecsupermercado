
Public Class Cat_Proveedores_RegistroAbono

#Region "  Variables de trabajo  "
    ' Variables para la consulta.
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    Public monto As Decimal
    Public adeudo As String
    Public ok As Boolean


#End Region

#Region "  Botón ACEPTAR  "
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If numAbono.Value <= 0 Then
            MessageBox.Show("No ha registrado la cantidad del abono.", " Abonos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            numAbono.Focus()
            numAbono.Select(0, 9)
            Return
        End If

        If numAbono.Value > Decimal.Parse(adeudo) Then
            MessageBox.Show("El monto es mayor al adeudo.", " Abonos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            numAbono.Focus()
            numAbono.Select(0, 9)
            Return
        End If

        monto = numAbono.Value
        ok = True

        Me.Close()

    End Sub
#End Region

#Region "  Botón Cancelar  "
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        ok = False
        Me.Close()
    End Sub
#End Region

#Region "  Evento LOAD  "
    Private Sub Cat_Clientes_RegistroAbono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        numAbono.Focus()
        numAbono.Select(0, 9)
    End Sub
#End Region

#Region "  Evento KeyDown  "
    Private Sub numAbono_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numAbono.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK_Button.Focus()
        End If
    End Sub
#End Region

#Region "  Rutina: imprimirTicket  "
    Private Sub imprimeTicket(ByVal deudaAntR As Double, _
                             ByVal abonoR As Double, _
                             ByVal deudaActR As Double, _
                             ByVal nombreClienteR As String)

        Dim ticket As New WindowsFormsApplication1.BarControls.Ticket

        'ticket.HeaderImage = "C:\imagen.jpg"; //esta propiedad no es obligatoria

        Caja = "Consulta126" : Parametros = ""
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        ticket.AddHeaderLine(ObjRet.DS.Tables(0).Rows(0).Item(1).ToString.Trim)
        ticket.AddHeaderLine(ObjRet.DS.Tables(0).Rows(0).Item(2).ToString.Trim)
        ticket.AddHeaderLine(ObjRet.DS.Tables(0).Rows(0).Item(3).ToString.Trim)
        ticket.AddHeaderLine(ObjRet.DS.Tables(0).Rows(0).Item(4).ToString.Trim)

        'El metodo AddSubHeaderLine es lo mismo al de AddHeaderLine con la diferencia
        'de que al final de cada linea agrega una linea punteada "=========="
        'ticket.AddSubHeaderLine("Caja # 1 - Ticket # 1")
        ticket.AddSubHeaderLine("Le atendió: " & nombreCompleto.Trim)
        ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())

        'El metodo AddItem requeire 3 parametros, el primero es cantidad, el segundo es la descripcion
        'del producto y el tercero es el precio
        'ticket.AddItem("1", "Articulo Prueba", "15.00")

        'El metodo AddTotal requiere 2 parametros, la descripcion del total, y el precio

        ticket.AddTotal("Cliente: " & nombreClienteR, "")
        ticket.AddTotal("", "") 'Ponemos un total en blanco que sirve de espacio
        ticket.AddTotal("DEUDA", deudaAntR.ToString("F"))
        ticket.AddTotal("ABONO", "-" & abonoR.ToString("F"))
        ticket.AddTotal("", "") 'Ponemos un total en blanco que sirve de espacio
        ticket.AddTotal("DEUDA ACTUAL", deudaActR.ToString("F"))
        ticket.AddTotal("", "") 'Ponemos un total en blanco que sirve de espacio

        'El metodo AddFooterLine funciona igual que la cabecera

        ticket.AddFooterLine(ObjRet.DS.Tables(0).Rows(0).Item(5).ToString.Trim)
        ticket.AddFooterLine(ObjRet.DS.Tables(0).Rows(0).Item(6).ToString.Trim)
        ticket.AddFooterLine(ObjRet.DS.Tables(0).Rows(0).Item(7).ToString.Trim)

        'Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un
        'parametro de tipo string que debe de ser el nombre de la impresora.
        'ticket.PrintTicket("EPSON TM-U220 Receipt"); 
        ticket.tipoImpresion = "abono"
        ticket.PrintTicket(ObjRet.DS.Tables(0).Rows(0).Item(0).ToString.Trim)
    End Sub
#End Region

End Class