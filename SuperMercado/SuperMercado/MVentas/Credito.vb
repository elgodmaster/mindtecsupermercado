Imports MindTec.Componentes

Public Class Credito

#Region " Variables de Trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Dim Total As Double
    Dim DsDatosCuenta As DataSet
    Dim Usuario As Integer
    Dim IdCuenta As Integer
    Dim Cventa As New ModuloVentas
#End Region

    Friend Sub VentaCreditos(ByVal TotalVentas As Double, ByVal DsDatos As DataSet, ByVal User As Integer, ByRef ClaseVentas As ModuloVentas)
        Total = TotalVentas
        DsDatosCuenta = DsDatos
        Usuario = User
        Cventa = ClaseVentas
    End Sub

    Sub CatalogoClientes()
        Caja = "Consulta105" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.CodigoCliente.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.CodigoCliente_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

        End If
    End Sub

    Private Sub CodigoCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoCliente.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoClientes()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta105" : Parametros = "V1=" & Me.CodigoCliente.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    BtnAceptar.PerformClick()
                End If
        End Select
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Caja = "Consulta105" : Parametros = "V1=" & Me.CodigoCliente.Text
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
        'Estatus
        If ObjRet.bOk Then
            'Asignar
            Me.NombreCliente.Text = Me.NombreCliente.Text & " " & lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            Me.RFC.Text = Me.RFC.Text & " " & lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|")
            Me.Direccion.Text = Me.Direccion.Text & " " & lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|") & " " & lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
            Me.Telefono.Text = Me.Telefono.Text & " " & lConsulta.ObtenerValor("V8", ObjRet.sResultado, "|")
            Me.CP.Text = Me.CP.Text & " " & lConsulta.ObtenerValor("V5", ObjRet.sResultado, "|")

            Me.GroupBox1.Visible = True
            Me.BtnAceptar.Enabled = False
            Me.CodigoCliente.Enabled = False
            Me.Nuevo.Visible = False

        End If
    End Sub

    Sub LimpiarPantalla()
        NombreCliente.Text = "Nombre"
        RFC.Text = "RFC"
        Direccion.Text = " Direccion "
        CP.Text = "CP"
        Telefono.Text = "Teléfono"
        CodigoCliente.Text = ""
        BtnAceptar.Enabled = True
        CodigoCliente.Enabled = True
        Me.RBUnArticulo.Checked = True
    End Sub

    Sub ObtenerIdCuenta()
        Caja = "Consulta116" : Parametros = "V1=" & Usuario & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "5", Parametros)
        If ObjRet.bOk Then
            IdCuenta = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)
        End If
    End Sub

#Region " Cargar Venta "
    Private Sub BtnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCargar.Click
        Dim Radio As String = ""
        If Me.RBUnArticulo.Checked = True Then
            Radio = Me.DsDatosCuenta.Tables("Table").Rows(0).Item("C2")
        Else
            Radio = "Varios Articulos"
        End If

        Caja = "Grabar116" : Parametros = "V1=" & IdCuenta & "|V2=|V3=0|V4=" & Usuario & "|V5=" & Me.CodigoCliente.Text & "|V6=0|V7=" & Radio & "|V8=" & Me.Total & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros, DsDatosCuenta)


        'Estatus
        If ObjRet.bOk Then
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            cerrar()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            LimpiarPantalla()
        End If
    End Sub
#End Region

    Private Sub Credito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Limpiar.PerformClick()
            Case Keys.F5
                BtnCargar.PerformClick()
        End Select
    End Sub

    Private Sub Credito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ObtenerIdCuenta()
    End Sub

    Sub cerrar()
        Cventa.LimpiarPantalla()
        Me.Close()
    End Sub

    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        LimpiarPantalla()
    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        Dim NCLiente As New Cat_Clientes
        NCLiente.StartPosition = FormStartPosition.CenterScreen
        NCLiente.WindowState = FormWindowState.Maximized
        NCLiente.Show()
    End Sub
End Class