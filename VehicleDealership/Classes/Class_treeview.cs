using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleDealership.Classes
{
	class Class_treeview
	{
		public static TreeNode Get_parent_node_by_level(TreeNode node, int int_level)
		{
			TreeNode tmp_node = node;

			if (int_level < 0) int_level = 0;

			if (tmp_node.Level < int_level)
			{
				throw new Exception("Node level is higher than desired parent node level.");
			}
			else
			{
				while (tmp_node.Parent != null && tmp_node.Level != int_level)
				{
					tmp_node = tmp_node.Parent;
				}
			}

			return tmp_node;
		}
	}
}
