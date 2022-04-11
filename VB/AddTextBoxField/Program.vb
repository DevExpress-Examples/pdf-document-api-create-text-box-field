Imports DevExpress.Pdf
Imports System.Drawing

Namespace AddTextBoxField

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using processor As PdfDocumentProcessor = New PdfDocumentProcessor()
                ' Create an empty document. 
                processor.CreateEmptyDocument("..\..\Result.pdf")
                ' Create and draw a text box field.
                Using graphics As PdfGraphics = processor.CreateGraphics()
                    DrawTextBoxField(graphics)
                    ' Render a page with graphics.
                    processor.RenderNewPage(PdfPaperSize.Letter, graphics)
                End Using
            End Using
        End Sub

        Private Shared Sub DrawTextBoxField(ByVal graphics As PdfGraphics)
            ' Create a text box field and specify its location.
            Dim textBox As PdfGraphicsAcroFormTextBoxField = New PdfGraphicsAcroFormTextBoxField("text box", New RectangleF(0, 10, 200, 30))
            ' Specify text box properties.
            textBox.Text = "Text Box"
            textBox.TextAlignment = PdfAcroFormStringAlignment.Near
            textBox.Appearance.FontSize = 12
            textBox.Appearance.BackgroundColor = Color.AliceBlue
            ' Add the field as graphics content.
            graphics.AddFormField(textBox)
        End Sub
    End Class
End Namespace
