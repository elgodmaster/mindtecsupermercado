Imports System
Imports System.Drawing.Printing

Public Class Tickets

#Region "  Variables de trabajo  "
    ' Variables para la consulta.
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
#End Region

#Region "  Evento: Tickets LOAD  "
    Private Sub Tickets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        cargaImpresoras()
        cargaLineasTicket()
    End Sub
#End Region

#Region "  Botón IMPRIMIR  "
    Private Sub ButtonImprimir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonImprimir.Click
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
        ticket.AddItem("1", "Articulo Prueba", "15.00")
        ticket.AddItem("2", "Articulo Prueba", "25.00")

        'El metodo AddTotal requiere 2 parametros, la descripcion del total, y el precio
        ticket.AddTotal("SUBTOTAL", "29.75")
        ticket.AddTotal("IVA", "5.25")
        ticket.AddTotal("TOTAL", "35.00")
        ticket.AddTotal("", "") 'Ponemos un total en blanco que sirve de espacio
        ticket.AddTotal("RECIBIDO", "50.00")
        ticket.AddTotal("CAMBIO", "15.00")
        ticket.AddTotal("", "") 'Ponemos un total en blanco que sirve de espacio
        ticket.AddTotal("USTED AHORRO", "0.00")

        'El metodo AddFooterLine funciona igual que la cabecera

        ticket.AddFooterLine(ObjRet.DS.Tables(0).Rows(0).Item(5).ToString.Trim)
        ticket.AddFooterLine(ObjRet.DS.Tables(0).Rows(0).Item(6).ToString.Trim)
        ticket.AddFooterLine(ObjRet.DS.Tables(0).Rows(0).Item(7).ToString.Trim)

        'Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un
        'parametro de tipo string que debe de ser el nombre de la impresora.
        'ticket.PrintTicket("EPSON TM-U220 Receipt"); 
        ticket.PrintTicket(ObjRet.DS.Tables(0).Rows(0).Item(0).ToString.Trim)
    End Sub
#End Region

#Region "  Botón GRABAR  "
    Private Sub ButtonGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGrabar.Click
        Dim Result As DialogResult

        Result = MessageBox.Show("¿Desea guardar los cambios?", "Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = Windows.Forms.DialogResult.Yes Then
            Caja = "GRABAR123"
            Parametros = "V1=" & ComboBoxImpresoras.Text.Trim & _
                         "|V2=" & TextBox1.Text.Trim & _
                         "|V3=" & TextBox2.Text.Trim & _
                         "|V4=" & TextBox3.Text.Trim & _
                         "|V5=" & TextBox4.Text.Trim & _
                         "|V6=" & TextBox5.Text.Trim & _
                         "|V7=" & TextBox6.Text.Trim & _
                         "|V8=" & TextBox7.Text.Trim

            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
            If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), " Tickets", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cargaLineasTicket()
            End If
        Else
            Return
        End If
    End Sub
#End Region

#Region "  Rutina: cargaImpresoras  "
    Private Sub cargaImpresoras()

        Dim pd As New PrintDocument
        Dim Impresoras As String

        ' Default printer      
        Dim s_Default_Printer As String = pd.PrinterSettings.PrinterName

        ' recorre las impresoras instaladas  
        For Each Impresoras In PrinterSettings.InstalledPrinters
            ComboBoxImpresoras.Items.Add(Impresoras.ToString)
        Next
        ' selecciona la impresora predeterminada  
        ComboBoxImpresoras.Text = s_Default_Printer
    End Sub
#End Region

#Region "  Rutina: cargaLineasTicket  "
    Private Sub cargaLineasTicket()
        Caja = "Consulta126" : Parametros = ""
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        ComboBoxImpresoras.Text = ObjRet.DS.Tables(0).Rows(0).Item(0)
        TextBox1.Text = ObjRet.DS.Tables(0).Rows(0).Item(1)
        TextBox2.Text = ObjRet.DS.Tables(0).Rows(0).Item(2)
        TextBox3.Text = ObjRet.DS.Tables(0).Rows(0).Item(3)
        TextBox4.Text = ObjRet.DS.Tables(0).Rows(0).Item(4)
        TextBox5.Text = ObjRet.DS.Tables(0).Rows(0).Item(5)
        TextBox6.Text = ObjRet.DS.Tables(0).Rows(0).Item(6)
        TextBox7.Text = ObjRet.DS.Tables(0).Rows(0).Item(7)

    End Sub
#End Region
    
#Region "  Cambio de TextBox con ENTER  "
    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox5_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox6.Focus()
        End If
    End Sub

    Private Sub TextBox6_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox7.Focus()
        End If
    End Sub
#End Region

End Class