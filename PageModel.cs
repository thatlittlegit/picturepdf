using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicturePDF
{
	internal class PageModel
	{
		public float Width { get; private set; }
		public float Height { get; private set; }

		private readonly ISet<ImageModel> elements = new HashSet<ImageModel>();

		public event EventHandler<ImageModel> ImageChanged;

		public PageModel(float width, float height)
		{
			Width = width;
			Height = height;
		}

		public void AddElement(ImageModel image)
		{
			image.Changed += (sender, args) => ImageChanged?.Invoke(this, image);
			elements.Add(image);
			ImageChanged?.Invoke(this, image);
		}

		public IEnumerable<ImageModel> Elements()
		{
			foreach (var element in elements)
			{
				yield return element;
			}
		}

		public ImageModel ElementAtPosition(float x, float y)
		{
			foreach (var element in elements.Reverse())
			{
				bool beyondLeftEdge = element.X <= x;
				bool afterTopEdge = element.Y <= y;
				bool withinRightEdge = element.X + element.Width >= x;
				bool withinBottomEdge = element.Y + element.Height >= y;

				if (beyondLeftEdge && afterTopEdge && withinRightEdge && withinBottomEdge)
				{
					return element;
				}
			}

			return null;
		}
	}

	internal class ImageModel
	{
		public float X { get; internal set; }
		public float Y { get; internal set; }
		public string Label { get; }

		public float Width => 2.54f * Content.Width / Content.HorizontalResolution;
		public float Height => 2.54f * Content.Height / Content.VerticalResolution;

		internal Image Content { get; set; }

		public event EventHandler<EventArgs> Changed;

		public ImageModel(Stream input, string label)
		{
			Content = Image.FromStream(input);
			Label = label;
		}

		public void Move(float x, float y)
		{
			X = x == -1 ? X : x;
			Y = y == -1 ? Y : y;
			Changed?.Invoke(this, null);
		}

		public Stream StreamBitmap()
		{
			Stream stream = new MemoryStream();
			Content.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
			return stream;
		}
	}
}
