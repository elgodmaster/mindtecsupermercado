Imports MindTec.Componentes

Public Class Usuarios

#Region "  Variables de trabajo  "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    Dim modificaronCampos As Boolean
#End Region

#Region "  Bótón ACEPTAR  "
    Private Sub buttonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAceptar.Click
        ButtonGrabar.Visible = True
        mostrarControles()

        Caja = "Consulta124" : Parametros = "V1=" & textBoxUsuario.Text.Trim & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

        If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then
            labelResul.Text = "Usuario registrado. Puede modificar cualquier valor y hacer clic en el botón guardar."
            llenarCampos(ObjRet.DS)
            buttonAceptar.Enabled = False
        Else
            labelResul.Text = "Usuario no registrado. LLene los campos necesarios y haga clic en el botón guardar."
            TextBoxNombreCompleto.Focus()
            mostrarControles()
            buttonAceptar.Enabled = False
        End If
    End Sub
#End Region

#Region "  Botón LIMPIAR  "
    Private Sub ButtonLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLimpiar.Click
        limpiarPantalla()
    End Sub
#End Region

#Region "  Botón GRABAR  "
    Private Sub ButtonGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGrabar.Click
        Dim Result As DialogResult
        '<Validación>
        If textBoxUsuario.Text.Trim = "" Then
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
            Caja = "Grabar122"
            Parametros = "V1=" & textBoxUsuario.Text.Trim & _
                         "|V2=" & TextBoxNombreCompleto.Text.Trim & _
                         "|V3=" & TextBoxContraseña.Text.Trim & _
                         "|V4=" & ComboBoxTipoPermiso.Text.Trim & "|"
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
            limpiarPantalla()
        Else
            Return
        End If
    End Sub
#End Region

#Region "  Evento: Usuarios LOAD  "
    Private Sub Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ButtonGrabar.Visible = False
        ocultarControles()
    End Sub
#End Region

#Region "  Evento: textBoxNombrePermiso KEYDOWN   "
    Private Sub CodigoCliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textBoxUsuario.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Usuarios()
            Case Keys.Enter
                buttonAceptar.Focus()
        End Select
    End Sub
#End Region

#Region "  Rutina: ocultarControles  "
    Private Sub ocultarControles()

        labelResul.Visible = False
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
    End Sub
#End Region

#Region "  Rutina: mostrarControles  "
    Private Sub mostrarControles()
        labelResul.Visible = True
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
    End Sub
#End Region

#Region "  Rutina: llenarCampos  "
    Private Sub llenarCampos(ByVal ds As DataSet)
        TextBoxContraseña.Text = ds.Tables(0).Rows(0).Item(1)
        TextBoxNombreCompleto.Text = ds.Tables(0).Rows(0).Item(2)
        ComboBoxTipoPermiso.Text = ds.Tables(0).Rows(0).Item(3).ToString.Trim

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
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.CodigoCliente_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub
#End Region

#Region "  Rutina: limpiarPantalla  "
    Private Sub limpiarPantalla()
        TextBoxContraseña.Clear()
        TextBoxNombreCompleto.Clear()
        textBoxUsuario.Clear()

        'Seguridad
        CheckBoxSegUsu.Checked = False
        CheckBoxSegPer.Checked = False
        'Reportes
        CheckBoxRepVen.Checked = False
        CheckBoxRepSalPro.Checked = False
        CheckBoxRepRetEfec.Checked = False
        CheckBoxRepProv.Checked = False
        CheckBoxRepProd.Checked = False
        CheckBoxRepFac.Checked = False
        CheckBoxRepEntPro.Checked = False
        CheckBoxRepDepEfec.Checked = False
        CheckBoxRepClie.Checked = False
        'Inventarios
        CheckBoxInvMov.Checked = False
        CheckBoxInvCon.Checked = False
        'Facturación
        CheckBoxFacFac.Checked = False
        CheckBoxFacCot.Checked = False
        'Configuración
        CheckBoxConTic.Checked = False
        CheckBoxConFac.Checked = False
        CheckBoxConCaja.Checked = False
        'Catálogos
        CheckBoxCatUni.Checked = False
        CheckBoxCatProv.Checked = False
        CheckBoxCatPro.Checked = False
        CheckBoxCatMar.Checked = False
        CheckBoxCatDep.Checked = False
        CheckBoxCatClie.Checked = False
        CheckBoxCatCat.Checked = False
        'Caja
        CheckBoxCajaCorte.Checked = False
        CheckBoxCajaEnt.Checked = False
        CheckBoxCajaSal.Checked = False

        ButtonGrabar.Visible = False
        buttonAceptar.Enabled = True
        textBoxUsuario.Clear()

        ocultarControles()
        textBoxUsuario.Focus()
    End Sub
#End Region

End Class