using iText.IO.Font;
using iText.Kernel.Font;
using iText.Layout.Element;
using TextAlignment = iText.Layout.Properties.TextAlignment;
using Border = iText.Layout.Borders.Border;

namespace SAESoft.Utilitarios
{
    public static class ReportUtils
    {
        private static Cell CrearCelda(string text, int size, TextAlignment alinear, Border borde, int filas, int cols, Boolean bold, PdfFont font = null)
        {
            Cell cell;
            Paragraph paragraph = new Paragraph(text)
                                  .SetFontSize(size);

            if (font != null)
            {
                paragraph.SetFont(font);
            }

            if (bold)
            {
                paragraph.SetBold();
            }

            cell = new Cell(filas, cols).Add(paragraph)
                   .SetTextAlignment(alinear)
                   .SetBorder(borde);
            return cell;
        }

        public static Cell celdaCoreana(string text, int size, TextAlignment alinear, Border borde, int filas, int cols, Boolean bold = false)
        {
            PdfFont coreano = PdfFontFactory.CreateFont(Properties.Resources.HANBatang, PdfEncodings.IDENTITY_H);
            return CrearCelda(text, size, alinear, borde, filas, cols, bold, coreano);
        }

        public static Cell celda(string text, int size, TextAlignment alinear, Border borde, int filas, int cols, Boolean bold = false)
        {
            return CrearCelda(text, size, alinear, borde, filas, cols, bold);
        }


    }
}
