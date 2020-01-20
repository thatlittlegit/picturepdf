using System;
using System.Drawing;
using System.Windows.Forms;

namespace PicturePDF
{
	public partial class MainWindow : Form
	{
		public Image Image
		{
			get => PictureBox.Image;
			set => PictureBox.Image = value;
		}

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

		private void UpdatePage() =>
			Page.Size = Image == null
				? new Size(0, 0)
				: new Size(
					(int)((Image.HorizontalResolution * 5.47f) * (float)ScaleControl.Value),
					(int)((Image.VerticalResolution * 8.5f) * (float)ScaleControl.Value)
					);

		private void OpenImageDialog(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				FileLabel.Text = openFileDialog.FileName;
				LoadImage(openFileDialog.OpenFile());
			}
		}

		public void LoadImage(System.IO.Stream stream)
		{
			PictureBox.Visible = true;
			Image = Image.FromStream(stream);
			ScaleChanged();

			xBar.Minimum = -Image.Width;
			xBar.Maximum = +Image.Width;
			yBar.Minimum = -Image.Height;
			yBar.Maximum = +Image.Height;
		}

		private void MakePdfButtonPressed(object sender, EventArgs e)
		{
			if (Image == null) return;
			System.IO.Stream stream = new System.IO.MemoryStream();
			Image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
			Program.MakePdf(stream, (xBar.Value / Image.HorizontalResolution, yBar.Value / Image.VerticalResolution));
		}

		private void ScaleChanged()
		{
			if (Image == null) return;
			PictureBox.Height = (int)(Image.Height * ScaleControl.Value);
			PictureBox.Width = (int)(Image.Width * ScaleControl.Value);
			UpdateAll();
		}

		private void UpdateXOffset() =>
			PictureBox.Location = new Point((int)(xBar.Value * ScaleControl.Value), PictureBox.Location.Y);

		private void UpdateYOffset() =>
			PictureBox.Location = new Point(PictureBox.Location.X, (int)(yBar.Value * ScaleControl.Value));
	}
}
