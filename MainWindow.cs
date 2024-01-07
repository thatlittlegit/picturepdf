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
		private string currentPath;

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

			void AddPaperSize(string resourceName, float width, float height)
			{
				string label = ExtraStrings.ResourceManager.GetString(resourceName) ?? resourceName;
				paperSizeChooser.DropDownItems.Add(new PaperSizeLabel(label, width, height));
			}

			AddPaperSize("paperSize.Ledger", 21.59f, 35.64f);
			AddPaperSize("paperSize.Tabloid", 21.59f, 35.64f);
			AddPaperSize("paperSize.Legal", 21.59f, 35.64f);
			AddPaperSize("paperSize.Letter", 21.59f, 27.94f);
			paperSizeChooser.DropDownItems.Add(new ToolStripSeparator());
			AddPaperSize("paperSize.A0", 84.10f, 118.9f);
			AddPaperSize("paperSize.A1", 118.9f, 59.40f);
			AddPaperSize("paperSize.A2", 42.00f, 59.40f);
			AddPaperSize("paperSize.A3", 42.00f, 29.70f);
			AddPaperSize("paperSize.A4", 21.00f, 29.70f);
			AddPaperSize("paperSize.A5", 21.00f, 14.80f);
			AddPaperSize("paperSize.A6", 10.50f, 14.80f);
			paperSizeChooser.DropDownItems.Add(new ToolStripSeparator());

			ToolStripButton custom = new ToolStripButton();
			custom.Enabled = false;
			custom.Text = ExtraStrings.ResourceManager.GetString("paperSize.Custom") ?? "paperSize.Custom";
			paperSizeChooser.DropDownItems.Add(custom);
		}

		private void addAdditionalImageButton_Click(object sender, EventArgs e)
		{
			var (stream, name) = OpenFileDialog();
			if (stream != null)
			{
				using (stream)
				{
					AddImage(stream, name);
				}
			}
		}

		private void openButton_Click(object sender, EventArgs e)
		{
			var (stream, name) = OpenFileDialog();
			if (stream == null)
			{
				return;
			}

			using (stream)
			{
				OpenPrimaryFile(stream, name);
			}
		}

		private (Stream, string) OpenFileDialog()
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				return (openFileDialog.OpenFile(), openFileDialog.FileName);
			}

			return (null, null);
		}

		private void OpenPrimaryFile(string name)
		{
			Stream stream;
			try
			{
				stream = new FileStream(name, FileMode.Open);
			}
			catch (Exception e)
			{
				Complain("Could not open '" + name + "': " + e.Message);
				return;
			}

			using (stream)
			{
				OpenPrimaryFile(stream, name);
			}
		}

		private void OpenPrimaryFile(Stream stream, string name)
		{
			ResetPage();
			if (!AddImage(stream, name))
			{
				return;
			}

			currentPath = name;
			FileLabel.Text = "";
			Text = currentPath;
		}

		private bool AddImage(Stream stream, string label)
		{
			try
			{
				ImageModel image = new ImageModel(stream, label);
				page.AddElement(image);
				return true;
			}
			catch (Exception e)
			{
				Complain("Could not add image: " + e.Message);
				return false;
			}
		}

		private void Complain(string message)
		{
			TaskDialog.ShowDialog(this, new TaskDialogPage
			{
				Caption = "PicturePDF",
				Text = message,
				Buttons = new TaskDialogButtonCollection
					{
						"OK"
					},
				Icon = TaskDialogIcon.Error,
			});
		}

		private void ResetPage()
		{
			if (page != null) page.PaperChanged -= page_PaperChanged;
			page = new PageModel(8.5f * 2.54f, 11f * 2.54f);
			page.PaperChanged += page_PaperChanged;
			page_PaperChanged(page, new EventArgs());
			pageView.Model = page;

			addAdditionalImageButton.Enabled = true;
			nextFileButton.Enabled = true;
			previousFileButton.Enabled = true;
			pdfGeneratingButton.Enabled = true;
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
			using Stream output = dialog.OpenFile();

			if (output == null)
			{
				return;
			}

			new PdfSharpExporter().Export(page, output);
		}

		private void zoomLabel_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			pageView.ZoomFactor = zoomMenuItems[e.ClickedItem.Text] / 100.0f;
		}

		private void pageView_ZoomFactorChanged(object sender, EventArgs e)
		{
			zoomLabel.Text = ((int)(pageView.ZoomFactor * 100)).ToString() + "%";
		}

		private void nextFileButton_Click(object sender, EventArgs e)
		{
			if (currentPath == null)
			{
				return;
			}

			bool done = false;
			foreach (string path in CurrentDirectoryImages())
			{
				if (done)
				{
					OpenPrimaryFile(path);
					return;
				}

				done = path == currentPath;
			}

			// Still here? Pick the first one.
			OpenPrimaryFile(CurrentDirectoryImages().First());
		}

		private void previousFileButton_Click(object sender, EventArgs e)
		{
			if (currentPath == null)
			{
				return;
			}

			string last = null;
			foreach (string path in CurrentDirectoryImages())
			{
				if (path == currentPath)
				{
					OpenPrimaryFile(last ?? CurrentDirectoryImages().Last());
					return;
				}

				last = path;
			}

			OpenPrimaryFile(last);
		}

		private IEnumerable<string> CurrentDirectoryImages()
		{
			if (currentPath == null)
			{
				yield break;
			}

			foreach (var name in Directory.EnumerateFiles(Path.GetDirectoryName(currentPath)))
			{
				string ext = Path.GetExtension(name);
				if (ext == ".png" || ext == ".jpeg" || ext == ".jpg" || ext == ".bmp")
				{
					yield return name;
				}
			}
		}

		private void pageView_SelectionChanged(object sender, ImageModel e)
		{
			FileLabel.Text = e?.Label ?? "";
		}

		private void paperSizeChooser_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			var selected = (PaperSizeLabel)e.ClickedItem;

			page.Resize(selected.PaperWidth, selected.PaperHeight);
		}

		private void page_PaperChanged(object sender, EventArgs e)
		{
			paperSizeChooser.Text = page.Width.ToString("N2") + "cm × " + page.Height.ToString("N2") + "cm";
		}
	}

	internal class PaperSizeLabel : ToolStripLabel
	{
		public readonly float PaperWidth;
		public readonly float PaperHeight;

		public PaperSizeLabel(string label, float width, float height) : base(label)
		{
			PaperWidth = width;
			PaperHeight = height;
		}
	}
}
