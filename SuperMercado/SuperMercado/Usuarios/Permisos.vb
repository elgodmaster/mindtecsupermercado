Imports MindTec.Componentes

Public Class Permisos

#Region "  Variables de trabajo  "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    Dim modificaronCampos As Boolean
    Dim nombrePermisoOriginal As String
#End Region

#Region "  Botón BUSCAR  "
    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Permisos()
    End Sub
#End Region

#Region "  Botón NUEVO  "
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        limpiarPermisos()
        txtNomPermiso.Clear()

        nombrePermisoOriginal = ""

        mostrarControles()
        mostrarControlesEditar()
    End Sub
#End Region

#Region "  Botón Limpiar  "
    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        limpiarPermisos()
    End Sub
#End Region

#Region "  Botón GRABAR  "
    Private Sub ButtonGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grabar.Click
        Dim Result As DialogResult
        If txtNomPermiso.Text.Trim = "" Then
            MessageBox.Show("Escriba el nombre del permiso.", " Permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textBoxNombrePermiso.Focus()
            Return
        End If

        Result = MessageBox.Show("¿Desea guardar los cambios?", "Permisos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = Windows.Forms.DialogResult.Yes Then
            Caja = "Grabar121"
            Parametros = "V0=" & nombrePermisoOriginal.ToUpper.Trim & _
                         "|V1=" & Me.txtNomPermiso.Text.ToUpper.Trim & _
 _
                         "|V2=" & CheckBoxRepProd.Checked & _
                         "|V3=" & CheckBoxRepEntPro.Checked & _
                         "|V4=" & CheckBoxRepSalPro.Checked & _
                         "|V5=" & CheckBoxRepClie.Checked & _
 _
                         "|V6=" & CheckBoxRepProv.Checked & _
                         "|V7=" & CheckBoxRepFac.Checked & _
                         "|V8=" & CheckBoxRepVen.Checked & _
                         "|V9=" & CheckBoxRepRetEfec.Checked & _
 _
                         "|V10=" & CheckBoxRepDepEfec.Checked & _
 _
                         "|V11=" & CheckBoxCatDep.Checked & _
                         "|V12=" & CheckBoxCatCat.Checked & _
                         "|V13=" & CheckBoxCatMar.Checked & _
                         "|V14=" & CheckBoxCatPro.Checked & _
 _
                         "|V15=" & CheckBoxCatClie.Checked & _
                         "|V16=" & CheckBoxCatProv.Checked & _
                         "|V17=" & CheckBoxCatUni.Checked & _
 _
                         "|V18=" & CheckBoxFacFac.Checked & _
                         "|V19=" & CheckBoxFacCot.Checked & _
 _
                         "|V20=" & CheckBoxInvMov.Checked & _
                         "|V21=" & CheckBoxInvCon.Checked & _
 _
                         "|V22=" & CheckBoxCajaCorte.Checked & _
                         "|V23=" & CheckBoxCajaEnt.Checked & _
                         "|V24=" & CheckBoxCajaSal.Checked & _
 _
                         "|V25=" & CheckBoxSegUsu.Checked & _
                         "|V26=" & CheckBoxSegPer.Checked & _
 _
                         "|V27=" & CheckBoxConCaja.Checked & _
                         "|V28=" & CheckBoxConFac.Checked & _
                         "|V29=" & CheckBoxConTic.Checked & "|"
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
            If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), " Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarPermisos()
                ocultarControles()
            Else
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), " Permisos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            Return
        End If
    End Sub
#End Region

#Region "  Evento: Permisos LOAD  "
    Private Sub Permisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grabar.Visible = False
        ocultarControles()

        modificaronCampos = False
    End Sub
#End Region

#Region "  Evento: textBoxNombrePermiso KEYDOWN   "
    Private Sub CodigoCliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textBoxNombrePermiso.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Permisos()
        End Select
    End Sub
#End Region

#Region "  Evento: CheckBoxSeleccionarTodo CLICK  "
    Private Sub CheckBoxSeleccionarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxSeleccionarTodo.Click
        If CheckBoxSeleccionarTodo.Checked = True Then
            'Seguridad
            CheckBoxSegUsu.Checked = True
            CheckBoxSegPer.Checked = True
            'Reportes
            CheckBoxRepVen.Checked = True
            CheckBoxRepSalPro.Checked = True
            CheckBoxRepRetEfec.Checked = True
            CheckBoxRepProv.Checked = True
            CheckBoxRepProd.Checked = True
            CheckBoxRepFac.Checked = True
            CheckBoxRepEntPro.Checked = True
            CheckBoxRepDepEfec.Checked = True
            CheckBoxRepClie.Checked = True
            'Inventarios
            CheckBoxInvMov.Checked = True
            CheckBoxInvCon.Checked = True
            'Facturación
            CheckBoxFacFac.Checked = True
            CheckBoxFacCot.Checked = True
            'Configuración
            CheckBoxConTic.Checked = True
            CheckBoxConFac.Checked = True
            CheckBoxConCaja.Checked = True
            'Catálogos
            CheckBoxCatUni.Checked = True
            CheckBoxCatProv.Checked = True
            CheckBoxCatPro.Checked = True
            CheckBoxCatMar.Checked = True
            CheckBoxCatDep.Checked = True
            CheckBoxCatClie.Checked = True
            CheckBoxCatCat.Checked = True
            'Caja
            CheckBoxCajaCorte.Checked = True
            CheckBoxCajaEnt.Checked = True
            CheckBoxCajaSal.Checked = True
        Else
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
        End If
    End Sub
#End Region

#Region "  Rutina: llenarCheckBox  "
    Private Sub llenarCheckBox(ByRef ds As DataSet)
        'Utilizando el resultado de la consulta 122
        'Reportes
        CheckBoxRepProd.Checked = ds.Tables(0).Rows(0).Item(0)
        CheckBoxRepEntPro.Checked = ds.Tables(0).Rows(0).Item(1)
        CheckBoxRepSalPro.Checked = ds.Tables(0).Rows(0).Item(2)
        CheckBoxRepClie.Checked = ds.Tables(0).Rows(0).Item(3)

        CheckBoxRepProv.Checked = ds.Tables(0).Rows(0).Item(4)
        CheckBoxRepFac.Checked = ds.Tables(0).Rows(0).Item(5)
        CheckBoxRepVen.Checked = ds.Tables(0).Rows(0).Item(6)
        CheckBoxRepRetEfec.Checked = ds.Tables(0).Rows(0).Item(7)

        CheckBoxRepDepEfec.Checked = ds.Tables(0).Rows(0).Item(8)

        'Catálogos
        CheckBoxCatDep.Checked = ds.Tables(0).Rows(0).Item(9)
        CheckBoxCatCat.Checked = ds.Tables(0).Rows(0).Item(10)
        CheckBoxCatMar.Checked = ds.Tables(0).Rows(0).Item(11)
        CheckBoxCatPro.Checked = ds.Tables(0).Rows(0).Item(12)

        CheckBoxCatClie.Checked = ds.Tables(0).Rows(0).Item(13)
        CheckBoxCatProv.Checked = ds.Tables(0).Rows(0).Item(14)
        CheckBoxCatUni.Checked = ds.Tables(0).Rows(0).Item(15)

        'Facturas
        CheckBoxFacFac.Checked = ds.Tables(0).Rows(0).Item(16)
        CheckBoxFacCot.Checked = ds.Tables(0).Rows(0).Item(17)

        'Inventarios
        CheckBoxInvMov.Checked = ds.Tables(0).Rows(0).Item(18)
        CheckBoxInvCon.Checked = ds.Tables(0).Rows(0).Item(19)

        'Caja
        CheckBoxCajaCorte.Checked = ds.Tables(0).Rows(0).Item(20)
        CheckBoxCajaEnt.Checked = ds.Tables(0).Rows(0).Item(21)
        CheckBoxCajaSal.Checked = ds.Tables(0).Rows(0).Item(22)

        'Seguridad
        CheckBoxSegUsu.Checked = ds.Tables(0).Rows(0).Item(23)
        CheckBoxSegPer.Checked = ds.Tables(0).Rows(0).Item(24)

        'Configuración
        CheckBoxConCaja.Checked = ds.Tables(0).Rows(0).Item(25)
        CheckBoxConFac.Checked = ds.Tables(0).Rows(0).Item(26)
        CheckBoxConTic.Checked = ds.Tables(0).Rows(0).Item(27)
    End Sub
#End Region

#Region "  Rutina: consulta122  "
    Sub consulta122()
        Caja = "Consulta122" : Parametros = "V1=" & textBoxNombrePermiso.Text.Trim & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then
            llenarCheckBox(ObjRet.DS)
            txtNomPermiso.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            nombrePermisoOriginal = txtNomPermiso.Text.Trim
            textBoxNombrePermiso.Enabled = False
            mostrarControles()
            mostrarControlesEditar()
        Else
            mostrarControles()
        End If
    End Sub
#End Region

#Region "  Rutina: Permisos  "
    Sub Permisos()
        Caja = "Consulta123" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            textBoxNombrePermiso.Text = nuevo.resultado

            If nuevo.resultado = "" Then
                Return
            End If

            consulta122()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub
#End Region

#Region "  Rutina: ocultarControles  "
    Private Sub ocultarControles()
        GroupBoxNombre.Visible = False
        Label2.Visible = False
        CheckBoxSeleccionarTodo.Visible = False
        GroupBoxCaja.Visible = False
        GroupBoxCatalogos.Visible = False
        GroupBoxConfiguracion.Visible = False
        GroupBoxFacturacion.Visible = False
        GroupBoxInventario.Visible = False
        GroupBoxReportes.Visible = False
        GroupBoxSeguridad.Visible = False

        textBoxNombrePermiso.Enabled = True
        textBoxNombrePermiso.Focus()
    End Sub
#End Region

#Region "  Rutina: mostrarControles  "
    Private Sub mostrarControles()
        GroupBoxNombre.Visible = True
        Label2.Visible = True
        CheckBoxSeleccionarTodo.Visible = True
        GroupBoxCaja.Visible = True
        GroupBoxCatalogos.Visible = True
        GroupBoxConfiguracion.Visible = True
        GroupBoxFacturacion.Visible = True
        GroupBoxInventario.Visible = True
        GroupBoxReportes.Visible = True
        GroupBoxSeguridad.Visible = True

        textBoxNombrePermiso.Enabled = False
        txtNomPermiso.Focus()
    End Sub
#End Region

#Region "  Rutina: mostrarControlesEditar  "
    Sub mostrarControlesEditar()
        Grabar.Visible = True
        Limpiar.Visible = True
    End Sub
#End Region

#Region "  Rutina: ocultarControlesEditar  "
    Sub ocultarControlesEditar()
        Grabar.Visible = False
        Limpiar.Visible = False
    End Sub
#End Region

#Region "  Rutina: limpiarPermisos  "
    Private Sub limpiarPermisos()
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

        CheckBoxSeleccionarTodo.Checked = False

        textBoxNombrePermiso.Clear()
        txtNomPermiso.Clear()

    End Sub
#End Region

#Region "  Evento: textBoxNombrePermiso - KEY PRESS  "
    Private Sub textBoxNombrePermiso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxNombrePermiso.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If textBoxNombrePermiso.Text.Trim = "" Then
                MessageBox.Show("Escriba el nombre del permiso.", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                textBoxNombrePermiso.Focus()
                Return
            End If

            consulta122()

        End If
    End Sub
#End Region
    
End Class