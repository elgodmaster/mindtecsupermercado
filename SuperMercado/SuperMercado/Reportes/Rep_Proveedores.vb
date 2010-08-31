Imports MindTec.Componentes
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Rep_Proveedores

#Region " Variables de trabajo "
    Dim Caja As String = ""
    Dim Parametros As String = ""
    Dim lConsulta As New ClsConsultas
    Dim ObjRet As CRetorno
    Dim ruta As String
#End Region

    Private Sub Rep_Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpiarPantalla()
    End Sub


#Region " Rutinas "
    Sub CatProveedores()
        Caja = "Consulta106" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            txt_Prov.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.txt_Prov_KeyDown(DBNull.Value, e)

        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub

    Sub CatEstados()
        Caja = "Consulta107" : Parametros = ""
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            TxtEstado.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.TxtEstado_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
        End If
    End Sub

    Sub CatCiudades()
        Caja = "Consulta108" : Parametros = "V1=" & Me.TxtEstado.Text
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "0", Parametros)
        If ObjRet.bOk Then
            Dim nuevo As Grid = New Grid(ObjRet.DS)
            TxtCiudad.Text = nuevo.resultado
            Dim e As KeyEventArgs
            e = New KeyEventArgs(Keys.Enter)
            Me.TxtCiudad_KeyDown(DBNull.Value, e)
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))

        End If
    End Sub

#End Region

#Region " Proveedor "
    Private Sub txt_Prov_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Prov.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatProveedores()
            Case Keys.Enter
                Caja = "Consulta106" : Parametros = "V1=" & Me.txt_Prov.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                If ObjRet.bOk Then
                    LblNombre.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                End If
        End Select
    End Sub
#End Region

#Region " Estado "
    Private Sub TxtEstado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEstado.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatEstados()
            Case Keys.Enter
                Caja = "Consulta107" : Parametros = "V1=" & Me.TxtEstado.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                If ObjRet.bOk Then
                    Lblest.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                End If
        End Select
    End Sub
#End Region

#Region " Ciudad "
    Private Sub TxtCiudad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCiudad.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                CatCiudades()
            Case Keys.Enter
                Caja = "Consulta108" : Parametros = "V1=" & Me.TxtEstado.Text & "|V2=" & Me.TxtCiudad.Text
                If lConsulta Is Nothing Then lConsulta = New ClsConsultas
                ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
                If ObjRet.bOk Then
                    LblCiudad.Text = lConsulta.ObtenerValor("V1", ObjRet.sResultado, "|")
                Else
                    MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
                End If
        End Select
    End Sub

#End Region

#Region " Limpiar "
    Sub LimpiarPantalla()
        Me.txt_Prov.Text = ""
        Me.TxtEstado.Text = ""
        Me.TxtCiudad.Text = ""
        Me.LblCiudad.Text = ""
        Me.Lblest.Text = ""
        Me.LblCiudad.Text = ""
    End Sub

    Private Sub Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpiar.Click
        LimpiarPantalla()
    End Sub

#End Region

#Region " Reporte "
    Sub CrearReporte()
        Caja = "Reporte003" : Parametros = "V1=" & Me.txt_Prov.Text & "|V2=" & Me.TxtEstado.Text & "|V3=" & Me.TxtCiudad.Text
        If lConsulta Is Nothing Then lConsulta = New ClsConsultas
        ObjRet = lConsulta.LlamarCaja(Caja, "1", Parametros)
        If ObjRet.bOk = True Then
            RProveedores()
            Limpiar.PerformClick()
        Else
            MessageBox.Show(lConsulta.ObtenerValor("2M", ObjRet.sResultado, "|", False))
            Limpiar.PerformClick()
        End If
    End Sub

    Sub RProveedores()
        Dim doc As New Document(iTextSharp.text.PageSize.LETTER, 30, 30, 20, 20)
        Try
            Dim a As New Random

            If Not System.IO.Directory.Exists("C:\\Proveedores\\") Then
                System.IO.Directory.CreateDirectory("C:\\Proveedores\\")
            End If

            ruta = "C:\\Proveedores\\Proveedor-" + Now.ToString("dd-MM-yyyy") + "_" + a.Next().ToString() + ".pdf"


            Dim pdfFilePath As String = ruta

            'Create Document class object and set its size to letter and give space left, right, Top, Bottom Margin
            Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(pdfFilePath, FileMode.Create))

            Dim texto As New iTextSharp.text.Header("Encabezado", True)
            doc.Open()
            ''Propiedades del documento

            'Open Document to write
            Dim font8 As Font = FontFactory.GetFont("ARIAL", 7)
            Dim font9 As Font = FontFactory.GetFont("ARIAL", 7, False, 8, 1, iTextSharp.text.BaseColor.BLACK)
            Dim FontTitulo As Font = FontFactory.GetFont("Verdana", 7, False, 12, 0, iTextSharp.text.BaseColor.BLACK)

            ''Imagen Logotipo de empresa
            Dim Logotipo As New iTextSharp.text.ImgCCITT(iTextSharp.text.ImgCCITT.GetInstance("F:\Mindtec\logoMindtec.png"))
            Logotipo.Alignment = iTextSharp.text.ImgCCITT.ALIGN_RIGHT
            Logotipo.ScalePercent(40)
            'jpg.Alignment = iTextSharp.text.Image.MIDDLE_ALIGN;


            Dim Titulo As New Paragraph("Reporte de Proveedores", FontTitulo)
            Dim Fecha As New Paragraph("Fecha:" + Now.ToShortDateString.ToString, font8)
            Titulo.Alignment = Element.ALIGN_CENTER

            Dim dt As DataTable = ObjRet.DS.Tables(0)

            If dt IsNot Nothing Then
                'Craete instance of the pdf table and set the number of column in that table
                Dim PdfTable As New PdfPTable(dt.Columns.Count)
                Dim PdfPCell As PdfPCell = Nothing



                'Add Header of the pdf table
                PdfPCell = New PdfPCell(New Phrase(New Chunk("Codigo", font8)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Razon Social", font8)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("RFC", font8)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Dirección", font8)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)


                PdfPCell = New PdfPCell(New Phrase(New Chunk("Colonia", font8)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("CP", font8)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Estado", font8)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Ciudad", font8)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Telefono", font8)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)


                PdfPCell = New PdfPCell(New Phrase(New Chunk("Ext", font8)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Celular", font8)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Fax", font8)))
                PdfPCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Email", font8)))
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
                Dim arreglo() As Integer = {90, 150, 90, 140, 70, 50, 70, 70, 80, 30, 70, 50, 120}


                PdfTable.SetWidths(arreglo)
                ' Give some space after the text or it may overlap the table

                ''Pie 

                doc.AddAuthor("Mindtec")
                doc.AddCreationDate()
                doc.Add(Logotipo)
                doc.Add(Titulo)
                doc.Add(Fecha)

                If Len(RTrim(LTrim(Me.TxtEstado.Text))) > 0 Then
                    Dim Filtro1 As New Paragraph("Estado: " + Me.Lblest.Text, font9)
                    doc.Add(Filtro1)
                End If

                If Len(RTrim(LTrim(Me.TxtCiudad.Text))) > 0 Then
                    Dim Filtro2 As New Paragraph("Ciudad: " + Me.LblCiudad.Text, font9)
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
#End Region


    Private Sub BtnRepo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRepo.Click
        CrearReporte()

    End Sub


    Private Sub Rep_pdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rep_pdf.Click
        CrearReporte()
    End Sub
End Class