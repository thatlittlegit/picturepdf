using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PicturePDF
{
	public partial class MainWindow : Form
	{
		private PageModel page;
		private ImageModel image;

		public MainWindow()
		{
			InitializeComponent();
		}

		#region Event implementations

		private void UpdateAll(object sender, EventArgs e) => UpdateAll();

		private void UpdateAll(object sender, LayoutEventArgs e) => UpdateAll();

		private void ScaleChanged(object sender, EventArgs e) => ScaleChanged();

		private void UpdateXOffset(object sender, EventArgs e) => UpdateXOffset();

		private void UpdateYOffset(object sender, EventArgs e) => UpdateYOffset();

		#endregion Event implementations

		internal void UpdateAll()
		{
			UpdatePage();
			UpdateXOffset();
			UpdateYOffset();
		}

		private void UpdatePage() { }/*
			Page.Size = Image == null
				? new Size(0, 0)
				: new Size(
					(int)((Image.HorizontalResolution * 5.47f) * (float)ScaleControl.Value),
					(int)((Image.VerticalResolution * 8.5f) * (float)ScaleControl.Value)
					);*/

		private void OpenImageDialog(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				FileLabel.Text = openFileDialog.FileName;
				LoadImage(openFileDialog.OpenFile());
			}
		}

		public void LoadImage(Stream stream)
		{
			page = new PageModel(8.5f * 2.54f, 11f * 2.54f);
			pageView1.Model = page;

			image = new ImageModel(stream);
			page.AddElement(image);

			xBar.Minimum = (int) -image.Width;
			xBar.Maximum = (int) +image.Width;
			yBar.Minimum = (int) -image.Height;
			yBar.Maximum = (int) +image.Height;
		}

		private void MakePdfButtonPressed(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog
			{
				AddExtension = true,
				DefaultExt = "pdf",
				Filter = "Portable Document Format|*.pdf",
				Title = "Save PDF to...",
			};
			dialog.ShowDialog(this);
			Stream output = dialog.OpenFile();

			if (output == null)
			{
				return;
			}

			Stream stream = new MemoryStream();
			image.Content.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
			Program.MakePdf(stream, output, (xBar.Value, yBar.Value));
		}

		private void ScaleChanged()
		{
			pageView1.ZoomFactor = (float) ScaleControl.Value;
		}

		private void UpdateXOffset() => image?.Move(xBar.Value, -1);
		private void UpdateYOffset() => image?.Move(-1, yBar.Value);
	}
}
