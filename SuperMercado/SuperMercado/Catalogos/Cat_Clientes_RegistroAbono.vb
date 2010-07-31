
Public Class Cat_Clientes_RegistroAbono

#Region "  Variables de trabajo  "
    ' Variables para la consulta.
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    Dim pos As Integer
    Dim montoAbono As String
    Dim cuenta As String
    Dim usuarioAbono As String
    Dim codigoCliente As String
    Dim dataSet As DataSet
    Dim DsViewCuentas As Object
    Dim lblSaldoActual As Label
    Dim nombreCliente As String

    Public nomCliente As String
    Public idCliente As String
    Public codigo As String

#End Region

#Region "  Botón ACEPTAR  "
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If numAbono.Value <= 0 Then
            MessageBox.Show("No ha registrado la cantidad del abono.", " Abonos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            numAbono.Focus()
            numAbono.Select(0, 9)
            Return
        End If

        Dim adeudo As Decimal
        adeudo = dataSet.Tables(0).Rows(pos).Item(3)

        If numAbono.Value > adeudo Then
            MessageBox.Show("El abono es mayor que el adeudo", " Abonos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            numAbono.Focus()
            numAbono.Select(0, 9)
            Return
        End If

        montoAbono = numAbono.Value.ToString
        Caja = "GRABAR117"
        Parametros = "V1=" & cuenta & _
                     "|V2=" & montoAbono & _
                     "|V3=" & idUsuario & _
                     "|V4=" & codigo

        ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

        dataSet.Tables(0).Clear()

        '|-------------------------------------------
        '| Se actualiza los datos de su estado de cuenta.
        '|-------------------------------------------

        Caja = "Consulta117" : Parametros = "V1=" & codigo.Trim & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

        ' Se inserta la consulta en el Grid Cuentas.
        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables.Count > 0 Then
                    For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                        dataSet.Tables(0).ImportRow(ObjRet.DS.Tables(0).Rows(i))
                    Next
                    dataSet.Tables(0).AcceptChanges()
                    DsViewCuentas = dataSet.Tables(0).DefaultView
                    'Else
                    '   FilaVacia()

                End If
            End If
        End If

        Dim deudaActualizada As Double
        Try
            deudaActualizada = dataSet.Tables(0).Rows(pos).Item(3)
        Catch ex As Exception
            deudaActualizada = 0
        End Try

        Caja = "Consulta105" : Parametros = "V1=" & idCliente.Trim
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)

        lblSaldoActual.Text = "$ " & lConsulta.ObtenerValor("V17", ObjRet.sResultado, "|")

        Me.Close()

        'imprimeTicket(adeudo, numAbono.Value, deudaActualizada, nombreCliente)

    End Sub
#End Region

#Region "  Botón Cancelar  "
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
#End Region

#Region "  Rutina grabarAbono  "
    Friend Sub pasoVariables(ByVal posR As Integer, _
                             ByRef cuentaR As String, _
                             ByRef usuarioR As String, _
                             ByRef codigoR As String, _
                             ByRef dataSetR As DataSet, _
                             ByRef dsViewCuentasR As Object, _
                             ByRef labelR As Label, _
                             ByVal nombreClienteR As String)
        Me.pos = posR
        Me.cuenta = cuentaR
        Me.usuarioAbono = usuarioR
        Me.codigoCliente = codigoR
        Me.dataSet = dataSetR
        Me.DsViewCuentas = dsViewCuentasR
        Me.lblSaldoActual = labelR
        Me.nombreCliente = nombreClienteR

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