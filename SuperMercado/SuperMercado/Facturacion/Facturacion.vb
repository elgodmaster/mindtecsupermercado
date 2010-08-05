Imports MindTec.Componentes

Public Class Facturacion

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

#Region " Load "
    Private Sub Facturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrearDsDatos()
        ConfiguraGridDatos()
        LimpiarPantalla()
        MensajePiePagina.Text = " Registre el numero de factura siguiente para comenzar"
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

        GridColumn = GridDatos.Columns.Add("C5", "Precio", EditorCustom)
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
        GridDatos.Columns.SetWidth(8, 0)
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

#Region " Factura KeyDown "
    Private Sub txtNoFactura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoFactura.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoFacturas()
            Case Keys.Enter
                Caja = "Consulta119" : Parametros = "V1=" & txtNoFactura.Text & "|"
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "4", Parametros)
                If ObjRet.bOk Then
                    btnAceptar.PerformClick()
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

                End If

        End Select
    End Sub
#End Region

#Region " Rutinas "
    Sub CatalogoProductos()
        Caja = "Consulta119" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            Txt_CodigoProducto.Text = nuevo.resultado
        End If
    End Sub

    Sub CatalogoVentas()
        Caja = "Consulta119" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "5", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            CodigoVenta.Text = nuevo.resultado
        End If
    End Sub

    Sub CatalogoFacturas()
        Caja = "Consulta119" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            txtNoFactura.Text = nuevo.resultado
        End If
    End Sub

    Sub Catalogodecotizaciones()
        Caja = "Consulta125" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.CodigoCotizacion.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.CodigoCotizacion_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

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

    Private Sub Txt_Cantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_Cantidad.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                AgregarProducto()
        End Select
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        AgregarProducto()
    End Sub

    Sub AgregarProducto()
        Dim Codigo As String = ""
        Dim Producto As String = ""
        Dim Unidad As String = ""
        Dim Costo As Double = 0

        Caja = "Consulta119" : Parametros = "V1=" & Txt_CodigoProducto.Text & "|"
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
            registro!C8 = 1 ''''''''''''''''''''''''''''''''''''''''''Corregir Descuento
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
            Me.RadioCotizacion.Enabled = True
            Me.RadioVenta.Enabled = True
            Me.TxtIva.Enabled = True
        Else
            Me.RadioCotizacion.Enabled = False
            Me.RadioVenta.Enabled = False
            Me.TxtIva.Enabled = False
            CodigoCotizacion.Enabled = False
            CodigoVenta.Enabled = False
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

#Region " Cliente "
    Private Sub CodigoCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoCliente.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoClientes()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta105" : Parametros = "V1=" & Me.CodigoCliente.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "4", Parametros)
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
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    CodigoCliente.Focus()
                End If
        End Select
    End Sub
#End Region

#Region " Aceptar "
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Caja = "Consulta119" : Parametros = "V1=" & txtNoFactura.Text & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "4", Parametros)
        If ObjRet.bOk Then
            Me.dtpFecha.Text = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|")
            Me.TxtIva.Text = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
            Me.CodigoCliente.Text = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|")
            Me.lblRFCCliente.Text = lConsulta.ObtenerValor("V5", ObjRet.sResultado, "|")
            Me.lblNombreCliente.Text = lConsulta.ObtenerValor("V6", ObjRet.sResultado, "|")
            Me.lblDireccionCliente.Text = lConsulta.ObtenerValor("V7", ObjRet.sResultado, "|")
            Me.lblcolonia.Text = lConsulta.ObtenerValor("V8", ObjRet.sResultado, "|")
            Me.LblCP.Text = lConsulta.ObtenerValor("V9", ObjRet.sResultado, "|")
            Me.lblEstadoCliente.Text = lConsulta.ObtenerValor("V10", ObjRet.sResultado, "|")
            Me.lblCiudadCliente.Text = lConsulta.ObtenerValor("V11", ObjRet.sResultado, "|")
            Me.chbGenerar.Checked = ((lConsulta.ObtenerValor("V12", ObjRet.sResultado, "|")))
            Me.txtNoFactura.Enabled = False
            Me.btnAceptar.Enabled = False
            Me.Nuevo.Visible = False

            If Not ObjRet.DS Is DBNull.Value Then
                If Not ObjRet.DS.Tables Is DBNull.Value Then
                    If ObjRet.DS.Tables.Count > 0 Then
                        For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                            DsDatos.Tables("Table").ImportRow(ObjRet.DS.Tables(0).Rows(i))
                        Next
                        DsDatos.Tables("Table").AcceptChanges()
                        DsView = DsDatos.Tables(0).DefaultView
                    End If
                End If
            End If

            If Len(RTrim(LTrim(Me.lblNombreCliente.Text))) = 0 Then
                Grabar.Visible = True

            Else
                Impresion.Visible = True
                Me.Eliminar.Visible = True
                chbGenerar.Enabled = False
                RadioCotizacion.Enabled = False
                RadioVenta.Enabled = False
                TxtIva.Enabled = False
                dtpFecha.Enabled = False
                CodigoCliente.Enabled = False
                Me.Txt_CodigoProducto.Enabled = False
                Me.Txt_Cantidad.Enabled = False
                Me.CodigoVenta.Enabled = False
                Me.CodigoCotizacion.Enabled = False
                Nuevo.Visible = False
                Agregar.Enabled = False
                Me.Descuento.Enabled = False
            End If


            If Len(RTrim(LTrim(lConsulta.ObtenerValor("V13", ObjRet.sResultado, "|")))) <> 0 Then
                Me.RadioCotizacion.Checked = True
                Me.CodigoCotizacion.Text = lConsulta.ObtenerValor("V13", ObjRet.sResultado, "|")
            End If

            If Len(RTrim(LTrim(lConsulta.ObtenerValor("V14", ObjRet.sResultado, "|")))) <> 0 Then
                Me.RadioVenta.Checked = True
                Me.CodigoVenta.Text = lConsulta.ObtenerValor("V14", ObjRet.sResultado, "|")
            End If


            Me.GroupBox1.Visible = True
            CalculaTotal()
            CodigoCliente.Focus()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
        ObjRet = Nothing
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
        Me.CodigoVenta.Text = ""
        Me.CodigoCotizacion.Text = ""


        txtNoFactura.Text = ""
        Txt_Cantidad.Text = "0.00"
        Txt_CodigoProducto.Text = ""
        TxtIva.Text = "16"
        GroupBox1.Visible = False
        Me.Txt_Cantidad.Enabled = True
        Me.Txt_CodigoProducto.Enabled = True


        RadioVenta.Checked = False
        RadioCotizacion.Checked = False
        Me.chbGenerar.Checked = True

        RadioVenta.Enabled = True
        RadioCotizacion.Enabled = True
        chbGenerar.Enabled = True
        TxtIva.Enabled = True
        CodigoCliente.Enabled = True
        dtpFecha.Enabled = True
        Nuevo.Visible = True

        DsDatos.Tables("Table").Clear()

        Me.CodigoVenta.Visible = False
        Me.CodigoCotizacion.Visible = False
        Me.CodigoVenta.Enabled = True
        Me.CodigoCotizacion.Enabled = True
        Me.Agregar.Enabled = True
        Me.Descuento.Enabled = True

        Me.btnAceptar.Enabled = True
        Me.txtNoFactura.Enabled = True
        Me.Impresion.Visible = False
        Me.Grabar.Visible = False
        Me.Eliminar.Visible = False

        Me.txtNoFactura.Focus()
    End Sub

    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        LimpiarPantalla()
    End Sub
#End Region

#Region " Radios "
    Private Sub RadioCotizacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioCotizacion.CheckedChanged

        If RadioCotizacion.Checked = True Then
            CodigoVenta.Visible = False
            Me.CodigoCotizacion.Text = ""
            CodigoCotizacion.Visible = True
            CodigoCotizacion.Enabled = True
            CodigoCotizacion.Focus()
        End If

        If RadioVenta.Checked = True Then
            CodigoCotizacion.Visible = False
            Me.CodigoVenta.Text = ""
            Me.CodigoVenta.Visible = True
            CodigoVenta.Enabled = True
            CodigoVenta.Focus()
        End If
    End Sub

    Private Sub RadioVenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioVenta.CheckedChanged
        If RadioCotizacion.Checked = True Then
            CodigoVenta.Visible = False
            Me.CodigoCotizacion.Text = ""
            CodigoCotizacion.Visible = True

        End If

        If RadioVenta.Checked = True Then
            CodigoCotizacion.Visible = False
            Me.CodigoVenta.Text = ""
            Me.CodigoVenta.Visible = True

        End If
    End Sub

#End Region

#Region " Grabar "

    Private Sub Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grabar.Click
        If Not DsDatos Is DBNull.Value Then
            If Not DsDatos.Tables Is DBNull.Value Then
                If DsDatos.Tables("Table").Rows.Count > 0 Then
                    Caja = "Grabar119" : Parametros = "V1=" & Me.txtNoFactura.Text & "|V2=" & Me.dtpFecha.Value.ToString("dd/MM/yyyy") & _
                        "|V3=" & CodigoCliente.Text & "|V4=" & Me.TxtIva.Text & "|V5=" & Me.CodigoCotizacion.Text & "|V6=" & Me.CodigoVenta.Text & _
                        "|V7=" & IdUsuario & "|V8=" & IdtipoCambio & "|V9=" & Me.chbGenerar.Checked & "|"
                    If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                    ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros, DsDatos)
                    'Estatus
                    If ObjRet.bOk Then
                        MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                        LimpiarPantalla()
                    Else
                        MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

                    End If
                Else
                    MessageBox.Show("Registre un producto antes de grabar")
                    Me.Txt_CodigoProducto.Focus()
                End If
            End If
        End If
    End Sub
#End Region

   

    Private Sub CodigoVenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoVenta.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoVentas()
            Case Keys.Enter
                Caja = "Consulta119" : Parametros = "V1=" & Me.CodigoVenta.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "6", Parametros)
                If ObjRet.bOk Then
                    If Not ObjRet.DS Is DBNull.Value Then
                        If Not ObjRet.DS.Tables Is DBNull.Value Then
                            If ObjRet.DS.Tables.Count > 0 Then
                                For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                                    DsDatos.Tables("Table").ImportRow(ObjRet.DS.Tables(0).Rows(i))
                                Next
                                DsDatos.Tables("Table").AcceptChanges()
                                DsView = DsDatos.Tables(0).DefaultView
                                Grabar.Visible = True
                            End If
                        End If
                    End If
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    LimpiarPantalla()
                End If

                CodigoCliente.Focus()
        End Select
    End Sub

    Private Sub CodigoCotizacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoCotizacion.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Catalogodecotizaciones()
            Case Keys.Enter, Keys.Down
                'Servicios
                Caja = "Consulta119" : Parametros = "V1=" & Me.CodigoCotizacion.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "7", Parametros)
                'Estatus
                If ObjRet.bOk Then
                    TxtIva.Text = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
                    CodigoCliente.Text = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|")
                    lblRFCCliente.Text = lConsulta.ObtenerValor("V5", ObjRet.sResultado, "|")
                    lblNombreCliente.Text = lConsulta.ObtenerValor("V6", ObjRet.sResultado, "|")
                    lblDireccionCliente.Text = lConsulta.ObtenerValor("V7", ObjRet.sResultado, "|")
                    lblcolonia.Text = lConsulta.ObtenerValor("V8", ObjRet.sResultado, "|")
                    LblCP.Text = lConsulta.ObtenerValor("V9", ObjRet.sResultado, "|")
                    lblEstadoCliente.Text = lConsulta.ObtenerValor("V10", ObjRet.sResultado, "|")
                    lblCiudadCliente.Text = lConsulta.ObtenerValor("V11", ObjRet.sResultado, "|")

                    GroupBoxDatosCliente.Visible = True
                    Grabar.Visible = True
                    Nuevo.Visible = False
                    ''Llenar Grid
                    If Not ObjRet.DS Is DBNull.Value Then
                        If Not ObjRet.DS.Tables Is DBNull.Value Then
                            If ObjRet.DS.Tables.Count > 0 Then
                                For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                                    DsDatos.Tables("Table").ImportRow(ObjRet.DS.Tables(0).Rows(i))
                                Next
                                DsDatos.Tables("Table").AcceptChanges()
                                DsView = DsDatos.Tables(0).DefaultView
                                CalculaTotal()
                            End If
                        End If
                    End If

                    Txt_CodigoProducto.Focus()
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                    LimpiarPantalla()
                End If
        End Select
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        Caja = "Eliminar119" : Parametros = "V1=" & Me.txtNoFactura.Text & "|"
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros, DsDatos)
        'Estatus
        If ObjRet.bOk Then
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            LimpiarPantalla()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

        End If
    End Sub
End Class