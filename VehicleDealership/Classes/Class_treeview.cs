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
				throw new Exception("Node level is lower than desired parent node level.");
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
		/// <summary>
		/// get first child at @int_level. if selected node already at @int_level level, will return selected node
		/// </summary>
		/// <param name="node"></param>
		/// <param name="int_level"></param>
		/// <returns></returns>
		public static TreeNode Get_child_at_level(TreeNode node, int int_level)
		{
			TreeNode tmp_node = node;

			if (int_level < 0) int_level = 0;

			if (tmp_node.Level > int_level)
			{
				throw new Exception("Node level is higher than desired child node level.");
			}
			else
			{
				while (tmp_node.FirstNode != null && tmp_node.Level != int_level)
				{
					tmp_node = tmp_node.FirstNode;
				}
			}

			return tmp_node; 
		}
	}
}
