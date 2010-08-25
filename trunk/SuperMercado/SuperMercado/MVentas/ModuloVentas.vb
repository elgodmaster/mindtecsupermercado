Imports MindTec.Componentes

Public Class ModuloVentas

#Region "  Variables de trabajo  "
    Dim DsDatos As DataSet
    Dim ViewDatos As DataView
    Private DsView As DataView
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Dim IdVenta As Integer
    Dim TotalVenta As Double = 0
    Public myPrincipal As Principal
#End Region

#Region " Eventos Principales "
    Private Sub ModuloVentas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                'Cerrar()
            Case Keys.F4
                LimpiarPantalla()
            Case Keys.F5
                Me.Agregar.PerformClick()
            Case Keys.F6
                'Nuevo.PerformClick()
            Case Keys.F8
                Btn_Efectivo.PerformClick()
            Case Keys.F9
                Btn_Credito.PerformClick()
                'Case Keys.F10
                '    GroupBoxPagos.Visible = True
                '    AceptarVenta.Enabled = False
                '    Txt_Pago.Focus()
            Case Keys.F11
                AceptarVenta.PerformClick()
            Case Keys.F12
                CancelarVenta.PerformClick()
        End Select
    End Sub
#End Region

#Region " Load "
    Private Sub ModuloVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Obtener El Numero siguiente de venta 
        ObtenerIdVenta()
        lblFecha.Text = Date.Now.ToLongDateString
        CrearDsDatos()
        ConfiguraGridDatos()
    End Sub
#End Region

#Region " Obtener IdVenta "
    Sub ObtenerIdVenta()
        Caja = "Consulta115" : Parametros = "V1=" & idUsuario & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "5", Parametros)
        If ObjRet.bOk Then
            IdVenta = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)
        End If
    End Sub
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
        DsDatos.Tables("Table").Columns.Add("C5", GetType(Double))
        DsDatos.Tables("Table").Columns.Add("C6", GetType(Double))
        DsDatos.Tables("Table").Columns.Add("C7", GetType(Integer))
        DsDatos.Tables("Table").Columns.Add("C8", GetType(Decimal))
        DsDatos.Tables("Table").Columns.Add("C9", GetType(Decimal))

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
        GridDatos.GetCell(0, 7).View = viewcolumnheaderCenter
    End Sub

    Private Sub GridDatosCrearColumnas(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
        'Borders

        Dim border As DevAge.Drawing.RectangleBorder = New DevAge.Drawing.RectangleBorder(New DevAge.Drawing.BorderLine(Color.Black), New DevAge.Drawing.BorderLine(Color.Black))
        'gcolorRow esta declarada en el moduloGeneral
        Dim noBorder As New DevAge.Drawing.RectangleBorder
        noBorder.SetColor(Color.Transparent)

        'vistas
        Dim viewCenter As CellBackColorAlternate = New CellBackColorAlternate(Color.White, gColorRow)
        viewCenter.Font = New Font("Verdana", 15, FontStyle.Regular)
        viewCenter.Border = noBorder
        viewCenter.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter


        Dim viewLeft As CellBackColorAlternate = New CellBackColorAlternate(Color.White, gColorRow)
        viewLeft.Font = New Font("Verdana", 15, FontStyle.Regular)
        viewLeft.Border = noBorder
        viewLeft.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft

        Dim viewRight As CellBackColorAlternate = New CellBackColorAlternate(Color.White, gColorRow)
        viewRight.Font = New Font("Verdana", 15, FontStyle.Regular)
        viewRight.Border = noBorder
        viewRight.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight

        Dim myfont As New Font("Verdana", 15, FontStyle.Regular)

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

        GridColumn = GridDatos.Columns.Add("C3", "Cant.", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatos.Columns.Add("C4", "Unidad", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.EnableStretch

        GridColumn = GridDatos.Columns.Add("C5", "P. U.", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatos.Columns.Add("C6", "Total", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.EnableAutoSize

        GridColumn = GridDatos.Columns.Add("C7", "IdVenta", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.None

        GridColumn = GridDatos.Columns.Add("C8", "Descuento", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.None

        GridColumn = GridDatos.Columns.Add("C9", " ", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewCenter
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.None

        GridDatos.Columns(0).Visible = False
        GridDatos.Columns(1).Visible = False
        GridDatos.Columns.SetWidth(2, 310)
        GridDatos.Columns.SetWidth(3, 60)
        GridDatos.Columns(4).Visible = False
        GridDatos.Columns.SetWidth(5, 85)
        GridDatos.Columns.SetWidth(6, 85)
        GridDatos.Columns.SetWidth(7, 0)
        GridDatos.Columns.SetWidth(8, 0)
        GridDatos.Columns.SetWidth(9, 10)
    End Sub

#End Region

#Region " Boton Borrar "
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

#Region " Calcular Total "
    Sub CalculaTotal()

        For h As Integer = 0 To DsDatos.Tables("Table").Rows.Count - 1
            TotalVenta = TotalVenta + Double.Parse(DsDatos.Tables("Table").Rows(h).Item("C6"))
        Next

        If TotalVenta = 0 Then
            AceptarVenta.Enabled = False
            Me.GroupBoxPagos.Visible = False
        End If

        Me.LblTotal.Text = FormatCurrency(TotalVenta)
        TotalVenta = 0

    End Sub
#End Region

#Region " Grid_KeyDown "
    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                'Cerrar()
        End Select
    End Sub
#End Region

#Region " Fila Vacia "
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
#End Region

#Region " Reloj y Fecha "
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora.Text = Date.Now.ToLongTimeString
    End Sub

#End Region

#Region "  Aceptar Venta  "
    Private Sub AceptarVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarVenta.Click
        GroupBoxPagos.Visible = True
        NumericUpDownPago.Select(0, 10)
        NumericUpDownPago.Focus()
    End Sub
#End Region

#Region " Codigo Producto"
    Private Sub Codigo_Producto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Codigo_Producto.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoProductos()
            Case Keys.Enter
                CajaProductos()
            Case Keys.Down
                If GridDatos.Rows.Count - 1 = 0 Then
                    Exit Sub
                End If
                GridDatos.Select()
                GridDatos.Selection.SelectRow(1, True)
            Case Keys.Right
                CantidadNumericUpDown.Select(0, 10)
                CantidadNumericUpDown.Focus()
        End Select
    End Sub
#End Region

#Region " Caja Productos "

    Sub CajaProductos()
        Dim Codigo As String = ""
        Dim Producto As String = ""
        Dim Unidad As String = ""
        Dim Costo As Double = 0
        Dim stockMin As Double

        Caja = "Consulta115" : Parametros = "V1=" & Codigo_Producto.Text & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
        If ObjRet.bOk Then
            Producto = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)
            Unidad = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|", False)
            Costo = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|", False)
            stockMin = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|", False)
            ''Mandar Llamar Llenar Fila con los datos necesarios

            LlenarFila(Producto, Unidad, Costo)

            Me.Codigo_Producto.Text = ""

            CantidadNumericUpDown.Value = 0
            Me.Codigo_Producto.Focus()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            Me.Codigo_Producto.Text = ""
            CantidadNumericUpDown.Value = 0
            Me.Codigo_Producto.Focus()
        End If
    End Sub
#End Region

#Region " Llenar Fila "
    Sub LlenarFila(ByVal Producto As String, ByVal Unidad As String, ByVal Costo As Double)

        ''Habilitar Botones de venta
        If AceptarVenta.Enabled = False Then
            AceptarVenta.Enabled = True
            CancelarVenta.Enabled = True
        End If


        Dim cantidad As Double
        Dim TotalCosto As Double = 0
        Double.Parse(Costo)

        Dim Igual As Boolean = 0
        Dim Encontro As Boolean = 0
        Dim fila As Integer = 0

        If CantidadNumericUpDown.Value <= 0 Then
            cantidad = 1
        Else
            cantidad = CantidadNumericUpDown.Value
        End If

        TotalCosto = cantidad * Costo

        For i As Integer = 0 To DsDatos.Tables("Table").Rows.Count - 1

            If DsDatos.Tables("Table").Rows(i).Item("C1") = Codigo_Producto.Text Then
                Igual = True
                DsDatos.Tables("Table").Rows(i).Item("C3") = DsDatos.Tables("Table").Rows(i).Item("C3") + cantidad
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
            registro!C1 = Codigo_Producto.Text
            registro!C2 = Producto
            registro!C3 = cantidad
            registro!C4 = Unidad
            registro!C5 = Costo
            registro!C6 = TotalCosto
            registro!C7 = IdVenta  ''Codigo de venta
            registro!C8 = 1


            DsDatos.Tables("Table").AcceptChanges()

        End If

        If Encontro = True Then
            DsDatos.Tables("Table").Rows(fila).Item("C1") = Codigo_Producto.Text
            DsDatos.Tables("Table").Rows(fila).Item("C2") = Producto
            DsDatos.Tables("Table").Rows(fila).Item("C3") = cantidad
            DsDatos.Tables("Table").Rows(fila).Item("C4") = Unidad
            DsDatos.Tables("Table").Rows(fila).Item("C5") = Costo
            DsDatos.Tables("Table").Rows(fila).Item("C6") = TotalCosto
            DsDatos.Tables("Table").Rows(fila).Item("C7") = IdVenta
            DsDatos.Tables("Table").Rows(fila).Item("C8") = 1
            DsDatos.Tables("Table").AcceptChanges()

        End If

        CalculaTotal()
    End Sub

#End Region

#Region " Limpiar Pantalla "
    Sub LimpiarPantalla()
        Me.DsDatos.Tables("Table").Clear()
        Me.DsDatos.AcceptChanges()
        Codigo_Producto.Text = ""
        CantidadNumericUpDown.Value = 0
        LblIva.Text = "$ 0.00"
        LblSubTotal.Text = "$ 0.00"
        LblTotal.Text = "$ 0.00"
        Me.LblCambio.Text = "0.00"
        Me.NumericUpDownPago.Value = 0
        Me.GroupBoxPagos.Visible = False
        AceptarVenta.Enabled = False
        CancelarVenta.Enabled = False
        Codigo_Producto.Focus()
    End Sub
#End Region

#Region " Cancelar Venta "
    Private Sub CancelarVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarVenta.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas cancelar la venta?", "SuperMercado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            LimpiarPantalla()
        End If
    End Sub
#End Region

#Region " Checador de precios"
    Private Sub ChecarPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChecarPrecio.Click
        Dim Checar = New ChecadorPrecios
        Checar.StartPosition = FormStartPosition.CenterScreen
        Checar.ShowDialog()

    End Sub
#End Region

#Region " Cantidad "
    Private Sub TxtCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CantidadNumericUpDown.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                CajaProductos()
            Case Keys.Left
                Codigo_Producto.Focus()
        End Select
    End Sub

    Private Sub TxtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

#End Region

#Region " Agregar Clic "
    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        CajaProductos()
    End Sub
#End Region

#Region " Descuento "
    Private Sub Descuento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim grid As SourceGrid.DataGrid = GridDatos
        Dim rows() As Object = grid.SelectedDataRows
        Dim row As DataRowView = Nothing

        If Not rows Is Nothing And rows.Length > 0 Then
            'Obtener el Renglon
            row = CType(rows(0), DataRowView)

        End If

    End Sub
#End Region

#Region " Rutinas - Catalogos "
    Sub CatalogoProductos()
        Caja = "Consulta103" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            Codigo_Producto.Text = nuevo.resultado
        End If
    End Sub
#End Region

#Region " Recibí TXT_PAGO "
    Private Sub Txt_Pago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
#End Region

#Region " Boton Efectivo"
    Private Sub Btn_Efectivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Efectivo.Click
        Dim TotalVenta As Double = 0.0
        Dim RecibiPago As Double = 0.0
        Dim Faltante As Double = 0.0
        Dim Total As String = ""
        Total = Mid(Me.LblTotal.Text, 2, Len(Me.LblTotal.Text))
        TotalVenta = Double.Parse(Total)
        RecibiPago = NumericUpDownPago.Value

        If TotalVenta <= RecibiPago Then
            Faltante = RecibiPago - TotalVenta
            Me.LblCambio.Text = FormatCurrency(Faltante)

            'Imprimir TICKET
            'imprimeTicket(TotalVenta, RecibiPago, Faltante)

            ''AbrirCajaRegistradora
            ''ModificarCaja
            ''ModificarInventario
            ''GuardarEnVentas
            ''ObtenerNuevoIdVenta

            ''Aqui se esta guardando la venta que se realizo en efectivo y actualizando las existencias
            Caja = "Grabar115" : Parametros = "V1=" & IdVenta & "|V3=0|V4=" & idUsuario & "|V5=0|"
            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros, DsDatos)
            'Estatus
            If ObjRet.bOk Then
                If Faltante = 0.0 Then
                    MessageBox.Show("Gracias por su compra, ¡vuelva pronto!", "SuperMercado")
                    LimpiarPantalla()
                Else
                    MessageBox.Show("Su Cambio es de " & FormatCurrency(Faltante))
                    LimpiarPantalla()
                End If
                'imprimeTicket(TotalVenta, RecibiPago, Faltante)
                ObtenerIdVenta()
            End If

        Else
            Faltante = TotalVenta - RecibiPago
            Faltante = FormatCurrency(Faltante)
            MessageBox.Show("No se a realizado el pago, hace falta" & FormatCurrency(Faltante))
        End If

        checkLimiteCaja()

    End Sub
#End Region

#Region " Boton Credito "
    Private Sub Btn_Credito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Credito.Click
        Dim Total As String = ""
        Total = Mid(Me.LblTotal.Text, 2, Len(Me.LblTotal.Text))
        TotalVenta = Double.Parse(Total)

        Dim Creditos As New Credito
        Creditos.VentaCreditos(TotalVenta, DsDatos, Me)
        Creditos.WindowState = FormWindowState.Normal
        Creditos.StartPosition = FormStartPosition.CenterScreen
        Creditos.ShowDialog()
    End Sub
#End Region

#Region " Boton Facturacion "
    Private Sub Btn_Factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Factura.Click

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

#Region "  Botón ELIMINAR PRODUCTO  "
    Private Sub eliminarProducto()
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

        If e.KeyCode = Keys.Delete Then
            eliminarProducto()
        End If

        If e.KeyCode = Keys.Up Then
            Dim pos As Integer = posRowGrid() + 1
            If GridDatos.Selection.IsSelectedCell(New SourceGrid.Position(1, 1)) Then
                Codigo_Producto.Focus()
                GridDatos.Selection.SelectRow(pos, False)
            Else
                GridDatos.Selection.SelectRow(pos - 1, True)
                GridDatos.Selection.SelectRow(pos, False)
            End If
        End If

        If e.KeyCode = Keys.Down Then
            Dim pos As Integer = posRowGrid() + 1
            GridDatos.Selection.SelectRow(pos + 1, True)
            GridDatos.Selection.SelectRow(pos, False)
        End If
    End Sub
#End Region

#Region "  Rutina: imprimeTicket  "
    Private Sub imprimeTicket(ByVal totalVentaR As Double, _
                             ByVal recibidoR As Double, _
                             ByVal faltanteR As Double)

        Dim ticket As New WindowsFormsApplication1.BarControls.Ticket

        'ticket.HeaderImage = "C:\imagen.jpg"; //esta propiedad no es obligatoria

        Caja = "Consulta126" : Parametros = ""
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        ticket.AddHeaderLine(ObjRet.DS.Tables(0).Rows(0).Item(1).ToString.Trim)
        ticket.AddHeaderLine(ObjRet.DS.Tables(0).Rows(0).Item(2).ToString.Trim)
        ticket.AddHeaderLine(ObjRet.DS.Tables(0).Rows(0).Item(3).ToString.Trim)
        ticket.AddHeaderLine(ObjRet.DS.Tables(0).Rows(0).Item(4).ToString.Trim)

        'El metodo AddSubHeaderLine es lo mismo al de AddHeaderLine con la diferencia
        'de que al final de cada linea agrega una linea punteada "=========="
        'ticket.AddSubHeaderLine("Caja # 1 - Ticket # 1")

        Dim numTicket As String
        numTicket = lConsulta.ObtenerValor("2R", ObjRet.sResultado, "|")

        ticket.AddSubHeaderLine("Ticket: " & numTicket.Trim)
        ticket.AddSubHeaderLine("Le atendió: " & nombreCompleto.Trim)
        ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())

        'El metodo AddItem requeire 3 parametros, el primero es cantidad, el segundo es la descripcion
        'del producto y el tercero es el precio
        'ticket.AddItem("1", "Articulo Prueba", "15.00")
        For n = 0 To DsDatos.Tables("Table").Rows.Count - 1
            If DsDatos.Tables("Table").Rows(n).Item("mC2").ToString.Trim <> "" Then
                'Dim precioTotal As 
                'precioTotal = DsDatos.Tables("Table").Rows(n).Item("C6").ToString("F")
                ticket.AddItem(DsDatos.Tables("Table").Rows(n).Item("C3").ToString, _
                               DsDatos.Tables("Table").Rows(n).Item("C2").ToString, _
                               DsDatos.Tables("Table").Rows(n).Item("C6").ToString)
            End If
        Next

        'El metodo AddTotal requiere 2 parametros, la descripcion del total, y el precio
        ticket.AddTotal("TOTAL", totalVentaR.ToString("F"))
        ticket.AddTotal("", "") 'Ponemos un total en blanco que sirve de espacio
        ticket.AddTotal("RECIBIDO", recibidoR.ToString("F"))
        ticket.AddTotal("CAMBIO", faltanteR.ToString("F"))
        ticket.AddTotal("", "") 'Ponemos un total en blanco que sirve de espacio

        'El metodo AddFooterLine funciona igual que la cabecera

        ticket.AddFooterLine(ObjRet.DS.Tables(0).Rows(0).Item(5).ToString.Trim)
        ticket.AddFooterLine(ObjRet.DS.Tables(0).Rows(0).Item(6).ToString.Trim)
        ticket.AddFooterLine(ObjRet.DS.Tables(0).Rows(0).Item(7).ToString.Trim)

        'Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un
        'parametro de tipo string que debe de ser el nombre de la impresora.
        'ticket.PrintTicket("EPSON TM-U220 Receipt"); 
        ticket.PrintTicket(ObjRet.DS.Tables(0).Rows(0).Item(0).ToString.Trim)


    End Sub
#End Region

#Region "  Evento: GridDatos - PAINT  (Calcula el tamaño de la última columna para ajustarse el tamaño del grid.)  "
    Private Sub GridDatos_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GridDatos.Paint
        Dim sizeColumns As Integer
        For n As Integer = 0 To GridDatos.Columns.Count - 2
            sizeColumns += GridDatos.Columns(n).Width
        Next

        Dim sizeGrid As Integer = GridDatos.Size.Width - sizeColumns - 4
        GridDatos.Columns.SetWidth(9, sizeGrid)
    End Sub
#End Region

#Region "  Rutina: checkLimiteCaja  "
    Sub checkLimiteCaja()
        ' CONFIGURACION_CAJA
        ' Si está activado un monto máximo por defecto se sugiere
        ' que se haga el corte.
        Caja = "Consulta112" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        Dim activadoMontoMaximo As Boolean
        Dim montoPorDefecto As Decimal
        activadoMontoMaximo = ObjRet.DS.Tables(0).Rows(0).Item(3)
        montoPorDefecto = ObjRet.DS.Tables(0).Rows(0).Item(4)

        If activadoMontoMaximo Then
            ' Se llama a al consulta111 conocer el total de dinero
            ' acumulado.

            Caja = "consulta111" : Parametros = "V1=" & idUsuario & "|"
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

            Dim sumEnt As Decimal
            Dim sumSal As Decimal
            Dim dinIni As Decimal
            Dim total As Decimal
            Dim ventasTotal As Decimal

            sumEnt = Decimal.Parse(ObjRet.DS.Tables(3).Rows(0).Item(1))
            sumSal = Decimal.Parse(ObjRet.DS.Tables(3).Rows(0).Item(2))
            dinIni = Decimal.Parse(ObjRet.DS.Tables(3).Rows(0).Item(0))
            ventasTotal = Decimal.Parse(ObjRet.DS.Tables(3).Rows(0).Item(3))
            total = dinIni + sumEnt + ventasTotal - sumSal

            If total >= montoPorDefecto Then
                MessageBox.Show("La cantidad actual en la caja es: " & FormatCurrency(total) & vbCrLf & _
                            "La cantidad máxima a tener en caja es: " & FormatCurrency(montoPorDefecto) & vbCrLf & _
                            vbCrLf & "Se le sugiere que haga el corte en caja.", "Información", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region
    
#Region "  Botón SALIR  "
    Private Sub toolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripButton6.Click
        Dim result As DialogResult
        result = MessageBox.Show("Está a punto de cerrar la aplicación. Todas las ventanas se cerrarán y cualquier información que no haya guardado se perderá. ¿Desea continuar?", " Cerrar la aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            End
        Else
            Return
        End If
    End Sub
#End Region

#Region "  Botón CERRAR SESIÓN  "
    Private Sub toolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripButton5.Click
        Dim result As DialogResult
        result = MessageBox.Show("Está a punto de cerrar su sesión. Todas las ventanas se cerrarán y cualquier información que no haya guardado se perderá. ¿Desea continuar?", " Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            myPrincipal.cerrarVentanasHijas()
            Me.myPrincipal.Visible = False
            myPrincipal.Login()
            myPrincipal.restriccionPermisos(usuario)
        Else
            Return
        End If
    End Sub
#End Region

#Region "  Botón HACER CORTE  "
    Private Sub toolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripButton4.Click
        'Caja
        Dim objCaja As Caja = objCaja.Instance
        objCaja.MdiParent = Me.myPrincipal
        objCaja.WindowState = FormWindowState.Maximized

        objCaja.StartPosition = FormStartPosition.CenterScreen
        objCaja.Show()
    End Sub
#End Region
    
End Class