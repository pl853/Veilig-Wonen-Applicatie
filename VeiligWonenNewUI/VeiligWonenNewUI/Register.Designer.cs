namespace VeiligWonenNewUI
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.firstname_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passcheck_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lastname_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.email_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.username_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Register_Btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Exit_btn = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(90, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register";
            // 
            // firstname_text
            // 
            this.firstname_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstname_text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.firstname_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstname_text.HintForeColor = System.Drawing.Color.Empty;
            this.firstname_text.HintText = "First Name";
            this.firstname_text.isPassword = false;
            this.firstname_text.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.firstname_text.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.firstname_text.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.firstname_text.LineThickness = 20;
            this.firstname_text.Location = new System.Drawing.Point(87, 198);
            this.firstname_text.Margin = new System.Windows.Forms.Padding(4);
            this.firstname_text.Name = "firstname_text";
            this.firstname_text.Size = new System.Drawing.Size(289, 42);
            this.firstname_text.TabIndex = 1;
            this.firstname_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Password_text
            // 
            this.Password_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password_text.HintForeColor = System.Drawing.Color.Empty;
            this.Password_text.HintText = "Password";
            this.Password_text.isPassword = true;
            this.Password_text.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.Password_text.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.Password_text.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.Password_text.LineThickness = 8;
            this.Password_text.Location = new System.Drawing.Point(87, 391);
            this.Password_text.Margin = new System.Windows.Forms.Padding(4);
            this.Password_text.Name = "Password_text";
            this.Password_text.Size = new System.Drawing.Size(289, 41);
            this.Password_text.TabIndex = 1;
            this.Password_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password_text.Enter += new System.EventHandler(this.Password_text_Enter);
            // 
            // passcheck_text
            // 
            this.passcheck_text.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.passcheck_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passcheck_text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passcheck_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passcheck_text.HintForeColor = System.Drawing.Color.Empty;
            this.passcheck_text.HintText = "Password check";
            this.passcheck_text.isPassword = true;
            this.passcheck_text.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.passcheck_text.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.passcheck_text.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.passcheck_text.LineThickness = 8;
            this.passcheck_text.Location = new System.Drawing.Point(87, 449);
            this.passcheck_text.Margin = new System.Windows.Forms.Padding(4);
            this.passcheck_text.Name = "passcheck_text";
            this.passcheck_text.Size = new System.Drawing.Size(289, 41);
            this.passcheck_text.TabIndex = 1;
            this.passcheck_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passcheck_text.Enter += new System.EventHandler(this.passcheck_text_Enter);
            // 
            // lastname_text
            // 
            this.lastname_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastname_text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lastname_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastname_text.HintForeColor = System.Drawing.Color.Empty;
            this.lastname_text.HintText = "Last name";
            this.lastname_text.isPassword = false;
            this.lastname_text.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.lastname_text.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.lastname_text.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.lastname_text.LineThickness = 8;
            this.lastname_text.Location = new System.Drawing.Point(87, 265);
            this.lastname_text.Margin = new System.Windows.Forms.Padding(4);
            this.lastname_text.Name = "lastname_text";
            this.lastname_text.Size = new System.Drawing.Size(289, 41);
            this.lastname_text.TabIndex = 1;
            this.lastname_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // email_text
            // 
            this.email_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email_text.HintForeColor = System.Drawing.Color.Empty;
            this.email_text.HintText = "Email ";
            this.email_text.isPassword = false;
            this.email_text.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.email_text.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.email_text.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.email_text.LineThickness = 8;
            this.email_text.Location = new System.Drawing.Point(87, 331);
            this.email_text.Margin = new System.Windows.Forms.Padding(4);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(289, 41);
            this.email_text.TabIndex = 1;
            this.email_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // username_text
            // 
            this.username_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_text.HintForeColor = System.Drawing.Color.Empty;
            this.username_text.HintText = "User name";
            this.username_text.isPassword = false;
            this.username_text.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.username_text.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.username_text.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.username_text.LineThickness = 8;
            this.username_text.Location = new System.Drawing.Point(87, 140);
            this.username_text.Margin = new System.Windows.Forms.Padding(4);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(289, 41);
            this.username_text.TabIndex = 1;
            this.username_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.Register_Btn.Location = new System.Drawing.Point(102, 540);
            this.Register_Btn.Margin = new System.Windows.Forms.Padding(5);
            this.Register_Btn.Name = "Register_Btn";
            this.Register_Btn.Size = new System.Drawing.Size(264, 58);
            this.Register_Btn.TabIndex = 12;
            this.Register_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Register_Btn.Click += new System.EventHandler(this.Register_Btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(397, 20);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(61, 53);
            this.Exit_btn.TabIndex = 25;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 66);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 625);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Register_Btn);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.lastname_text);
            this.Controls.Add(this.passcheck_text);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.firstname_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox firstname_text;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password_text;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passcheck_text;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lastname_text;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email_text;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username_text;
        private Bunifu.Framework.UI.BunifuThinButton2 Register_Btn;
        private System.Windows.Forms.PictureBox Exit_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}