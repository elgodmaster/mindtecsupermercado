Public Class Caja

#Region " Variables de trabajo "
    ' Variables para la consulta.
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    ' Para Grid ENTRADAS
    Dim dsDatosEntradas As DataSet
    Dim dtEntradas As DataTable
    Dim viewDatosEntradas As Object
    Dim DsViewEntradas As Object
    ' Para Grid SALIDAS
    Dim dsDatosSalidas As DataSet
    Dim dtSalidas As DataTable
    Dim viewDatosSalidas As Object
    Dim DsViewSalidas As Object


#End Region

    Private Sub Caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' -- Configuración de los componenetes --
        lblRetirar.Visible = False

        ' Entradas
        CrearDsDatosENTRADAS()
        ConfiguraGridDatosENTRADAS()
        ' Salidas
        CrearDsDatosSALIDAS()
        ConfiguraGridDatosSALIDAS()
    End Sub

    Private Sub btnEspFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Caja_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

#Region "Grid Datos ENTRADAS"

    Sub CrearDsDatosENTRADAS()
        dsDatosEntradas = New DataSet("Root")
        dtEntradas = New DataTable("Table")
        dsDatosEntradas.Tables.Add(dtEntradas)

        'DsDatos.Tables("Table").Columns.Add("C0", GetType(String))
        dsDatosEntradas.Tables("Table").Columns.Add("C1", GetType(String))
        dsDatosEntradas.Tables("Table").Columns.Add("C2", GetType(String))
        dsDatosEntradas.Tables("Table").Columns.Add("C3", GetType(String))
        'DsDatos.Tables("Table").Columns.Add("C4", GetType(String))
        'DsDatos.Tables("Table").Columns.Add("C5", GetType(String))

    End Sub

    Sub ConfiguraGridDatosENTRADAS()
        ViewDatosEntradas = DsDatosEntradas.Tables("Table").DefaultView

        ViewDatosEntradas.AllowEdit = False
        ViewDatosEntradas.AllowNew = False
        ViewDatosEntradas.AllowDelete = True

        GridDatosEntradas.FixedRows = 1
        GridDatosEntradas.FixedColumns = 1
        GridDatosEntradas.DeleteRowsWithDeleteKey = False
        GridDatosEntradas.DeleteQuestionMessage = Nothing

        ' Renglon encabezado

        GridDatosEntradas.Columns.Insert(0, SourceGrid.DataGridColumn.CreateRowHeader(GridDatosEntradas))

        Dim BindList2 As DevAge.ComponentModel.IBoundList = New DevAge.ComponentModel.BoundDataView(ViewDatosEntradas)

        ' Se crean las columnas.
        GridDatosCrearColumnasENTRADAS(GridDatosEntradas.Columns, BindList2)

        GridDatosEntradas.DataSource = BindList2

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

        GridDatosEntradas.GetCell(0, 1).View = viewcolumnheader
        GridDatosEntradas.GetCell(0, 2).View = viewcolumnheader
        GridDatosEntradas.GetCell(0, 3).View = viewcolumnheader
        'GridDatos.GetCell(0, 4).View = viewcolumnheader
        'GridDatos.GetCell(0, 5).View = viewcolumnheader

    End Sub

    Private Sub GridDatosCrearColumnasENTRADAS(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
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

        'Dim Cantidadkeydown As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents
        'AddHandler Cantidadkeydown.KeyDown, New KeyEventHandler(AddressOf cant_keydown)

        'Definicion de la celda
        Dim EditorCustom As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        EditorCustom.EditableMode = SourceGrid.EditableMode.None

        'Crear columnas
        Dim GridColumn As SourceGrid.DataGridColumn
        ''AGRAGAR BOTON
        ' GridColumn = GridDatos.Columns.Add(Nothing, "", New SourceGrid.Cells.Button("+"))
        ' GridColumn.DataCell.AddController(gridKeydown)
        'GridColumn.DataCell.AddController(clickEvent2)
        'GridColumn.DataCell.View = viewBtn
        'GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize


        'GridColumn = GridDatos.Columns.Add("C0", "Fecha", EditorCustom)
        'GridColumn.DataCell.AddController(gridKeydown)
        'GridColumn.DataCell.View = viewNormal
        'GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosEntradas.Columns.Add("C1", "Razón", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosEntradas.Columns.Add("C2", "Monto", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosEntradas.Columns.Add("C3", "Fecha", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        'GridColumn = GridDatos.Columns.Add("C4", "Unidad", EditorCustom)
        'GridColumn.DataCell.AddController(gridKeydown)
        'GridColumn.DataCell.View = viewNormal
        'GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.EnableStretch

        'GridColumn = GridDatos.Columns.Add("C5", "Precio Unitario", EditorCustom)
        'GridColumn.DataCell.AddController(gridKeydown)
        'GridColumn.DataCell.View = viewNormal
        'GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize



        GridDatosEntradas.Columns(0).Visible = False
        GridDatosEntradas.Columns.SetWidth(1, 227)
        GridDatosEntradas.Columns.SetWidth(2, 60)
        GridDatosEntradas.Columns.SetWidth(3, 135)
        'GridDatos.Columns.SetWidth(4, 150)
        'GridDatos.Columns.SetWidth(5, 150)
    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

#End Region
#Region "Grid Datos SALIDAS"

    Sub CrearDsDatosSALIDAS()
        dsDatosSalidas = New DataSet("Root")
        dtSalidas = New DataTable("Table")
        dsDatosSalidas.Tables.Add(dtSalidas)

        'DsDatos.Tables("Table").Columns.Add("C0", GetType(String))
        dsDatosSalidas.Tables("Table").Columns.Add("C1", GetType(String))
        dsDatosSalidas.Tables("Table").Columns.Add("C2", GetType(String))
        dsDatosSalidas.Tables("Table").Columns.Add("C3", GetType(String))
        'DsDatos.Tables("Table").Columns.Add("C4", GetType(String))
        'DsDatos.Tables("Table").Columns.Add("C5", GetType(String))

    End Sub

    Sub ConfiguraGridDatosSALIDAS()
        viewDatosSalidas = dsDatosSalidas.Tables("Table").DefaultView

        viewDatosSalidas.AllowEdit = False
        viewDatosSalidas.AllowNew = False
        viewDatosSalidas.AllowDelete = True

        GridDatosSalidas.FixedRows = 1
        GridDatosSalidas.FixedColumns = 1
        GridDatosSalidas.DeleteRowsWithDeleteKey = False
        GridDatosSalidas.DeleteQuestionMessage = Nothing

        'Renglon encabezado

        GridDatosSalidas.Columns.Insert(0, SourceGrid.DataGridColumn.CreateRowHeader(GridDatosSalidas))

        Dim BindList2 As DevAge.ComponentModel.IBoundList = New DevAge.ComponentModel.BoundDataView(viewDatosSalidas)

        GridDatosCrearColumnasSALIDAS(GridDatosSalidas.Columns, BindList2)

        GridDatosSalidas.DataSource = BindList2

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

        GridDatosSalidas.GetCell(0, 1).View = viewcolumnheader
        GridDatosSalidas.GetCell(0, 2).View = viewcolumnheader
        GridDatosSalidas.GetCell(0, 3).View = viewcolumnheader
        'GridDatos.GetCell(0, 4).View = viewcolumnheader
        'GridDatos.GetCell(0, 5).View = viewcolumnheader

    End Sub

    Private Sub GridDatosCrearColumnasSALIDAS(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
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

        'Dim Cantidadkeydown As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents
        'AddHandler Cantidadkeydown.KeyDown, New KeyEventHandler(AddressOf cant_keydown)

        'Definicion de la celda
        Dim EditorCustom As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        EditorCustom.EditableMode = SourceGrid.EditableMode.None

        'Crear columnas
        Dim GridColumn As SourceGrid.DataGridColumn
        ''AGRAGAR BOTON
        ' GridColumn = GridDatos.Columns.Add(Nothing, "", New SourceGrid.Cells.Button("+"))
        ' GridColumn.DataCell.AddController(gridKeydown)
        'GridColumn.DataCell.AddController(clickEvent2)
        'GridColumn.DataCell.View = viewBtn
        'GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize


        'GridColumn = GridDatos.Columns.Add("C0", "Fecha", EditorCustom)
        'GridColumn.DataCell.AddController(gridKeydown)
        'GridColumn.DataCell.View = viewNormal
        'GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosSalidas.Columns.Add("C1", "Razón", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosSalidas.Columns.Add("C2", "Monto", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosSalidas.Columns.Add("C3", "Fecha", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        'GridColumn = GridDatos.Columns.Add("C4", "Unidad", EditorCustom)
        'GridColumn.DataCell.AddController(gridKeydown)
        'GridColumn.DataCell.View = viewNormal
        'GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.EnableStretch

        'GridColumn = GridDatos.Columns.Add("C5", "Precio Unitario", EditorCustom)
        'GridColumn.DataCell.AddController(gridKeydown)
        'GridColumn.DataCell.View = viewNormal
        'GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize



        GridDatosSalidas.Columns(0).Visible = False
        GridDatosSalidas.Columns.SetWidth(1, 227)
        GridDatosSalidas.Columns.SetWidth(2, 60)
        GridDatosSalidas.Columns.SetWidth(3, 135)
        'GridDatos.Columns.SetWidth(4, 150)
        'GridDatos.Columns.SetWidth(5, 150)
    End Sub

#End Region

    Private Sub btnHacerCorte_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHacerCorte.Click
        lblRetirar.Visible = False
        ' Se llama a al consulta111 para realizar el corte.

        Caja = "consulta111" : Parametros = ""
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        ' Se inserta la consulta en el Grid ENTRADAS.
        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables.Count > 0 Then
                    For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                        dsDatosEntradas.Tables(0).ImportRow(ObjRet.DS.Tables(0).Rows(i))
                    Next
                    dsDatosEntradas.Tables(0).AcceptChanges()
                    DsViewEntradas = dsDatosEntradas.Tables(0).DefaultView
                    'Else
                    '   FilaVacia()

                End If
            End If
        End If
        ' Se inserta la consulta en el Grid SALIDAS.
        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables(1).Rows.Count > 0 Then
                    For i As Integer = 0 To ObjRet.DS.Tables(1).Rows.Count - 1
                        dsDatosSalidas.Tables(0).ImportRow(ObjRet.DS.Tables(1).Rows(i))
                    Next
                    dsDatosSalidas.Tables(0).AcceptChanges()
                    DsViewSalidas = dsDatosSalidas.Tables(0).DefaultView
                    'Else
                    '   FilaVacia()
                End If
            End If
        End If

        'Total.
        Dim sumEnt As Decimal
        Dim sumSal As Decimal
        Dim dinIni As Decimal
        Dim total As Decimal

        sumEnt = Decimal.Parse(ObjRet.DS.Tables(2).Rows(0).Item(1))
        sumSal = Decimal.Parse(ObjRet.DS.Tables(2).Rows(0).Item(2))
        dinIni = Decimal.Parse(ObjRet.DS.Tables(2).Rows(0).Item(0))

        If sumEnt = 0 And sumSal = 0 Then
            MessageBox.Show("No se han registrado entradas o salidas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf sumEnt = 0 Then
            MessageBox.Show("No se han registrado entradas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf sumSal = 0 Then
            MessageBox.Show("No se han registrado salidas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        lblEntradaDin.Text = "$" & sumEnt
        lblSalDinero.Text = "$" & sumSal

        lblDineroCaja.Text = "$" & ObjRet.DS.Tables(2).Rows(0).Item(0).ToString
        lblTotalEntradas.Text = "$" & sumEnt
        lblSalidas.Text = "$" & sumSal

        total = dinIni + sumEnt - sumSal

        lblTotal.Text = "$" & total.ToString

        ' CONFIGURACION_CAJA
        ' Si está activado un monto inicial por defecto se sugiere
        ' una cantidad a retirar: El dinero del corte menos del dinero
        ' inicial por defecto.
        Caja = "Consulta112" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

        Dim activadoMontoPorDefecto As Boolean
        Dim montoPorDefecto As Decimal
        activadoMontoPorDefecto = ObjRet.DS.Tables(0).Rows(0).Item(1)
        montoPorDefecto = ObjRet.DS.Tables(0).Rows(0).Item(2)

        If activadoMontoPorDefecto Then
            Dim montoRetirar As Decimal
            If total > montoPorDefecto Then
                montoRetirar = total - montoPorDefecto
                lblRetirar.Visible = True
                lblRetirar.Text = "Por favor retire: $" & montoRetirar
            End If
        End If

    End Sub

End Class