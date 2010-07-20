Imports MindTec.Componentes

Public Class Cat_Productos

#Region "  Variables de trabajo  "

    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    Dim copiaCodigo As String

#End Region

#Region "  Evento: Cat_Productos - LOAD  "
    Private Sub Cat_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ocultarGroupBox()
        keyCodigo.Focus()

    End Sub
#End Region

#Region "  Botón BUSCAR  "
    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        catalogo()
    End Sub
#End Region

#Region "  Botón GRABAR  "
    Private Sub Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grabar.Click
        grabar129()

        ocultarBotonesEditar()
        ocultarGroupBox()

        keyCodigo.Clear()
        keyCodigo.Focus()

    End Sub
#End Region

#Region "  Rutina: ocultarGroupBox  "
    Sub ocultarGroupBox()
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
    End Sub
#End Region

#Region "  Rutina: mostrarGroupBox  "
    Sub mostrarGroupBox()
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True
    End Sub
#End Region

#Region "  Rutina: mostrarBotonesEditar  "
    Sub mostrarBotonesEditar()
        Grabar.Visible = True
        Limpiar.Visible = True
    End Sub
#End Region

#Region "  Rutina: ocultarBotonesEditar  "
    Sub ocultarBotonesEditar()
        Grabar.Visible = False
        Limpiar.Visible = False
    End Sub
#End Region

#Region "  Rutina: catalogo  "
    Sub catalogo()
        Caja = "Consulta135" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            If nuevo.resultado = "" Then
                Return
            End If

            keyCodigo.Text = nuevo.resultado
            consulta136()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub
#End Region

#Region "  Rutina: consulta136  "
    Sub consulta136()
        mostrarGroupBox()
        mostrarBotonesEditar()

        existencia.Visible = False
        Label13.Visible = False

        Caja = "Consulta136" : Parametros = "V1=" & keyCodigo.Text.Trim
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        If ObjRet.bOk Then
            descripcion.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            codigo.Text = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|")
            unidad.Text = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
            categoria.Text = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|")
            marca.Text = lConsulta.ObtenerValor("V5", ObjRet.sResultado, "|")
            departamento.Text = lConsulta.ObtenerValor("V6", ObjRet.sResultado, "|")

            costoCompra.Value = lConsulta.ObtenerValor("V7", ObjRet.sResultado, "|")
            precioVenta.Value = lConsulta.ObtenerValor("V8", ObjRet.sResultado, "|")

            stockMinimo.Value = lConsulta.ObtenerValor("V9", ObjRet.sResultado, "|")
        Else
            MessageBox.Show("El codigo de ese producto no ha sido dado de alta.", " Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        copiaCodigo = codigo.Text

        keyCodigo.SelectAll()
        keyCodigo.Focus()

    End Sub
#End Region

#Region "  Rutina: grabar129  "
    Sub grabar129()
        Caja = "GRABAR129" : Parametros = "V0=" & copiaCodigo.Trim & _
                                          "|V1=" & descripcion.Text.Trim & _
                                          "|V2=" & codigo.Text.Trim & _
                                          "|V3=" & unidad.Text.Trim & _
                                          "|V4=" & categoria.Text.Trim & _
                                          "|V5=" & marca.Text.Trim & _
                                          "|V6=" & departamento.Text.Trim & _
                                          "|V7=" & costoCompra.Value.ToString & _
                                          "|V8=" & precioVenta.Value.ToString & _
                                          "|V9=" & stockMinimo.Value.ToString & _
                                          "|V10=" & existencia.Value.ToString & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

    End Sub
#End Region

#Region "  Evento: keyCodigo - KEY PRESS  "
    Private Sub keyCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles keyCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            consulta136()

        End If
    End Sub
#End Region



End Class