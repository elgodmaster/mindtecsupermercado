﻿Public Class Cat_Cliente_DetalleAbono

#Region "  Variables de trabajo  "
    ' Variables para la consulta.
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    ' Para Grid ABONO
    Dim dsDatosAbono As DataSet
    Dim dtAbono As DataTable
    Dim viewDatosAbono As Object
    Dim DsViewAbono As Object

    Dim idCuenta As Integer
#End Region

#Region "  Evento Cat_Cliente_DetalleAbono Carga  "
    Private Sub Cat_Cliente_DetalleAbono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrearDsDatosABONO()
        ConfiguraGridDatosAbono()

        ' Consulta regresa el detalle de una cuenta por cobrar

        Caja = "consulta118b" : Parametros = "V1=" & idCuenta & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, 1, Parametros)

        ' Se inserta la consulta en el Grid ENTRADAS.
        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables.Count > 0 Then
                    For i As Integer = 0 To ObjRet.DS.Tables(0).Rows.Count - 1
                        dsDatosAbono.Tables(0).ImportRow(ObjRet.DS.Tables(0).Rows(i))
                    Next
                    dsDatosAbono.Tables(0).AcceptChanges()
                    DsViewAbono = dsDatosAbono.Tables(0).DefaultView
                    'Else
                    '   FilaVacia()

                End If
            End If
        End If

    End Sub

#End Region

#Region "  Rutina cargaIdCuenta  "
    Friend Sub cargaIdCuenta(ByVal idCuentaR As Integer)
        idCuenta = idCuentaR
    End Sub
#End Region

#Region "  Grid Datos ABONO  "

    Sub CrearDsDatosABONO()
        dsDatosAbono = New DataSet("Root")
        dtAbono = New DataTable("Table")
        dsDatosAbono.Tables.Add(dtAbono)

        'DsDatos.Tables("Table").Columns.Add("C0", GetType(String))
        dsDatosAbono.Tables("Table").Columns.Add("C1", GetType(String))
        dsDatosAbono.Tables("Table").Columns.Add("C2", GetType(String))
        dsDatosAbono.Tables("Table").Columns.Add("C3", GetType(String))
        dsDatosAbono.Tables("Table").Columns.Add("C4", GetType(String))

    End Sub

    Sub ConfiguraGridDatosAbono()
        viewDatosAbono = dsDatosAbono.Tables("Table").DefaultView

        viewDatosAbono.AllowEdit = False
        viewDatosAbono.AllowNew = False
        viewDatosAbono.AllowDelete = True

        GridDatosAbonos.FixedRows = 1
        GridDatosAbonos.FixedColumns = 1
        GridDatosAbonos.DeleteRowsWithDeleteKey = False
        GridDatosAbonos.DeleteQuestionMessage = Nothing

        ' Renglon encabezado

        GridDatosAbonos.Columns.Insert(0, SourceGrid.DataGridColumn.CreateRowHeader(GridDatosAbonos))

        Dim BindList2 As DevAge.ComponentModel.IBoundList = New DevAge.ComponentModel.BoundDataView(viewDatosAbono)

        ' Se crean las columnas.
        GridDatosCrearColumnasABONO(GridDatosAbonos.Columns, BindList2)

        GridDatosAbonos.DataSource = BindList2

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

        GridDatosAbonos.GetCell(0, 1).View = viewcolumnheader
        GridDatosAbonos.GetCell(0, 2).View = viewcolumnheader
        GridDatosAbonos.GetCell(0, 3).View = viewcolumnheader
        GridDatosAbonos.GetCell(0, 4).View = viewcolumnheader

    End Sub

    Private Sub GridDatosCrearColumnasABONO(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
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

        'Definicion de la celda
        Dim EditorCustom As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        EditorCustom.EditableMode = SourceGrid.EditableMode.None

        'Crear columnas
        Dim GridColumn As SourceGrid.DataGridColumn

        GridColumn = GridDatosAbonos.Columns.Add("C1", "Folio", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosAbonos.Columns.Add("C2", "Monto", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosAbonos.Columns.Add("C3", "Fecha", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosAbonos.Columns.Add("C4", "Usuario", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridDatosAbonos.Columns(0).Visible = False
        GridDatosAbonos.Columns.SetWidth(1, 60)
        GridDatosAbonos.Columns.SetWidth(2, 8)
        GridDatosAbonos.Columns.SetWidth(3, 90)
        GridDatosAbonos.Columns.SetWidth(4, 60)

    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

#End Region

End Class