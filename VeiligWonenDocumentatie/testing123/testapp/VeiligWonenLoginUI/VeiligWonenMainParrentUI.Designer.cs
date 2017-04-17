namespace VeiligWonenLoginUI
{
    partial class VeiligWonenMainParrentUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeiligWonenMainParrentUI));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Exit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_LoginButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit_MenuItem,
            this.Menu_LoginButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(51, 19, 0, 31);
            this.menuStrip.Size = new System.Drawing.Size(206, 768);
            this.menuStrip.Stretch = false;
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // Exit_MenuItem
            // 
            this.Exit_MenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Exit_MenuItem.BackColor = System.Drawing.Color.Transparent;
            this.Exit_MenuItem.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_MenuItem.ForeColor = System.Drawing.Color.Red;
            this.Exit_MenuItem.Name = "Exit_MenuItem";
            this.Exit_MenuItem.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Exit_MenuItem.Size = new System.Drawing.Size(103, 50);
            this.Exit_MenuItem.Text = "X";
            this.Exit_MenuItem.Click += new System.EventHandler(this.Exit_MenuItem_Click);
            // 
            // Menu_LoginButton
            // 
            this.Menu_LoginButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Menu_LoginButton.BackColor = System.Drawing.Color.DimGray;
            this.Menu_LoginButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_LoginButton.ForeColor = System.Drawing.Color.White;
            this.Menu_LoginButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Menu_LoginButton.Name = "Menu_LoginButton";
            this.Menu_LoginButton.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.Menu_LoginButton.Size = new System.Drawing.Size(103, 37);
            this.Menu_LoginButton.Text = "Login";
            this.Menu_LoginButton.Click += new System.EventHandler(this.Menu_LoginButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 220);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // VeiligWonenMainParrentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1189, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VeiligWonenMainParrentUI";
            this.Text = "VeiligWonen";
            this.TransparencyKey = System.Drawing.Color.Gainsboro;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem Menu_LoginButton;
        private System.Windows.Forms.ToolStripMenuItem Exit_MenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



