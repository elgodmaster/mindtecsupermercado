Imports MindTec.Componentes

Public Class InventarioEntradas

#Region "  Variables de trabajo  "

    Dim DsDatos As DataSet
    Dim ViewDatos As DataView
    Private DsView As DataView
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Dim identrada As String
    Dim TotalEntrada As Double = 0

    Dim numFolioEntrada As String = ""

#End Region

#Region "  Grid Datos  "

    Sub CrearDsDatos()
        'Creando Datatable  con tipo de dato
        Dim dt As DataTable
        DsDatos = New DataSet("Root")
        dt = New DataTable("Table")
        DsDatos.Tables.Add(dt)

        DsDatos.Tables("Table").Columns.Add("C1", GetType(String))
        DsDatos.Tables("Table").Columns.Add("C2", GetType(String))
        DsDatos.Tables("Table").Columns.Add("C3", GetType(Double))
        DsDatos.Tables("Table").Columns.Add("C4", GetType(String))
        DsDatos.Tables("Table").Columns.Add("C5", GetType(Double))
        DsDatos.Tables("Table").Columns.Add("C6", GetType(Double))
        DsDatos.Tables("Table").Columns.Add("C7", GetType(Integer))
        DsDatos.Tables("Table").Columns.Add("C8", GetType(String))

    End Sub

    Sub ConfiguraGridDatos()
        ViewDatos = DsDatos.Tables("Table").DefaultView

        ViewDatos.AllowEdit = False
        ViewDatos.AllowNew = False
        ViewDatos.AllowDelete = True

        GridDatos.FixedRows = 1
        GridDatos.FixedColumns = 1
        GridDatos.DeleteRowsWithDeleteKey = False
        GridDatos.DeleteQuestionMessage = Nothing


        'Renglon encabezado

        GridDatos.Columns.Insert(0, SourceGrid.DataGridColumn.CreateRowHeader(GridDatos))

        Dim BindList2 As DevAge.ComponentModel.IBoundList = New DevAge.ComponentModel.BoundDataView(ViewDatos)

        GridDatosCrearColumnas(GridDatos.Columns, BindList2)

        GridDatos.DataSource = BindList2

        Dim cColorHeader As Color
        cColorHeader = Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(5, Byte), Integer))

        'Vista columna encabezado

        'Vista columna encabezado
        Dim viewcolumnheaderLeft As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader0 As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheaderLeft.Font = New Font("Verdana", 9, FontStyle.Regular)
        viewcolumnheaderLeft.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft

        Dim viewcolumnheaderRight As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader2 As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheaderRight.Font = New Font("Verdana", 9, FontStyle.Regular)
        viewcolumnheaderRight.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight

        Dim viewcolumnheaderCenter As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader3 As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheaderCenter.Font = New Font("Verdana", 9, FontStyle.Regular)
        viewcolumnheaderCenter.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter

        GridDatos.GetCell(0, 1).View = viewcolumnheaderCenter
        GridDatos.GetCell(0, 2).View = viewcolumnheaderLeft
        GridDatos.GetCell(0, 3).View = viewcolumnheaderCenter
        GridDatos.GetCell(0, 4).View = viewcolumnheaderCenter
        GridDatos.GetCell(0, 5).View = viewcolumnheaderCenter
        GridDatos.GetCell(0, 6).View = viewcolumnheaderCenter
        GridDatos.GetCell(0, 7).View = viewcolumnheaderRight

    End Sub

    Private Sub GridDatosCrearColumnas(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
        'Borders

        Dim border As DevAge.Drawing.RectangleBorder = New DevAge.Drawing.RectangleBorder(New DevAge.Drawing.BorderLine(Color.Black), New DevAge.Drawing.BorderLine(Color.Black))
        'gcolorRow esta declarada en el moduloGeneral
        Dim noBorder As New DevAge.Drawing.RectangleBorder
        noBorder.SetColor(Color.Transparent)

        'vistas
        Dim viewCenter As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewCenter.Font = New Font("Verdana", 11, FontStyle.Bold)
        viewCenter.Border = noBorder
        viewCenter.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter

        Dim viewLeft As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewLeft.Font = New Font("Verdana", 11, FontStyle.Bold)
        viewLeft.Border = noBorder
        viewLeft.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft

        Dim viewRight As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewRight.Font = New Font("Verdana", 11, FontStyle.Bold)
        viewRight.Border = noBorder
        viewRight.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight

        Dim myfont As New Font("Verdana", 8, FontStyle.Regular)

        'Eventos

        Dim gridKeydown As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents
        AddHandler gridKeydown.KeyDown, New KeyEventHandler(AddressOf Grid_KeyDown)

        'Dim Codigokeydown As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents
        'AddHandler Codigokeydown.KeyDown, New KeyEventHandler(AddressOf codigo_keydown)

        Dim Cantidadkeydown As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents
        AddHandler Cantidadkeydown.KeyDown, New KeyEventHandler(AddressOf cant_keydown)

        'Definicion de la celda
        Dim EditorCustom As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        EditorCustom.EditableMode = SourceGrid.EditableMode.None

        Dim Editable As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        Editable.EditableMode = SourceGrid.EditableMode.AnyKey

        Dim editorCantidad As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(Double))
        AddHandler editorCantidad.KeyPress, New KeyPressEventHandler(AddressOf GridCantidad_KeyPress)

        Dim clickEvent As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents()
        AddHandler clickEvent.Click, New EventHandler(AddressOf BotonBorrar_Click)

        'Dim editorCodigo As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        'AddHandler editorCodigo.KeyPress, New KeyPressEventHandler(AddressOf GridCodigo_KeyPress)
        'Crear columnas
        Dim GridColumn As SourceGrid.DataGridColumn

        GridColumn = GridDatos.Columns.Add("C1", "Código", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatos.Columns.Add("C2", "Producto", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewLeft
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatos.Columns.Add("C3", "Cantidad", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatos.Columns.Add("C4", "Unidad", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.EnableStretch

        GridColumn = GridDatos.Columns.Add("C5", "Costo Unitario", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatos.Columns.Add("C6", "Costo Total", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.EnableAutoSize

        GridColumn = GridDatos.Columns.Add("C7", "Entrada", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.None

        GridColumn = GridDatos.Columns.Add("C8", " ", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.None

        GridDatos.Columns(0).Visible = False
        GridDatos.Columns.SetWidth(1, 160)
        GridDatos.Columns.SetWidth(2, 310)
        GridDatos.Columns.SetWidth(3, 75)
        GridDatos.Columns.SetWidth(4, 110)
        GridDatos.Columns.SetWidth(5, 100)
        GridDatos.Columns.SetWidth(6, 150)
        GridDatos.Columns(7).Visible = False
        GridDatos.Columns.SetWidth(8, 10)

    End Sub

#End Region

#Region "  Eventos Principales  "
    Private Sub InventarioEntradas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Cerrar()
            Case Keys.F4
                Limpiar.PerformClick()
            Case Keys.F6

            Case Keys.F9
                Grabar.PerformClick()
        End Select
    End Sub
#End Region

#Region "  Evento: InventarioEntradas - LOAD  "
    Private Sub InventarioEntradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrearDsDatos()
        ConfiguraGridDatos()

        LimpiarPantalla()

        ' Necesario para actualizar el inventario por medio de 
        'grabar109.
        getFolioEntrada()

        CodigoProveedor.Focus()
    End Sub
#End Region

#Region "  Rutina: Llenar Fila  "
    Sub LlenarFila(ByVal Producto As String, ByVal Unidad As String, ByVal Costo As Double)
        If CantidadNumericUpDown.Value < 1 Then
            CantidadNumericUpDown.Value = 1
        End If

        Dim Cantidad As Double = CantidadNumericUpDown.Value
        Dim TotalCosto As Double = 0
        Double.Parse(Costo)
        TotalCosto = Cantidad * Costo
        Dim Igual As Boolean = 0
        Dim Encontro As Boolean = 0
        Dim fila As Integer = 0
        For i As Integer = 0 To DsDatos.Tables("Table").Rows.Count - 1

            If DsDatos.Tables("Table").Rows(i).Item("C1") = Txt_CodigoProducto.Text Then
                Igual = True
                DsDatos.Tables("Table").Rows(i).Item("C3") = DsDatos.Tables("Table").Rows(i).Item("C3") + Cantidad
                DsDatos.Tables("Table").Rows(i).Item("C6") = DsDatos.Tables("Table").Rows(i).Item("C3") * Costo
                DsDatos.Tables("Table").AcceptChanges()

            End If
        Next

        If Igual = False Then
            For j As Integer = 0 To DsDatos.Tables("Table").Rows.Count - 1
                If Len(RTrim(LTrim(DsDatos.Tables("Table").Rows(j).Item("C1")))) = 0 Then
                    Encontro = True
                    fila = j
                    Exit For
                End If

            Next
        End If


        If Igual = False And Encontro = False Then
            Dim registro As DataRow = Me.DsDatos.Tables("Table").NewRow
            Me.DsDatos.Tables("Table").Rows.Add(registro)
            registro!C1 = Txt_CodigoProducto.Text
            registro!C2 = Producto
            registro!C3 = Cantidad
            registro!C4 = Unidad
            registro!C5 = Costo
            registro!C6 = TotalCosto
            registro!C7 = numFolioEntrada


            DsDatos.Tables("Table").AcceptChanges()

        End If

        If Encontro = True Then
            DsDatos.Tables("Table").Rows(fila).Item("C1") = Txt_CodigoProducto.Text
            DsDatos.Tables("Table").Rows(fila).Item("C2") = Producto
            DsDatos.Tables("Table").Rows(fila).Item("C3") = Cantidad
            DsDatos.Tables("Table").Rows(fila).Item("C4") = Unidad
            DsDatos.Tables("Table").Rows(fila).Item("C5") = Costo
            DsDatos.Tables("Table").Rows(fila).Item("C6") = TotalCosto
            DsDatos.Tables("Table").Rows(fila).Item("C7") = numFolioEntrada
            DsDatos.Tables("Table").AcceptChanges()

        End If

        CalculaTotal()
    End Sub

#End Region

#Region "  Rutinas  "
    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                Cerrar()
        End Select
    End Sub

    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        LimpiarPantalla()
    End Sub

    Sub LlenarGrid()
        For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
            DsDatos.Tables("Table").ImportRow(ObjRet.DS.Tables(0).Rows(i))
        Next
        DsDatos.Tables("Table").AcceptChanges()
        DsView = DsDatos.Tables(0).DefaultView
        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables.Count > 0 Then
                    'LlenarGrid()
                    'FilaVacia()
                Else
                    'FilaVacia()
                End If
            End If
        End If
    End Sub

    Sub FilaVacia()
        Dim grid As SourceGrid.DataGrid = GridDatos
        Dim rows() As Object = grid.SelectedDataRows
        Dim row As DataRowView = Nothing

        If DsDatos.Tables("Table").Rows.Count <= 0 Then

            'Variable de Trabajo
            Dim Codigo As String = ""
            Dim Producto As String = ""
            Dim Cantidad As Double = 0
            Dim Unidad As String = ""

            Dim registro As DataRow = Me.DsDatos.Tables("Table").NewRow
            Me.DsDatos.Tables("Table").Rows.Add(registro)
            registro!C1 = Codigo
            registro!C2 = Producto
            registro!C3 = Cantidad
            registro!C4 = Unidad


            DsDatos.Tables("Table").AcceptChanges()

        End If

    End Sub

    Sub Cerrar()
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas salir de esta pantalla?", "SuperMercado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Me.DsDatos = Nothing
            Me.Close()
        End If
    End Sub

    'Sub CatalogoEntradas()
    '    Caja = "Consulta109" : Parametros = ""
    '    If lConsulta Is Nothing Then lConsulta = New ClsConsultas
    '    ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
    '    If ObjRet.bOk Then
    '        Dim nuevo As Grid = New Grid(ObjRet.DS)
    '        numFolioEntrada = nuevo.resultado

    '        If nuevo.resultado = "" Then
    '            Return
    '        End If

    '        Dim e As KeyEventArgs
    '        e = New KeyEventArgs(Keys.Enter)
    '        Me.FolioEntrada_KeyDown(DBNull.Value, e)
    '    Else
    '        MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
    '    End If
    'End Sub


    Sub CatalogoProveedor()
        Caja = "Consulta106" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.CodigoProveedor.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.CodigoProveedor_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

        End If
    End Sub

    Sub CatalogoProductos()
        Caja = "Consulta103" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            Txt_CodigoProducto.Text = nuevo.resultado
        End If
    End Sub
#End Region

#Region "  Rutina: CalcularTotal  "
    Sub CalculaTotal()

        For h As Integer = 0 To DsDatos.Tables("Table").Rows.Count - 1
            TotalEntrada = TotalEntrada + Double.Parse(DsDatos.Tables("Table").Rows(h).Item("C6"))
        Next

        lblTotal.Text = FormatCurrency(TotalEntrada.ToString)
        TotalEntrada = 0

    End Sub
#End Region
    
#Region "  Rutina: LimpiarPantalla  "
    Sub LimpiarPantalla()
        Me.Fecha.Value = Now
        Me.CodigoProveedor.Clear()
        Me.txtFactura.Clear()

        Me.Txt_CodigoProducto.Clear()
        Me.CantidadNumericUpDown.Value = 0

        lblTotal.Text = "$ 0.00"

        Me.DsDatos.Tables("Table").Clear()
        MensajePiePagina.Text = "Esc=Salir F2=Catálogo F4=Limpiar Pantalla F6=Nuevo"

        CodigoProveedor.Focus()
    End Sub
#End Region    

#Region "  Grid Cantidad KeyDown And KeyPress  "
    Private Sub cant_keydown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Dim Grid As SourceGrid.DataGrid = GridDatos
        Dim pos As Integer = Grid.Selection.ActivePosition.Row
        Select Case e.KeyCode
            Case Keys.Enter
                Txt_CodigoProducto.Focus()
        End Select
    End Sub


    Private Sub GridCantidad_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)

        Dim grid As SourceGrid.DataGrid = GridDatos
        Dim rows As Object = grid.SelectedDataRows
        Dim Row As DataRowView = Nothing
        Dim Sender2 As Object = CType(sender.Control, TextBox)
        If Not rows Is Nothing And rows.Length > 0 Then
            Row = CType(rows(0), DataRowView)
            Row.DataView.AllowEdit = True

        End If

    End Sub
#End Region

#Region "  Evento: CodigoProducto - KEY PRESS  "
    Private Sub Txt_CodigoProducto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_CodigoProducto.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.F2)
                CatalogoProductos()
            Case ChrW(Keys.Enter)
                e.Handled = True
                Caja = "Consulta109" : Parametros = "V1=" & Txt_CodigoProducto.Text & "|"
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
                If ObjRet.bOk Then

                    CantidadNumericUpDown.Select(0, 10)
                    CantidadNumericUpDown.Focus()
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    Me.Txt_CodigoProducto.Text = ""
                    CantidadNumericUpDown.Select(0, 10)
                    Me.CantidadNumericUpDown.Value = 0

                    Me.Txt_CodigoProducto.Focus()
                End If
        End Select
    End Sub
#End Region

#Region "  Evento: Cantidad - KEY DOWN  "
    Private Sub Txt_Cantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CantidadNumericUpDown.KeyDown
        Dim Codigo As String = ""
        Dim Producto As String = ""
        Dim Unidad As String = ""
        Dim Costo As Double = 0

        Select Case e.KeyCode
            Case Keys.Enter
                Caja = "Consulta109" : Parametros = "V1=" & Txt_CodigoProducto.Text & "|"
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "6", Parametros)
                If ObjRet.bOk Then
                    Producto = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)
                    Unidad = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|", False)
                    Costo = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|", False)
                    ''Mandar Llamar Llenar Fila con los datos necesarios
                    LlenarFila(Producto, Unidad, Costo)

                    Me.Txt_CodigoProducto.Text = ""

                    CantidadNumericUpDown.Value = 0
                    Me.Txt_CodigoProducto.Focus()
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    Me.Txt_CodigoProducto.Text = ""

                    CantidadNumericUpDown.Value = 0
                    Me.Txt_CodigoProducto.Focus()
                End If
        End Select
    End Sub
#End Region

#Region "  Botón ACTUALIZAR  "
    Private Sub Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grabar.Click
        If GridDatos.DataSource.Count = 0 Then
            MessageBox.Show("No ha registrado productos.", " Entradas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txt_CodigoProducto.Focus()
            Return
        End If

        Caja = "Grabar109" : Parametros = "V1=" & numFolioEntrada & _
                                          "|V2=" & Me.Fecha.Value.ToString("dd/MM/yyyy") & _
                                          "|V3=" & idUsuario & _
                                          "|V4=" & Me.txtFactura.Text.Trim & _
                                          "|V5=" & Me.CodigoProveedor.Text.Trim & _
                                          "|V6=|"

        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros, DsDatos)
        'Estatus
        If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then
            'MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), " Entradas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Inventario actualizado.", " Entradas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarPantalla()
            getFolioEntrada()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), " Entradas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.CodigoProveedor.Focus()
        End If
    End Sub
#End Region

#Region "  Botón NUEVO  "
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getFolioEntrada()
        LimpiarPantalla()
    End Sub
#End Region

#Region "  Botón ELIMINAR PRODUCTO  "
    Private Sub ButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
        If posRowGrid() < 0 Then
            Return
        End If
        DsDatos.Tables(0).Rows.RemoveAt(posRowGrid)

        Dim dsDatosTemp As DataSet
        Dim dt As DataTable
        dsDatosTemp = New DataSet("Root")
        dt = New DataTable("Table")
        dsDatosTemp.Tables.Add(dt)

        'DsDatos.Tables("Table").Columns.Add("C0", GetType(String))
        dsDatosTemp.Tables("Table").Columns.Add("C1", GetType(String))
        dsDatosTemp.Tables("Table").Columns.Add("C2", GetType(String))
        dsDatosTemp.Tables("Table").Columns.Add("C3", GetType(Double))
        dsDatosTemp.Tables("Table").Columns.Add("C4", GetType(String))
        dsDatosTemp.Tables("Table").Columns.Add("C5", GetType(Double))
        dsDatosTemp.Tables("Table").Columns.Add("C6", GetType(Double))
        dsDatosTemp.Tables("Table").Columns.Add("C7", GetType(Integer))

        For n As Integer = 0 To DsDatos.Tables(0).Rows.Count - 1
            Try
                dsDatosTemp.Tables(0).ImportRow(DsDatos.Tables(0).Rows(n))
            Catch ex As Exception

            End Try
        Next

        Dim final As Integer = DsDatos.Tables(0).Rows.Count - 1
        DsDatos.Tables(0).Clear()

        Dim countTemp As Integer = dsDatosTemp.Tables(0).Rows.Count
        Dim countDsDa As Integer = DsDatos.Tables(0).Rows.Count

        For n As Integer = 0 To final
            DsDatos.Tables(0).ImportRow(dsDatosTemp.Tables(0).Rows(n))
        Next

        CalculaTotal()
    End Sub
#End Region

#Region "  Botón AGREGAR A CUENTAS POR COBRAR  "
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CodigoProveedor.Text.Trim = "" Then
            MessageBox.Show("Registre el código del proveedor.", " Entradas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CodigoProveedor.Focus()
            Return
        End If

        If txtFactura.Text.Trim = "" Then
            MessageBox.Show("Registre el número de la factura.", " Entradas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFactura.Focus()
            Return
        End If

        If GridDatos.DataSource.Count = 0 Then
            MessageBox.Show("No ha registrado productos.", " Entradas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txt_CodigoProducto.Focus()
            Return
        End If

        grabar130()

        If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|"), " Entradas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarPantalla()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|"), " Entradas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CodigoProveedor.SelectAll()
            CodigoProveedor.Focus()
        End If
    End Sub
#End Region

#Region "  Botón PAGAR CON EFECTIVO  "
    Private Sub ButtonEfectivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEfectivo.Click
        If GridDatos.DataSource.Count = 0 Then
            MessageBox.Show("No ha registrado productos.", " Entradas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txt_CodigoProducto.Focus()
            Return
        End If

        Dim total As String
        total = lblTotal.Text.Remove(0, 1)

        Caja = "Grabar109" : Parametros = "V1=" & numFolioEntrada & _
                                          "|V2=" & Me.Fecha.Value.ToString("dd/MM/yyyy") & _
                                          "|V3=" & idUsuario & _
                                          "|V4=" & Me.txtFactura.Text.Trim & _
                                          "|V5=" & Me.CodigoProveedor.Text.Trim & _
                                          "|V6=" & total & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas

        ' Segundo parámetro, "Validar", es igual a dos. De esa forma se hace un
        ' retiro automático en la caja igual al monto total que costó la entrada.
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros, DsDatos)
        'Estatus
        If lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "OK" Then
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), " Entradas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarPantalla()
            getFolioEntrada()
        ElseIf lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|") = "ERROR02" Then
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), " Entradas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), " Entradas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.CodigoProveedor.Focus()
        End If

    End Sub
#End Region

#Region "  Proveedor  "
    Private Sub CodigoProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoProveedor.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoProveedor()
            Case Keys.Enter
                Caja = "Consulta106" : Parametros = "V1=" & Me.CodigoProveedor.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    If Len(LTrim(RTrim(lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)))) = 0 Then
                        MessageBox.Show("El codigo del proveedor no esta registrado")
                    Else

                    End If


                End If
        End Select
    End Sub
#End Region
    
#Region "  Rutina: posRowGrid  "
    Private Function posRowGrid() As Integer
        Dim pos() As Integer = GridDatos.Selection.GetSelectionRegion.GetRowsIndex
        If pos.Length = 0 Then
            Return -1
        Else
            Return pos(0) - 1
        End If
    End Function
#End Region

#Region "  Evento: GridDatos - KEY DOWN  (Para aumentar o disminuar la cantidad)  "
    Private Sub GridDatos_keyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridDatos.KeyDown
        ' Usuario teclea un +(107), aumenta la cantidad.
        If e.KeyCode = 107 Then
            GridDatos.DataSource.Item(posRowGrid).row(2) += 1
            GridDatos.DataSource.Item(posRowGrid).row(5) = GridDatos.DataSource.Item(posRowGrid).row(4) * GridDatos.DataSource.Item(posRowGrid).row(2)
            CalculaTotal()
        End If

        ' Usuario teclea un -(109), disminuye la cantidad.
        If e.KeyCode = 109 Then
            If GridDatos.DataSource.Item(posRowGrid).row(2) > 1 Then
                GridDatos.DataSource.Item(posRowGrid).row(2) -= 1
                GridDatos.DataSource.Item(posRowGrid).row(5) = GridDatos.DataSource.Item(posRowGrid).row(4) * GridDatos.DataSource.Item(posRowGrid).row(2)
                CalculaTotal()
            End If
        End If
    End Sub
#End Region

#Region "  Rutina: grabar130  "
    Sub grabar130()
        Dim total As String
        total = lblTotal.Text.Remove(0, 1)

        Caja = "grabar130" : Parametros = "V1=" & CodigoProveedor.Text.Trim & _
                                          "|V2=" & idUsuario & _
                                          "|V3=" & txtFactura.Text.Trim & _
                                          "|V4=" & total

        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros, DsDatos)

    End Sub
#End Region

#Region "  Rutina: getFolioEntrada  "
    Sub getFolioEntrada()
        ' Obtiene el folio de entrada, necesario para hacer una inserción
        'con grabar109.

        Caja = "Consulta109" : Parametros = "V1=" & numFolioEntrada.Trim
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "5", Parametros)

        'Estatus
        If ObjRet.bOk Then
            numFolioEntrada = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)
            lblNumEntrada.Text = numFolioEntrada
        End If
        ObjRet = Nothing

    End Sub
#End Region
    
#Region "  Evento: GridDatos - PAINT  (Calcula el tamaño de la última columna para ajustarse el tamaño del grid.)  "
    Private Sub GridDatos_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GridDatos.Paint
        Dim sizeColumns As Integer
        For n As Integer = 0 To GridDatos.Columns.Count - 2
            sizeColumns += GridDatos.Columns(n).Width
        Next

        Dim sizeGrid As Integer = GridDatos.Size.Width - sizeColumns - 6
        GridDatos.Columns.SetWidth(8, sizeGrid)
    End Sub
#End Region
    
#Region "  Boton Borrar  - DESHABILITADO  "
    Private Sub BotonBorrar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim grid As SourceGrid.DataGrid = GridDatos
        Dim pos As Integer = grid.Selection.ActivePosition.Row
        Dim contador As Integer = grid.Rows.Count

        'If contador = 2 And pos = 1 Then
        'Eliminar Rows
        ' Else
        'DsDatos.Tables("Table").Rows(pos - 1).Delete()
        DsDatos.Tables("Table").Rows(pos - 1).Item("C1") = ""
        DsDatos.Tables("Table").Rows(pos - 1).Item("C2") = ""
        DsDatos.Tables("Table").Rows(pos - 1).Item("C3") = 0
        DsDatos.Tables("Table").Rows(pos - 1).Item("C4") = ""
        DsDatos.Tables("Table").Rows(pos - 1).Item("C5") = 0
        DsDatos.Tables("Table").Rows(pos - 1).Item("C6") = 0

        CalculaTotal()

        ' End If
    End Sub
#End Region

#Region "  Cambio de textBox con Enter  "
    Private Sub CodigoProveedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CodigoProveedor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtFactura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactura.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Txt_CodigoProducto.Focus()
        End If
    End Sub
#End Region

End Class