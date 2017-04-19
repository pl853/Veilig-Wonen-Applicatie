namespace VeiligWonenNewUI
{
    partial class Login_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_UI));
            this.label1 = new System.Windows.Forms.Label();
            this.Login_Btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Register_Btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Username_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Exit_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // Login_Btn
            // 
            this.Login_Btn.ActiveBorderThickness = 1;
            this.Login_Btn.ActiveCornerRadius = 20;
            this.Login_Btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.Login_Btn.ActiveForecolor = System.Drawing.Color.White;
            this.Login_Btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.Login_Btn.BackColor = System.Drawing.SystemColors.Control;
            this.Login_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_Btn.BackgroundImage")));
            this.Login_Btn.ButtonText = "Login";
            this.Login_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Btn.ForeColor = System.Drawing.Color.White;
            this.Login_Btn.IdleBorderThickness = 1;
            this.Login_Btn.IdleCornerRadius = 20;
            this.Login_Btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(241)))));
            this.Login_Btn.IdleForecolor = System.Drawing.Color.White;
            this.Login_Btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(241)))));
            this.Login_Btn.Location = new System.Drawing.Point(50, 281);
            this.Login_Btn.Margin = new System.Windows.Forms.Padding(5);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(264, 58);
            this.Login_Btn.TabIndex = 3;
            this.Login_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // Register_Btn
            // 
            this.Register_Btn.ActiveBorderThickness = 1;
            this.Register_Btn.ActiveCornerRadius = 20;
            this.Register_Btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.Register_Btn.ActiveForecolor = System.Drawing.Color.White;
            this.Register_Btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.Register_Btn.BackColor = System.Drawing.SystemColors.Control;
            this.Register_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Register_Btn.BackgroundImage")));
            this.Register_Btn.ButtonText = "Register";
            this.Register_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Register_Btn.IdleBorderThickness = 1;
            this.Register_Btn.IdleCornerRadius = 20;
            this.Register_Btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(241)))));
            this.Register_Btn.IdleForecolor = System.Drawing.Color.White;
            this.Register_Btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(241)))));
            this.Register_Btn.Location = new System.Drawing.Point(50, 349);
            this.Register_Btn.Margin = new System.Windows.Forms.Padding(5);
            this.Register_Btn.Name = "Register_Btn";
            this.Register_Btn.Size = new System.Drawing.Size(264, 58);
            this.Register_Btn.TabIndex = 4;
            this.Register_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Register_Btn.Click += new System.EventHandler(this.Register_Btn_Click);
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_TextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Username_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username_TextBox.HintForeColor = System.Drawing.Color.Empty;
            this.Username_TextBox.HintText = "User Name";
            this.Username_TextBox.isPassword = false;
            this.Username_TextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.Username_TextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.Username_TextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.Username_TextBox.LineThickness = 8;
            this.Username_TextBox.Location = new System.Drawing.Point(69, 112);
            this.Username_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(225, 41);
            this.Username_TextBox.TabIndex = 5;
            this.Username_TextBox.Text = "admin";
            this.Username_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_TextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password_TextBox.HintForeColor = System.Drawing.Color.Empty;
            this.Password_TextBox.HintText = "Password";
            this.Password_TextBox.isPassword = false;
            this.Password_TextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.Password_TextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.Password_TextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.Password_TextBox.LineThickness = 3;
            this.Password_TextBox.Location = new System.Drawing.Point(69, 189);
            this.Password_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(225, 41);
            this.Password_TextBox.TabIndex = 6;
            this.Password_TextBox.Text = "pass123";
            this.Password_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password_TextBox.Enter += new System.EventHandler(this.Password_TextBox_Enter);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(302, -1);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(61, 53);
            this.Exit_btn.TabIndex = 24;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Login_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 430);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Username_TextBox);
            this.Controls.Add(this.Register_Btn);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_UI";
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 Login_Btn;
        private Bunifu.Framework.UI.BunifuThinButton2 Register_Btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Username_TextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password_TextBox;
        private System.Windows.Forms.PictureBox Exit_btn;
    }
}