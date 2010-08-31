Imports MindTec.Componentes
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Rep_Productos

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Dim ruta As String
#End Region

    Private Sub Rep_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpiarPantalla()
    End Sub




    Sub LimpiarPantalla()
        Me.TxtCat.Text = ""
        Me.TxtCodigo.Text = ""
        Me.TxtDep.Text = ""
        Me.TxtMarca.Text = ""
        Me.LblCat.Text = ""
        Me.LblDep.Text = ""
        Me.LblMar.Text = ""
        Me.LblNombre.Text = ""

    End Sub

#Region " Rutinas "
    Sub CatalogoProductos()
        Caja = "Consulta103" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            TxtCodigo.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.TxtCodigo_KeyDown(DBNull.Value, e)
        End If
    End Sub

    Sub CatalogoCat()
        Caja = "Consulta101" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            Me.TxtCat.Text = nuevo.resultado

            If nuevo.resultado = "" Then
                Return
            End If

            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.TxtCat_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub


    Sub Cat_Dep()
        Caja = "Consulta100" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            If nuevo.resultado = "" Then
                Return
            End If
            Me.TxtDep.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.TxtDep_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub


    Sub Cat_Mar()
        Caja = "Consulta102" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            If nuevo.resultado = "" Then
                Return
            End If
            Me.TxtMarca.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.TxtMarca_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub
#End Region




    Private Sub TxtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodigo.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoProductos()
            Case Keys.Enter
                Caja = "Consulta103" : Parametros = "V1=" & Me.TxtCodigo.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
                If ObjRet.bOk Then
                    LblNombre.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")

                End If
        End Select
    End Sub

    Private Sub TxtDep_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDep.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Cat_Dep()
            Case Keys.Enter
                Caja = "Consulta100" : Parametros = "V1=" & Me.TxtDep.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                If ObjRet.bOk Then
                    LblDep.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")

                End If
        End Select
    End Sub

    Private Sub TxtCat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCat.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatalogoCat()
            Case Keys.Enter
                Caja = "Consulta101" : Parametros = "V1=" & Me.TxtCat.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                If ObjRet.bOk Then
                    LblCat.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")

                End If
        End Select
    End Sub

    Private Sub TxtMarca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMarca.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Cat_Mar()
            Case Keys.Enter
                Caja = "Consulta102" : Parametros = "V1=" & Me.TxtMarca.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                If ObjRet.bOk Then
                    LblMar.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")

                End If
        End Select
    End Sub


#Region " Boton Reporte "
    Private Sub BtnRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRep.Click
        Caja = "Reporte004" : Parametros = "V1=" & Me.TxtCodigo.Text & "|V2=" & Me.TxtDep.Text & "|V3=" & Me.TxtCat.Text & "|V4=" & Me.TxtMarca.Text
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
        If ObjRet.bOk = True Then
            Productos()
            LimpiarPantalla()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            LimpiarPantalla()
        End If
    End Sub

    Private Sub Rep_pdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rep_pdf.Click
        BtnRep.PerformClick()
    End Sub


#End Region


#Region " Reporte "
    Sub Productos()
        Dim doc As New Document(iTextSharp.text.PageSize.LETTER, 30, 30, 20, 20)
        Try
            Dim a As New Random

            If Not System.IO.Directory.Exists("C:\\Productos\\") Then
                System.IO.Directory.CreateDirectory("C:\\Productos\\")
            End If

            ruta = "C:\\Productos\\Productos-" + Now.ToString("dd-MM-yyy") + "_" + a.Next().ToString() + ".pdf"


            Dim pdfFilePath As String = ruta

            'Create Document class object and set its size to letter and give space left, right, Top, Bottom Margin
            Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(pdfFilePath, FileMode.Create))

            Dim texto As New iTextSharp.text.Header("Encabezado", True)
            doc.Open()
            ''Propiedades del documento

            'Open Document to write
            Dim font8 As Font = FontFactory.GetFont("ARIAL", 7, False, 8, 0, iTextSharp.text.BaseColor.BLACK)
            Dim font9 As Font = FontFactory.GetFont("ARIAL", 7, False, 8, 1, iTextSharp.text.BaseColor.BLACK)
            Dim FontTitulo As Font = FontFactory.GetFont("ARIAL", 7, False, 12, 0, iTextSharp.text.BaseColor.BLACK)

            ''Imagen Logotipo de empresa
            Dim Logotipo As New iTextSharp.text.ImgCCITT(iTextSharp.text.ImgCCITT.GetInstance("F:\Mindtec\logoMindtec.png"))
            Logotipo.Alignment = iTextSharp.text.ImgCCITT.ALIGN_RIGHT
            Logotipo.ScalePercent(40)
            'jpg.Alignment = iTextSharp.text.Image.MIDDLE_ALIGN;


            Dim Titulo As New Paragraph("Reporte de Productos", FontTitulo)
            Dim Fecha As New Paragraph("Fecha:" + Now.ToShortDateString.ToString, font8)
            Titulo.Alignment = Element.ALIGN_CENTER

            Dim dt As DataTable = ObjRet.DS.Tables(0)

            If dt IsNot Nothing Then
                'Craete instance of the pdf table and set the number of column in that table
                Dim PdfTable As New PdfPTable(dt.Columns.Count)
                Dim PdfPCell As PdfPCell = Nothing



                'Add Header of the pdf table
                PdfPCell = New PdfPCell(New Phrase(New Chunk("Codigo", font9)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Descripción", font9)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Unidad", font9)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Costo", font9)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)


                PdfPCell = New PdfPCell(New Phrase(New Chunk("Precio", font9)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Margen", font9)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("StockMinimo", font9)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Existencia", font9)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                'How add the data from datatable to pdf table
                For rows As Integer = 0 To dt.Rows.Count - 1
                    For column As Integer = 0 To dt.Columns.Count - 1
                        PdfPCell = New PdfPCell(New Phrase(New Chunk(dt.Rows(rows)(column).ToString(), font8)))
                        PdfTable.AddCell(PdfPCell)
                    Next
                Next

                PdfTable.SpacingBefore = 15.0F
                PdfTable.WidthPercentage = 100
                Dim arreglo() As Integer = {90, 230, 90, 60, 70, 50, 73, 70}


                PdfTable.SetWidths(arreglo)
                ' Give some space after the text or it may overlap the table

                ''Pie 

                doc.AddCreationDate()
                doc.Add(Logotipo)
                doc.Add(Titulo)
                doc.Add(Fecha)

                If Len(RTrim(LTrim(Me.TxtCodigo.Text))) > 0 Then
                    Dim Filtro1 As New Paragraph("Codigo:" + Me.TxtCodigo.Text + " " + Me.LblNombre.Text, font9)
                    doc.Add(Filtro1)
                End If

                If Len(RTrim(LTrim(Me.TxtDep.Text))) > 0 Then
                    Dim Filtro2 As New Paragraph("Departamento: " + Me.LblDep.Text, font9)
                    doc.Add(Filtro2)
                End If

                If Len(RTrim(LTrim(Me.TxtCat.Text))) > 0 Then
                    Dim Filtro3 As New Paragraph("Categoria: " + Me.LblCat.Text, font9)
                    doc.Add(Filtro3)
                End If

                If Len(RTrim(LTrim(Me.TxtMarca.Text))) > 0 Then
                    Dim Filtro3 As New Paragraph("Marca: " + Me.LblMar.Text, font9)
                    doc.Add(Filtro3)
                End If

                ' add paragraph to the document
                ' add pdf table to the document
                doc.Add(PdfTable)
                ''Agregar operaciones 
            End If
        Catch docEx As DocumentException
            'handle pdf document exception if any
        Catch ioEx As IOException
            ' handle IO exception
        Catch ex As Exception
            ' ahndle other exception if occurs
        Finally
            'Close document and writer
            doc.Close()

        End Try
        System.Diagnostics.Process.Start(ruta)

    End Sub
#End Region

    Private Sub Limpiar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        LimpiarPantalla()
    End Sub

   
End Class