Imports MindTec.Componentes

Public Class Credito

#Region "  Variables de Trabajo  "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Dim Total As Double
    Dim DsDatosCuenta As DataSet
    Dim IdCuenta As Integer
    Dim Cventa As ModuloVentas = ModuloVentas.Instance
#End Region

#Region "  Evento: Credito - LOAD  "
    Private Sub Credito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ObtenerIdCuenta()

        consulta128()

        ComboBoxNombreCliente.DataSource = ObjRet.DS.Tables(0)
        ComboBoxNombreCliente.DisplayMember = ObjRet.DS.Tables(0).Columns(1).Caption.ToString
        'ComboBoxNombreCliente.Text = "LINDOR"

        ComboBoxNombreCliente.Select(0, 50)
        ComboBoxNombreCliente.Focus()
    End Sub
#End Region

#Region "  Evento: ComboBoxNombreCliente - DROP DOWN CLOSED  "
    Private Sub ComboBoxNombreCliente_DropDownClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxNombreCliente.DropDownClosed
        consulta105()

        textBoxCodigo.Text = lConsulta.ObtenerValor("V18", ObjRet.sResultado, "|")
        TextBoxCP.Text = lConsulta.ObtenerValor("V5", ObjRet.sResultado, "|")
        TextBoxDireccion.Text = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|")
        TextBoxRFC.Text = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|")
        TextBoxTelefono.Text = lConsulta.ObtenerValor("V8", ObjRet.sResultado, "|")
    End Sub
#End Region

#Region "  Botón CARGAR VENTA  "
    Private Sub ButtonCargarVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCargarVenta.Click
        Dim Radio As String = ""

        If ComboBoxNombreCliente.Text = "" Then
            Return
        End If

        If Me.RBUnArticulo.Checked = True Then
            Radio = Me.DsDatosCuenta.Tables("Table").Rows(0).Item("C2")
        Else
            Radio = "Varios Artículos"
        End If

        Caja = "Grabar116" : Parametros = "V1=" & IdCuenta & "|V2=|V3=0|V4=" & idUsuario & "|V5=" & Me.textBoxCodigo.Text & "|V6=0|V7=" & Radio & "|V8=" & Me.Total & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros, DsDatosCuenta)

        'Estatus
        If ObjRet.bOk Then
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            Total = 0
            Me.Close()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub
#End Region

#Region "  Rutina: VentaCreditos  "
    Friend Sub VentaCreditos(ByRef TotalVentas As Double, ByVal DsDatos As DataSet, ByRef ClaseVentas As ModuloVentas)
        Total = TotalVentas
        DsDatosCuenta = DsDatos
        Cventa = ClaseVentas
    End Sub
#End Region

#Region "  Rutina: ObtenerIdCuenta  "
    Sub ObtenerIdCuenta()
        Caja = "Consulta116" : Parametros = "V1=" & idUsuario & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "5", Parametros)
        If ObjRet.bOk Then
            IdCuenta = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)
        End If
    End Sub
#End Region

#Region "  Rutina: consulta105  "
    Sub consulta105()
        'Regresa algunos campos de un cliente.
        Caja = "Consulta105" : Parametros = "V1=" & ComboBoxNombreCliente.Text.Trim & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
    End Sub
#End Region

#Region "  Rutina: consulta128  "
    Sub consulta128()
        'Devuelve la lista de todos los clientes.
        Caja = "consulta128" : Parametros = ""
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
    End Sub
#End Region

End Class