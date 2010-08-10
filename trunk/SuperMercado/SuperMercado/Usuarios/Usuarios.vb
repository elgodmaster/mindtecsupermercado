Imports MindTec.Componentes

Public Class Usuarios

#Region "  Variables de trabajo  "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    Dim modificaronCampos As Boolean
    Dim usuarioOriginal As String
    Dim usuarioNuevo As String
#End Region

#Region "  Boton BUSCAR  "
    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Usuarios()
    End Sub
#End Region

#Region "  Botón NUEVO  "
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        limpiarPantalla()
        mostrarControles()
        mostrarBotonesEditar()

        usuarioOriginal = ""

    End Sub
#End Region

#Region "  Bótón ACEPTAR  "
    Private Sub buttonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If textBoxUsuario.Text.Trim = "" Then
            MessageBox.Show("Escriba el nombre del usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxUsuario.Focus()
            Return
        End If

        consulta124()

    End Sub
#End Region

#Region "  Botón LIMPIAR  "
    Private Sub ButtonLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        limpiarPantalla()
    End Sub
#End Region

#Region "  Botón GRABAR  "
    Private Sub ButtonGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grabar.Click
        Dim Result As DialogResult
        '<Validación>
        If txtUsuario.Text.Trim = "" Then
            MessageBox.Show("Escriba el nombre del usuario.", " Permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textBoxUsuario.Focus()
            Return
        End If

        If TextBoxNombreCompleto.Text.Trim = "" Then
            MessageBox.Show("Escriba el nombre completo del usuario.", " Permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxNombreCompleto.Focus()
            Return
        End If

        If TextBoxContraseña.Text.Trim = "" Then
            MessageBox.Show("Escriba la contraseña del usuario.", " Permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxContraseña.Focus()
            Return
        End If

        If ComboBoxTipoPermiso.Text.Trim = "" Then
            MessageBox.Show("Seleccione el tipo de permiso del usuario.", " Permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBoxTipoPermiso.Focus()
            Return
        End If
        '<\Validación>

        Result = MessageBox.Show("¿Desea guardar los cambios?", "Permisos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = Windows.Forms.DialogResult.Yes Then

            grabrar122()

            If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), " Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarPantalla()
                ocultarControles()
                ocultarBotonesEditar()
            Else
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), " Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Return
        End If
    End Sub
#End Region

#Region "  Evento: Usuarios LOAD  "
    Private Sub Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        textBoxUsuario.Enabled = True
        Grabar.Visible = False
        ocultarControles()

        'Carga el comboBox
        Caja = "Consulta123" : Parametros = ""
        ObjRet = lConsulta.LlamarCaja(Caja, 2, Parametros)

        ComboBoxTipoPermiso.DataSource = ObjRet.DS.Tables(0)
        ComboBoxTipoPermiso.DisplayMember = ObjRet.DS.Tables(0).Columns(0).Caption.ToString.Trim

        llenarCheckBox()
    End Sub
#End Region

#Region "  Evento: textBoxNombrePermiso KEYDOWN   "
    Private Sub CodigoCliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textBoxUsuario.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Usuarios()
            Case Keys.Enter

        End Select
    End Sub
#End Region

#Region "  Evento: ComboBoxTipoPermiso DROP_DOWN_CLOSED  "
    Private Sub ComboBoxTipoPermiso_DropDownClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTipoPermiso.DropDownClosed
        llenarCheckBox()
    End Sub
#End Region

#Region "  Rutina: ocultarControles  "
    Private Sub ocultarControles()

        GroupBoxDatos.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        ComboBoxTipoPermiso.Visible = False
        GroupBoxCaja.Visible = False
        GroupBoxCatalogos.Visible = False
        GroupBoxConfiguracion.Visible = False
        GroupBoxFacturacion.Visible = False
        GroupBoxInventario.Visible = False
        GroupBoxReportes.Visible = False
        GroupBoxSeguridad.Visible = False

        textBoxUsuario.Enabled = True
        textBoxUsuario.Focus()
    End Sub
#End Region

#Region "  Rutina: mostrarControles  "
    Private Sub mostrarControles()
        GroupBoxDatos.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        ComboBoxTipoPermiso.Visible = True
        GroupBoxCaja.Visible = True
        GroupBoxCatalogos.Visible = True
        GroupBoxConfiguracion.Visible = True
        GroupBoxFacturacion.Visible = True
        GroupBoxInventario.Visible = True
        GroupBoxReportes.Visible = True
        GroupBoxSeguridad.Visible = True

        textBoxUsuario.Enabled = False
        txtUsuario.Focus()
    End Sub
#End Region

#Region "  Rutina: grabar122  "
    Sub grabrar122()
        Caja = "Grabar122"
        Parametros = "V1=" & usuarioOriginal & _
                     "|V2=" & TextBoxNombreCompleto.Text.Trim & _
                     "|V3=" & TextBoxContraseña.Text.Trim & _
                     "|V4=" & ComboBoxTipoPermiso.Text.Trim & _
                     "|V5=" & txtUsuario.Text.Trim & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
    End Sub
#End Region

#Region "  Rutina: Consulta124  "
    Sub consulta124()

        Caja = "Consulta124" : Parametros = "V1=" & textBoxUsuario.Text.Trim & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

        If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then

            txtUsuario.Text = ObjRet.DS.Tables(0).Rows(0).Item(0)
            TextBoxContraseña.Text = ObjRet.DS.Tables(0).Rows(0).Item(1)
            TextBoxNombreCompleto.Text = ObjRet.DS.Tables(0).Rows(0).Item(2)
            ComboBoxTipoPermiso.Text = ObjRet.DS.Tables(0).Rows(0).Item(3).ToString.Trim

            usuarioOriginal = txtUsuario.Text.Trim

            llenarCheckBox()

            mostrarControles()
            mostrarBotonesEditar()
        Else
            TextBoxNombreCompleto.Focus()
            mostrarControles()
            mostrarBotonesEditar()

        End If
    End Sub
#End Region

#Region "  Rutina: llenarCheckBox  "
    Private Sub llenarCheckBox()
        Caja = "Consulta122" : Parametros = "V1=" & ComboBoxTipoPermiso.Text.Trim & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        'Reportes
        CheckBoxRepProd.Checked = ObjRet.DS.Tables(0).Rows(0).Item(0)
        CheckBoxRepEntPro.Checked = ObjRet.DS.Tables(0).Rows(0).Item(1)
        CheckBoxRepSalPro.Checked = ObjRet.DS.Tables(0).Rows(0).Item(2)
        CheckBoxRepClie.Checked = ObjRet.DS.Tables(0).Rows(0).Item(3)

        CheckBoxRepProv.Checked = ObjRet.DS.Tables(0).Rows(0).Item(4)
        CheckBoxRepFac.Checked = ObjRet.DS.Tables(0).Rows(0).Item(5)
        CheckBoxRepVen.Checked = ObjRet.DS.Tables(0).Rows(0).Item(6)
        CheckBoxRepRetEfec.Checked = ObjRet.DS.Tables(0).Rows(0).Item(7)

        CheckBoxRepDepEfec.Checked = ObjRet.DS.Tables(0).Rows(0).Item(8)

        'Catálogos
        CheckBoxCatDep.Checked = ObjRet.DS.Tables(0).Rows(0).Item(9)
        CheckBoxCatCat.Checked = ObjRet.DS.Tables(0).Rows(0).Item(10)
        CheckBoxCatMar.Checked = ObjRet.DS.Tables(0).Rows(0).Item(11)
        CheckBoxCatPro.Checked = ObjRet.DS.Tables(0).Rows(0).Item(12)

        CheckBoxCatClie.Checked = ObjRet.DS.Tables(0).Rows(0).Item(13)
        CheckBoxCatProv.Checked = ObjRet.DS.Tables(0).Rows(0).Item(14)
        CheckBoxCatUni.Checked = ObjRet.DS.Tables(0).Rows(0).Item(15)

        'Facturas
        CheckBoxFacFac.Checked = ObjRet.DS.Tables(0).Rows(0).Item(16)
        CheckBoxFacCot.Checked = ObjRet.DS.Tables(0).Rows(0).Item(17)

        'Inventarios
        CheckBoxInvMov.Checked = ObjRet.DS.Tables(0).Rows(0).Item(18)
        CheckBoxInvCon.Checked = ObjRet.DS.Tables(0).Rows(0).Item(19)

        'Caja
        CheckBoxCajaCorte.Checked = ObjRet.DS.Tables(0).Rows(0).Item(20)
        CheckBoxCajaEnt.Checked = ObjRet.DS.Tables(0).Rows(0).Item(21)
        CheckBoxCajaSal.Checked = ObjRet.DS.Tables(0).Rows(0).Item(22)

        'Seguridad
        CheckBoxSegUsu.Checked = ObjRet.DS.Tables(0).Rows(0).Item(23)
        CheckBoxSegPer.Checked = ObjRet.DS.Tables(0).Rows(0).Item(24)

        'Configuración
        CheckBoxConCaja.Checked = ObjRet.DS.Tables(0).Rows(0).Item(25)
        CheckBoxConFac.Checked = ObjRet.DS.Tables(0).Rows(0).Item(26)
        CheckBoxConTic.Checked = ObjRet.DS.Tables(0).Rows(0).Item(27)
    End Sub
#End Region

#Region "  Rutina: Usuarios  "
    Sub Usuarios()
        Caja = "Consulta121" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.textBoxUsuario.Text = nuevo.resultado

            If nuevo.resultado = "" Then
                Return
            End If

            consulta124()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub
#End Region

#Region "  Rutina: mostrarBotonesEditar  "
    Sub mostrarBotonesEditar()
        Limpiar.Visible = True
        Grabar.Visible = True
    End Sub
#End Region

#Region "  Rutina: ocultarBotonesEditar  "
    Sub ocultarBotonesEditar()
        Limpiar.Visible = False
        Grabar.Visible = False
    End Sub
#End Region

#Region "  Rutina: limpiarPantalla  "
    Private Sub limpiarPantalla()
        textBoxUsuario.Clear()
        txtUsuario.Clear()
        TextBoxContraseña.Clear()
        TextBoxNombreCompleto.Clear()
    End Sub
#End Region

#Region "  Cambio de TextBox con ENTER  "
    Private Sub txtUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TextBoxNombreCompleto.Focus()
        End If
    End Sub

    Private Sub TextBoxNombreCompleto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxNombreCompleto.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxContraseña.Focus()
        End If
    End Sub

    Private Sub TextBoxContraseña_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBoxTipoPermiso.Focus()
        End If
    End Sub
#End Region

#Region "  Evento: textBoxUsuario - KEY PRESS  "
    Private Sub textBoxUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            consulta124()
        End If
    End Sub
#End Region
    

End Class