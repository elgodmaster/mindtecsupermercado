Imports System.Data
Imports System.Data.SqlClient

Public Class Principal

#Region "Variables De Trabajo"
    Private DsDatos As DataSet
    Private ViewDatos As DataView
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    'Variables para Caja
    Dim objRegistroEntrada = Nothing
    Dim objRegistroSalida = Nothing

    Dim objDineroCaja = Nothing
#End Region

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        Dim inic As New inicial
        inic.MdiParent = Me
        inic.WindowState = FormWindowState.Maximized

        inic.StartPosition = FormStartPosition.CenterScreen
        inic.Show()
        Me.MenuStrip1.MdiWindowListItem = Ventanas
        '----------   Muestra la MAC  ------------
        MessageBox.Show("La direcci�n MAC de su equipo es: " & obtenMac(), "MAC", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Cotizaci�nToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)

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

    'Private Sub Devoluci�nToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Devoluci�nToolStripMenuItem1.Click
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
        Dim frm_sal As New Movimiento_Salidas
        frm_sal.MdiParent = Me
        frm_sal.WindowState = FormWindowState.Maximized

        frm_sal.StartPosition = FormStartPosition.CenterScreen
        frm_sal.Show()
    End Sub

    Private Sub corteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles corteToolStripMenuItem.Click

        ' Se verifica que la fecha m�s reciente en la tabla caja sea distinta a la actual.
        ' Si lo es, se procede a ingresar un nuevo registro con la fecha actual.

        ' Conexi�n.
        Dim lConexion = New SqlConnection

        '*-- Para conectar desde el servidor.                --*
        Dim sCadena As String = String.Empty
        sCadena = My.Settings.Servidor
        lConexion.ConnectionString = sCadena

        '*-- Para conectarla localmente desde PCLINDORMARIO. --*
        'lConexion.ConnectionString = "Data Source=PCLINDORMARIO;Initial Catalog=PVF_LogicaNegocios;Integrated Security=True"

        Try
            lConexion.Open()
        Catch ex As Exception
            MessageBox.Show("Error en la conexion.")
        End Try

        ' Valida la fecha para solicitar o no, el dinero inicial en caja.
        Dim objSqlAdapter As New SqlDataAdapter
        Dim objDataSet As New DataSet
        Dim objCommand As New SqlCommand

        objCommand.CommandText = "CONSULTA_FECHA_CAJA"
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.Connection = lConexion

        With objCommand.Parameters
            .Clear()
            .Add("@fecha", SqlDbType.VarChar, 20).Value = ""
            .Item("@fecha").Direction = ParameterDirection.InputOutput
            .Add("@resul", SqlDbType.VarChar, 20).Value = ""
            .Item("@resul").Direction = ParameterDirection.InputOutput
        End With

        objSqlAdapter.SelectCommand = objCommand

        Try
            objSqlAdapter.Fill(objDataSet)
        Catch ex As Exception
            MessageBox.Show("Error al tratar de realizar la conexi�n.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If objCommand.Parameters.Item("@resul").Value = "OK" Then
            If objCommand.Parameters.Item("@fecha").Value <> Date.Now.Date Then
                ' Presenta la ventana para ingresar el dinero inicial en la caja.
                If objDineroCaja Is Nothing Then
                    Dim objDineroCaja As New dineroCaja
                    objDineroCaja.numDineroInicial.Focus()
                    objDineroCaja.numDineroInicial.Select(0, 4)
                    objDineroCaja.StartPosition = FormStartPosition.CenterScreen
                    objDineroCaja.Show()
                End If
            Else
                ' Configurar y mostrar la ventana caja.
                Dim cajaActual As New Caja
                cajaActual.MdiParent = Me
                cajaActual.WindowState = FormWindowState.Maximized

                cajaActual.StartPosition = FormStartPosition.CenterScreen
                cajaActual.Show()
            End If
        ElseIf (objCommand.Parameters.Item("@resul").Value = "ERROR") Then
            MessageBox.Show("No se encontr� ning�n registro.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' Se cierra la conexi�n.
        lConexion.Close()
    End Sub
    Public Function obtenMac() As String
        Dim str As String
        Dim p As New Process

        ' StartInfo representa el conjunto de par�metros que se van a
        ' utilizar en un proceso.


        p.StartInfo.UseShellExecute = False

        p.StartInfo.RedirectStandardOutput = True

        p.StartInfo.FileName = "GetMac.exe"

        p.StartInfo.Arguments = "/fo list"

        p.Start()

        'StandardOutput Obtiene una secuencia que se utiliza para leer la salida de la aplicaci�n.

        str = p.StandardOutput.ReadLine

        str = p.StandardOutput.ReadLine

        p.WaitForExit()

        Return str.Substring(23)
    End Function
End Class
