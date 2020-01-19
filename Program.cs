using System;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace PicturePDF
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}

		public static void MakePdf(System.IO.Stream imageStream, (float, float) point)
		{
			using PdfDocument document = new PdfDocument();

			PdfPage page = document.AddPage();
			page.Height = new XUnit() { Centimeter = 21.75 };
			page.Width = new XUnit() { Centimeter = 13.9 };
			XGraphics gfx = XGraphics.FromPdfPage(page);

			gfx.DrawImage(XImage.FromStream(imageStream), new XPoint(XUnit.FromInch(point.Item1), XUnit.FromInch(point.Item2)));
			const string filename = "PageSizes_tempfile.pdf";
			document.Save(filename);
		}
	}
}
