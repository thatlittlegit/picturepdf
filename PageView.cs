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
using static System.Net.Mime.MediaTypeNames;

namespace PicturePDF
{
	internal class PageView : ScrollableControl
	{
		private float zoomFactorStore = 1.0f;
		private PageModel pageModelStore = null;

		private ImageModel grabbing = null;
		private float grabXOffset = 0.0f;
		private float grabYOffset = 0.0f;

		private bool holdingControl = false;

		private static readonly float PIXELS_PER_CENTIMETRE = 96.0f / 2.54f;

		public event EventHandler ZoomFactorChanged;
		public event EventHandler<ImageModel> SelectionChanged;

		public float ZoomFactor
		{
			get => zoomFactorStore;
			set
			{
				zoomFactorStore = value;
				UpdateScrollInfo();
				Invalidate();
				ZoomFactorChanged?.Invoke(this, new EventArgs());
			}
		}

		public PageModel Model
		{
			get => pageModelStore;
			set
			{
				if (pageModelStore != null)
				{
					pageModelStore.ImageChanged -= model_ImageChanged;
					pageModelStore.PaperChanged -= model_PaperChanged;
				}

				pageModelStore = value;

				if (pageModelStore != null)
				{
					pageModelStore.ImageChanged += model_ImageChanged;
					pageModelStore.PaperChanged += model_PaperChanged;
				}

				UpdateScrollInfo();
				Invalidate();
			}
		}

		private void model_ImageChanged(object sender, ImageModel args)
		{
			Invalidate();
		}

		private void model_PaperChanged(object sender, EventArgs args)
		{
			UpdateScrollInfo();
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

			width += 2;
			height += 2;

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

			if (grabbing != null)
			{
				Pen dashed = new Pen(new SolidBrush(Color.Gray), 4);
				dashed.DashStyle = DashStyle.Dot;

				RectangleF border = new RectangleF
				{
					X = grabbing.X * scale,
					Y = grabbing.Y * scale,
					Width = grabbing.Width * scale,
					Height = grabbing.Height * scale,
				};
				e.Graphics.DrawRectangle(dashed, Rectangle.Round(border));
			}
			e.Graphics.DrawRectangle(outline, Rectangle.Round(area));
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			var (cmX, cmY) = XYtoCentimetre(e.X, e.Y);
			grabbing?.Move(cmX - grabXOffset, cmY - grabYOffset);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			var (cmX, cmY) = XYtoCentimetre(e.X, e.Y);

			grabbing = Model?.ElementAtPosition(cmX, cmY);
			grabXOffset = grabbing != null ? cmX - grabbing.X : 0.0f;
			grabYOffset = grabbing != null ? cmY - grabbing.Y : 0.0f;

			SelectionChanged(this, grabbing);
			Invalidate();
		}

		private Tuple<float, float> XYtoCentimetre(float x, float y)
		{
			float nx = (x + HorizontalScroll.Value) / (PIXELS_PER_CENTIMETRE * ZoomFactor);
			float ny = (y + VerticalScroll.Value) / (PIXELS_PER_CENTIMETRE * ZoomFactor);

			return new Tuple<float, float>(nx, ny);
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			grabbing = null;
			Invalidate();
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			holdingControl = e.Control;
		}

		protected override void OnKeyUp(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			holdingControl = e.Control;
		}

		protected override void OnMouseWheel(MouseEventArgs e)
		{
			if (holdingControl)
			{
				float adjusted = ZoomFactor + (ZoomFactor * 0.2f * e.Delta / 120f);

				ZoomFactor = Math.Clamp(adjusted, 0.1f, 8.0f);
				return;
			}

			base.OnMouseWheel(e);
		}
	}
}
