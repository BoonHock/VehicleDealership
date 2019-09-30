using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDealership.Classes
{
	class Class_image
	{
		/// <summary>
		/// resize image according to box size
		/// </summary>
		/// <param name="img"></param>
		/// <param name="box_size"></param>
		/// <param name="resize_only_if_bigger">if true, image will only be resized if bigger. if false, smaller image will be made bigger</param>
		/// <returns></returns>
		public static Image Resize_image(Image img, float box_size, bool resize_only_if_bigger = true)
		{
			img = Get_image_correct_exif_rotation(img);

			if (resize_only_if_bigger && img.Height < box_size && img.Width < box_size) return img;

			float scaleHeight = (float)box_size / (float)img.Height;
			float scaleWidth = (float)box_size / (float)img.Width;

			float scale = Math.Min(scaleHeight, scaleWidth);

			return new Bitmap(img, (int)(img.Width * scale), (int)(img.Height * scale));
		}
		public static byte[] Image_to_byte_array(Image img)
		{
			img = Get_image_correct_exif_rotation(img);

			byte[] byte_image = null;
			using (MemoryStream ms = new MemoryStream())
			{
				img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
				byte_image = ms.ToArray();
			}
			return byte_image;
		}
		public static Image Byte_array_to_image(byte[] byte_image)
		{
			using (var ms = new MemoryStream(byte_image))
			{
				return Image.FromStream(ms);
			}
		}
		public static void Export_byte_array_to_jpeg_image(string path, byte[] byte_image)
		{
			File.WriteAllBytes(path + ".jpeg", byte_image);
		}

		public static Image Get_image_correct_exif_rotation(Image img)
		{
			int orientationId = 0x0112;

			if (img.PropertyIdList.Contains(orientationId))
			{
				int orientation = img.GetPropertyItem(orientationId).Value[0];
				RotateFlipType rotateFlip;

				switch (orientation)
				{
					case 1: rotateFlip = RotateFlipType.RotateNoneFlipNone; break;
					case 2: rotateFlip = RotateFlipType.RotateNoneFlipX; break;
					case 3: rotateFlip = RotateFlipType.Rotate180FlipNone; break;
					case 4: rotateFlip = RotateFlipType.Rotate180FlipX; break;
					case 5: rotateFlip = RotateFlipType.Rotate90FlipX; break;
					case 6: rotateFlip = RotateFlipType.Rotate90FlipNone; break;
					case 7: rotateFlip = RotateFlipType.Rotate270FlipX; break;
					case 8: rotateFlip = RotateFlipType.Rotate270FlipNone; break;
					default: rotateFlip = RotateFlipType.RotateNoneFlipNone; break;
				}
				if (rotateFlip != RotateFlipType.RotateNoneFlipNone)
				{
					img.RotateFlip(rotateFlip);
					img.RemovePropertyItem(orientationId);
				}
			}
			return img;
		}
	}
}
