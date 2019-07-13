using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VehicleDealership.Classes
{
	class Class_misc
	{
		/// <summary>
		/// resize image according to box size
		/// </summary>
		/// <param name="img"></param>
		/// <param name="box_size"></param>
		/// <param name="resize_only_if_bigger">if true, image will only be resized if bigger. if false, smaller image will be made bigger</param>
		/// <returns></returns>
		public static Image Resized_image(Image img, float box_size, bool resize_only_if_bigger = true)
		{
			if (resize_only_if_bigger && img.Height < box_size && img.Width < box_size) return img;

			float scaleHeight = (float)box_size / (float)img.Height;
			float scaleWidth = (float)box_size / (float)img.Width;

			float scale = Math.Min(scaleHeight, scaleWidth);

			return new Bitmap(img, (int)(img.Width * scale), (int)(img.Height * scale));
		}

	}
}
