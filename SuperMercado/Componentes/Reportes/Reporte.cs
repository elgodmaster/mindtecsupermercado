using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using System.Drawing;


namespace Componentes
{
    public class Reporte
    {
        Document document;
        PdfWriter writer;
        PdfContentByte cb;
        float mmPixelEquiX, mmPixelEquiY;
        public Reporte(string ruta)
        {

            document = new Document(PageSize.A4);

            try
            {
                writer = PdfWriter.GetInstance(document, new FileStream(ruta, FileMode.Create));
            }
            catch(Exception e)
            {
                System.IO.Directory.CreateDirectory("Reportes");
                writer = PdfWriter.GetInstance(document, new FileStream(ruta, FileMode.Create));
            }
            document.Open();
            cb = writer.DirectContent;
            this.mmPixelEquiX = document.PageSize.Width / 210.0f;
            this.mmPixelEquiY = document.PageSize.Height / 297.0f;


        }
        
        private float mmToPixelX(float x)
        {
            return x * this.mmPixelEquiX;
        }
        
        private float mmToPixelY(float y)
        {
            return document.PageSize.Height - (y * this.mmPixelEquiY);
        }

        public void textoDer(string str, float x, float y)
        { 
            try{
                x = mmToPixelX(x);
                y = mmToPixelY(y);
           
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED); cb.BeginText();
                cb.SetFontAndSize(bf, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, str, x, y, 0);
                cb.EndText();
            }
            catch (Exception de){
                Console.Error.WriteLine(de.Message);
            }     
        }

        public void textoIzq(string str, float x, float y)
        {
            try
            {
                x = mmToPixelX(x);
                y = mmToPixelY(y);

                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED); cb.BeginText();
                cb.SetFontAndSize(bf, 12);
                cb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, str, x, y, 0);
                cb.EndText();
            }
            catch (Exception de)
            {
                Console.Error.WriteLine(de.Message);
            }
        }

        public void tabla(List<List<object>> datos, float[] anchos, float x, float y)
        {
            float w = 0.0f;
            for (int i = 0; i < anchos.Length ; i++)
            {
                anchos[i] = mmToPixelX(anchos[i]);
                w += anchos[i];
            }
            x = mmToPixelX(x);
            y = mmToPixelY(y);

            PdfPTable tabla = new PdfPTable(anchos);
            PdfPCell celda;
            tabla.TotalWidth = w;
            foreach (List<object> row in datos)
                foreach (object obj in row)
                {
                    celda = new PdfPCell();
                    if (obj is double || obj is float)
                    {

                        celda = new PdfPCell(new Phrase(((double)obj).ToString("N")));
                        celda.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                       

                    }
                    else if (obj is string)
                    {
                        celda = new PdfPCell(new Phrase(obj.ToString()));
                        celda.HorizontalAlignment = PdfPCell.ALIGN_LEFT;

                    }
                    else if (obj is DateTime)
                    {
                        celda = new PdfPCell(new Phrase(((DateTime)obj).ToShortDateString()));
                        celda.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

                    }
                    else if (obj is int)
                    {
                        celda = new PdfPCell(new Phrase(((int)obj).ToString()));
                        celda.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;

                    }
                    celda.Border = PdfPCell.NO_BORDER;
                    tabla.AddCell(celda);

                }
            tabla.WriteSelectedRows(0, tabla.Rows.Count, x, y, cb);
        }
        
        public void cerrar()
        {
            if (document.IsOpen())
                document.Close();
        }

    }
}
