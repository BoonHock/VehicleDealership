using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleDealership.Classes
{
	class Class_form
	{
		public delegate void MyFunction();
		public static void Show_dialog_as_mdi_child(Form form_child, Form form_parent, MyFunction f)
		{
			form_child.MdiParent = form_parent.MdiParent;
			form_child.FormClosed += (sender2, e2) => Form_closed(form_child, form_parent, f);
			form_child.Show();
			form_parent.Visible = false;
		}
		private static void Form_closed(Form form_child, Form form_parent, MyFunction f)
		{
			form_parent.Visible = true;
			if (form_child.DialogResult == DialogResult.OK) f();
		}
	}
}
