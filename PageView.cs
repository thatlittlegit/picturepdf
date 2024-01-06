using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturePDF
{
	internal class PageView : ScrollableControl
	{
		private float zoomFactorStore = 1.0f;
		private PageModel pageModelStore = null;

		private ImageModel grabbing = null;
		private float grabXOffset = 0.0f;
		private float grabYOffset = 0.0f;

		private static readonly float PIXELS_PER_CENTIMETRE = 96.0f / 2.54f;

		public float ZoomFactor
		{
			get => zoomFactorStore;
			set
			{
				zoomFactorStore = value;
				UpdateScrollInfo();
				Invalidate();
			}
		}

		public PageModel Model
		{
			get => pageModelStore;
			set
			{
				if (pageModelStore != null) pageModelStore.ImageChanged -= model_ImageChanged;
				pageModelStore = value;
				if (pageModelStore != null) pageModelStore.ImageChanged += model_ImageChanged;
				UpdateScrollInfo();
				Invalidate();
			}
		}

		private void model_ImageChanged(object sender, ImageModel args)
		{
			Invalidate();
		}

		protected override void OnCreateControl()
		{
			base.OnCreateControl();

			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

			AutoScroll = true;
			UpdateScrollInfo();
		}

		private void UpdateScrollInfo()
		{
			if (Model == null)
			{
				AutoScrollMinSize = new Size(0, 0);
				return;
			}

			float width = Model.Width * PIXELS_PER_CENTIMETRE * ZoomFactor;
			float height = Model.Height * PIXELS_PER_CENTIMETRE * ZoomFactor;

			width += 1;
			height += 1;

			AutoScrollMinSize = new Size((int)width, (int)height);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			e.Graphics.Clear(SystemColors.AppWorkspace);
			if (Model == null) return;

			Pen outline = new Pen(new SolidBrush(Color.Black), 1.0f);
			Brush pageColour = new SolidBrush(Color.White);

			e.Graphics.TranslateTransform(-HorizontalScroll.Value, -VerticalScroll.Value);
			RectangleF area = new RectangleF
			{
				X = 0,
				Y = 0,
				Width = Model.Width,
				Height = Model.Height,
			};

			area.Width *= PIXELS_PER_CENTIMETRE * ZoomFactor;
			area.Height *= PIXELS_PER_CENTIMETRE * ZoomFactor;

			e.Graphics.FillRectangle(pageColour, area);

			float scale = PIXELS_PER_CENTIMETRE * zoomFactorStore;
			GraphicsState state = e.Graphics.Save();
			e.Graphics.IntersectClip(area);
			e.Graphics.ScaleTransform(scale, scale);
			foreach (ImageModel image in Model.Elements())
			{
				e.Graphics.DrawImage(image.Content, image.X, image.Y, image.Width, image.Height);
			}
			e.Graphics.Restore(state);

			e.Graphics.DrawRectangle(outline, Rectangle.Round(area));
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			float cmX = e.X / PIXELS_PER_CENTIMETRE;
			float cmY = e.Y / PIXELS_PER_CENTIMETRE;

			grabbing?.Move(cmX - grabXOffset, cmY - grabYOffset);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			float cmX = e.X / PIXELS_PER_CENTIMETRE;
			float cmY = e.Y / PIXELS_PER_CENTIMETRE;

			grabbing = Model.ElementAtPosition(cmX, cmY);
			grabXOffset = cmX - grabbing.X;
			grabYOffset = cmY - grabbing.Y;
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			grabbing = null;
		}
	}
}
