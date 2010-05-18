Imports MindTec.Componentes

Public Class ModuloVentas

#Region " Variables de trabajo "
    Dim DsDatos As DataSet
    Dim ViewDatos As DataView
    Private DsView As DataView
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Dim IdVenta As Integer
    Dim TotalVenta As Double = 0
    Dim Usuario As Integer = 2
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
                'Grabar.PerformClick()
            Case Keys.F10
                GroupBoxPagos.Visible = True
                AceptarVenta.Enabled = False
                Txt_Pago.Focus()
                Me.Focus()
                Txt_Pago.Focus()
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
        Caja = "Consulta115" : Parametros = "V1=" & Usuario & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "5", Parametros)
        If ObjRet.bOk Then
            IdVenta = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)
        End If
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
        DsDatos.Tables("Table").Columns.Add("C8", GetType(Decimal))

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
        viewcolumnheader.Font = New Font("Verdana", 12, FontStyle.Bold)
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
        viewNormal.Font = New Font("Verdana", 12, FontStyle.Regular)
        viewNormal.Border = border

        Dim myfont As New Font("Verdana", 12, FontStyle.Regular)

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

        GridColumn = GridDatos.Columns.Add("C5", "Precio Unitario", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatos.Columns.Add("C6", "Precio Total", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.EnableAutoSize

        GridColumn = GridDatos.Columns.Add("C7", "IdVenta", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.None

        GridColumn = GridDatos.Columns.Add("C8", "Descuento", EditorCustom)
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
        GridDatos.Columns.SetWidth(9, 0)
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

#Region " Codigo Producto"
    Private Sub Codigo_Producto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Codigo_Producto.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoProductos()
            Case Keys.Enter
                CajaProductos()
        End Select
    End Sub
#End Region

#Region " Caja Productos "

    Sub CajaProductos()
        Dim Codigo As String = ""
        Dim Producto As String = ""
        Dim Unidad As String = ""
        Dim Costo As Double = 0

        Caja = "Consulta115" : Parametros = "V1=" & Codigo_Producto.Text & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
        If ObjRet.bOk Then
            Producto = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)
            Unidad = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|", False)
            Costo = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|", False)
            ''Mandar Llamar Llenar Fila con los datos necesarios
            LlenarFila(Producto, Unidad, Costo)

            Me.Codigo_Producto.Text = ""

            Me.TxtCantidad.Text = "0.00"
            Me.Codigo_Producto.Focus()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            Me.Codigo_Producto.Text = ""
            Me.TxtCantidad.Text = "0.00"
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

        If Me.TxtCantidad.Text = "0.00" Or Len(LTrim(RTrim(Me.TxtCantidad.Text))) = 0 Then
            cantidad = 1
        Else
            cantidad = Double.Parse(TxtCantidad.Text)
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
        TxtCantidad.Text = "0.00"
        LblIva.Text = "$0.00"
        LblSubTotal.Text = "$0.00"
        LblTotal.Text = "0.00"
        Me.LblCambio.Text = "0.00"
        Me.Txt_Pago.Text = "0.00"
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

#Region " Aceptar Venta "
    Private Sub AceptarVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarVenta.Click
        Me.GroupBoxPagos.Visible = True
        Me.AceptarVenta.Enabled = False
        Me.Txt_Pago.Focus()
    End Sub
#End Region

#Region " Cantidad "
    Private Sub TxtCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCantidad.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                CajaProductos()
        End Select
    End Sub

    Private Sub TxtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidad.KeyPress
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
    Private Sub Descuento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Descuento.Click
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
    Private Sub Txt_Pago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Pago.KeyPress
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
        RecibiPago = Double.Parse(Me.Txt_Pago.Text)

        If TotalVenta <= RecibiPago Then
            Faltante = RecibiPago - TotalVenta
            Me.LblCambio.Text = FormatCurrency(Faltante)

            ''Imprimir Ticket
            ''AbrirCajaRegistradora
            ''ModificarCaja
            ''ModificarInventario
            ''GuardarEnVentas
            ''ObtenerNuevoIdVenta

            ''Aqui se esta guardando la venta que se realizo en efectivo y actualizando las existencias
            Caja = "Grabar115" : Parametros = "V1=" & IdVenta & "|V3=0|V4=" & Usuario & "|V5=0|"
            If lConsulta Is Nothing Then lConsulta = New ClsConsultas
            ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros, DsDatos)
            'Estatus
            If ObjRet.bOk Then
                If Faltante = 0.0 Then
                    MessageBox.Show("Gracias Por Su Compra, Vuelva pronto", "SuperMercado")
                    LimpiarPantalla()
                Else
                    MessageBox.Show("Su Cambio es de" & FormatCurrency(Faltante))
                    LimpiarPantalla()
                End If

                ObtenerIdVenta()
            End If

        Else
            Faltante = TotalVenta - RecibiPago
            Faltante = FormatCurrency(Faltante)
            MessageBox.Show("No se a realizado el pago, hace falta" & FormatCurrency(Faltante))
        End If


    End Sub

#End Region

#Region " Boton Credito "
    Private Sub Btn_Credito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Credito.Click
        Dim Total As String = ""
        Total = Mid(Me.LblTotal.Text, 2, Len(Me.LblTotal.Text))
        TotalVenta = Double.Parse(Total)

        Dim Creditos As New Credito
        Creditos.VentaCreditos(TotalVenta, DsDatos, Usuario)
        Creditos.WindowState = FormWindowState.Normal
        Creditos.StartPosition = FormStartPosition.CenterScreen
        Creditos.Show()
    End Sub
#End Region

    Private Sub Btn_Factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Factura.Click

    End Sub

    Friend Sub CreditosCerrar(ByVal x As Integer)
        If x = 1 Then
            LimpiarPantalla()
        End If
    End Sub
End Class