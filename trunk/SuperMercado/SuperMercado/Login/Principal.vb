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

    'Módulo de ventas
    Dim Mventas As New ModuloVentas

    'Catálogos
    Dim Cat_Dep As New Cat_Departamentos
    Dim Cat_Cat As New Cat_Categorias
    Dim Cat_Mar As New Cat_Marcas
    Dim Cat_Prod As New Cat_Productos

    Dim Cat_Clte As New Cat_Clientes
    Dim Cat_Prov As New Cat_Proveedores
    Dim Cat_Unid As New Cat_Unidades

    '

    Dim objCaja As New Caja
    Dim objDineroCaja As New dineroCaja
    Dim objLogin As New Login
    Dim objPermisos As New Permisos


#End Region

#Region "  Evento: Principal LOAD  "
    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Login()
        Me.WindowState = FormWindowState.Maximized

        ' Configuración de la ventana principal.
        Dim inic As New inicial
        inic.MdiParent = Me
        inic.WindowState = FormWindowState.Maximized
        inic.StartPosition = FormStartPosition.CenterScreen
        inic.Show()
        Me.MenuStrip1.MdiWindowListItem = Ventanas
        MacCaja()
    End Sub
#End Region

#Region "  Menú Ventas  "
    Private Sub ModuloDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuloDeVentasToolStripMenuItem.Click
        Mventas.MdiParent = Me
        Mventas.WindowState = FormWindowState.Maximized

        Mventas.StartPosition = FormStartPosition.CenterParent
        Mventas.Show()
    End Sub
#End Region

    'Menú Reportes

#Region "  Menú Catálogos  "
    Private Sub MenuDepartamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDepartamentos.Click
        Cat_Dep.MdiParent = Me
        Cat_Dep.WindowState = FormWindowState.Maximized

        Cat_Dep.StartPosition = FormStartPosition.CenterScreen
        Cat_Dep.Show()
    End Sub

    Private Sub MenuCategorias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCategorias.Click
        Cat_Cat.MdiParent = Me
        Cat_Cat.WindowState = FormWindowState.Maximized

        Cat_Cat.StartPosition = FormStartPosition.CenterScreen
        Cat_Cat.Show()
    End Sub

    Private Sub MenuMarcas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMarcas.Click
        Cat_Mar.MdiParent = Me
        Cat_Mar.WindowState = FormWindowState.Maximized

        Cat_Mar.StartPosition = FormStartPosition.CenterScreen
        Cat_Mar.Show()
    End Sub

    Private Sub MenuProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProductos.Click
        Cat_Prod.MdiParent = Me
        Cat_Prod.WindowState = FormWindowState.Maximized

        Cat_Prod.StartPosition = FormStartPosition.CenterScreen
        Cat_Prod.Show()
    End Sub

    Private Sub MenuClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuClientes.Click
        Cat_Clte.MdiParent = Me
        Cat_Clte.WindowState = FormWindowState.Maximized

        Cat_Clte.StartPosition = FormStartPosition.CenterScreen
        Cat_Clte.Show()
    End Sub

    Private Sub MenuProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProveedores.Click
        Cat_Prov.MdiParent = Me
        Cat_Prov.WindowState = FormWindowState.Maximized

        Cat_Prov.StartPosition = FormStartPosition.CenterScreen
        Cat_Prov.Show()
    End Sub

    Private Sub MenuUnidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUnidades.Click
        Cat_Unid.MdiParent = Me
        Cat_Unid.WindowState = FormWindowState.Maximized

        Cat_Unid.StartPosition = FormStartPosition.CenterScreen
        Cat_Unid.Show()
    End Sub
#End Region

#Region "  Menú Facturación  "
    Private Sub FacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaToolStripMenuItem.Click
        Dim Facturas As New Facturacion
        Facturas.MdiParent = Me
        Facturas.WindowState = FormWindowState.Maximized

        Facturas.StartPosition = FormStartPosition.CenterScreen
        Facturas.Show()
    End Sub
#End Region

#Region "  Menú Inventarios  "
    Private Sub EntradasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem1.Click
        Dim frm_ent As New InventarioEntradas
        frm_ent.MdiParent = Me
        frm_ent.WindowState = FormWindowState.Maximized

        frm_ent.StartPosition = FormStartPosition.CenterScreen
        frm_ent.Show()
    End Sub

    Private Sub SalidasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidasToolStripMenuItem1.Click
        Dim frm_sal As New InventarioSalidas
        frm_sal.MdiParent = Me
        frm_sal.WindowState = FormWindowState.Maximized

        frm_sal.StartPosition = FormStartPosition.CenterScreen
        frm_sal.Show()
    End Sub
#End Region

#Region "  Menú Caja  "
    Private Sub corteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles corteToolStripMenuItem.Click
        ' Configurar y mostrar la ventana caja.
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
    Private Sub GrupoDePermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoDePermisosToolStripMenuItem.Click
        ' Configurar y mostrar la ventana permisos.
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
#End Region   

#Region "  Menú Salir  "
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
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

#Region "  Rutina: MacCaja  "
    Sub MacCaja()
        '----------   Muestra la MAC  ------------
        'MessageBox.Show("La dirección MAC de su equipo es: " & obtenMac(), "MAC", MessageBoxButtons.OK, MessageBoxIcon.Information)


        '--- Consulta110: registro con la fecha más reciente en la tabla caja ---
        ' Se verifica que la fecha más reciente en la tabla caja sea distinta a la actual.
        ' Si lo es, se procede a ingresar un nuevo registro con la fecha actual.

        Caja = "CONSULTA110" : Parametros = ""

        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        Dim existe As Boolean
        existe = ObjRet.DS.Tables(1).Rows(0).Item(1)

        If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|", False) = "OK" Then
            ' Si no hay un registro con la fecha actual en la tabla Caja_Corte,
            ' se inserta uno con la fecha actual.
            If existe Then
                If Date.Parse(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False)) <> Date.Now.Date Then

                    ' CONFIGURACION_CAJA
                    ' Si está activado un monto inicial por defecto se inserta
                    ' directamente. Para esto llamamos a la consulta112 y obtenemos
                    ' la configuración.
                    Caja = "Consulta112" : Parametros = ""
                    If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                    ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

                    Dim activadoMontoPorDefecto As Boolean
                    Dim montoPorDefecto As Decimal
                    activadoMontoPorDefecto = ObjRet.DS.Tables(0).Rows(0).Item(1)
                    montoPorDefecto = ObjRet.DS.Tables(0).Rows(0).Item(2)

                    ' Activado un monto inicial por defecto.
                    If activadoMontoPorDefecto Then
                        Caja = "GRABAR110" : Parametros = "V1=" & montoPorDefecto & "|"

                        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

                    Else ' No se encuentra activado, por lo tanto muestra la ventana
                        ' DineroCaja para ingresarlo manualmente.
                        If objDineroCaja Is Nothing Then
                            Dim objDineroCaja = New dineroCaja()
                            objDineroCaja.StartPosition = FormStartPosition.CenterParent
                            objDineroCaja.ShowDialog()
                        End If
                    End If
                End If

            End If


            ' No existe ningún registro en la tabla Caja_Corte, se procede a insertar
            ' el primer registro.
        ElseIf lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|", False) = "ERROR" Then

            ' CONFIGURACION_CAJA
            ' Si está activado un monto inicial por defecto se inserta
            ' directamente. Para esto llamamos a la consulta112 y obtenemos
            ' la configuración.
            Caja = "Consulta112" : Parametros = ""
            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

            Dim activadoMontoPorDefecto As Boolean
            Dim montoPorDefecto As Decimal
            activadoMontoPorDefecto = ObjRet.DS.Tables(0).Rows(0).Item(1)
            montoPorDefecto = ObjRet.DS.Tables(0).Rows(0).Item(2)

            ' Activado un monto inicial por defecto.
            If activadoMontoPorDefecto Then
                Caja = "GRABAR110" : Parametros = "V1=" & montoPorDefecto & "|"

                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

            Else ' No se encuentra activado, por lo tanto muestra la ventana
                ' DineroCaja para ingresarlo manualmente.
                If objDineroCaja Is Nothing Then
                    Dim objDineroCaja = New dineroCaja()
                    objDineroCaja.StartPosition = FormStartPosition.CenterParent
                    objDineroCaja.ShowDialog()
                End If
            End If
        End If

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

End Class
