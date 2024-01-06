using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace PicturePDF
{
	internal class PdfSharpExporter
	{
		public void Export(PageModel page, Stream output)
		{
			using PdfDocument document = new PdfDocument();
			document.Info.Creator = "PicturePDF";

			PdfPage pdfPage = document.AddPage();
			pdfPage.Width = new XUnit() { Centimeter = page.Width };
			pdfPage.Height = new XUnit() { Centimeter = page.Height };
			XGraphics gfx = XGraphics.FromPdfPage(pdfPage);

			foreach (ImageModel element in page.Elements())
			{
				var x = XUnit.FromCentimeter(element.X).Point;
				var y = XUnit.FromCentimeter(element.Y).Point;
				var width = XUnit.FromCentimeter(element.Width).Point;
				var height = XUnit.FromCentimeter(element.Height).Point;
				var rect = new XRect(x, y, width, height);

				gfx.DrawImage(XImage.FromStream(element.StreamBitmap()), rect);
			}

			document.Save(output);
		}
	}
}
