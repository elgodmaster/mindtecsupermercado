Imports System.Data
Imports System.Data.SqlClient

Public Class Principal

#Region "Variables De Trabajo"
    Private DsDatos As DataSet
    Private ViewDatos As DataView
    ' Variables para las consultas.
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    ' Variables para Caja
    Dim objRegistroEntrada As New registroEntrada
    Dim objRegistroSalida As New registroSalida
    Dim objDineroCaja As New dineroCaja
    Dim objConfigCaja As configuracion
    ' Variables para los menús principales.
    Dim cajaActual As New Caja

#End Region

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Configuración para las ventanas de caja.
        objRegistroEntrada = Nothing
        objRegistroSalida = Nothing
        objDineroCaja = Nothing
        objConfigCaja = Nothing
        cajaActual = Nothing

        ' Configuración de la ventana principal.
        Dim inic As New inicial
        'Me.WindowState = FormWindowState.Maximized
        inic.MdiParent = Me
        inic.WindowState = FormWindowState.Maximized
        inic.StartPosition = FormStartPosition.CenterScreen
        inic.Show()
        Me.MenuStrip1.MdiWindowListItem = Ventanas

        '----------   Muestra la MAC  ------------
        'MessageBox.Show("La dirección MAC de su equipo es: " & obtenMac(), "MAC", MessageBoxButtons.OK, MessageBoxIcon.Information)

        
        '--- Consulta110: registro con la fecha más reciente en la tabla caja ---
        ' Se verifica que la fecha más reciente en la tabla caja sea distinta a la actual.
        ' Si lo es, se procede a ingresar un nuevo registro con la fecha actual.


        Caja = "CONSULTA110" : Parametros = ""

        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
        ' Se inserta el primer registro.
        If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|", False) = "OK" Then
            ' Si no hay un registro con la fecha actual en la tabla Caja_Corte,
            ' se inserta uno con la fecha actual.
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

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CotizaciónToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        'Dim Cotiza As New cotizacion
        'Cotiza.MdiParent = Me
        'Cotiza.WindowState = FormWindowState.Maximized

        'Cotiza.StartPosition = FormStartPosition.CenterScreen
        'Cotiza.Show()


    End Sub

    'Private Sub EntradasToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem3.Click
    '   
    'End Sub

    'Private Sub SalidasToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidasToolStripMenuItem3.Click
    '    
    'End Sub

    'Private Sub ExistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistenciasToolStripMenuItem.Click
    '    Dim frm_exis As New Consulta_Existencias
    '    frm_exis.MdiParent = Me
    '    frm_exis.WindowState = FormWindowState.Maximized

    '    frm_exis.StartPosition = FormStartPosition.CenterScreen
    '    frm_exis.Show()
    'End Sub

    'Private Sub EntradasToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem4.Click
    '    Dim con_ent As New consulta_Entradas
    '    con_ent.MdiParent = Me
    '    con_ent.WindowState = FormWindowState.Maximized

    '    con_ent.StartPosition = FormStartPosition.CenterScreen
    '    con_ent.Show()
    'End Sub

    'Private Sub SalidasToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidasToolStripMenuItem4.Click
    '    Dim con_ent As New consulta_Salidas
    '    con_ent.MdiParent = Me
    '    con_ent.WindowState = FormWindowState.Maximized

    '    con_ent.StartPosition = FormStartPosition.CenterScreen
    '    con_ent.Show()
    'End Sub

    'Private Sub FacturarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturarToolStripMenuItem.Click
    '    Dim Facturas As New Factura
    '    Facturas.MdiParent = Me
    '    Facturas.WindowState = FormWindowState.Maximized

    '    Facturas.StartPosition = FormStartPosition.CenterScreen
    '    Facturas.Show()
    'End Sub

    'Private Sub CotizarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizarToolStripMenuItem1.Click
    '    Dim Cot As New cotizacion
    '    Cot.MdiParent = Me
    '    Cot.WindowState = FormWindowState.Maximized
    '    Cot.StartPosition = FormStartPosition.CenterScreen
    '    Cot.Show()
    'End Sub

    'Private Sub DevoluciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevoluciónToolStripMenuItem1.Click
    '    Dim Dev As New Devolucion
    '    Dev.MdiParent = Me
    '    Dev.WindowState = FormWindowState.Maximized
    '    Dev.StartPosition = FormStartPosition.CenterScreen
    '    Dev.BackgroundImage = Me.BackgroundImage
    '    Dev.Show()
    'End Sub

    'Private Sub UsuariosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem1.Click
    '    Dim User As New Usuario
    '    User.MdiParent = Me
    '    User.WindowState = FormWindowState.Maximized
    '    User.StartPosition = FormStartPosition.CenterScreen
    '    User.Show()
    'End Sub

    'Private Sub ProductosToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem3.Click
    '    Dim rep_prod As New rep_productos
    '    rep_prod.StartPosition = FormStartPosition.CenterScreen
    '    rep_prod.Show()
    'End Sub

    'Private Sub EntradasDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasDeProductosToolStripMenuItem.Click
    '    Dim rep_ent As New rep_entradas
    '    rep_ent.StartPosition = FormStartPosition.CenterScreen
    '    rep_ent.Show()
    'End Sub

    'Private Sub SalidasDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidasDeProductosToolStripMenuItem.Click
    '    Dim rep_sal As New rep_salidas
    '    rep_sal.StartPosition = FormStartPosition.CenterScreen
    '    rep_sal.Show()
    'End Sub

    'Private Sub ClientesToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem3.Click
    '    Dim rep_cli As New rep_clientes
    '    rep_cli.StartPosition = FormStartPosition.CenterScreen
    '    rep_cli.Show()
    'End Sub

    'Private Sub ProveedoresToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem3.Click
    '    Dim rep_prov As New rep_proveedores
    '    rep_prov.StartPosition = FormStartPosition.CenterScreen
    '    rep_prov.Show()
    'End Sub

    'Private Sub FacturasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem1.Click
    '    Dim rep_fac As New rep_facturas
    '    rep_fac.StartPosition = FormStartPosition.CenterScreen
    '    rep_fac.Show()
    'End Sub

    'Private Sub VentasToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem3.Click
    '    Dim rep_ven As New rep_ventas
    '    rep_ven.StartPosition = FormStartPosition.CenterScreen
    '    rep_ven.Show()
    'End Sub

    'Private Sub RetirosDeEfectivoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetirosDeEfectivoToolStripMenuItem1.Click
    '    Dim rep_rEfe As New rep_retiroEfe
    '    rep_rEfe.StartPosition = FormStartPosition.CenterScreen
    '    rep_rEfe.Show()
    'End Sub

    'Private Sub DepositosDeEfectivoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepositosDeEfectivoToolStripMenuItem1.Click
    '    Dim rep_dEfe As New rep_entradasEfe
    '    rep_dEfe.StartPosition = FormStartPosition.CenterScreen
    '    rep_dEfe.Show()
    'End Sub

    'Private Sub ModuloDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuloDeVentasToolStripMenuItem.Click
    '    Dim ven As New Mod_ventas
    '    ven.MdiParent = Me
    '    ven.StartPosition = FormStartPosition.CenterScreen
    '    ven.Show()
    'End Sub

#Region " Catalogos "
    Private Sub MenuDepartamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDepartamentos.Click
        Dim Cat_Dep As New Cat_Departamentos

        Cat_Dep.MdiParent = Me
        Cat_Dep.WindowState = FormWindowState.Maximized

        Cat_Dep.StartPosition = FormStartPosition.CenterScreen
        Cat_Dep.Show()

    End Sub

    Private Sub MenuCategorias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCategorias.Click
        Dim Cat_Cat As New Cat_Categorias
        Cat_Cat.MdiParent = Me
        Cat_Cat.WindowState = FormWindowState.Maximized

        Cat_Cat.StartPosition = FormStartPosition.CenterScreen
        Cat_Cat.Show()
    End Sub

    Private Sub MenuMarcas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMarcas.Click
        Dim Cat_Mar As New Cat_Marcas
        Cat_Mar.MdiParent = Me
        Cat_Mar.WindowState = FormWindowState.Maximized

        Cat_Mar.StartPosition = FormStartPosition.CenterScreen
        Cat_Mar.Show()
    End Sub

    Private Sub MenuProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProductos.Click
        Dim Cat_Prod As New Cat_Productos
        Cat_Prod.MdiParent = Me
        Cat_Prod.WindowState = FormWindowState.Maximized

        Cat_Prod.StartPosition = FormStartPosition.CenterScreen
        Cat_Prod.Show()
    End Sub

    Private Sub MenuClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuClientes.Click
        Dim Cat_Clte As New Cat_Clientes
        Cat_Clte.MdiParent = Me
        Cat_Clte.WindowState = FormWindowState.Maximized
        Cat_Clte.StartPosition = FormStartPosition.CenterScreen
        Cat_Clte.Show()
    End Sub

    Private Sub MenuProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProveedores.Click
        Dim Cat_Prov As New Cat_Proveedores
        Cat_Prov.MdiParent = Me
        Cat_Prov.WindowState = FormWindowState.Maximized
        Cat_Prov.StartPosition = FormStartPosition.CenterScreen
        Cat_Prov.Show()
    End Sub

    Private Sub MenuUnidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUnidades.Click
        Dim Cat_Unid As New Cat_Unidades
        Cat_Unid.MdiParent = Me
        Cat_Unid.WindowState = FormWindowState.Maximized
        Cat_Unid.StartPosition = FormStartPosition.CenterScreen
        Cat_Unid.Show()
    End Sub
#End Region

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

    Private Sub corteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles corteToolStripMenuItem.Click

        ' Configurar y mostrar la ventana caja.
        If cajaActual Is Nothing Then
            cajaActual = New Caja()
            cajaActual.MdiParent = Me
            cajaActual.WindowState = FormWindowState.Maximized

            cajaActual.StartPosition = FormStartPosition.CenterScreen
            cajaActual.Show()
        End If
    End Sub

    Private Sub EntradasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradasToolStripMenuItem2.Click
        If objRegistroEntrada Is Nothing Then
            Dim objRegistroEntrada = New registroEntrada()
            objRegistroEntrada.StartPosition = FormStartPosition.CenterScreen
            objRegistroEntrada.ShowDialog()
        End If
    End Sub

    Private Sub SalidasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidasToolStripMenuItem2.Click
        If objRegistroSalida Is Nothing Then
            Dim objRegistroSalida = New registroSalida()
            objRegistroSalida.StartPosition = FormStartPosition.CenterScreen
            objRegistroSalida.ShowDialog()
        End If
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        If objConfigCaja Is Nothing Then
            Dim objConfigCaja = New configuracion
            objConfigCaja.StartPosition = FormStartPosition.CenterScreen
            objConfigCaja.ShowDialog()
        End If
    End Sub

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

    Private Sub FacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaToolStripMenuItem.Click
        Dim Facturas As New Facturacion
        Facturas.MdiParent = Me
        Facturas.WindowState = FormWindowState.Maximized

        Facturas.StartPosition = FormStartPosition.CenterScreen
        Facturas.Show()
    End Sub
End Class
