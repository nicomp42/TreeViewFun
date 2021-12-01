
namespace TreeViewFun
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvTeams = new System.Windows.Forms.TreeView();
            this.btnInit = new System.Windows.Forms.Button();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTeamToSelectedNode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvTeams
            // 
            this.tvTeams.Location = new System.Drawing.Point(66, 32);
            this.tvTeams.Name = "tvTeams";
            this.tvTeams.Size = new System.Drawing.Size(398, 406);
            this.tvTeams.TabIndex = 0;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(483, 414);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 1;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(573, 32);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(115, 20);
            this.txtTeam.TabIndex = 2;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(694, 32);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeam.TabIndex = 3;
            this.btnAddTeam.Text = "AddTeam";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team";
            // 
            // btnAddTeamToSelectedNode
            // 
            this.btnAddTeamToSelectedNode.Location = new System.Drawing.Point(694, 61);
            this.btnAddTeamToSelectedNode.Name = "btnAddTeamToSelectedNode";
            this.btnAddTeamToSelectedNode.Size = new System.Drawing.Size(75, 62);
            this.btnAddTeamToSelectedNode.TabIndex = 5;
            this.btnAddTeamToSelectedNode.Text = "Add Team to Selected Node";
            this.btnAddTeamToSelectedNode.UseVisualStyleBackColor = true;
            this.btnAddTeamToSelectedNode.Click += new System.EventHandler(this.btnAddTeamToSelectedNode_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddTeamToSelectedNode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.txtTeam);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.tvTeams);
            this.Name = "frmMain";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvTeams;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTeamToSelectedNode;
    }
}

