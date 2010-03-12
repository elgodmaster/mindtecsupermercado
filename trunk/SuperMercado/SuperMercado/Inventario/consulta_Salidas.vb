Public Class consulta_Salidas
#Region "Variables de trabajo"
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Dim lblList As List(Of LabelExt)
    Dim catList As List(Of String)
#End Region

    Private Sub consulta_Entradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Caja = "Consulta150" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
        If ObjRet.bOk Then
            Me.DataGrid1.DataSource = New DevAge.ComponentModel.BoundDataView(ObjRet.DS.Tables(0).DefaultView)
            Me.DataGrid1.AutoSizeCells()
            For i = 0 To Me.DataGrid1.Columns.Count - 1
                Me.DataGrid1.GetCell(1, i).Editor.EnableEdit = False
                Me.DataGrid1.GetCell(1, i).AddController(New KeyEvent(Me))
            Next



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
            lbl1.Text = categoria + ": " + item.Trim()
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
        Private padre As consulta_Salidas
        Private filt As String
        Public Sub New(ByVal padre As consulta_Salidas)
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
        Dim padre As consulta_Salidas
        Public Sub New(ByVal frm As consulta_Salidas)
            MyBase.New()
            padre = frm
        End Sub
        Public Overrides Sub OnDoubleClick(ByVal sender As SourceGrid.CellContext, ByVal e As System.EventArgs)
            MyBase.OnDoubleClick(sender, e)
            padre.addLabel(padre.nombreColumna(sender.Position.Column), sender.Value)
        End Sub
    End Class
End Class