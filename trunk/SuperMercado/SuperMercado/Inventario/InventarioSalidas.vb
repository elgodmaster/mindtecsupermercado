Imports MindTec.Componentes

Public Class InventarioSalidas

#Region "  Variables de trabajo  "

    Dim DsDatos As DataSet
    Dim ViewDatos As DataView
    Private DsView As DataView
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Dim idSalida As String

    Dim numFolioSalida As String = ""
    Dim TotalEntrada As Decimal

#End Region

#Region "  Grid Datos  "

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
        DsDatos.Tables("Table").Columns.Add("C5", GetType(Integer))
        DsDatos.Tables("Table").Columns.Add("C6", GetType(String))

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
    End Sub

    Private Sub GridDatosCrearColumnas(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
        'Borders

        Dim noBorder As New DevAge.Drawing.RectangleBorder
        noBorder.SetColor(Color.White)

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

        'Definicion de la celda
        Dim EditorCustom As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        EditorCustom.EditableMode = SourceGrid.EditableMode.None

        Dim Editable As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        Editable.EditableMode = SourceGrid.EditableMode.AnyKey

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

        GridColumn = GridDatos.Columns.Add("C5", "Salida", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.EnableStretch

        GridColumn = GridDatos.Columns.Add("C6", " ", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.EnableStretch

        GridDatos.Columns(0).Visible = False
        GridDatos.Columns.SetWidth(1, 160)
        GridDatos.Columns.SetWidth(2, 310)
        GridDatos.Columns.SetWidth(3, 100)
        GridDatos.Columns.SetWidth(4, 100)
        GridDatos.Columns(5).Visible = False
        GridDatos.Columns.SetWidth(6, 10)

    End Sub

#End Region

#Region "  Evento: InventarioSalidas - LOAD  "
    Private Sub InventarioSalidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrearDsDatos()
        ConfiguraGridDatos()

        LimpiarPantalla()

        ' Necesario para actualizar el inventario por medio de 
        'grabar109.
        getFolioSalida()

    End Sub
#End Region

#Region "  Evento: InventarioSalidas - KEY DOWN  "
    Private Sub InventarioSalidas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Cerrar()
            Case Keys.F4
                Limpiar.PerformClick()
            Case Keys.F6
                'Nuevo.PerformClick()
            Case Keys.F9
                Grabar.PerformClick()
        End Select
    End Sub
#End Region

#Region "  Evento: GridDatos - KEY DOWN  (Para aumentar o disminuar la cantidad)  "
    Private Sub GridDatos_keyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridDatos.KeyDown
        ' Usuario teclea un +(107), aumenta la cantidad.
        If e.KeyCode = 107 Then
            GridDatos.DataSource.Item(posRowGrid).row(2) += 1
        End If

        ' Usuario teclea un -(109), disminuye la cantidad.
        If e.KeyCode = 109 Then
            If GridDatos.DataSource.Item(posRowGrid).row(2) > 1 Then
                GridDatos.DataSource.Item(posRowGrid).row(2) -= 1
            End If
        End If
    End Sub
#End Region

#Region "  Rutina: LimpiarPantalla  "
    Sub LimpiarPantalla()

        Me.Fecha.Value = Now
        Me.Txt_CodigoProducto.Text = ""
        CantidadNumericUpDown.Value = 0
        Me.txtMotivo.Text = ""
        DsDatos.Tables("Table").Clear()
    End Sub
#End Region

#Region "  Rutina: Llenar Fila  "
    Sub LlenarFila(ByVal Producto As String, ByVal Unidad As String)
        If CantidadNumericUpDown.Value < 1 Then
            CantidadNumericUpDown.Value = 1
        End If

        Dim Cantidad As Double = CantidadNumericUpDown.Value
        Dim Igual As Boolean = 0
        Dim Encontro As Boolean = 0
        Dim fila As Integer = 0
        For i As Integer = 0 To DsDatos.Tables("Table").Rows.Count - 1

            If DsDatos.Tables("Table").Rows(i).Item("C1") = Txt_CodigoProducto.Text Then
                Igual = True
                DsDatos.Tables("Table").Rows(i).Item("C3") = DsDatos.Tables("Table").Rows(i).Item("C3") + Cantidad
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
            registro!C5 = numFolioSalida.Trim
            DsDatos.Tables("Table").AcceptChanges()

        End If

        If Encontro = True Then
            DsDatos.Tables("Table").Rows(fila).Item("C1") = Txt_CodigoProducto.Text
            DsDatos.Tables("Table").Rows(fila).Item("C2") = Producto
            DsDatos.Tables("Table").Rows(fila).Item("C3") = Cantidad
            DsDatos.Tables("Table").Rows(fila).Item("C4") = Unidad
            DsDatos.Tables("Table").Rows(fila).Item("C5") = numFolioSalida.Trim
            DsDatos.Tables("Table").AcceptChanges()

        End If
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

    Sub CatalogoSalidas()
        Caja = "Consulta113" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            numFolioSalida = nuevo.resultado

            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            'Me.FolioSalida_KeyDown(DBNull.Value, e)
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
            SendKeys.Send("{ENTER}")
        End If
    End Sub
#End Region

#Region "  Botón ACTUALIZAR  "
    'V3 = IdUsuario
    Private Sub Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grabar.Click
        If GridDatos.DataSource.Count = 0 Then
            MessageBox.Show("No ha registrado productos.", " Salidas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txt_CodigoProducto.Focus()
            Return
        End If

        Caja = "Grabar113" : Parametros = "V1=" & numFolioSalida.Trim & _
                                          "|V2=" & Me.Fecha.Value.ToString("dd/MM/yyyy") & _
                                          "|V3=" & idUsuario & _
                                          "|V4=" & Me.txtMotivo.Text & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros, DsDatos)
        'Estatus
        If ObjRet.bOk Then
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), " Salidas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarPantalla()
            getFolioSalida()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False), " Salidas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtMotivo.Focus()
        End If
    End Sub
#End Region

#Region "  Botón NUEVO  "
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Caja = "Consulta113" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
        'Estatus
        If ObjRet.bOk Then
            numFolioSalida = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)

            Me.Grabar.Visible = True
            Me.GroupBox1.Visible = True
            Me.txtMotivo.Focus()

        End If
        ObjRet = Nothing
    End Sub
#End Region

#Region "  Producto  "
    Private Sub Txt_CodigoProducto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_CodigoProducto.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoProductos()
            Case Keys.Enter
                Caja = "Consulta109" : Parametros = "V1=" & Txt_CodigoProducto.Text & "|"
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
                If ObjRet.bOk Then

                    CantidadNumericUpDown.Select(0, 10)
                    CantidadNumericUpDown.Focus()
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    Me.Txt_CodigoProducto.Text = ""
                    CantidadNumericUpDown.Value = 0

                    Me.Txt_CodigoProducto.Focus()
                End If
        End Select
    End Sub
#End Region

#Region "  Cantidad  "
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
                    ''Mandar Llamar Llenar Fila con los datos necesarios
                    LlenarFila(Producto, Unidad)

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

#Region "  Botón ACEPTAR  "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Caja = "Consulta113" : Parametros = "V1=" & numFolioSalida.Trim & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)
        'Estatus
        If ObjRet.bOk Then
            Fecha.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
            txtMotivo.Text = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|", False)
            If Not ObjRet.DS Is DBNull.Value Then
                If Not ObjRet.DS.Tables Is DBNull.Value Then
                    If ObjRet.DS.Tables.Count > 0 Then
                        Me.Grabar.Visible = False

                        For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                            DsDatos.Tables("Table").ImportRow(ObjRet.DS.Tables(0).Rows(i))
                        Next
                        DsDatos.Tables("Table").AcceptChanges()
                    End If

                End If
            End If
            Me.GroupBox1.Visible = True

        End If
    End Sub
#End Region

#Region "  Rutina: getFolioSalida  "
    Sub getFolioSalida()
        ' Obtiene el folio de salida necesario para hacer una incerción con
        'grabar113.

        Caja = "Consulta113" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)

        'Estatus
        If ObjRet.bOk Then
            numFolioSalida = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)
            lblNumSalida.Text = numFolioSalida
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
        Dim sizeGrid As Integer = GridDatos.Size.Width - sizeColumns - 4
        GridDatos.Columns.SetWidth(6, sizeGrid)
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
        dsDatosTemp.Tables("Table").Columns.Add("C5", GetType(Integer))
        dsDatosTemp.Tables("Table").Columns.Add("C6", GetType(String))

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

    End Sub
#End Region
    
#Region "  Cambio de TextBox con ENTER  "
    Private Sub txtMotivo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMotivo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Txt_CodigoProducto.Focus()
        End If
    End Sub
#End Region
    
#Region "  Evento: CodigoProducto - KEY PRESS  "
    Private Sub Txt_CodigoProducto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_CodigoProducto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            CantidadNumericUpDown.Focus()
        End If
    End Sub
#End Region
    
End Class