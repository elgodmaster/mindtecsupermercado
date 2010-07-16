'Imports System.Data
'Imports System.Data.SqlClient

Public Class Principal

#Region "  Variables De Trabajo  "

    Private DsDatos As DataSet
    Private ViewDatos As DataView

    ' Variables para las consultas.
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    Public objDineroCaja As New dineroCaja

    'Login
    Public objLogin As New Login

#End Region

#Region "  Evento: Principal LOAD  "
    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login()
        restriccionPermisos(usuario)

        Me.WindowState = FormWindowState.Maximized

        '' Configuración de la ventana principal.
        'Dim inic As New inicial
        'inic.MdiParent = Me
        'inic.WindowState = FormWindowState.Maximized
        'inic.StartPosition = FormStartPosition.CenterScreen

        'inic.Show()
        Me.MenuStrip1.MdiWindowListItem = Ventanas
    End Sub
#End Region

#Region "  Menú Ventas  "
    Private Sub ModuloDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuloDeVentasToolStripMenuItem.Click
        Dim mventas As ModuloVentas = ModuloVentas.Instance
        Mventas.MdiParent = Me
        Mventas.WindowState = FormWindowState.Maximized

        Mventas.StartPosition = FormStartPosition.CenterParent
        Mventas.Show()
    End Sub
#End Region

#Region "  Menú Devoluciones  "
    Private Sub DevoluciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevoluciónToolStripMenuItem1.Click
        Dim objDevolucion As Devoluciones = Devoluciones.Instance
        objDevolucion.MdiParent = Me
        objDevolucion.WindowState = FormWindowState.Maximized

        objDevolucion.StartPosition = FormStartPosition.CenterScreen
        objDevolucion.Show()
    End Sub
#End Region

    'Menú Reportes

#Region "  Menú Catálogos  "
    Private Sub MenuDepartamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDepartamentos.Click
        Dim Cat_Dep As Cat_Departamentos = Cat_Dep.Instance
        Cat_Dep.MdiParent = Me
        Cat_Dep.WindowState = FormWindowState.Maximized

        Cat_Dep.StartPosition = FormStartPosition.CenterScreen
        Cat_Dep.Show()
    End Sub

    Private Sub MenuCategorias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCategorias.Click
        Dim Cat_Cat As Cat_Categorias = Cat_Categorias.Instance
        Cat_Cat.MdiParent = Me
        Cat_Cat.WindowState = FormWindowState.Maximized

        Cat_Cat.StartPosition = FormStartPosition.CenterScreen
        Cat_Cat.Show()
    End Sub

    Private Sub MenuMarcas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMarcas.Click
        Dim cat_mar As Cat_Marcas = Cat_Marcas.Instance
        Cat_Mar.MdiParent = Me
        Cat_Mar.WindowState = FormWindowState.Maximized

        Cat_Mar.StartPosition = FormStartPosition.CenterScreen
        Cat_Mar.Show()
    End Sub

    Private Sub MenuProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProductos.Click
        Dim cat_prod As Cat_Productos = Cat_Productos.Instance
        Cat_Prod.MdiParent = Me
        Cat_Prod.WindowState = FormWindowState.Maximized

        Cat_Prod.StartPosition = FormStartPosition.CenterScreen
        Cat_Prod.Show()
    End Sub

    Private Sub MenuClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuClientes.Click
        Dim cat_clte As Cat_Clientes = Cat_Clientes.Instance
        Cat_Clte.MdiParent = Me
        Cat_Clte.WindowState = FormWindowState.Maximized

        Cat_Clte.StartPosition = FormStartPosition.CenterScreen
        Cat_Clte.Show()
    End Sub

    Private Sub MenuProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProveedores.Click
        Dim cat_prov As Cat_Proveedores = Cat_Proveedores.Instance
        Cat_Prov.MdiParent = Me
        Cat_Prov.WindowState = FormWindowState.Maximized

        Cat_Prov.StartPosition = FormStartPosition.CenterScreen
        Cat_Prov.Show()
    End Sub

    Private Sub MenuUnidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUnidades.Click
        Dim cat_unid As Cat_Unidades = Cat_Unidades.Instance
        Cat_Unid.MdiParent = Me
        Cat_Unid.WindowState = FormWindowState.Maximized

        Cat_Unid.StartPosition = FormStartPosition.CenterScreen
        Cat_Unid.Show()
    End Sub
#End Region

#Region "  Menú Facturación  "
    Private Sub FacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaToolStripMenuItem.Click
        Dim Facturas As Facturacion = Facturacion.Instance
        Facturas.MdiParent = Me
        Facturas.WindowState = FormWindowState.Maximized

        Facturas.StartPosition = FormStartPosition.CenterScreen
        Facturas.Show()
    End Sub

    Private Sub CotizaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizaciónToolStripMenuItem.Click
        Dim Cotiza As Cotización = Cotización.Instance
        Cotiza.MdiParent = Me
        Cotiza.WindowState = FormWindowState.Maximized

        Cotiza.StartPosition = FormStartPosition.CenterScreen
        Cotiza.Show()
    End Sub
#End Region

#Region "  Menú Inventarios  "
    Private Sub EntradasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem1.Click
        Dim frm_ent As InventarioEntradas = InventarioEntradas.Instance
        frm_ent.MdiParent = Me
        frm_ent.WindowState = FormWindowState.Maximized

        frm_ent.StartPosition = FormStartPosition.CenterScreen
        frm_ent.Show()
    End Sub

    Private Sub SalidasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidasToolStripMenuItem1.Click
        Dim frm_sal As InventarioSalidas = InventarioSalidas.Instance
        frm_sal.MdiParent = Me
        frm_sal.WindowState = FormWindowState.Maximized

        frm_sal.StartPosition = FormStartPosition.CenterScreen
        frm_sal.Show()
    End Sub
#End Region

#Region "  Menú Caja  "
    Private Sub corteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles corteToolStripMenuItem.Click
        'Caja
        Dim objCaja As Caja = objCaja.Instance
        objCaja.MdiParent = Me
        objCaja.WindowState = FormWindowState.Maximized

        objCaja.StartPosition = FormStartPosition.CenterScreen
        objCaja.Show()
    End Sub

    Private Sub EntradasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem2.Click
        Dim objRegistroEntrada As New registroEntrada
        objRegistroEntrada.StartPosition = FormStartPosition.CenterScreen
        objRegistroEntrada.ShowDialog()
    End Sub

    Private Sub SalidasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidasToolStripMenuItem2.Click
        Dim objRegistroSalida As New registroSalida
        objRegistroSalida.StartPosition = FormStartPosition.CenterScreen
        objRegistroSalida.ShowDialog()
    End Sub
#End Region

#Region "  Menú Seguridad  "
    Private Sub UsuariosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem1.Click
        Dim objUsuarios As Usuarios = Usuarios.Instance
        objUsuarios.MdiParent = Me
        objUsuarios.WindowState = FormWindowState.Maximized

        objUsuarios.StartPosition = FormStartPosition.CenterScreen
        objUsuarios.Show()
    End Sub

    Private Sub GrupoDePermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoDePermisosToolStripMenuItem.Click
        ' Configurar y mostrar la ventana permisos.
        Dim objPermisos As Permisos = Permisos.Instance
        objPermisos.MdiParent = Me
        objPermisos.WindowState = FormWindowState.Maximized

        objPermisos.StartPosition = FormStartPosition.CenterScreen
        objPermisos.Show()
    End Sub
#End Region

#Region "  Menú Configuración  "
    Private Sub CajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaToolStripMenuItem1.Click
        Dim objConfigCaja As New configuracion
        objConfigCaja.StartPosition = FormStartPosition.CenterScreen
        objConfigCaja.ShowDialog()
    End Sub

    Private Sub TicketsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TicketsToolStripMenuItem.Click
        Dim objTickets As Tickets = Tickets.Instance
        objTickets.MdiParent = Me
        objTickets.WindowState = FormWindowState.Maximized
        objTickets.Show()
    End Sub
#End Region   

#Region "  Menú Sesión  "
    Private Sub CambiarDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarDeUsuarioToolStripMenuItem.Click
        Dim objCambioUsuario As New cambioUsuario
        objCambioUsuario.cargaRefPrincipal(Me)

        objCambioUsuario.StartPosition = FormStartPosition.CenterScreen
        objCambioUsuario.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Dim result As DialogResult
        result = MessageBox.Show("Está a punto de cerrar su sesión. Todas las ventanas se cerrarán y cualquier información que no haya guardado se perderá. ¿Desea continuar?", " Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            cerrarVentanasHijas()
            Me.Visible = False
            Login()
            restriccionPermisos(usuario)
        Else
            Return
        End If
    End Sub

#End Region

#Region "  Rutina: Login  "
    Sub Login()
        Dim logear = New Login
        logear.cargaRefPrincipal(Me)
        logear.StartPosition = FormStartPosition.CenterScreen
        logear.Width = 699
        logear.Height = 205
        logear.ShowDialog()
    End Sub
#End Region

#Region "  Rutina: obtenMac  "
    Public Function obtenMac() As String
        Dim str As String
        Dim p As New Process

        ' StartInfo representa el conjunto de parámetros que se van a
        ' utilizar en un proceso.


        p.StartInfo.UseShellExecute = False

        p.StartInfo.RedirectStandardOutput = True

        p.StartInfo.FileName = "GetMac.exe"

        p.StartInfo.Arguments = "/fo list"

        p.Start()

        'StandardOutput Obtiene una secuencia que se utiliza para leer la salida de la aplicación.

        str = p.StandardOutput.ReadLine

        str = p.StandardOutput.ReadLine

        p.WaitForExit()

        Return str.Substring(23)
    End Function
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
            ReportesToolStripMenuItem1.Visible = False
        Else
            ReportesToolStripMenuItem1.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(0) = "0" Then
            ProductosToolStripMenuItem3.Visible = False
        Else
            ProductosToolStripMenuItem3.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(1) = "0" Then
            EntradasDeProductosToolStripMenuItem.Visible = False
        Else
            EntradasDeProductosToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(2) = "0" Then
            SalidasDeProductosToolStripMenuItem.Visible = False
        Else
            SalidasDeProductosToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(3) = "0" Then
            ClientesToolStripMenuItem3.Visible = False
        Else
            ClientesToolStripMenuItem3.Visible = True
        End If


        If ObjRet.DS.Tables(0).Rows(0).Item(4) = "0" Then
            ProveedoresToolStripMenuItem3.Visible = False
        Else
            ProveedoresToolStripMenuItem3.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(5) = "0" Then
            FacturasToolStripMenuItem1.Visible = False
        Else
            FacturasToolStripMenuItem1.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(6) = "0" Then
            VentasToolStripMenuItem3.Visible = False
        Else
            VentasToolStripMenuItem3.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(7) = "0" Then
            RetirosDeEfectivoToolStripMenuItem1.Visible = False
        Else
            RetirosDeEfectivoToolStripMenuItem1.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(8) = "0" Then
            DepositosDeEfectivoToolStripMenuItem1.Visible = False
        Else
            DepositosDeEfectivoToolStripMenuItem1.Visible = True
        End If


        'CATÁLOGOS
        If ObjRet.DS.Tables(0).Rows(0).Item(9) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(10) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(11) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(12) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(13) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(14) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(15) = "0" Then

            catálogosToolStripMenuItem.Visible = False
        Else
            catálogosToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(9) = "0" Then
            MenuDepartamentos.Visible = False
        Else
            MenuDepartamentos.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(10) = "0" Then
            MenuCategorias.Visible = False
        Else
            MenuCategorias.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(11) = "0" Then
            MenuMarcas.Visible = False
        Else
            MenuMarcas.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(12) = "0" Then
            MenuProductos.Visible = False
        Else
            MenuProductos.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(13) = "0" Then
            MenuClientes.Visible = False
        Else
            MenuClientes.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(14) = "0" Then
            MenuProveedores.Visible = False
        Else
            MenuProveedores.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(15) = "0" Then
            MenuUnidades.Visible = False
        Else
            MenuUnidades.Visible = True
        End If

        'FACTURA
        If ObjRet.DS.Tables(0).Rows(0).Item(16) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(17) = "0" Then

            ToolStripMenuItem1.Visible = False
        Else
            ToolStripMenuItem1.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(16) = "0" Then
            FacturaToolStripMenuItem.Visible = False
        Else
            FacturaToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(17) = "0" Then
            CotizaciónToolStripMenuItem.Visible = False
        Else
            CotizaciónToolStripMenuItem.Visible = True
        End If

        'INVENTARIO
        If ObjRet.DS.Tables(0).Rows(0).Item(18) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(19) = "0" Then

            inventarioToolStripMenuItem.Visible = False
        Else
            inventarioToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(18) = "0" Then
            movimientosToolStripMenuItem.Visible = False
        Else
            movimientosToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(19) = "0" Then
            consultasToolStripMenuItem.Visible = False
        Else
            consultasToolStripMenuItem.Visible = True
        End If

        'CAJA
        If ObjRet.DS.Tables(0).Rows(0).Item(20) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(21) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(22) = "0" Then

            cajaToolStripMenuItem.Visible = False
        Else
            cajaToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(20) = "0" Then
            corteToolStripMenuItem.Visible = False
        Else
            corteToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(21) = "0" Then
            EntradasToolStripMenuItem2.Visible = False
        Else
            EntradasToolStripMenuItem2.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(22) = "0" Then
            SalidasToolStripMenuItem2.Visible = False
        Else
            SalidasToolStripMenuItem2.Visible = True
        End If

        'SEGURIDAD
        If ObjRet.DS.Tables(0).Rows(0).Item(23) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(24) = "0" Then

            SeguridadToolStripMenuItem1.Visible = False
        Else
            SeguridadToolStripMenuItem1.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(23) = "0" Then
            UsuariosToolStripMenuItem1.Visible = False
        Else
            UsuariosToolStripMenuItem1.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(24) = "0" Then
            GrupoDePermisosToolStripMenuItem.Visible = False
        Else
            GrupoDePermisosToolStripMenuItem.Visible = True
        End If

        'CONFIGURACIÓN
        If ObjRet.DS.Tables(0).Rows(0).Item(25) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(26) = "0" And _
        ObjRet.DS.Tables(0).Rows(0).Item(27) = "0" Then
            ConfiguracinToolStripMenuItem.Visible = False
        Else
            ConfiguracinToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(25) = "0" Then
            CajaToolStripMenuItem1.Visible = False
        Else
            CajaToolStripMenuItem1.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(26) = "0" Then
            ReportesToolStripMenuItem.Visible = False
        Else
            ReportesToolStripMenuItem.Visible = True
        End If

        If ObjRet.DS.Tables(0).Rows(0).Item(27) = "0" Then
            TicketsToolStripMenuItem.Visible = False
        Else
            TicketsToolStripMenuItem.Visible = True
        End If

    End Sub
#End Region

#Region "  Rutina: cerrarVentanasHijas  "
    Private Sub cerrarVentanasHijas()
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(0).Close()
        Next
    End Sub
#End Region

End Class
