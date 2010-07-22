Imports MindTec.Componentes

Public Class Cat_Clientes

#Region "  Variables de trabajo  "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    ' Grid datos para ABONOS
    Dim montoDef As Decimal

    ' Grid datos para CUENTAS
    Public dsDatosCuentas As DataSet
    Public dtCuentas As DataTable
    Public viewDatosCuentas As Object
    Public DsViewCuentas As Object

    ' Grid datos para CLIENTES
    Dim dsDatosClientes As DataSet
    Dim dtClientes As DataTable
    Dim viewDatosClientes As Object
    Dim DsViewClientes As Object

    ' Para las consultas
    Dim idCliente As String
    Dim codigo As String
    Dim copiaCodigo As String
#End Region

#Region "  Grid Datos CLIENTES  "

    Sub CrearDsDatosCLIENTES()
        dsDatosClientes = New DataSet("Root")
        dtClientes = New DataTable("Table")
        dsDatosClientes.Tables.Add(dtClientes)

        dsDatosClientes.Tables("Table").Columns.Add("C1", GetType(String))
        dsDatosClientes.Tables("Table").Columns.Add("C2", GetType(String))
        dsDatosClientes.Tables("Table").Columns.Add("C3", GetType(String))
        dsDatosClientes.Tables("Table").Columns.Add("C4", GetType(String))
        dsDatosClientes.Tables("Table").Columns.Add("C5", GetType(String))
        dsDatosClientes.Tables("Table").Columns.Add("C6", GetType(String))
        dsDatosClientes.Tables("Table").Columns.Add("C7", GetType(String))

    End Sub

    Sub ConfiguraGridDatosCLIENTES()
        viewDatosClientes = dsDatosClientes.Tables("Table").DefaultView

        viewDatosClientes.AllowEdit = False
        viewDatosClientes.AllowNew = False
        viewDatosClientes.AllowDelete = True

        GridDatosCLIENTES.FixedRows = 1
        GridDatosCLIENTES.FixedColumns = 1
        GridDatosCLIENTES.DeleteRowsWithDeleteKey = False
        GridDatosCLIENTES.DeleteQuestionMessage = Nothing
        GridDatosCLIENTES.SelectionMode = SourceGrid.GridSelectionMode.Row

        ' Renglon encabezado

        GridDatosCLIENTES.Columns.Insert(0, SourceGrid.DataGridColumn.CreateRowHeader(GridDatosCLIENTES))

        Dim BindList2 As DevAge.ComponentModel.IBoundList = New DevAge.ComponentModel.BoundDataView(viewDatosClientes)

        ' Se crean las columnas.
        GridDatosCrearColumnasCLIENTES(GridDatosCLIENTES.Columns, BindList2)

        GridDatosCLIENTES.DataSource = BindList2

        Dim cColorHeader As Color
        cColorHeader = Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(168, Byte), Integer))

        'Vista columna encabezado

        Dim viewcolumnheader As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewcolumnheader.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft

        Dim viewcolumnheader2 As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader2 As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader2.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewcolumnheader2.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight

        Dim viewcolumnheader3 As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader3 As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader3.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewcolumnheader3.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter


        GridDatosCLIENTES.GetCell(0, 1).View = viewcolumnheader3
        GridDatosCLIENTES.GetCell(0, 2).View = viewcolumnheader
        GridDatosCLIENTES.GetCell(0, 3).View = viewcolumnheader
        GridDatosCLIENTES.GetCell(0, 4).View = viewcolumnheader
        GridDatosCLIENTES.GetCell(0, 5).View = viewcolumnheader3
        GridDatosCLIENTES.GetCell(0, 6).View = viewcolumnheader

    End Sub

    Private Sub GridDatosCrearColumnasCLIENTES(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
        'Borders

        Dim border As DevAge.Drawing.RectangleBorder = New DevAge.Drawing.RectangleBorder(New DevAge.Drawing.BorderLine(Color.White), New DevAge.Drawing.BorderLine(Color.White))
        'gcolorRow esta declarada en el moduloGeneral

        'vistas
        Dim viewCenter As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewCenter.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewCenter.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter


        Dim viewIzquierda As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewIzquierda.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewIzquierda.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft

        Dim viewDerecha As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewDerecha.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewDerecha.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight

        Dim myfont As New Font("Verdana", 8, FontStyle.Regular)

        'Eventos

        Dim gridKeydown As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents
        AddHandler gridKeydown.KeyDown, New KeyEventHandler(AddressOf Grid_KeyDown)

        'Definicion de la celda
        Dim EditorCustom As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        EditorCustom.EditableMode = SourceGrid.EditableMode.None

        'Crear columnas
        Dim GridColumn As SourceGrid.DataGridColumn

        GridColumn = GridDatosCLIENTES.Columns.Add("C1", "ID", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCLIENTES.Columns.Add("C2", "Nombre", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewIzquierda
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCLIENTES.Columns.Add("C3", "Colonia", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewIzquierda
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCLIENTES.Columns.Add("C4", "Dirección", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewIzquierda
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCLIENTES.Columns.Add("C5", "Teléfono", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCLIENTES.Columns.Add("C6", "E-Mail", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewIzquierda
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridDatosCLIENTES.Columns(0).Visible = False

        GridDatosCLIENTES.Columns.SetWidth(1, 50)
        GridDatosCLIENTES.Columns.SetWidth(2, 200)
        GridDatosCLIENTES.Columns.SetWidth(3, 145)
        GridDatosCLIENTES.Columns.SetWidth(4, 300)
        GridDatosCLIENTES.Columns.SetWidth(5, 90)
        GridDatosCLIENTES.Columns.SetWidth(6, 170)

    End Sub
#End Region

#Region "  Grid Datos CUENTAS  "

    Sub CreardsDatosCuentas()

        dsDatosCuentas = New DataSet("Root")
        dtCuentas = New DataTable("Table")
        dsDatosCuentas.Tables.Add(dtCuentas)

        'DsDatos.Tables("Table").Columns.Add("C0", GetType(String))
        'COLUMNAS
        dsDatosCuentas.Tables("Table").Columns.Add("C1", GetType(String))
        dsDatosCuentas.Tables("Table").Columns.Add("C2", GetType(String))
        dsDatosCuentas.Tables("Table").Columns.Add("C3", GetType(String))
        dsDatosCuentas.Tables("Table").Columns.Add("C4", GetType(String))
        dsDatosCuentas.Tables("Table").Columns.Add("C5", GetType(String))

    End Sub

    Sub ConfiguraGridDatosCuentas()
        viewDatosCuentas = dsDatosCuentas.Tables("Table").DefaultView

        viewDatosCuentas.AllowEdit = False
        viewDatosCuentas.AllowNew = False
        viewDatosCuentas.AllowDelete = True

        GridDatosCuentas.FixedRows = 1
        GridDatosCuentas.FixedColumns = 1
        GridDatosCuentas.DeleteRowsWithDeleteKey = False
        GridDatosCuentas.DeleteQuestionMessage = Nothing
        GridDatosCuentas.Selection.EnableMultiSelection = False

        ' Renglon encabezado

        GridDatosCuentas.Columns.Insert(0, SourceGrid.DataGridColumn.CreateRowHeader(GridDatosCuentas))

        Dim BindList2 As DevAge.ComponentModel.IBoundList = New DevAge.ComponentModel.BoundDataView(viewDatosCuentas)

        ' Se crean las columnas.
        GridDatosCrearColumnasCUENTAS(GridDatosCuentas.Columns, BindList2)

        GridDatosCuentas.DataSource = BindList2

        Dim cColorHeader As Color
        cColorHeader = Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(168, Byte), Integer))

        'Vista columna encabezado
        Dim viewcolumnheader As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewcolumnheader.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft

        Dim viewcolumnheader2 As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader2 As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader2.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewcolumnheader2.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight

        Dim viewcolumnheader3 As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader3 As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader3.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewcolumnheader3.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter

        'COLUMNAS
        GridDatosCuentas.GetCell(0, 1).View = viewcolumnheader3
        GridDatosCuentas.GetCell(0, 2).View = viewcolumnheader
        GridDatosCuentas.GetCell(0, 3).View = viewcolumnheader3
        GridDatosCuentas.GetCell(0, 4).View = viewcolumnheader3
        GridDatosCuentas.GetCell(0, 5).View = viewcolumnheader3

    End Sub

    Private Sub GridDatosCrearColumnasCUENTAS(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
        'Borders

        Dim border As DevAge.Drawing.RectangleBorder = New DevAge.Drawing.RectangleBorder(New DevAge.Drawing.BorderLine(Color.Black), New DevAge.Drawing.BorderLine(Color.Black))
        'gcolorRow esta declarada en el moduloGeneral

        'vistas
        Dim viewCenter As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewCenter.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewCenter.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter

        Dim viewIzquierda As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewIzquierda.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewIzquierda.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft

        Dim viewDerecha As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewDerecha.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewDerecha.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight

        Dim myfont As New Font("Verdana", 8, FontStyle.Regular)


        'EVENTOS

        Dim gridKeydown As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents
        AddHandler gridKeydown.KeyDown, New KeyEventHandler(AddressOf Grid_KeyDown)

        'Definicion de la celda
        Dim EditorCustom As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        EditorCustom.EditableMode = SourceGrid.EditableMode.None

        'Crear columnas
        Dim GridColumn As SourceGrid.DataGridColumn

        GridColumn = GridDatosCuentas.Columns.Add("C1", "Cuenta", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCuentas.Columns.Add("C2", "Artículo(s)", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewIzquierda
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCuentas.Columns.Add("C3", "Monto", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewDerecha
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCuentas.Columns.Add("C4", "Adeudo", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewDerecha
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosCuentas.Columns.Add("C5", "Abonado", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewDerecha
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridDatosCuentas.Columns(0).Visible = False

        ''COLUMNAS

        GridDatosCuentas.Columns.SetWidth(1, 70)
        GridDatosCuentas.Columns.SetWidth(2, 149)
        GridDatosCuentas.Columns.SetWidth(3, 128)
        GridDatosCuentas.Columns.SetWidth(4, 128)
        GridDatosCuentas.Columns.SetWidth(5, 128)

    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
#End Region

#Region "  Evento: Cat_Clientes - LOAD  "
    Private Sub Cat_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ocultarControlesAbonos()

        showClientsGrid()

        ' Ocultar algunos elementos.
        ClientesTabControl.Visible = False

        Me.Grabar.Visible = False
        ' Se cargan el comboBox de Estados
        Caja = "Consulta114a" : Parametros = ""
        ObjRet = lConsulta.LlamarCaja(Caja, 2, Parametros)
        EstadosComboBox.DataSource = ObjRet.DS.Tables(0)
        EstadosComboBox.DisplayMember = ObjRet.DS.Tables(0).Columns(0).Caption.ToString
        EstadosComboBox.Text = "Aguascalientes"

        Caja = "Consulta114b" : Parametros = "V1=" & EstadosComboBox.Text & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, 2, Parametros)

        CiudadesComboBox.DataSource = ObjRet.DS.Tables(0)
        CiudadesComboBox.DisplayMember = ObjRet.DS.Tables(0).Columns(0).Caption.ToString

        CreardsDatosCuentas()
        ConfiguraGridDatosCuentas()
        CrearDsDatosCLIENTES()
        ConfiguraGridDatosCLIENTES()

        consulta128()

    End Sub
#End Region

#Region " Rutinas "
    Sub MoverFlechas(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Down, Keys.Up
                If e.KeyCode = Keys.Up Then
                    SendKeys.Send("+{TAB}")
                Else
                    SendKeys.Send("{TAB}")
                End If
        End Select
    End Sub

    Sub Cerrar()
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas salir de esta pantalla?", "HidroIntel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtEstado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub
    Private Sub AdeudosTabPage_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdeudosTabPage.Enter
        mostrarControlesAbonos()
    End Sub

    Private Sub AdeudosTabPage_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdeudosTabPage.Leave
        ocultarControlesAbonos()
    End Sub

#End Region

#Region "  Botón BUSCAR  "
    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        textBoxCliente.Enabled = True

        showClientsGrid()
        textBoxCliente.Clear()
        textBoxCliente.Focus()
        Limpiar.Visible = False
        Grabar.Visible = False
        ToolStripButtonNuevo.Visible = True
        ToolStripStatusLabelClientes.Text = "Escriba el nombre o número de identificación de un cliente para filtrar los resultados."

        consulta128()

    End Sub
#End Region

#Region "  Botón NUEVO  "
    Private Sub ToolStripButtonNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonNuevo.Click
        limpiarPantalla()
        showData()
        ToolStripButtonNuevo.Visible = False
        Limpiar.Visible = True
        Grabar.Visible = True

        copiaCodigo = ""

        ClientesTabControl.SelectTab(0)
        TxtNombre.Focus()
    End Sub
#End Region

#Region "  Botón GRABAR  "
    Private Sub Grabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grabar.Click
        'Variable de trabajo
        Dim Result As DialogResult
        Dim resultado As String
        Result = MessageBox.Show("¿Desea guardar los cambios realizados?  ", " Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            grabra105()
            resultado = lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False)
            If ObjRet.bOk Then
                MessageBox.Show(" " & resultado, " Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarPantalla()
            Else
                MessageBox.Show(" " & resultado, " Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            showClientsGrid()

            consulta128()

            Limpiar.Visible = False
            Grabar.Visible = False
        End If
    End Sub
#End Region

#Region "  Botón LIMPIAR  "
    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        limpiarPantalla()
    End Sub
#End Region

#Region "  Botón ELIMINAR CUENTA  "
    Private Sub ToolStripButtonEliminarCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonEliminarCuenta.Click
        Dim pos As Integer = posRowCuentas()
        If pos < 0 Then
            Return
        End If

        Dim resul As DialogResult
        resul = MessageBox.Show(" La cuenta será liquidada, ¿desea continuar?", " Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resul = Windows.Forms.DialogResult.Yes Then
            eliminar104()
        End If
    End Sub
#End Region

#Region "  Botón DETALLE  "
    Private Sub ToolStripButtonDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonDetalle.Click
        Dim pos As Integer = posRowCuentas()
        If pos < 0 Then
            Return
        End If

        Dim idCuenta As Integer = dsDatosCuentas.Tables(0).Rows(pos).Item(0)

        Dim objDetalle As New Cat_Clientes_DetalleVenta
        objDetalle.nomCliente = textBoxCliente.Text.Trim
        objDetalle.idCliente = idCliente
        objDetalle.codigo = codigo
        objDetalle.cargaIdCuenta(idCuenta, Me.textBoxCliente.Text.Trim, Me)
        objDetalle.StartPosition = FormStartPosition.CenterScreen
        objDetalle.Show()
    End Sub
#End Region

#Region "  Botón ABONOS REGISTRADOS  "
    Private Sub ToolStripButtonAbonos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonAbonos.Click
        Dim pos As Integer = posRowCuentas()
        If pos < 0 Then
            Return
        End If
        Dim idCuenta As Integer = dsDatosCuentas.Tables(0).Rows(pos).Item(0)

        Dim objAbonos As New Cat_Cliente_DetalleAbono
        objAbonos.cargaIdCuenta(idCuenta)
        objAbonos.StartPosition = FormStartPosition.CenterScreen
        objAbonos.Show()
    End Sub
#End Region

#Region "  Botón ABONAR  "
    Private Sub ToolStripButtonAbonar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonAbonar.Click
        Dim pos As Integer = posRowCuentas()
        If pos < 0 Then
            Return
        End If

        Dim idCuenta As String = dsDatosCuentas.Tables(0).Rows(pos).Item(0).ToString

        Dim objRegistroAbono As New Cat_Clientes_RegistroAbono()
        objRegistroAbono.idCliente = idCliente
        objRegistroAbono.codigo = codigo
        objRegistroAbono.nomCliente = textBoxCliente.Text.Trim
        objRegistroAbono.StartPosition = FormStartPosition.CenterScreen
        objRegistroAbono.pasoVariables(pos, _
                                       idCuenta, _
                                       usuario, _
                                       codigo, _
                                       dsDatosCuentas, _
                                       DsViewCuentas, _
                                       lblSaldoActual, _
                                       Me.TxtNombre.Text)
        objRegistroAbono.Show()
    End Sub
#End Region

#Region "  Rutina: limpiarPantalla  "
    Sub limpiarPantalla()
        Me.textBoxCliente.Clear()
        Me.TxtNombre.Clear()
        Me.txtRfc.Clear()
        Me.TxtColonia.Clear()
        Me.TxtDireccion.Clear()
        Me.Txtcp.Clear()
        Me.TxtMail.Clear()
        Me.TxtTel.Clear()
        Me.TxtTel2.Clear()
        Me.TxtCel.Clear()
        Me.TxtCel2.Clear()
        Me.txtext.Clear()
        Me.txtext2.Clear()
        Me.TxtFax.Clear()
        Me.txtCodigo.Clear()
        Me.txtLimCred.Value = 0

        lblSaldoActual.Text = "$ 0.00"
        lblLimiteCredito.Text = "$ 0.00"

        dsDatosCuentas.Tables(0).Clear()

        TxtNombre.Focus()
    End Sub
#End Region

#Region "  Rutina: posRowCuentas  "
    Private Function posRowCuentas() As Integer
        Dim pos() As Integer = GridDatosCuentas.Selection.GetSelectionRegion.GetRowsIndex
        If pos.Length = 0 Then
            Return -1
        Else
            Return pos(0) - 1
        End If
    End Function
#End Region

#Region "  Rutina: posRowClientes "
    Private Function posRowClientes() As Integer
        Dim pos() As Integer = GridDatosCLIENTES.Selection.GetSelectionRegion.GetRowsIndex
        If pos.Length = 0 Then
            Return -1
        Else
            Return pos(0) - 1
        End If
    End Function
#End Region

#Region "  Rutina: mostrarControlesAbonos  "
    Private Sub mostrarControlesAbonos()
        ToolStripSeparator1.Visible = True
        ToolStripButtonEliminarCuenta.Visible = True
        ToolStripButtonAbonos.Visible = True
        ToolStripButtonDetalle.Visible = True
        ToolStripButtonAbonar.Visible = True
    End Sub
#End Region

#Region "  Rutina: ocultarControlesAbonos  "
    Private Sub ocultarControlesAbonos()
        ToolStripSeparator1.Visible = False
        ToolStripButtonEliminarCuenta.Visible = False
        ToolStripButtonAbonos.Visible = False
        ToolStripButtonDetalle.Visible = False
        ToolStripButtonAbonar.Visible = False
    End Sub
#End Region

#Region "  Rutina: updateGrid  "
    Public Sub updateGrid()
        '|-------------------------------------------
        '| Se actualiza los datos de su estado de cuenta.
        '|-------------------------------------------

        Dim pos As Integer = posRowCuentas()

        Caja = "Consulta117" : Parametros = "V1=" & Me.textBoxCliente.Text.Trim & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

        ' Se inserta la consulta en el Grid Cuentas.
        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables.Count > 0 Then
                    For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                        dsDatosCuentas.Tables(0).ImportRow(ObjRet.DS.Tables(0).Rows(i))
                    Next
                    dsDatosCuentas.Tables(0).AcceptChanges()
                    DsViewCuentas = dsDatosCuentas.Tables(0).DefaultView
                    'Else
                    '   FilaVacia()

                End If
            End If
        End If

        Dim deudaActualizada As Double
        Try
            deudaActualizada = dsDatosCuentas.Tables(0).Rows(pos).Item(3)
        Catch ex As Exception
            deudaActualizada = 0
        End Try

        Caja = "Consulta105" : Parametros = "V1=" & Me.textBoxCliente.Text.Trim
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)

        lblSaldoActual.Text = "$ " & lConsulta.ObtenerValor("V17", ObjRet.sResultado, "|")


    End Sub
#End Region

#Region "  Rutina: showData  "
    Private Sub showData()
        PanelDatos.SetBounds(11, 138, 1000, 525)
        ClientesTabControl.Visible = True
        PanelDatos.Visible = True
        Grabar.Visible = True
        ToolStripStatusLabelClientes.Text = "Seleccione el campo de texto Cliente para hacer una nueva búsqueda."

        PanelGrid.Visible = False
    End Sub
#End Region

#Region "  Rutina: showClientsGrid  "
    Sub showClientsGrid()
        PanelGrid.Visible = True
        PanelGrid.SetBounds(11, 150, 1000, 525)

        PanelDatos.Visible = False
    End Sub
#End Region

#Region "  Rutina: consulta105  "
    Sub consulta105()

        Caja = "Consulta105" : Parametros = "V1=" & idCliente.Trim
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
        If ObjRet.bOk Then

            'Asignar
            Me.TxtNombre.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            Me.txtRfc.Text = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|")
            Me.TxtColonia.Text = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
            Me.TxtDireccion.Text = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|")
            Me.Txtcp.Text = lConsulta.ObtenerValor("V5", ObjRet.sResultado, "|")
            Me.EstadosComboBox.Text = lConsulta.ObtenerValor("V6", ObjRet.sResultado, "|")
            Me.CiudadesComboBox.Text = lConsulta.ObtenerValor("V7", ObjRet.sResultado, "|")
            Me.TxtTel.Text = lConsulta.ObtenerValor("V8", ObjRet.sResultado, "|")
            Me.txtext.Text = lConsulta.ObtenerValor("V9", ObjRet.sResultado, "|")
            Me.TxtTel2.Text = lConsulta.ObtenerValor("V10", ObjRet.sResultado, "|")
            Me.txtext2.Text = lConsulta.ObtenerValor("V11", ObjRet.sResultado, "|")
            Me.TxtCel.Text = lConsulta.ObtenerValor("V12", ObjRet.sResultado, "|")
            Me.TxtCel2.Text = lConsulta.ObtenerValor("V13", ObjRet.sResultado, "|")
            Me.TxtFax.Text = lConsulta.ObtenerValor("V14", ObjRet.sResultado, "|")
            Me.TxtMail.Text = lConsulta.ObtenerValor("V15", ObjRet.sResultado, "|")
            Me.txtCodigo.Text = lConsulta.ObtenerValor("V18", ObjRet.sResultado, "|")

            If lConsulta.ObtenerValor("V16", ObjRet.sResultado, "|") = "" Then
                Me.txtLimCred.Value = 0
                lblLimiteCredito.Text = "$ 0.00"
            Else
                Me.txtLimCred.Value = lConsulta.ObtenerValor("V16", ObjRet.sResultado, "|")
                lblLimiteCredito.Text = FormatCurrency(lConsulta.ObtenerValor("V16", ObjRet.sResultado, "|"))
            End If

            ' MODIFICAR 
            If lConsulta.ObtenerValor("V17", ObjRet.sResultado, "|") = "" Then
                lblSaldoActual.Text = "$ 0.00"
            Else
                lblSaldoActual.Text = FormatCurrency(lConsulta.ObtenerValor("V17", ObjRet.sResultado, "|"))
            End If
        End If
    End Sub
#End Region

#Region "  Rutina: consulta117  "
    Sub consulta117()
        'Actualiza el grid de las cuentas por cobrar de un cliente.

        dsDatosCuentas.Tables(0).Clear()

        Caja = "Consulta117" : Parametros = "V1=" & codigo.Trim & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables.Count > 0 Then
                    For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                        dsDatosCuentas.Tables(0).ImportRow(ObjRet.DS.Tables(0).Rows(i))
                    Next
                    dsDatosCuentas.Tables(0).AcceptChanges()
                    DsViewCuentas = dsDatosCuentas.Tables(0).DefaultView
                    'Else
                    '   FilaVacia()

                End If
            End If
        End If
    End Sub
#End Region

#Region "  Rutina: consulta128  "
    Sub consulta128()
        'Actualiza el grid de todos los clientes según el valor de textBoxCliente.
        dsDatosClientes.Tables(0).Clear()

        Caja = "consulta128" : Parametros = "V1=" & textBoxCliente.Text.Trim
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        ' Se inserta la consulta en el Grid Cuentas.
        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables.Count > 0 Then
                    Dim rows As Integer
                    rows = ObjRet.DS.Tables(0).Rows.Count - 1
                    For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                        dsDatosClientes.Tables(0).ImportRow(ObjRet.DS.Tables(0).Rows(i))
                    Next
                    dsDatosClientes.Tables(0).AcceptChanges()
                    DsViewClientes = dsDatosClientes.Tables(0).DefaultView
                    'Else
                    '   FilaVacia()

                End If
            End If
        End If
    End Sub
#End Region

#Region "  Rutina: GRABAR105  "
    Sub grabra105()
        Caja = "Grabar105" : Parametros = "V1=" & copiaCodigo.Trim & _
                                  "|V2=" & Me.TxtNombre.Text.Trim & _
                                  "|V3=" & Me.txtRfc.Text.Trim & _
                                  "|V4=" & Me.TxtColonia.Text.Trim & _
                                  "|V5=" & Me.TxtDireccion.Text.Trim & _
                                  "|V6=" & Me.Txtcp.Text.Trim & _
                                  "|V7=" & Me.EstadosComboBox.Text.Trim & _
                                  "|V8=" & Me.CiudadesComboBox.Text.Trim & _
                                  "|V9=" & Me.TxtTel.Text.Trim & _
                                  "|V10=" & Me.txtext.Text.Trim & _
                                  "|V11=" & Me.TxtTel2.Text.Trim & _
                                  "|V12=" & Me.txtext2.Text.Trim & _
                                  "|V13=" & Me.TxtCel.Text.Trim & _
                                  "|V14=" & Me.TxtCel2.Text.Trim & _
                                  "|V15=" & Me.TxtFax.Text.Trim & _
                                  "|V16=" & Me.TxtMail.Text.Trim & _
                                  "|V17=" & Me.txtLimCred.Value & _
                                  "|V18=" & Me.txtCodigo.Text.Trim

        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

    End Sub
#End Region

#Region "  Rutina: eliminar104  "
    Sub eliminar104()
        Dim idCuenta As String
        Dim adeudo As String

        idCuenta = dsDatosCuentas.Tables(0).Rows(posRowCuentas).Item(0).ToString
        adeudo = dsDatosCuentas.Tables(0).Rows(posRowCuentas).Item(3).ToString.Trim
        adeudo = adeudo.Remove(0, 2)



        Caja = "eliminar104" : Parametros = "V1=" & idCuenta & _
                                            "|V2=" & adeudo & _
                                            "|V3=" & TxtNombre.Text.Trim & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)

        consulta117()

        consulta105()

    End Sub
#End Region

#Region "  Evento: textBoxCliente - TEXT CHANGED  "
    Private Sub textBoxCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBoxCliente.TextChanged
        consulta128()
    End Sub
#End Region

#Region "  Evento: EstadosComboBox - SELECTED VALUE CHANGED  "
    Private Sub EstadosComboBox_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadosComboBox.SelectedValueChanged
        Dim objRet2 As CRetorno

        Caja = "Consulta114b" : Parametros = "V1=" & EstadosComboBox.Text & "|"
        objRet2 = lConsulta.LlamarCaja(Caja, 2, Parametros)

        CiudadesComboBox.DataSource = objRet2.DS.Tables(0)
        CiudadesComboBox.DisplayMember = objRet2.DS.Tables(0).Columns(0).Caption.ToString
    End Sub
#End Region

#Region "  Evento: GridDatosCLIENTES - DOUBLECLICK  "
    Private Sub GridDatosCLIENTES_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDatosCLIENTES.DoubleClick
        textBoxCliente.Enabled = False
        Dim nom As String

        nom = dsDatosClientes.Tables(0).Rows(posRowClientes).Item(1).ToString
        idCliente = dsDatosClientes.Tables(0).Rows(posRowClientes).Item(0).ToString
        codigo = dsDatosClientes.Tables(0).Rows(posRowClientes).Item(6).ToString

        textBoxCliente.Text = nom.Trim

        consulta105()

        consulta117()

        showData()

        copiaCodigo = txtCodigo.Text.Trim

        ClientesTabControl.SelectedIndex = 0

    End Sub
#End Region

#Region "  Rutinas: cambio de textBox con Enter  "
    Private Sub TxtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtCodigo.Focus()
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtRfc.Focus()
        End If
    End Sub

    Private Sub txtRfc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRfc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            EstadosComboBox.Focus()
        End If
    End Sub

    Private Sub EstadosComboBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EstadosComboBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            CiudadesComboBox.Focus()
        End If
    End Sub

    Private Sub CiudadesComboBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CiudadesComboBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtDireccion.Focus()
        End If
    End Sub

    Private Sub TxtDireccion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDireccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtColonia.Focus()
        End If
    End Sub

    Private Sub TxtColonia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtColonia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Txtcp.Focus()
        End If
    End Sub

    Private Sub Txtcp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcp.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtLimCred.Select(0, 10)
            txtLimCred.Focus()
        End If
    End Sub

    Private Sub txtLimCred_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLimCred.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtMail.Focus()
        End If
    End Sub

    Private Sub TxtMail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMail.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtTel.Focus()
        End If
    End Sub

    Private Sub TxtTel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTel.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtext.Focus()
        End If
    End Sub

    Private Sub txtext_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtext.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtTel2.Focus()
        End If
    End Sub

    Private Sub TxtTel2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTel2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtext2.Focus()
        End If
    End Sub

    Private Sub txtext2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtext2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtCel.Focus()
        End If
    End Sub

    Private Sub TxtCel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCel.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtCel2.Focus()
        End If
    End Sub

    Private Sub TxtCel2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCel2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TxtFax.Focus()
        End If
    End Sub

    Private Sub TxtFax_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFax.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Grabar.Select()
        End If
    End Sub
#End Region

#Region "  Evento: ClientesTabControl - ENTER/LEAVE  "

#End Region    

End Class

