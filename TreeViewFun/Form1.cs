using System;
using System.Collections.Generic;
/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */

using System.Windows.Forms;
using UtilsNamespace;

namespace TreeViewFun
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Initalize the Form when it loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            Utils.InitTeamTreeView(tvTeams);
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            Utils.AddTeamNode(tvTeams, txtTeam.Text);
        }

        private void btnAddTeamToSelectedNode_Click(object sender, EventArgs e)
        {
            Utils.AddTeamToSelectedNode(tvTeams, txtTeam.Text);
        }
    }
}
