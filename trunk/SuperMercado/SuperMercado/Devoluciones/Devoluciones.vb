Public Class Devoluciones

#Region "  Variables de trabajo  "
    ' Variables para la consulta.
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno

    ' Para Grid Ticket
    Public dsDatosTicket As DataSet
    Public dtTicket As DataTable
    Public viewDatosTicket As Object
    Public DsViewTicket As Object

    Dim resul As DialogResult
    Dim idVentaDetalla As Integer
    Dim totArt As Decimal
    Dim numArt As Decimal
    Dim canArt As Integer

#End Region

#Region "  Evento: Devoluciones LOAD  "
    Private Sub Devoluciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ocultarControles()
        CrearDsDatosDETALLE()
        ConfiguraGridDatosDetalle()
    End Sub
#End Region

#Region "  Botón Aceptar  "
    Private Sub buttonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAceptar.Click
        If textBoxTicket.Text.Trim = "" Then
            MessageBox.Show("No ha escrito el número de un ticket.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        consulta127()

        If lConsulta.ObtenerValor("V0", ObjRet.sResultado, "|") = "OK" Then
            actualizarGrid()
            mostrarControles()
        Else
            MessageBox.Show("No ha sido expedido un ticket con ese número.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        textBoxTicket.Select(0, 10)
        textBoxTicket.Focus()

    End Sub
#End Region

#Region "  Botón Devolver  "
    Private Sub ToolStripButtonDevolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonDevolver.Click
        If posRow() < 0 Then
            Return
        End If

        totArt = dsDatosTicket.Tables(0).Rows(posRow).Item(0)
        idVentaDetalla = dsDatosTicket.Tables(0).Rows(posRow).Item(3)
        canArt = dsDatosTicket.Tables(0).Rows.Count

        If totArt = 1 Then
            numArt = totArt
        Else
            Dim objDevolucion As New Devoluciones_cantidad
            objDevolucion.totArtDev = totArt
            objDevolucion.StartPosition = FormStartPosition.CenterScreen
            objDevolucion.ShowDialog()
            numArt = objDevolucion.numArtDev
        End If

        If canArt = 1 Then
            resul = MessageBox.Show("La cuenta será liquidada, ¿desea continuar?", " Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resul = Windows.Forms.DialogResult.No Then
                textBoxTicket.Select(0, 10)
                textBoxTicket.Focus()
                Return
            End If
        End If

        grabar126()
        consulta127()
        actualizarGrid()

        textBoxTicket.Select(0, 10)
        textBoxTicket.Focus()

    End Sub
#End Region

#Region "  Botón Limpiar  "
    Private Sub ButtonLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLimpiar.Click
        limpiarPantalla()
    End Sub
#End Region

#Region "  Grid Datos DETALLE  "

    Sub CrearDsDatosDETALLE()
        dsDatosTicket = New DataSet("Root")
        dtTicket = New DataTable("Table")
        dsDatosTicket.Tables.Add(dtTicket)

        dsDatosTicket.Tables("Table").Columns.Add("C1", GetType(String))
        dsDatosTicket.Tables("Table").Columns.Add("C2", GetType(String))
        dsDatosTicket.Tables("Table").Columns.Add("C3", GetType(String))
        dsDatosTicket.Tables("Table").Columns.Add("C4", GetType(String))

    End Sub

    Sub ConfiguraGridDatosDetalle()
        viewDatosTicket = dsDatosTicket.Tables("Table").DefaultView

        viewDatosTicket.AllowEdit = False
        viewDatosTicket.AllowNew = False
        viewDatosTicket.AllowDelete = True

        GridDatosTicket.FixedRows = 1
        GridDatosTicket.FixedColumns = 1
        GridDatosTicket.DeleteRowsWithDeleteKey = False
        GridDatosTicket.DeleteQuestionMessage = Nothing
        GridDatosTicket.SelectionMode = SourceGrid.GridSelectionMode.Row

        ' Renglon encabezado

        GridDatosTicket.Columns.Insert(0, SourceGrid.DataGridColumn.CreateRowHeader(GridDatosTicket))

        Dim BindList2 As DevAge.ComponentModel.IBoundList = New DevAge.ComponentModel.BoundDataView(viewDatosTicket)

        ' Se crean las columnas.
        GridDatosCrearColumnasTicket(GridDatosTicket.Columns, BindList2)

        GridDatosTicket.DataSource = BindList2

        Dim cColorHeader As Color
        cColorHeader = Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(168, Byte), Integer))

        'Vista columna encabezado

        Dim viewcolumnheader As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader.Font = New Font("Lucida Console", 8, FontStyle.Regular)
        viewcolumnheader.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft

        Dim viewcolumnheader2 As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader2 As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader2.Font = New Font("Lucida Console", 8, FontStyle.Regular)
        viewcolumnheader2.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight

        Dim viewcolumnheader3 As SourceGrid.Cells.Views.ColumnHeader = New SourceGrid.Cells.Views.ColumnHeader
        Dim backheader3 As DevAge.Drawing.VisualElements.ColumnHeader = New DevAge.Drawing.VisualElements.ColumnHeader
        viewcolumnheader3.Font = New Font("Lucida Console", 8, FontStyle.Regular)
        viewcolumnheader3.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter


        GridDatosTicket.GetCell(0, 1).View = viewcolumnheader3
        GridDatosTicket.GetCell(0, 2).View = viewcolumnheader
        GridDatosTicket.GetCell(0, 3).View = viewcolumnheader2

    End Sub

    Private Sub GridDatosCrearColumnasTicket(ByVal columns As SourceGrid.DataGridColumns, ByVal Bindlist As DevAge.ComponentModel.IBoundList)
        'Borders

        Dim border As DevAge.Drawing.RectangleBorder = New DevAge.Drawing.RectangleBorder(New DevAge.Drawing.BorderLine(Color.White), New DevAge.Drawing.BorderLine(Color.White))
        'gcolorRow esta declarada en el moduloGeneral

        'vistas
        Dim viewNormal As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewNormal.Font = New Font("Lucida Console", 8, FontStyle.Regular)
        viewNormal.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter


        Dim viewIzquierda As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewIzquierda.Font = New Font("Lucida Console", 8, FontStyle.Regular)
        viewIzquierda.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleLeft

        Dim viewDerecha As CellBackColorAlternate = New CellBackColorAlternate(Color.White, Color.White)
        viewDerecha.Font = New Font("Lucida Console", 8, FontStyle.Regular)
        viewDerecha.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight

        Dim myfont As New Font("Verdana", 8, FontStyle.Regular)

        'Eventos

        Dim gridKeydown As SourceGrid.Cells.Controllers.CustomEvents = New SourceGrid.Cells.Controllers.CustomEvents
        AddHandler gridKeydown.KeyDown, New KeyEventHandler(AddressOf Grid_KeyDown)

        'Definicion de la celda
        Dim EditorCustom As SourceGrid.Cells.Editors.TextBox = New SourceGrid.Cells.Editors.TextBox(GetType(String))
        EditorCustom.EditableMode = SourceGrid.EditableMode.None

        'Crear columnas
        Dim GridColumn As SourceGrid.DataGridColumn

        GridColumn = GridDatosTicket.Columns.Add("C1", "Cant", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosTicket.Columns.Add("C2", "Descripción", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewIzquierda
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosTicket.Columns.Add("C3", "Importe", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewDerecha
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridColumn = GridDatosTicket.Columns.Add("C4", "Id", EditorCustom)
        GridColumn.DataCell.AddController(gridKeydown)
        GridColumn.DataCell.View = viewNormal
        GridColumn.AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize

        GridDatosTicket.Columns(0).Visible = False

        GridDatosTicket.Columns.SetWidth(1, 40)
        GridDatosTicket.Columns.SetWidth(2, 145)
        GridDatosTicket.Columns.SetWidth(3, 80)

        GridDatosTicket.Columns(4).Visible = False


    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

#End Region

#Region "  Rutina: mostrarControles  "
    Private Sub mostrarControles()
        PanelDev.Visible = True
        ToolStripButtonDevolver.Visible = True
    End Sub
#End Region

#Region "  Rutina: ocultarControles  "
    Private Sub ocultarControles()
        PanelDev.Visible = False
        ToolStripButtonDevolver.Visible = False
    End Sub
#End Region

#Region "  Rutina: consulta127  "
    Private Sub consulta127()
        Caja = "Consulta127" : Parametros = "V1=" & textBoxTicket.Text & "|"
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
    End Sub
#End Region

#Region "  Rutina: Grabar126  "
    Private Sub grabar126()
        Caja = "grabar126" : Parametros = "V1=" & numArt & _
                                          "|V2=" & totArt & _
                                          "|V3=" & idVentaDetalla & "|"

        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)

    End Sub
#End Region

#Region "  Rutina: actualizarGrid  "
    Private Sub actualizarGrid()
        lblLiquidado.Visible = False
        dsDatosTicket.Tables(0).Clear()
        ' Se inserta la consulta en el Grid ENTRADAS.
        If Not ObjRet.DS Is DBNull.Value Then
            If Not ObjRet.DS.Tables Is DBNull.Value Then
                If ObjRet.DS.Tables.Count > 0 Then
                    For i As Integer = 0 To ObjRet.DS.Tables(1).Rows.Count - 1
                        dsDatosTicket.Tables(0).ImportRow(ObjRet.DS.Tables(1).Rows(i))
                    Next
                    dsDatosTicket.Tables(0).AcceptChanges()
                    DsViewTicket = dsDatosTicket.Tables(0).DefaultView
                    'Else
                    '   FilaVacia()

                End If
            End If
        End If

        Dim rows As Integer
        rows = ObjRet.DS.Tables(1).Rows.Count
        If rows = 0 Then
            lblLiquidado.Visible = True
        End If

        TextBoxNumTicket.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
        TextBoxCajero.Text = lConsulta.ObtenerValor("V2", ObjRet.sResultado, "|")
        TextBoxFecha.Text = lConsulta.ObtenerValor("V3", ObjRet.sResultado, "|")
        TextBoxTotal.Text = lConsulta.ObtenerValor("V4", ObjRet.sResultado, "|")
    End Sub
#End Region

#Region "  Rutina: limpiarPantalla  "
    Private Sub limpiarPantalla()
        textBoxTicket.Clear()
        textBoxTicket.Focus()
        ocultarControles()
    End Sub
#End Region

#Region "  Rutina: posRow  "
    Private Function posRow() As Integer
        Dim pos() As Integer = GridDatosTicket.Selection.GetSelectionRegion.GetRowsIndex
        If pos.Length = 0 Then
            Return -1
        Else
            Return pos(0) - 1
        End If
    End Function
#End Region

#Region "  Eventos cambio textBox con Enter  "
    Private Sub textBoxTicket_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textBoxTicket.KeyDown
        If e.KeyCode = Keys.Enter Then
            buttonAceptar.Focus()
        End If
    End Sub
#End Region

End Class