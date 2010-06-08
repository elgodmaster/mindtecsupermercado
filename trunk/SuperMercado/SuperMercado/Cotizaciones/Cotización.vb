Imports MindTec.Componentes

Public Class Cotización

#Region " Variables de trabajo "
    Dim DsDatos As DataSet
    Dim ViewDatos As DataView
    Private DsView As DataView
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Dim SubTotal As Double
    Dim Iva As Double
    Dim Total As Double
    Dim IdUsuario As Integer = 1
    Dim IdtipoCambio As Integer = 1
#End Region

    Private Sub Cotización_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrearDsDatos()
        ConfiguraGridDatos()
        LimpiarPantalla()

    End Sub

#Region " Cliente "
    Private Sub CodigoCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoCliente.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoClientes()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta105" : Parametros = "V1=" & Me.CodigoCliente.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    Caja = "Consulta105" : Parametros = "V1=" & Me.CodigoCliente.Text
                    If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                    ObjRet = lConsulta.LlamarCaja(Caja, "2", Parametros)

                    lblRFCCliente.Text = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|")
                    lblNombreCliente.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                    lblDireccionCliente.Text = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|")
                    lblcolonia.Text = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
                    LblCP.Text = lConsulta.ObtenerValor("V5", ObjRet.sResultado, "|")
                    lblEstadoCliente.Text = lConsulta.ObtenerValor("V6", ObjRet.sResultado, "|")
                    lblCiudadCliente.Text = lConsulta.ObtenerValor("V7", ObjRet.sResultado, "|")

                    GroupBoxDatosCliente.Visible = True

                    Txt_CodigoProducto.Focus()
                End If
        End Select
    End Sub
#End Region

#Region " Productos "
    Private Sub Txt_CodigoProducto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_CodigoProducto.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoProductos()
            Case Keys.Enter
                AgregarProducto()
        End Select
    End Sub

#End Region

#Region " Llenar Fila "
    Sub LlenarFila(ByVal Producto As String, ByVal Unidad As String, ByVal Costo As Double)

        ''Habilitar Botones de venta
        If Me.Grabar.Visible = False Then
            Me.Grabar.Visible = True

        End If


        Dim cantidad As Double
        Dim TotalCosto As Double = 0
        Double.Parse(Costo)

        Dim Igual As Boolean = 0
        Dim Encontro As Boolean = 0
        Dim fila As Integer = 0

        If Me.Txt_Cantidad.Text = "0.00" Or Len(LTrim(RTrim(Me.Txt_Cantidad.Text))) = 0 Then
            cantidad = 1
        Else
            cantidad = Double.Parse(Txt_Cantidad.Text)
        End If

        TotalCosto = cantidad * Costo

        For i As Integer = 0 To DsDatos.Tables("Table").Rows.Count - 1

            If DsDatos.Tables("Table").Rows(i).Item("C1") = Txt_CodigoProducto.Text Then
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
            registro!C1 = Txt_CodigoProducto.Text
            registro!C2 = Producto
            registro!C3 = cantidad
            registro!C4 = Unidad
            registro!C5 = Costo
            registro!C6 = TotalCosto

            DsDatos.Tables("Table").AcceptChanges()

        End If

        If Encontro = True Then
            DsDatos.Tables("Table").Rows(fila).Item("C1") = Txt_CodigoProducto.Text
            DsDatos.Tables("Table").Rows(fila).Item("C2") = Producto
            DsDatos.Tables("Table").Rows(fila).Item("C3") = cantidad
            DsDatos.Tables("Table").Rows(fila).Item("C4") = Unidad
            DsDatos.Tables("Table").Rows(fila).Item("C5") = Costo
            DsDatos.Tables("Table").Rows(fila).Item("C6") = TotalCosto
            DsDatos.Tables("Table").AcceptChanges()

        End If

        CalculaTotal()
    End Sub
#End Region

#Region " Rutinas "
    Sub CatalogoProductos()
        Caja = "Consulta125" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            Txt_CodigoProducto.Text = nuevo.resultado
        End If
    End Sub

    Sub CatalogoClientes()
        Caja = "Consulta105" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.CodigoCliente.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.CodigoCliente_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

        End If
    End Sub

    Sub AgregarProducto()
        Dim Codigo As String = ""
        Dim Producto As String = ""
        Dim Unidad As String = ""
        Dim Costo As Double = 0

        Caja = "Consulta125" : Parametros = "V1=" & Txt_CodigoProducto.Text & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
        If ObjRet.bOk Then
            Producto = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|", False)
            Unidad = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|", False)
            Costo = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|", False)
            ''Mandar Llamar Llenar Fila con los datos necesarios
            LlenarFila(Producto, Unidad, Costo)

            Me.Txt_CodigoProducto.Text = ""

            Me.Txt_Cantidad.Text = "0.00"
            Me.Txt_CodigoProducto.Focus()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            Me.Txt_CodigoProducto.Text = ""
            Me.Txt_Cantidad.Text = "0.00"
            Me.Txt_CodigoProducto.Focus()
        End If
    End Sub

    Sub Cerrar()
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas salir de esta pantalla?", "Supermercado Beltrán", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
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
        DsDatos.Tables("Table").Columns.Add("C8", GetType(Double))

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
        ''AGRAGAR BOTON
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

        GridColumn = GridDatos.Columns.Add("C5", "Precio U", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatos.Columns.Add("C6", "Total", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.EnableStretch

        GridColumn = GridDatos.Columns.Add("C8", "Descuento", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.EnableStretch

        GridDatos.Columns(0).Visible = False
        GridDatos.Columns.SetWidth(1, 30)
        GridDatos.Columns.SetWidth(2, 150)
        GridDatos.Columns.SetWidth(3, 300)
        GridDatos.Columns.SetWidth(4, 100)
        GridDatos.Columns.SetWidth(5, 130)
        GridDatos.Columns.SetWidth(6, 130)
        GridDatos.Columns.SetWidth(7, 130)
    End Sub

#End Region

#Region " Grid KeyDown "
    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.F4
                Limpiar.PerformClick()
            Case Keys.F9
                Grabar.PerformClick()
            Case Keys.F11
                Impresion.PerformClick()
            Case Keys.Escape
                Cerrar()
        End Select
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
            SubTotal = SubTotal + Double.Parse(DsDatos.Tables("Table").Rows(h).Item("C6"))
        Next

        If SubTotal = 0 Then
            Me.Grabar.Visible = False
            'Me.RadioCotizacion.Enabled = True
            'Me.RadioVenta.Enabled = True
            Me.TxtIva.Enabled = True
        Else
            'Me.RadioCotizacion.Enabled = False
            'Me.RadioVenta.Enabled = False
            Me.TxtIva.Enabled = False

        End If

        Iva = SubTotal * (Double.Parse(TxtIva.Text) / 100)
        Total = SubTotal + Iva

        Me.LblSubtotal.Text = FormatCurrency(SubTotal)
        Me.lblIVA.Text = FormatCurrency(Iva)
        Me.LBLTOTAL.Text = FormatCurrency(Total)

        SubTotal = 0
        Iva = 0
        Total = 0
    End Sub
#End Region

#Region " Limpiar Pantalla "

    Sub LimpiarPantalla()
        Me.lblCiudadCliente.Text = ""
        Me.lblcolonia.Text = ""
        Me.lblcolonia.Text = ""
        Me.LblCP.Text = ""
        Me.lblDireccionCliente.Text = ""
        Me.lblEstadoCliente.Text = ""
        Me.lblNombreCliente.Text = ""
        Me.lblRFCCliente.Text = ""
        Me.lblIVA.Text = "0.00"
        Me.LBLTOTAL.Text = "0.00"
        Me.LblSubtotal.Text = "0.00"
    

        txtNoFactura.Text = ""
        Txt_Cantidad.Text = "0.00"
        Txt_CodigoProducto.Text = ""
        TxtIva.Text = "16"
       
        TxtIva.Enabled = True
        Me.btnAceptar.Enabled = True
        Me.txtNoFactura.Enabled = True
        Me.Impresion.Visible = False
        Me.Grabar.Visible = False
        Me.Cotiza.Visible = False
        Me.GroupBoxDatosCliente.Visible = False
        Me.TxtIva.Visible = False
        Me.dtpFecha.Visible = False
        Me.LAbeliva.Visible = False
        Me.Labelfecha.Visible = False
        DsDatos.Tables("Table").Clear()
        Me.txtNoFactura.Focus()
    End Sub

    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        LimpiarPantalla()
    End Sub
#End Region

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

    End Sub
End Class