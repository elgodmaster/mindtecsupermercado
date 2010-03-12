Public Class Consulta_Existencias
#Region "Variables de trabajo"
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Dim lblList As List(Of LabelExt)
    Dim catList As List(Of String)
#End Region

    Private Sub frm_Existencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Caja = "Consulta150" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then

            For Each obj As DataRow In ObjRet.DS.Tables(0).Rows
                obj.Item("CostoTotal") = obj.Item("CostoTotal") * obj.Item("Existencia")
                obj.Item("Precio") = obj.Item("Precio") * obj.Item("Existencia")
            Next
            Me.DataGrid1.DataSource = New DevAge.ComponentModel.BoundDataView(ObjRet.DS.Tables(0).DefaultView)
            Me.DataGrid1.AutoSizeCells()
            For i = 0 To Me.DataGrid1.Columns.Count - 1
                Me.DataGrid1.GetCell(1, i).Editor.EnableEdit = False
            Next
            Me.DataGrid1.GetCell(1, 1).AddController(New KeyEvent(Me))
            Me.DataGrid1.GetCell(1, 3).AddController(New KeyEvent(Me))
            DataGrid1.Columns.Item(0).Width = 102
            DataGrid1.Columns.Item(1).Width = 105
            DataGrid1.Columns.Item(2).Width = 155
            DataGrid1.Columns.Item(3).Width = 105
            DataGrid1.Columns.Item(4).Width = 105
            DataGrid1.Columns.Item(5).Width = 105
            DataGrid1.Columns.Item(6).Width = 105
            DataGrid1.Columns.Item(7).Width = 94

        End If

        lblList = New List(Of LabelExt)
        catList = New List(Of String)

        Dim lbl1 As New LabelExt(Me)
        lbl1.BackColor = Color.Transparent
        lbl1.AutoSize = True
        lbl1.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl1.ForeColor = System.Drawing.Color.SteelBlue
        lbl1.Location = New System.Drawing.Point(29, 91)
        lbl1.Name = "lblGeneral"
        lbl1.TabIndex = 232
        lbl1.Text = "General"
        lblList.Add(lbl1)
        catList.Add("General")
        Me.Controls.Add(lbl1)


    End Sub



    Public Sub addLabel(ByVal categoria As String, ByVal item As String)
        Dim lbl1 As New LabelExt(Me)
        Dim x As Integer
        If Me.catList.IndexOf(categoria) < 0 Then
            lbl1.BackColor = Color.Transparent
            lbl1.AutoSize = True
            lbl1.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lbl1.ForeColor = System.Drawing.Color.SteelBlue
            x = lblList.Item(lblList.Count - 1).Right + 10
            lbl1.Location = New System.Drawing.Point(x, 91)
            lbl1.Name = "lbl" + categoria
            lbl1.TabIndex = 232
            lbl1.Text = categoria + ": " + item
            lbl1.Filtro = lblList.Item(lblList.Count - 1).Filtro
            If lbl1.Filtro.ToString().Trim().Length > 1 Then
                lbl1.Filtro = lbl1.Filtro + " and " + categoria + "='" + item + "'"
            Else
                lbl1.Filtro = categoria + "='" + item + "'"
            End If
            lblList.Add(lbl1)
            Me.Controls.Add(lbl1)
            Me.catList.Add(categoria)
            DirectCast(Me.DataGrid1.DataSource, DevAge.ComponentModel.BoundDataView).mDataView.RowFilter = lbl1.Filtro
        End If



    End Sub

    Public ReadOnly Property nombreColumna(ByVal index As Integer)
        Get
            Return DataGrid1.Columns.IndexToPropertyColumn(index).DisplayName()
        End Get
    End Property

    Public Sub SetLabelAct(ByVal lbl As LabelExt)
        Dim ban As New Boolean
        Dim i As Integer

        ban = False
        i = 0
        While Not lblList.Item(i).Equals(lbl)
            i = i + 1
        End While
        DirectCast(Me.DataGrid1.DataSource, DevAge.ComponentModel.BoundDataView).mDataView.RowFilter = lblList(i).Filtro
        i = i + 1
        While lblList.Count > i
            Me.Controls.Remove(lblList.Item(i))
            lblList.RemoveAt(i)
            catList.RemoveAt(i)
        End While

    End Sub

    Class LabelExt
        Inherits Label
        Private padre As Consulta_Existencias
        Private filt As String
        Public Sub New(ByVal padre As Consulta_Existencias)
            MyBase.New()
            Me.padre = padre
            filt = ""
        End Sub
        Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
            MyBase.OnClick(e)
            Me.padre.SetLabelAct(Me)
        End Sub
        Public Property Filtro()
            Get
                Return filt
            End Get
            Set(ByVal value)
                filt = value
            End Set
        End Property
    End Class

    Class KeyEvent
        Inherits SourceGrid.Cells.Controllers.ControllerBase
        Dim padre As Consulta_Existencias
        Public Sub New(ByVal frm As Consulta_Existencias)
            MyBase.New()
            padre = frm
        End Sub
        Public Overrides Sub OnDoubleClick(ByVal sender As SourceGrid.CellContext, ByVal e As System.EventArgs)
            MyBase.OnDoubleClick(sender, e)
            padre.addLabel(padre.nombreColumna(sender.Position.Column), sender.Value)
        End Sub
    End Class

#Region " Rutinas "


    Sub CrearReporteExcel()
        Dim excel As New Microsoft.Office.Interop.Excel.Application

        Dim libro As Microsoft.Office.Interop.Excel.Workbook
        Dim hoja As Microsoft.Office.Interop.Excel.Worksheet



        libro = excel.Workbooks.Open(Application.StartupPath + "\Reportes\Plantillas\repExistencias.xls")
        hoja = excel.ActiveSheet

        hoja.Cells(2, 11) = DateTime.Now.ToShortDateString

        Dim i As Integer
        Dim j As Integer
        Dim row As DataRowView
        i = 10
        j = 1


        For k As Integer = 0 To Me.DataGrid1.DataSource.Count - 1
            row = Me.DataGrid1.DataSource.Item(k)
            hoja.Cells(i + k, 1) = row.Item("Codigo")

            hoja.Cells(i + k, 2) = row.Item("Categoria")
            hoja.Cells(i + k, 3) = row.Item("Producto")
            hoja.Cells(i + k, 4) = row.Item("Marca")
            hoja.Cells(i + k, 5) = row.Item("Entradas")
            hoja.Cells(i + k, 6) = row.Item("Salidas")
            hoja.Cells(i + k, 7) = row.Item("Existencia")
            hoja.Cells(i + k, 8) = row.Item("Unidad")
            hoja.Cells(i + k, 9) = row.Item("CostoUnitario")
            hoja.Cells(i + k, 10) = row.Item("CostoTotal")
            hoja.Cells(i + k, 11) = row.Item("PrecioUnitario")
            hoja.Cells(i + k, 12) = row.Item("Precio")
        Next
       

        excel.Visible = True
        If Not System.IO.Directory.Exists("c:\Reportes\") Then
            System.IO.Directory.CreateDirectory("c:\Reportes\")
        End If

        Dim a As New Random

        hoja.SaveAs("c:\Reportes\RepExistencias " + DateTime.Now.ToLongDateString() + ".xls")

    End Sub

#End Region


    Private Sub ExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarExcel.Click
        CrearReporteExcel()
    End Sub
End Class