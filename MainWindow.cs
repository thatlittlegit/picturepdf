using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PicturePDF
{
	public partial class MainWindow : Form
	{
		private PageModel page;
		private ImageModel image;

		private IDictionary<string, int> zoomMenuItems
			= new Dictionary<string, int>();

		public MainWindow()
		{
			InitializeComponent();

			IList<ToolStripLabel> labels = new List<ToolStripLabel>();
			foreach (var increment in new int[] { 25, 50, 75, 100, 125, 150, 175, 200, 400, 800 })
			{
				string label = increment + "%";
				zoomMenuItems.Add(label, increment);
				labels.Add(new ToolStripLabel(label));
			}

			zoomLabel.DropDownItems.AddRange(labels.ToArray());
		}

		#region Event implementations

		private void UpdateAll(object sender, EventArgs e) => UpdateAll();

		private void UpdateAll(object sender, LayoutEventArgs e) => UpdateAll();

		#endregion Event implementations

		internal void UpdateAll()
		{
			UpdatePage();
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
			new PdfSharpExporter().Export(page, output);
		}

		private void zoomLabel_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			pageView1.ZoomFactor = zoomMenuItems[e.ClickedItem.Text] / 100.0f;
		}

		private void pageView1_ZoomFactorChanged(object sender, EventArgs e)
		{
			zoomLabel.Text = ((int)(pageView1.ZoomFactor * 100)).ToString() + "%";
		}
	}
}
