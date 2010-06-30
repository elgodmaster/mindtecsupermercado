Public Class Cat_Clientes_DetalleVenta

#Region "  Variables de trabajo  "
    ' Variables para la consulta.
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    ' Para Grid DETALLE
    Public dsDatosDetalle As DataSet
    Public dtDetalle As DataTable
    Public viewDatosDetalle As Object
    Public DsViewDetalle As Object

    Public idCuenta As Integer
    Public codigoCliente As String

    Public objCatCliente As Cat_Clientes
#End Region

#Region "  Evento Cat_Cliente_Detalla Carga  "
    Private Sub Cat_Clientes_Detalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrearDsDatosDETALLE()
        ConfiguraGridDatosDetalle()

        ' Consulta regresa el detalle de una cuenta por cobrar

        Caja = "consulta118a" : Parametros = "V1=" & idCuenta & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

        ' Se inserta la consulta en el Grid ENTRADAS.
        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables.Count > 0 Then
                    For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                        dsDatosDetalle.Tables(0).ImportRow(ObjRet.DS.Tables(0).Rows(i))
                    Next
                    dsDatosDetalle.Tables(0).AcceptChanges()
                    DsViewDetalle = dsDatosDetalle.Tables(0).DefaultView
                    'Else
                    '   FilaVacia()

                End If
            End If
        End If

    End Sub
#End Region

#Region "  Rutina cargaIdCuenta  "
    Friend Sub cargaIdCuenta(ByVal idCuentaR As Integer, _
                             ByVal codigoClienteR As String, _
                             ByRef objCatClienteR As Cat_Clientes)
        idCuenta = idCuentaR
        codigoCliente = codigoClienteR
        objCatCliente = objCatClienteR
    End Sub
#End Region

#Region "  Grid Datos DETALLE  "

    Sub CrearDsDatosDETALLE()
        dsDatosDetalle = New DataSet("Root")
        dtDetalle = New DataTable("Table")
        dsDatosDetalle.Tables.Add(dtDetalle)

        'DsDatos.Tables("Table").Columns.Add("C0", GetType(String))
        dsDatosDetalle.Tables("Table").Columns.Add("C1", GetType(String))
        dsDatosDetalle.Tables("Table").Columns.Add("C2", GetType(String))
        dsDatosDetalle.Tables("Table").Columns.Add("C3", GetType(String))
        dsDatosDetalle.Tables("Table").Columns.Add("C4", GetType(String))
        dsDatosDetalle.Tables("Table").Columns.Add("C5", GetType(String))
        dsDatosDetalle.Tables("Table").Columns.Add("C6", GetType(String))

    End Sub

    Sub ConfiguraGridDatosDetalle()
        viewDatosDetalle = dsDatosDetalle.Tables("Table").DefaultView

        viewDatosDetalle.AllowEdit = False
        viewDatosDetalle.AllowNew = False
        viewDatosDetalle.AllowDelete = True

        GridDatosDetalle.FixedRows = 1
        GridDatosDetalle.FixedColumns = 1
        GridDatosDetalle.DeleteRowsWithDeleteKey = False
        GridDatosDetalle.DeleteQuestionMessage = Nothing

        ' Renglon encabezado

        GridDatosDetalle.Columns.Insert(0, SourceGrid.DataGridColumn.CreateRowHeader(GridDatosDetalle))

        Dim BindList2 As DevAge.ComponentModel.IBoundList = New DevAge.ComponentModel.BoundDataView(viewDatosDetalle)

        ' Se crean las columnas.
        GridDatosCrearColumnasDETALLE(GridDatosDetalle.Columns, BindList2)

        GridDatosDetalle.DataSource = BindList2

        Dim cColorHeader As Color
        cColorHeader = Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(168, Byte), Integer))

        'Vista columna encabezado

        Dim viewcolumnheader As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        backheader.BackColor = cColorHeader
        backheader.Border = DevAge.Drawing.RectangleBorder.RectangleBlack1Width
        viewcolumnheader.Background = backheader
        viewcolumnheader.ForeColor = Color.Black
        viewcolumnheader.Font = New Font("Verdana", 8, FontStyle.Bold)
        viewcolumnheader.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter

        GridDatosDetalle.GetCell(0, 1).View = viewcolumnheader
        GridDatosDetalle.GetCell(0, 2).View = viewcolumnheader
        GridDatosDetalle.GetCell(0, 3).View = viewcolumnheader
        GridDatosDetalle.GetCell(0, 4).View = viewcolumnheader
        GridDatosDetalle.GetCell(0, 5).View = viewcolumnheader

    End Sub

    Private Sub GridDatosCrearColumnasDETALLE(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
        'Borders

        Dim border As DevAge.Drawing.RectangleBorder = New DevAge.Drawing.RectangleBorder(New DevAge.Drawing.BorderLine(Color.Black), New DevAge.Drawing.BorderLine(Color.Black))
        'gcolorRow esta declarada en el moduloGeneral

        'vistas
        Dim viewNormal As CellBackColorAlternate = New CellBackColorAlternate(gColorRow, Color.White)
        viewNormal.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewNormal.Border = border

        Dim viewDinero As CellBackColorAlternate = New CellBackColorAlternate(gColorRow, Color.White)
        viewDinero.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewDinero.Border = border
        viewDinero.TextAlignment = DevAge.Drawing.ContentAlignment.BottomRight

        Dim viewNormalCentrado As CellBackColorAlternate = New CellBackColorAlternate(gColorRow, Color.White)
        viewNormalCentrado.Font = New Font("Verdana", 8, FontStyle.Regular)
        viewNormalCentrado.Border = border
        viewNormalCentrado.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter

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

        'Definicion de la celda
        Dim EditorCustom As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        EditorCustom.EditableMode = SourceGrid.EditableMode.None

        'Crear columnas
        Dim GridColumn As SourceGrid.DataGridColumn

        GridColumn = GridDatosDetalle.Columns.Add("C1", "Producto", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosDetalle.Columns.Add("C2", "Cantidad", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormalCentrado
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosDetalle.Columns.Add("C3", "Precio", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewDinero
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosDetalle.Columns.Add("C4", "Descuento", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormalCentrado
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosDetalle.Columns.Add("C5", "Total", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewDinero
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosDetalle.Columns.Add("C6", "ID", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewDinero
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridDatosDetalle.Columns(0).Visible = False
        GridDatosDetalle.Columns.SetWidth(1, 160)
        GridDatosDetalle.Columns.SetWidth(2, 76)
        GridDatosDetalle.Columns.SetWidth(3, 80)
        GridDatosDetalle.Columns.SetWidth(4, 80)
        GridDatosDetalle.Columns.SetWidth(5, 80)
        GridDatosDetalle.Columns(6).Visible = False


    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

#End Region

#Region "  Botón DevolverArtículo  "
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pos As Integer = posRow()
        If pos < 0 Then
            MessageBox.Show("Ninguna artículo ha sido seleccionada.", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim descArticulo As String
        descArticulo = dsDatosDetalle.Tables(0).Rows(posRow).Item(0).ToString
        Dim objDevolucion As New Cat_Clientes_Devolucion
        objDevolucion.cargaRefPrin(Me, codigoCliente)
        objDevolucion.StartPosition = FormStartPosition.CenterScreen
        objDevolucion.ShowDialog()
    End Sub
#End Region

#Region "  Rutina: posRow  "
    Public Function posRow() As Integer
        Dim pos() As Integer = GridDatosDetalle.Selection.GetSelectionRegion.GetRowsIndex
        If pos.Length = 0 Then
            Return -1
        Else
            Return pos(0) - 1
        End If
    End Function
#End Region

End Class