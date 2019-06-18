using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using VehicleDealership.Datasets;

namespace VehicleDealership.View
{
	public partial class Form_log_in : Form
	{
		public Form_log_in()
		{
			InitializeComponent();
		}
		public string Username { get; private set; } = "";
		private void Btn_log_in_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			if (Log_in())
			{
				// logged in
				Username = txt_username.Text.Trim();
				Cursor.Current = Cursors.Default;
				this.DialogResult = DialogResult.OK;
				this.Close();
				return;
			}
			Cursor.Current = Cursors.Default;
			lbl_invalid_login.Visible = true;
		}
		private bool Log_in()
		{
			string str_username = txt_username.Text.Trim();
			string str_password = txt_password.Text;

			User_ds.sp_user_loginDataTable dttable_user = User_ds.Select_password(str_username);

			if (dttable_user.Rows.Count == 0 || !((bool)dttable_user.Rows[0]["is_active"])) return false;

			return VerifyHash(str_password, dttable_user.Rows[0]["password"].ToString());
		}
		/// <summary>
		/// https://chandradev819.wordpress.com/2011/04/11/how-to-encrypt-and-decrypt-password-in-asp-net-using-c/
		/// </summary>
		/// <param name="plainText"></param>
		/// <param name="saltBytes"></param>
		/// <returns></returns>
		public static string ComputeHash(string plainText, byte[] saltBytes)
		{
			// If salt is not specified, generate it.
			if (saltBytes == null)
			{
				// Define min and max salt sizes.
				int minSaltSize = 4;
				int maxSaltSize = 8;

				// Generate a random number for the size of the salt.
				Random random = new Random();
				int saltSize = random.Next(minSaltSize, maxSaltSize);

				// Allocate a byte array, which will hold the salt.
				saltBytes = new byte[saltSize];

				// Initialize a random number generator.
				RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

				// Fill the salt with cryptographically strong byte values.
				rng.GetNonZeroBytes(saltBytes);
			}

			// Convert plain text into a byte array.
			byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

			// Allocate array, which will hold plain text and salt.
			byte[] plainTextWithSaltBytes =
			new byte[plainTextBytes.Length + saltBytes.Length];

			// Copy plain text bytes into resulting array.
			for (int i = 0; i < plainTextBytes.Length; i++)
				plainTextWithSaltBytes[i] = plainTextBytes[i];

			// Append salt bytes to the resulting array.
			for (int i = 0; i < saltBytes.Length; i++)
				plainTextWithSaltBytes[plainTextBytes.Length + i] = saltBytes[i];

			HashAlgorithm hash = new SHA384Managed();

			// Compute hash value of our plain text with appended salt.
			byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);

			// Create array which will hold hash and original salt bytes.
			byte[] hashWithSaltBytes = new byte[hashBytes.Length +
			saltBytes.Length];

			// Copy hash bytes into resulting array.
			for (int i = 0; i < hashBytes.Length; i++)
				hashWithSaltBytes[i] = hashBytes[i];

			// Append salt bytes to the result.
			for (int i = 0; i < saltBytes.Length; i++)
				hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];

			// Convert result into a base64-encoded string.
			string hashValue = Convert.ToBase64String(hashWithSaltBytes);

			// Return the result.
			return hashValue;
		}
		/// <summary>
		/// https://chandradev819.wordpress.com/2011/04/11/how-to-encrypt-and-decrypt-password-in-asp-net-using-c/
		/// </summary>
		/// <param name="plainText"></param>
		/// <param name="hashValue"></param>
		/// <returns></returns>
		public static bool VerifyHash(string plainText, string hashValue)
		{
			// Convert base64-encoded hash value into a byte array.
			byte[] hashWithSaltBytes = Convert.FromBase64String(hashValue);

			// We must know size of hash (without salt).
			int hashSizeInBits = 384, hashSizeInBytes;

			// Convert size of hash from bits to bytes.
			hashSizeInBytes = hashSizeInBits / 8;

			// Make sure that the specified hash value is long enough.
			if (hashWithSaltBytes.Length < hashSizeInBytes)
				return false;

			// Allocate array to hold original salt bytes retrieved from hash.
			byte[] saltBytes = new byte[hashWithSaltBytes.Length - hashSizeInBytes];

			// Copy salt from the end of the hash to the new array.
			for (int i = 0; i < saltBytes.Length; i++)
				saltBytes[i] = hashWithSaltBytes[hashSizeInBytes + i];

			// Compute a new hash string.
			string expectedHashString = ComputeHash(plainText, saltBytes);

			// If the computed hash matches the specified hash,
			// the plain text value must be correct.
			return (hashValue == expectedHashString);
		}

	}
}
