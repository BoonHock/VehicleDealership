using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

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
		public static byte[] Image_to_byte_array(Image img)
		{
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

		public static void Display_dataset_error(string class_name, string function_name, string error_msg)
		{
			MessageBox.Show("An error has occured. \n" + class_name + "." + function_name +
				"\n Error:" + error_msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		public static void Go_url (string str_url)
		{
			try
			{
				Process.Start(str_url);
			}
			catch (Exception)
			{
				MessageBox.Show("URL invalid.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
