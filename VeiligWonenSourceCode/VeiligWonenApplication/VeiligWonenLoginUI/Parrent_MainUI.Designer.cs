namespace VeiligWonenLoginUI
{
    partial class Parrent_MainUI
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
            this.LoggedInAs_Lable = new System.Windows.Forms.Label();
            this.Name_Lable = new System.Windows.Forms.Label();
            this.ZoekHuis_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddHuis_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.AddData_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoggedInAs_Lable
            // 
            this.LoggedInAs_Lable.AutoSize = true;
            this.LoggedInAs_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInAs_Lable.Location = new System.Drawing.Point(6, 753);
            this.LoggedInAs_Lable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 40);
            this.LoggedInAs_Lable.Name = "LoggedInAs_Lable";
            this.LoggedInAs_Lable.Size = new System.Drawing.Size(155, 25);
            this.LoggedInAs_Lable.TabIndex = 2;
            this.LoggedInAs_Lable.Text = "Logged in as : ";
            // 
            // Name_Lable
            // 
            this.Name_Lable.AutoSize = true;
            this.Name_Lable.Location = new System.Drawing.Point(167, 760);
            this.Name_Lable.Name = "Name_Lable";
            this.Name_Lable.Size = new System.Drawing.Size(0, 17);
            this.Name_Lable.TabIndex = 3;
            // 
            // ZoekHuis_MenuItem
            // 
            this.ZoekHuis_MenuItem.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoekHuis_MenuItem.Margin = new System.Windows.Forms.Padding(0, 270, 0, 0);
            this.ZoekHuis_MenuItem.Name = "ZoekHuis_MenuItem";
            this.ZoekHuis_MenuItem.Size = new System.Drawing.Size(277, 30);
            this.ZoekHuis_MenuItem.Text = "Zoek naar een huis";
            this.ZoekHuis_MenuItem.Click += new System.EventHandler(this.ZoekHuis_MenuItem_Click);
            // 
            // AddHuis_MenuItem
            // 
            this.AddHuis_MenuItem.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHuis_MenuItem.Margin = new System.Windows.Forms.Padding(0, 220, 0, 0);
            this.AddHuis_MenuItem.Name = "AddHuis_MenuItem";
            this.AddHuis_MenuItem.Size = new System.Drawing.Size(277, 33);
            this.AddHuis_MenuItem.Text = "Manage Houses";
            this.AddHuis_MenuItem.Click += new System.EventHandler(this.AddHuis_MenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoekHuis_MenuItem,
            this.AddHuis_MenuItem,
            this.AddData_MenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(286, 844);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // AddData_MenuItem
            // 
            this.AddData_MenuItem.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddData_MenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.AddData_MenuItem.Name = "AddData_MenuItem";
            this.AddData_MenuItem.Size = new System.Drawing.Size(277, 33);
            this.AddData_MenuItem.Text = "Manage Data";
            // 
            // Parrent_MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 844);
            this.Controls.Add(this.Name_Lable);
            this.Controls.Add(this.LoggedInAs_Lable);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Parrent_MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VeiligWonen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Parrent_MainUI_FormClosing);
            this.Load += new System.EventHandler(this.Parrent_MainUI_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label LoggedInAs_Lable;
        private System.Windows.Forms.Label Name_Lable;
        private System.Windows.Forms.ToolStripMenuItem ZoekHuis_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddHuis_MenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddData_MenuItem;
    }
}



