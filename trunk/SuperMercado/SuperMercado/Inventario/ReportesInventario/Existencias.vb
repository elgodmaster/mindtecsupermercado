Public Class Existencias


#Region "Variables de trabajo"
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Dim lblList As List(Of LabelExt)
    Dim catList As List(Of String)
    Dim labelfiltro As String = ""
#End Region

#Region "Eventos"
    Private Sub consulta_Existencias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Cerrar()
        End Select
    End Sub
#End Region

#Region " Load "
    Private Sub consulta_Existencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Caja = "Consulta138" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
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
        lbl1.ForeColor = System.Drawing.Color.Green
        lbl1.Location = New System.Drawing.Point(29, 91)
        lbl1.Name = "lblGeneral"
        lbl1.TabIndex = 232
        lbl1.Text = "General"
        lblList.Add(lbl1)
        catList.Add("General")
        Me.Controls.Add(lbl1)
        CalcularTotal()
    End Sub

#End Region

#Region " Label "
    Public Sub addLabel(ByVal categoria As String, ByVal item As String)
        Dim lbl1 As New LabelExt(Me)
        Dim x As Integer
        If Me.catList.IndexOf(categoria) < 0 Then
            lbl1.BackColor = Color.Transparent
            lbl1.AutoSize = True
            lbl1.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lbl1.ForeColor = System.Drawing.Color.Orange
            x = lblList.Item(lblList.Count - 1).Right + 10
            lbl1.Location = New System.Drawing.Point(x, 91)
            lbl1.Name = "lbl" + categoria
            lbl1.TabIndex = 232
            If Len(RTrim(LTrim(item))) <> 0 Then
                lbl1.Text = categoria + ": " + item.Trim()
                lbl1.Filtro = lblList.Item(lblList.Count - 1).Filtro
            Else
                MessageBox.Show("Seleccione un registro que contenga información", "Hola")
            End If

            If lbl1.Filtro.ToString().Trim().Length > 1 Then
                lbl1.Filtro = lbl1.Filtro + " and " + categoria + "='" + item + "'"
            Else
                lbl1.Filtro = categoria + "='" + item + "'"
            End If
            lblList.Add(lbl1)
            Me.Controls.Add(lbl1)
            Me.catList.Add(categoria)
            DirectCast(Me.DataGrid1.DataSource, DevAge.ComponentModel.BoundDataView).mDataView.RowFilter = lbl1.Filtro
            CalcularTotal()
            labelfiltro = lbl1.Filtro.ToString
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
        CalcularTotal()
        labelfiltro = lbl.Filtro.ToString
    End Sub

    Class LabelExt
        Inherits Label
        Private padre As Existencias
        Private filt As String
        Public Sub New(ByVal padre As Existencias)
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
        Dim padre As Existencias
        Public Sub New(ByVal frm As Existencias)
            MyBase.New()
            padre = frm
        End Sub
        Public Overrides Sub OnDoubleClick(ByVal sender As SourceGrid.CellContext, ByVal e As System.EventArgs)
            MyBase.OnDoubleClick(sender, e)
            padre.addLabel(padre.nombreColumna(sender.Position.Column), sender.Value)
        End Sub
    End Class
#End Region



#Region " Rutinas "
    Sub Cerrar()
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Deseas salir de esta pantalla?", "Entradas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region

    Sub Excelazo()

        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Open("F:\MindTec\PRUEBAS_PROYECTOS\PruebasReportes\PruebasReportes\Componentes\Reportes\PlantillaReportesExistencia.xlsx")
            exHoja = exLibro.ActiveSheet

            ' ¿Cuantas columnas y cuantas filas?
            'Dim NCol As Integer = ElGrid.ColumnCount
            'Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            'For i As Integer = 1 To DataGrid1.Columns.Count - 1
            '    exHoja.Cells.Item(1, i) = DataGrid1.Columns(i - 1)
            '    'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            'Next
            exHoja.Cells(2, 8) = "Fecha: " & Now().ToShortDateString
            exHoja.Cells(3, 8) = "Usuario: Valencia"
            exHoja.Cells(4, 8) = LblReg.Text
            exHoja.Cells(5, 8) = LblTotal.Text
            exHoja.Cells(6, 2) = labelfiltro
            ' exHoja.Cells(5, 5).size = 22


            'DataGrid1.Columns(1).HeaderCell.ToString()

            For Fila As Integer = 0 To DataGrid1.Rows.Count - 3
                For Col As Integer = 0 To DataGrid1.Columns.Count - 1
                    exHoja.Cells.Item(Fila + 9, Col + 1) = DataGrid1.DataSource.Item(Fila).row(Col)

                Next
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            'exHoja.Rows.Item(1).Font.Bold = 1
            'exHoja.Rows.Item(1).HorizontalAlignment = 3
            'exHoja.Columns.AutoFit()


            'Aplicación visible
            exApp.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

        End Try

    End Sub

    Private Sub Impresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Impresion.Click
        Excelazo()
    End Sub

    Sub CalcularTotal()

        ''''Calcula total de registros
        Dim x As Integer = DataGrid1.Rows.Count - 2
        LblReg.Text = "No.Registros: " + x.ToString

        ''''Calcular total de dinero
        Dim nSuma As Double = 0.0
        For i As Integer = 0 To DataGrid1.Rows.Count - 3

            nSuma += DataGrid1.DataSource.Item(i).row(8)
            'If Not IsDBNull(pDt.Rows.Item(pColumna)) Then
            '    nSuma += pDt.Rows.Item(pColumna)
            'End If
        Next
        LblTotal.Text = "Monto Total " & FormatCurrency(nSuma)


    End Sub

End Class