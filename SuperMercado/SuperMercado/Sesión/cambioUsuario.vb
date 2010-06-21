Public Class cambioUsuario

#Region "  Variables de trabajo  "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    Dim pr As Principal
#End Region

#Region "  Evento: cambioUsuario LOAD  "
    Private Sub cambioUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        textBoxUsuario.Focus()
    End Sub
#End Region

#Region "  Botón Aceptar  "
    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click
        '<Validaciones>
        If textBoxUsuario.Text.Trim = "" Then
            MessageBox.Show("No ha escrito su nombre de usuario.", " Cambio de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxUsuario.Focus()
            Return
        End If

        If textBoxPassword.Text.Trim = "" Then
            MessageBox.Show("No ha escrito su contraseña de usuario.", " Cambio de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxPassword.Focus()
            Return
        End If
        '<Validaciones>

        Caja = "Consulta120" : Parametros = "V1=" & textBoxUsuario.Text.Trim & "|" & _
                                            "V2=" & textBoxPassword.Text.Trim & "|"

        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then
            cerrarVentanasHijas()
            usuario = textBoxUsuario.Text.Trim
            nombreCompleto = lConsulta.ObtenerValor("3R", ObjRet.sResultado, "|")
            mostrarInicial()
            restriccionPermisos(textBoxUsuario.Text)
            Me.Close()
        ElseIf lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "ERROR1" Then
            MessageBox.Show("El nombre de usuario no es válido.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxUsuario.Focus()
            textBoxUsuario.SelectAll()
        ElseIf lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "ERROR2" Then
            MessageBox.Show("La contraseña está mal escrita.", "SuperMercado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textBoxPassword.Focus()
            textBoxPassword.SelectAll()
        End If
    End Sub
#End Region

#Region "  Botón Cancelar  "
    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub
#End Region

#Region "  Rutina: cargaRefPrincipal  "
    Friend Sub cargaRefPrincipal(ByRef PrincipalR As Principal)
        pr = PrincipalR
    End Sub
#End Region

#Region "  Rutina: cerrarVentanasHijas  "
    Private Sub cerrarVentanasHijas()
        For i As Integer = 0 To pr.MdiChildren.Length - 1
            pr.MdiChildren(0).Close()
        Next
    End Sub
#End Region

#Region "  Rutina: mostrarInicial  "
    Private Sub mostrarInicial()
        Dim inic As New inicial
        inic.MdiParent = pr
        inic.WindowState = FormWindowState.Maximized
        inic.StartPosition = FormStartPosition.CenterScreen
        inic.Show()
    End Sub
#End Region

#Region "  Cambio de textBox con Enter  "
    Private Sub textBoxUsuario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textBoxUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            textBoxPassword.Focus()
        End If
    End Sub

    Private Sub textBoxPassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textBoxPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonAceptar.Focus()
        End If
    End Sub
#End Region

#Region "  Rutina: restriccionPermisos  "
    Private Sub restriccionPermisos(ByVal nombreUsuarioR As String)
        Caja = "Consulta122b" : Parametros = "V1=" & nombreUsuarioR + "|"
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        'Catálogos
        If ObjRet.DS.Tables(0).Rows(0).Item(0) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(1) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(2) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(3) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(4) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(5) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(6) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(7) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(8) = "0" Then
            pr.ReportesToolStripMenuItem1.Visible = False
        Else
            pr.ReportesToolStripMenuItem1.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(0) = "0" Then
            pr.ProductosToolStripMenuItem3.Visible = False
        Else
            pr.ProductosToolStripMenuItem3.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(1) = "0" Then
            pr.EntradasDeProductosToolStripMenuItem.Visible = False
        Else
            pr.EntradasDeProductosToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(2) = "0" Then
            pr.SalidasDeProductosToolStripMenuItem.Visible = False
        Else
            pr.SalidasDeProductosToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(3) = "0" Then
            pr.ClientesToolStripMenuItem3.Visible = False
        Else
            pr.ClientesToolStripMenuItem3.Visible = True
        End If


        If ObjRet.DS.Tables(0).Rows(0).Item(4) = "0" Then
            pr.ProveedoresToolStripMenuItem3.Visible = False
        Else
            pr.ProveedoresToolStripMenuItem3.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(5) = "0" Then
            pr.FacturasToolStripMenuItem1.Visible = False
        Else
            pr.FacturasToolStripMenuItem1.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(6) = "0" Then
            pr.VentasToolStripMenuItem3.Visible = False
        Else
            pr.VentasToolStripMenuItem3.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(7) = "0" Then
            pr.RetirosDeEfectivoToolStripMenuItem1.Visible = False
        Else
            pr.RetirosDeEfectivoToolStripMenuItem1.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(8) = "0" Then
            pr.DepositosDeEfectivoToolStripMenuItem1.Visible = False
        Else
            pr.DepositosDeEfectivoToolStripMenuItem1.Visible = True
        End If


        'CATÁLOGOS
        If ObjRet.DS.Tables(0).Rows(0).Item(9) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(10) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(11) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(12) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(13) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(14) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(15) = "0" Then

            pr.catálogosToolStripMenuItem.Visible = False
        Else
            pr.catálogosToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(9) = "0" Then
            pr.MenuDepartamentos.Visible = False
        Else
            pr.MenuDepartamentos.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(10) = "0" Then
            pr.MenuCategorias.Visible = False
        Else
            pr.MenuCategorias.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(11) = "0" Then
            pr.MenuMarcas.Visible = False
        Else
            pr.MenuMarcas.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(12) = "0" Then
            pr.MenuProductos.Visible = False
        Else
            pr.MenuProductos.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(13) = "0" Then
            pr.MenuClientes.Visible = False
        Else
            pr.MenuClientes.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(14) = "0" Then
            pr.MenuProveedores.Visible = False
        Else
            pr.MenuProveedores.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(15) = "0" Then
            pr.MenuUnidades.Visible = False
        Else
            pr.MenuUnidades.Visible = True
        End If

        'FACTURA
        If ObjRet.DS.Tables(0).Rows(0).Item(16) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(17) = "0" Then

            pr.ToolStripMenuItem1.Visible = False
        Else
            pr.ToolStripMenuItem1.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(16) = "0" Then
            pr.FacturaToolStripMenuItem.Visible = False
        Else
            pr.FacturaToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(17) = "0" Then
            pr.CotizaciónToolStripMenuItem.Visible = False
        Else
            pr.CotizaciónToolStripMenuItem.Visible = True
        End If

        'INVENTARIO
        If ObjRet.DS.Tables(0).Rows(0).Item(18) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(19) = "0" Then

            pr.inventarioToolStripMenuItem.Visible = False
        Else
            pr.inventarioToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(18) = "0" Then
            pr.movimientosToolStripMenuItem.Visible = False
        Else
            pr.movimientosToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(19) = "0" Then
            pr.consultasToolStripMenuItem.Visible = False
        Else
            pr.consultasToolStripMenuItem.Visible = True
        End If

        'CAJA
        If ObjRet.DS.Tables(0).Rows(0).Item(20) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(21) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(22) = "0" Then

            pr.cajaToolStripMenuItem.Visible = False
        Else
            pr.cajaToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(20) = "0" Then
            pr.corteToolStripMenuItem.Visible = False
        Else
            pr.corteToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(21) = "0" Then
            pr.EntradasToolStripMenuItem2.Visible = False
        Else
            pr.EntradasToolStripMenuItem2.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(22) = "0" Then
            pr.SalidasToolStripMenuItem2.Visible = False
        Else
            pr.SalidasToolStripMenuItem2.Visible = True
        End If

        'SEGURIDAD
        If ObjRet.DS.Tables(0).Rows(0).Item(23) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(24) = "0" Then

            pr.SeguridadToolStripMenuItem1.Visible = False
        Else
            pr.SeguridadToolStripMenuItem1.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(23) = "0" Then
            pr.UsuariosToolStripMenuItem1.Visible = False
        Else
            pr.UsuariosToolStripMenuItem1.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(24) = "0" Then
            pr.GrupoDePermisosToolStripMenuItem.Visible = False
        Else
            pr.GrupoDePermisosToolStripMenuItem.Visible = True
        End If

        'CONFIGURACIÓN
        If ObjRet.DS.Tables(0).Rows(0).Item(25) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(26) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(27) = "0" Then
            pr.ConfiguracinToolStripMenuItem.Visible = False
        Else
            pr.ConfiguracinToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(25) = "0" Then
            pr.CajaToolStripMenuItem1.Visible = False
        Else
            pr.CajaToolStripMenuItem1.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(26) = "0" Then
            pr.ReportesToolStripMenuItem.Visible = False
        Else
            pr.ReportesToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(27) = "0" Then
            pr.TicketsToolStripMenuItem.Visible = False
        Else
            pr.TicketsToolStripMenuItem.Visible = True
        End If

    End Sub
#End Region

End Class