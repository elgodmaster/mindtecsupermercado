﻿Imports MindTec.Componentes

Public Class InventarioEntradas

#Region " Variables de trabajo"
    Dim DsDatos As DataSet
    Dim ViewDatos As DataView
    Private DsView As DataView
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Dim identrada As String
    Dim TotalEntrada As Double = 0
#End Region

#Region "Eventos Principales"
    Private Sub InventarioEntradas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Cerrar()
            Case Keys.F4
                Limpiar.PerformClick()
            Case Keys.F6
                Nuevo.PerformClick()
            Case Keys.F9
                Grabar.PerformClick()
        End Select
    End Sub

    Private Sub InventarioEntradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrearDsDatos()
        ConfiguraGridDatos()
        LimpiarPantalla()
    End Sub
#End Region

#Region " Rutinas "
    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                Cerrar()
        End Select
    End Sub

    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        LimpiarPantalla()
    End Sub

    Sub LimpiarPantalla()
        Me.GroupBox1.Visible = False
        Me.Grabar.Visible = False
        Me.Eliminar.Visible = False
        Me.btnAceptar.Enabled = True
        Me.FolioEntrada.Enabled = True
        Me.Nuevo.Visible = True
        Me.Fecha.Value = Now
        Me.CodigoProveedor.Text = ""
        Me.FolioEntrada.Text = ""
        Me.NombreProveedor.Text = ""
        Me.txtFactura.Text = ""
        Me.Txt_CodigoProducto.Text = ""
        Me.Txt_Cantidad.Text = "0.00"
        Me.DsDatos.Tables("Table").Clear()
        MensajePiePagina.Text = "Esc=Salir F2=Catálogo F4=Limpiar Pantalla F6=Nuevo"
        Me.FolioEntrada.Focus()
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

#Region " Llenar Fila "
    Sub LlenarFila(ByVal Producto As String, ByVal Unidad As String, ByVal Costo As Double)
        Dim Cantidad As Double = Double.Parse(Me.Txt_Cantidad.Text)
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
            registro!C7 = Me.FolioEntrada.Text


            DsDatos.Tables("Table").AcceptChanges()

        End If

        If Encontro = True Then
            DsDatos.Tables("Table").Rows(fila).Item("C1") = Txt_CodigoProducto.Text
            DsDatos.Tables("Table").Rows(fila).Item("C2") = Producto
            DsDatos.Tables("Table").Rows(fila).Item("C3") = Cantidad
            DsDatos.Tables("Table").Rows(fila).Item("C4") = Unidad
            DsDatos.Tables("Table").Rows(fila).Item("C5") = Costo
            DsDatos.Tables("Table").Rows(fila).Item("C6") = TotalCosto
            DsDatos.Tables("Table").Rows(fila).Item("C7") = FolioEntrada.Text
            DsDatos.Tables("Table").AcceptChanges()

        End If

        CalculaTotal()
    End Sub

#End Region

    Sub CalculaTotal()

        For h As Integer = 0 To DsDatos.Tables("Table").Rows.Count - 1
            TotalEntrada = TotalEntrada + Double.Parse(DsDatos.Tables("Table").Rows(h).Item("C6"))
        Next

        Me.Txt_TotalEntrada.Text = TotalEntrada
        TotalEntrada = 0

    End Sub

    Sub Cerrar()
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas salir de esta pantalla?", "SuperMercado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Me.DsDatos = Nothing
            Me.Close()
        End If
    End Sub

    Sub CatalogoEntradas()
        Caja = "Consulta109" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            Me.FolioEntrada.Text = nuevo.resultado

            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.FolioEntrada_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub


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

#Region " Codigo_KeyDown And KeyPress"
    'Private Sub codigo_keydown(ByVal sender As Object, ByVal e As KeyEventArgs)
    '    Dim grid As SourceGrid.DataGrid = GridDatos
    '    Dim pos As Integer = grid.Selection.ActivePosition.Row
    '    Dim posicion As Object
    '    posicion = New SourceGrid.Position(pos, 3)
    '    Dim posicion2 As Object
    '    posicion2 = New SourceGrid.Position(pos, 1)
    '    Dim Context As SourceGrid.CellContext
    '    Context = New SourceGrid.CellContext(grid, New SourceGrid.Position(pos, 1))

    '    Select Case e.KeyCode
    '        Case Keys.F2
    '            CatalogoProductos(pos)
    '        Case Keys.Enter
    '            Dim a As String = DsDatos.Tables("Table").Rows(pos - 1).Item("C1")
    '            Caja = "Consulta109" : Parametros = "V1=" & Context.DisplayText
    '            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
    '            ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
    '            If ObjRet.bOk Then
    '                DsDatos.Tables("Table").Rows(pos - 1).Item("C1") = Context.DisplayText
    '                DsDatos.Tables("Table").Rows(pos - 1).Item("C2") = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)
    '                DsDatos.Tables("Table").Rows(pos - 1).Item("C4") = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|", False)
    '                grid.Selection.Focus(posicion, True)
    '            Else
    '                grid.Selection.Focus(posicion2, True)
    '            End If

    '    End Select
    'End Sub

    'Private Sub GridCodigo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
    '    '    Dim grid As SourceGrid.DataGrid = GridDatos
    '    '    Dim rows As Object = grid.SelectedDataRows
    '    '    Dim Row As DataRowView = Nothing
    '    '    Dim Sender2 As Object = CType(sender.Control, TextBox)

    '    '    If Not rows Is Nothing And rows.Length > 0 Then

    '    '        Row = CType(rows(0), DataRowView)
    '    '        Row.DataView.AllowEdit = True
    '    '        Row.Row.AcceptChanges()
    '    '        DsDatos.AcceptChanges()
    '    '        grid.Refresh()
    '    '        DsDatos.GetChanges()
    '    '    End If
    '    Dim Grid As SourceGrid.DataGrid = GridDatos

    '    Dim enviado As Object = CType(sender.control, TextBox)
    '    Dim posicion As Object = Grid.Selection.ActivePosition


    'End Sub

#End Region

#Region " Grid Cantidad KeyDown And KeyPress "
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

#Region " Producto "
    Private Sub Txt_CodigoProducto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_CodigoProducto.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoProductos()
            Case Keys.Enter
                Caja = "Consulta109" : Parametros = "V1=" & Txt_CodigoProducto.Text & "|"
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
                If ObjRet.bOk Then
                    Me.LblProducto.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)
                    Txt_Cantidad.Focus()
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    Me.Txt_CodigoProducto.Text = ""
                    Me.Txt_Cantidad.Text = "0.00"
                    Me.LblProducto.Text = ""
                    Me.Txt_CodigoProducto.Focus()
                End If
        End Select
    End Sub
#End Region

#Region " Cantidad "
    Private Sub Txt_Cantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_Cantidad.KeyDown
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
                    Me.LblProducto.Text = ""
                    Me.Txt_Cantidad.Text = "0.0"
                    Me.Txt_CodigoProducto.Focus()
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    Me.Txt_CodigoProducto.Text = ""
                    Me.LblProducto.Text = ""
                    Me.Txt_Cantidad.Text = "0.0"
                    Me.Txt_CodigoProducto.Focus()
                End If
        End Select
    End Sub
#End Region

#Region " Grid Datos "

    Sub CrearDsDatos()
        'Creando Datatable  con tipo de dato
        Dim dt As DataTable
        DsDatos = New DataSet("Root")
        dt = New DataTable("Table")
        DsDatos.Tables.Add(dt)

        'DsDatos.Tables("Table").Columns.Add("C0", GetType(String))
        DsDatos.Tables("Table").Columns.Add("C1", GetType(String))
        DsDatos.Tables("Table").Columns.Add("C2", GetType(String))
        DsDatos.Tables("Table").Columns.Add("C3", GetType(Double))
        DsDatos.Tables("Table").Columns.Add("C4", GetType(String))
        DsDatos.Tables("Table").Columns.Add("C5", GetType(Double))
        DsDatos.Tables("Table").Columns.Add("C6", GetType(Double))
        DsDatos.Tables("Table").Columns.Add("C7", GetType(Integer))

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

        Dim viewcolumnheader As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        backheader.BackColor = cColorHeader
        backheader.Border = DevAge.Drawing.RectangleBorder.RectangleBlack1Width
        viewcolumnheader.Background = backheader
        viewcolumnheader.ForeColor = Color.Black
        viewcolumnheader.Font = New Font("Verdana", 8, FontStyle.Bold)
        viewcolumnheader.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter

        GridDatos.GetCell(0, 1).View = viewcolumnheader
        GridDatos.GetCell(0, 2).View = viewcolumnheader
        GridDatos.GetCell(0, 3).View = viewcolumnheader
        GridDatos.GetCell(0, 4).View = viewcolumnheader
        GridDatos.GetCell(0, 5).View = viewcolumnheader
        GridDatos.GetCell(0, 6).View = viewcolumnheader
        GridDatos.GetCell(0, 7).View = viewcolumnheader
    End Sub

    Private Sub GridDatosCrearColumnas(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
        'Borders

        Dim border As DevAge.Drawing.RectangleBorder = New DevAge.Drawing.RectangleBorder(New DevAge.Drawing.BorderLine(Color.Black), New DevAge.Drawing.BorderLine(Color.Black))
        'gcolorRow esta declarada en el moduloGeneral

        'vistas
        Dim viewNormal As CellBackColorAlternate = New CellBackColorAlternate(gColorRow, Color.White)
        viewNormal.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewNormal.Border = border

        Dim myfont As New Font("Verdana", 8, FontStyle.Regular)

        Dim viewBtn As SourceGrid.Cells.Views.Button = New SourceGrid.Cells.Views.Button()
        viewBtn.BackColor = gColorRow
        viewBtn.Border = border
        viewBtn.Font = myfont
        viewBtn.ForeColor = Color.Black
        viewBtn.TextAlignment = DevAge.Drawing.ContentAlignment.BottomCenter

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
        'AGRAGAR BOTON
        GridColumn = GridDatos.Columns.Add(Nothing, "", New SourceGrid.Cells.Button("-"))
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.AddController(clickEvent)
        GridColumn.DataCell.View = viewBtn
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize


        'GridColumn = GridDatos.Columns.Add("C0", "Fecha", EditorCustom)
        'GridColumn.DataCell.AddController(gridKeydown)
        'GridColumn.DataCell.View = viewNormal
        'GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatos.Columns.Add("C1", "Código", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatos.Columns.Add("C2", "Producto", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatos.Columns.Add("C3", "Cantidad", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatos.Columns.Add("C4", "Unidad", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.EnableStretch

        GridColumn = GridDatos.Columns.Add("C5", "Costo Unitario", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatos.Columns.Add("C6", "Costo Total", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.EnableAutoSize

        GridColumn = GridDatos.Columns.Add("C7", "Entrada", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.None

        GridDatos.Columns(0).Visible = False
        GridDatos.Columns.SetWidth(1, 30)
        GridDatos.Columns.SetWidth(2, 150)
        GridDatos.Columns.SetWidth(3, 300)
        GridDatos.Columns.SetWidth(4, 100)
        GridDatos.Columns.SetWidth(5, 100)
        GridDatos.Columns.SetWidth(6, 100)
        GridDatos.Columns.SetWidth(7, 150)
        GridDatos.Columns.SetWidth(8, 0)
    End Sub

#End Region

#Region " Folio Entrada "
    Private Sub FolioEntrada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FolioEntrada.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoEntradas()
            Case Keys.Enter
                Caja = "Consulta109" : Parametros = "V1=" & Me.FolioEntrada.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    btnAceptar.PerformClick()
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                End If
        End Select
    End Sub
#End Region

#Region " Aceptar "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Len(LTrim(RTrim(Me.FolioEntrada.Text))) = 0 Then
            Nuevo.PerformClick()
        Else
            Caja = "Consulta109" : Parametros = "V1=" & Me.FolioEntrada.Text.Trim & "|"
            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
            'Estatus
            If ObjRet.bOk Then
                If Not ObjRet.DS Is DBNull.Value Then
                    If Not ObjRet.DS.Tables Is DBNull.Value Then
                        If ObjRet.DS.Tables.Count > 0 Then
                            Me.Grabar.Visible = False
                            Me.Eliminar.Visible = True
                            Me.txtFactura.Enabled = False
                            Me.Txt_Cantidad.Enabled = False
                            Me.Fecha.Enabled = False
                            Me.Txt_CodigoProducto.Enabled = False
                            Me.CodigoProveedor.Enabled = False

                            For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                                DsDatos.Tables("Table").ImportRow(ObjRet.DS.Tables(0).Rows(i))
                            Next
                            DsDatos.Tables("Table").AcceptChanges()
                            CalculaTotal()
                        End If
                    End If
                End If

                Me.FolioEntrada.Enabled = False
                Me.Nuevo.Visible = False
                Me.btnAceptar.Enabled = False
                Me.GroupBox1.Visible = True

                Me.Fecha.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                Me.CodigoProveedor.Text = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|")
                Me.NombreProveedor.Text = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
                Me.txtFactura.Text = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|")
            Else
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            End If

        End If
        ObjRet = Nothing
    End Sub
#End Region

#Region " Grabar "

    Private Sub Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grabar.Click
        If DsDatos.Tables("Table").Rows.Count >= 0 And DsDatos.Tables("Table").Rows(0).Item("C3") <> 0 Then
            Caja = "Grabar109" : Parametros = "V1=" & Me.FolioEntrada.Text & "|V2=" & Me.Fecha.Value.ToString("dd/MM/yyyy") & "|V3=|V4=" & Me.txtFactura.Text & "|V5=" & Me.CodigoProveedor.Text & "|"
            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros, DsDatos)
            'Estatus
            If ObjRet.bOk Then
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            Else
                MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                Me.CodigoProveedor.Focus()
            End If
        Else
            MessageBox.Show("Registre un producto antes de grabar")
            Me.Txt_CodigoProducto.Focus()
        End If
    End Sub
#End Region

#Region " Nuevo "
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        Caja = "Consulta109" : Parametros = "V1=" & Me.FolioEntrada.Text
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "5", Parametros)
        'Estatus
        If ObjRet.bOk Then
            Me.FolioEntrada.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)
            Me.btnAceptar.Enabled = False
            Me.FolioEntrada.Enabled = False
            Me.Nuevo.Visible = False
            Me.Grabar.Visible = True
            Me.GroupBox1.Visible = True
            FilaVacia()
            Me.CodigoProveedor.Focus()

        End If
        ObjRet = Nothing
    End Sub
#End Region

#Region " Proveedor "
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
                        Me.NombreProveedor.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)
                    End If


                End If
        End Select
    End Sub
#End Region

#Region "Boton Borrar"
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



End Class