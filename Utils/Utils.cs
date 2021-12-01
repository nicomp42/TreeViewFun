/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilsNamespace
{
    public class Utils
    {
        /// <summary>
        /// Add data to a TreeView control
        /// </summary>
        /// <param name="tv">The TreeView control to be initialized</param>
        public static void InitTeamTreeView(TreeView tv) {
            tv.Nodes.Clear();
            // Adds new node as a child node of the currently selected node.  
            TreeNode newNode = new TreeNode("Teams");
            tv.Nodes.Add(newNode);
            newNode.Nodes.Add(new TreeNode("Bengals"));
            newNode.Nodes.Add(new TreeNode("Steelers"));
            newNode.Nodes.Add(new TreeNode("Browns"));
            newNode.Nodes.Add(new TreeNode("Ravens"));
        }
        /// <summary>
        /// Add data to a TreeView control
        /// </summary>
        /// <param name="tv">The TreeView control to be initialized</param>
        /// <param name="fileName">The data file from which to read</param>
        public static void InitTeamTreeView(TreeView tv, String fileName) {

        }
        public static void AddTeamNode(TreeView tv, String team) {
            tv.Nodes.Add(new TreeNode(team));
        }
        public static void AddTeamToSelectedNode(TreeView tv, String team) {
            tv.SelectedNode.Nodes.Add(new TreeNode(team));
        }
    }
}
