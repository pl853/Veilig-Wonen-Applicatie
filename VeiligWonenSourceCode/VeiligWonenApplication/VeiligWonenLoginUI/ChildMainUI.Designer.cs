namespace VeiligWonenLoginUI
{
    partial class ChildMainUI
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
            this.GoogleMapsControl = new GMap.NET.WindowsForms.GMapControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Stadsgebied_Dropdown = new System.Windows.Forms.ComboBox();
            this.Wijk_Dropdown = new System.Windows.Forms.ComboBox();
            this.Straat_TextBox = new System.Windows.Forms.TextBox();
            this.Huisnummer_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrijsTot_Textbox = new System.Windows.Forms.TextBox();
            this.PrijsVan_Textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.KoopHuur_Dropdown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Zoek_Button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoogleMapsControl
            // 
            this.GoogleMapsControl.Bearing = 0F;
            this.GoogleMapsControl.CanDragMap = true;
            this.GoogleMapsControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.GoogleMapsControl.GrayScaleMode = false;
            this.GoogleMapsControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GoogleMapsControl.LevelsKeepInMemmory = 5;
            this.GoogleMapsControl.Location = new System.Drawing.Point(-1, 295);
            this.GoogleMapsControl.MarkersEnabled = true;
            this.GoogleMapsControl.MaxZoom = 2;
            this.GoogleMapsControl.MinZoom = 2;
            this.GoogleMapsControl.MouseWheelZoomEnabled = true;
            this.GoogleMapsControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GoogleMapsControl.Name = "GoogleMapsControl";
            this.GoogleMapsControl.NegativeMode = false;
            this.GoogleMapsControl.PolygonsEnabled = true;
            this.GoogleMapsControl.RetryLoadTile = 0;
            this.GoogleMapsControl.RoutesEnabled = true;
            this.GoogleMapsControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GoogleMapsControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GoogleMapsControl.ShowTileGridLines = false;
            this.GoogleMapsControl.Size = new System.Drawing.Size(859, 543);
            this.GoogleMapsControl.TabIndex = 0;
            this.GoogleMapsControl.Zoom = 0D;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(850, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(452, 842);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(444, 813);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(444, 813);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Stadsgebied_Dropdown
            // 
            this.Stadsgebied_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Stadsgebied_Dropdown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stadsgebied_Dropdown.FormattingEnabled = true;
            this.Stadsgebied_Dropdown.Location = new System.Drawing.Point(161, 25);
            this.Stadsgebied_Dropdown.Name = "Stadsgebied_Dropdown";
            this.Stadsgebied_Dropdown.Size = new System.Drawing.Size(260, 33);
            this.Stadsgebied_Dropdown.TabIndex = 2;
            this.Stadsgebied_Dropdown.SelectedIndexChanged += new System.EventHandler(this.Stadsgebied_Dropdown_SelectedIndexChanged);
            this.Stadsgebied_Dropdown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Stadsgebied_Dropdown_MouseDown);
            // 
            // Wijk_Dropdown
            // 
            this.Wijk_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Wijk_Dropdown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wijk_Dropdown.FormattingEnabled = true;
            this.Wijk_Dropdown.Location = new System.Drawing.Point(161, 82);
            this.Wijk_Dropdown.Name = "Wijk_Dropdown";
            this.Wijk_Dropdown.Size = new System.Drawing.Size(232, 33);
            this.Wijk_Dropdown.TabIndex = 3;
            this.Wijk_Dropdown.SelectedIndexChanged += new System.EventHandler(this.Wijk_Dropdown_SelectedIndexChanged);
            // 
            // Straat_TextBox
            // 
            this.Straat_TextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Straat_TextBox.Location = new System.Drawing.Point(161, 143);
            this.Straat_TextBox.Name = "Straat_TextBox";
            this.Straat_TextBox.Size = new System.Drawing.Size(181, 32);
            this.Straat_TextBox.TabIndex = 4;
            // 
            // Huisnummer_TextBox
            // 
            this.Huisnummer_TextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Huisnummer_TextBox.Location = new System.Drawing.Point(161, 197);
            this.Huisnummer_TextBox.Name = "Huisnummer_TextBox";
            this.Huisnummer_TextBox.Size = new System.Drawing.Size(82, 32);
            this.Huisnummer_TextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stadsgebied :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Huisnummer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Straat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wijk :";
            // 
            // PrijsTot_Textbox
            // 
            this.PrijsTot_Textbox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrijsTot_Textbox.Location = new System.Drawing.Point(737, 88);
            this.PrijsTot_Textbox.Name = "PrijsTot_Textbox";
            this.PrijsTot_Textbox.Size = new System.Drawing.Size(82, 32);
            this.PrijsTot_Textbox.TabIndex = 10;
            // 
            // PrijsVan_Textbox
            // 
            this.PrijsVan_Textbox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrijsVan_Textbox.Location = new System.Drawing.Point(566, 88);
            this.PrijsVan_Textbox.Name = "PrijsVan_Textbox";
            this.PrijsVan_Textbox.Size = new System.Drawing.Size(82, 32);
            this.PrijsVan_Textbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prijs  van :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(665, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "tot :";
            // 
            // KoopHuur_Dropdown
            // 
            this.KoopHuur_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KoopHuur_Dropdown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KoopHuur_Dropdown.FormattingEnabled = true;
            this.KoopHuur_Dropdown.Location = new System.Drawing.Point(638, 25);
            this.KoopHuur_Dropdown.Name = "KoopHuur_Dropdown";
            this.KoopHuur_Dropdown.Size = new System.Drawing.Size(181, 33);
            this.KoopHuur_Dropdown.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Te koop/ Te huur :";
            // 
            // Zoek_Button
            // 
            this.Zoek_Button.Location = new System.Drawing.Point(655, 233);
            this.Zoek_Button.Name = "Zoek_Button";
            this.Zoek_Button.Size = new System.Drawing.Size(132, 40);
            this.Zoek_Button.TabIndex = 16;
            this.Zoek_Button.Text = "Zoek";
            this.Zoek_Button.UseVisualStyleBackColor = true;
            this.Zoek_Button.Click += new System.EventHandler(this.Zoek_Button_Click);
            // 
            // ChildMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 842);
            this.Controls.Add(this.Zoek_Button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KoopHuur_Dropdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrijsVan_Textbox);
            this.Controls.Add(this.PrijsTot_Textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Huisnummer_TextBox);
            this.Controls.Add(this.Straat_TextBox);
            this.Controls.Add(this.Wijk_Dropdown);
            this.Controls.Add(this.Stadsgebied_Dropdown);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.GoogleMapsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildMainUI";
            this.Text = "ChildMainUI";
            this.Load += new System.EventHandler(this.ChildMainUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl GoogleMapsControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox Stadsgebied_Dropdown;
        private System.Windows.Forms.ComboBox Wijk_Dropdown;
        private System.Windows.Forms.TextBox Straat_TextBox;
        private System.Windows.Forms.TextBox Huisnummer_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrijsTot_Textbox;
        private System.Windows.Forms.TextBox PrijsVan_Textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox KoopHuur_Dropdown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Zoek_Button;
    }
}