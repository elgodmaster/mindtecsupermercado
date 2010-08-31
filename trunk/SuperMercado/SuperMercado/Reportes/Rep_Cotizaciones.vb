Imports MindTec.Componentes
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Rep_Cotizaciones

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Dim ruta As String
#End Region

    Private Sub Rep_Cotizaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiarpantalla()
    End Sub

#Region " Rutinas "

    Sub CatCotizaciones()
        Caja = "Consulta125" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "3", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.TxtCotizacion.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.txtcotizacion_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

        End If
    End Sub

    Sub CatClientes()
        Caja = "Consulta105" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)

            Me.TxtCliente.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.TxtCliente_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

        End If
    End Sub
#End Region


    Private Sub TxtCotizacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCotizacion.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatCotizaciones()
            Case Keys.Enter
                Caja = "Consulta125" : Parametros = "V1=" & Me.TxtCotizacion.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                If ObjRet.bOk Then
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                End If
        End Select
    End Sub

    Private Sub TxtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCliente.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatClientes()
            Case Keys.Enter
                Caja = "Consulta105" : Parametros = "V1=" & Me.TxtCliente.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                If ObjRet.bOk Then
                    LblCliente.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                End If
        End Select
    End Sub

#Region " Reporte "

    Sub CrearReporte()
        Caja = "Reporte006" : Parametros = "V1=" & Me.TxtCotizacion.Text & "|V2=" & Me.TxtCliente.Text & "|V3=" & Me.Fecha1.Value.ToShortDateString & "|V4=" & Me.Fecha2.Value.ToShortDateString
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
        If ObjRet.bOk = True Then
            Cotizaciones()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub

    Sub Cotizaciones()
        Dim doc As New Document(iTextSharp.text.PageSize.LETTER, 30, 30, 20, 20)
        Try
            Dim a As New Random

            If Not System.IO.Directory.Exists("C:\\Cotizaciones\\") Then
                System.IO.Directory.CreateDirectory("C:\\Cotizaciones\\")
            End If

            ruta = "C:\\Cotizaciones\\Cotización-" + Now.ToString("dd-MM-yyyy") + "_" + a.Next().ToString() + ".pdf"


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


            Dim Titulo As New Paragraph("Reporte de Cotizaciones", FontTitulo)
            Dim Fecha As New Paragraph("Fecha:" + Now.ToShortDateString.ToString, font8)
            Titulo.Alignment = Element.ALIGN_CENTER

            Dim dt As DataTable = ObjRet.DS.Tables(0)

            If dt IsNot Nothing Then
                'Craete instance of the pdf table and set the number of column in that table
                Dim PdfTable As New PdfPTable(dt.Columns.Count)
                Dim PdfPCell As PdfPCell = Nothing



                'Add Header of the pdf table
                PdfPCell = New PdfPCell(New Phrase(New Chunk("No", font9)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Cliente", font9)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Fecha", font9)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Sub-total", font9)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)


                PdfPCell = New PdfPCell(New Phrase(New Chunk("IVA", font9)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Total", font9)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                'PdfPCell = New PdfPCell(New Phrase(New Chunk("StockMinimo", font9)))
                'PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                'PdfTable.AddCell(PdfPCell)


                'How add the data from datatable to pdf table
                For rows As Integer = 0 To dt.Rows.Count - 1
                    For column As Integer = 0 To dt.Columns.Count - 1
                        PdfPCell = New PdfPCell(New Phrase(New Chunk(dt.Rows(rows)(column).ToString(), font8)))
                        PdfTable.AddCell(PdfPCell)
                    Next
                Next

                PdfTable.SpacingBefore = 15.0F
                PdfTable.WidthPercentage = 100
                Dim arreglo() As Integer = {90, 230, 90, 60, 70, 50}


                PdfTable.SetWidths(arreglo)
                ' Give some space after the text or it may overlap the table

                ''Pie 

                doc.AddCreationDate()
                doc.Add(Logotipo)
                doc.Add(Titulo)
                doc.Add(Fecha)

                If Len(RTrim(LTrim(Me.TxtCotizacion.Text))) > 0 Then
                    Dim Filtro1 As New Paragraph("NoCotización: " + Me.TxtCotizacion.Text, font9)
                    doc.Add(Filtro1)
                End If

                If Len(RTrim(LTrim(Me.TxtCliente.Text))) > 0 Then
                    Dim Filtro2 As New Paragraph("Cliente: " + Me.TxtCliente.Text, font9)
                    doc.Add(Filtro2)
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

    Private Sub BtnRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRep.Click
        CrearReporte()
    End Sub

    Private Sub Rep_pdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rep_pdf.Click
        CrearReporte()
    End Sub

#End Region

    Sub Limpiarpantalla()
        Me.TxtCotizacion.Text = ""
        Me.TxtCliente.Text = ""
        Me.LblCliente.Text = ""
        Me.Fecha2.Value = Now
        Me.Fecha1.Value = Now
    End Sub
   
    Private Sub Limpiar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        Limpiarpantalla()
    End Sub
End Class