using DevExpress.Pdf;
using System.Drawing;

namespace AddTextBoxField {
    class Program {
        static void Main(string[] args) {
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {

                // Create an empty document. 
                processor.CreateEmptyDocument("..\\..\\Result.pdf");

                // Create and draw a text box field.
                using (PdfGraphics graphics = processor.CreateGraphics()) {
                    DrawTextBoxField(graphics);

                    // Render a page with graphics.
                    processor.RenderNewPage(PdfPaperSize.Letter, graphics);
                }
            }
        }

        static void DrawTextBoxField(PdfGraphics graphics) {

            // Create a text box field and specify its location.
            PdfGraphicsAcroFormTextBoxField textBox = new PdfGraphicsAcroFormTextBoxField("text box", new RectangleF(0, 10, 200, 30));

            // Specify text box properties.
            textBox.Text = "Text Box";           
            textBox.TextAlignment = PdfAcroFormStringAlignment.Near;
            textBox.Appearance.FontSize = 12;
            textBox.Appearance.BackgroundColor = Color.AliceBlue;          
          
            // Add the field as graphics content.
            graphics.AddFormField(textBox);
        }
    }
}
