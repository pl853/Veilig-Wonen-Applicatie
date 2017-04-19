namespace VeiligWonenNewUI
{
    partial class Addhuis_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addhuis_UI));
            this.LongTextBox = new System.Windows.Forms.TextBox();
            this.LatTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.HID_Lable = new System.Windows.Forms.Label();
            this.HID_Textbox = new System.Windows.Forms.TextBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Prijs_Textbox = new System.Windows.Forms.TextBox();
            this.Omschrijving_TextBox = new System.Windows.Forms.RichTextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.dataGridView_HuisResults = new System.Windows.Forms.DataGridView();
            this.HID_Collumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Gebied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Wijk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Straat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Huisnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_KoopHuur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Prijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Long = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HuurKoop_Textbox = new System.Windows.Forms.ComboBox();
            this.Huisnum_Textbox = new System.Windows.Forms.TextBox();
            this.Straat_TextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_Wijk = new System.Windows.Forms.Label();
            this.label_stadsgebied = new System.Windows.Forms.Label();
            this.Wijk_Dropdown = new System.Windows.Forms.ComboBox();
            this.gebied_Dropdown = new System.Windows.Forms.ComboBox();
            this.Exit_btn = new System.Windows.Forms.PictureBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.Show_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HuisResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // LongTextBox
            // 
            this.LongTextBox.Location = new System.Drawing.Point(836, 251);
            this.LongTextBox.Name = "LongTextBox";
            this.LongTextBox.Size = new System.Drawing.Size(100, 22);
            this.LongTextBox.TabIndex = 74;
            // 
            // LatTextBox
            // 
            this.LatTextBox.Location = new System.Drawing.Point(641, 251);
            this.LatTextBox.Name = "LatTextBox";
            this.LatTextBox.Size = new System.Drawing.Size(100, 22);
            this.LatTextBox.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(755, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 72;
            this.label10.Text = "Longditute :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(510, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 71;
            this.label11.Text = "Position  Latitude :";
            // 
            // HID_Lable
            // 
            this.HID_Lable.AutoSize = true;
            this.HID_Lable.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HID_Lable.Location = new System.Drawing.Point(41, 60);
            this.HID_Lable.Name = "HID_Lable";
            this.HID_Lable.Size = new System.Drawing.Size(66, 25);
            this.HID_Lable.TabIndex = 70;
            this.HID_Lable.Text = "HID :";
            // 
            // HID_Textbox
            // 
            this.HID_Textbox.Enabled = false;
            this.HID_Textbox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HID_Textbox.Location = new System.Drawing.Point(252, 57);
            this.HID_Textbox.Name = "HID_Textbox";
            this.HID_Textbox.Size = new System.Drawing.Size(98, 32);
            this.HID_Textbox.TabIndex = 69;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(729, 314);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(68, 41);
            this.Search_Button.TabIndex = 68;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(524, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 25);
            this.label12.TabIndex = 67;
            this.label12.Text = "Omschrijving :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(547, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 25);
            this.label13.TabIndex = 66;
            this.label13.Text = "Vraag prijs :";
            // 
            // Prijs_Textbox
            // 
            this.Prijs_Textbox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prijs_Textbox.Location = new System.Drawing.Point(703, 57);
            this.Prijs_Textbox.Name = "Prijs_Textbox";
            this.Prijs_Textbox.Size = new System.Drawing.Size(241, 32);
            this.Prijs_Textbox.TabIndex = 65;
            // 
            // Omschrijving_TextBox
            // 
            this.Omschrijving_TextBox.Location = new System.Drawing.Point(703, 118);
            this.Omschrijving_TextBox.Name = "Omschrijving_TextBox";
            this.Omschrijving_TextBox.Size = new System.Drawing.Size(241, 107);
            this.Omschrijving_TextBox.TabIndex = 64;
            this.Omschrijving_TextBox.Text = "";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(655, 314);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(68, 41);
            this.UpdateButton.TabIndex = 63;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(586, 314);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(63, 41);
            this.Delete_button.TabIndex = 62;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(513, 314);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(67, 41);
            this.Button_Add.TabIndex = 61;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // dataGridView_HuisResults
            // 
            this.dataGridView_HuisResults.AllowUserToAddRows = false;
            this.dataGridView_HuisResults.AllowUserToDeleteRows = false;
            this.dataGridView_HuisResults.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_HuisResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HuisResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HID_Collumn,
            this.Column_Gebied,
            this.Column_Wijk,
            this.Column_Straat,
            this.Column_Huisnum,
            this.Column_KoopHuur,
            this.Column_Prijs,
            this.Column_Description,
            this.Lat,
            this.Long});
            this.dataGridView_HuisResults.Location = new System.Drawing.Point(51, 393);
            this.dataGridView_HuisResults.Name = "dataGridView_HuisResults";
            this.dataGridView_HuisResults.ReadOnly = true;
            this.dataGridView_HuisResults.RowTemplate.Height = 24;
            this.dataGridView_HuisResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_HuisResults.Size = new System.Drawing.Size(893, 267);
            this.dataGridView_HuisResults.StandardTab = true;
            this.dataGridView_HuisResults.TabIndex = 60;
            this.dataGridView_HuisResults.TabStop = false;
            this.dataGridView_HuisResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_HuisResults_MouseDoubleClick);
            // 
            // HID_Collumn
            // 
            this.HID_Collumn.HeaderText = "HID";
            this.HID_Collumn.Name = "HID_Collumn";
            this.HID_Collumn.ReadOnly = true;
            this.HID_Collumn.Width = 40;
            // 
            // Column_Gebied
            // 
            this.Column_Gebied.HeaderText = "Gebied";
            this.Column_Gebied.MinimumWidth = 10;
            this.Column_Gebied.Name = "Column_Gebied";
            this.Column_Gebied.ReadOnly = true;
            this.Column_Gebied.Width = 150;
            // 
            // Column_Wijk
            // 
            this.Column_Wijk.HeaderText = "Wijk";
            this.Column_Wijk.Name = "Column_Wijk";
            this.Column_Wijk.ReadOnly = true;
            this.Column_Wijk.Width = 150;
            // 
            // Column_Straat
            // 
            this.Column_Straat.HeaderText = "Straat";
            this.Column_Straat.Name = "Column_Straat";
            this.Column_Straat.ReadOnly = true;
            this.Column_Straat.Width = 150;
            // 
            // Column_Huisnum
            // 
            this.Column_Huisnum.HeaderText = "Num";
            this.Column_Huisnum.Name = "Column_Huisnum";
            this.Column_Huisnum.ReadOnly = true;
            this.Column_Huisnum.Width = 50;
            // 
            // Column_KoopHuur
            // 
            this.Column_KoopHuur.HeaderText = "Te koop / Te huur";
            this.Column_KoopHuur.Name = "Column_KoopHuur";
            this.Column_KoopHuur.ReadOnly = true;
            // 
            // Column_Prijs
            // 
            this.Column_Prijs.HeaderText = "Prijs";
            this.Column_Prijs.Name = "Column_Prijs";
            this.Column_Prijs.ReadOnly = true;
            this.Column_Prijs.Width = 60;
            // 
            // Column_Description
            // 
            this.Column_Description.HeaderText = "Omschrijving";
            this.Column_Description.Name = "Column_Description";
            this.Column_Description.ReadOnly = true;
            this.Column_Description.Width = 150;
            // 
            // Lat
            // 
            this.Lat.HeaderText = "Lat";
            this.Lat.Name = "Lat";
            this.Lat.ReadOnly = true;
            // 
            // Long
            // 
            this.Long.HeaderText = "Long";
            this.Long.Name = "Long";
            this.Long.ReadOnly = true;
            // 
            // HuurKoop_Textbox
            // 
            this.HuurKoop_Textbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HuurKoop_Textbox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuurKoop_Textbox.FormattingEnabled = true;
            this.HuurKoop_Textbox.Items.AddRange(new object[] {
            "Te koop",
            "Te huur"});
            this.HuurKoop_Textbox.Location = new System.Drawing.Point(252, 322);
            this.HuurKoop_Textbox.Name = "HuurKoop_Textbox";
            this.HuurKoop_Textbox.Size = new System.Drawing.Size(229, 33);
            this.HuurKoop_Textbox.TabIndex = 59;
            // 
            // Huisnum_Textbox
            // 
            this.Huisnum_Textbox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Huisnum_Textbox.Location = new System.Drawing.Point(252, 268);
            this.Huisnum_Textbox.Name = "Huisnum_Textbox";
            this.Huisnum_Textbox.Size = new System.Drawing.Size(76, 32);
            this.Huisnum_Textbox.TabIndex = 58;
            // 
            // Straat_TextBox
            // 
            this.Straat_TextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Straat_TextBox.Location = new System.Drawing.Point(252, 214);
            this.Straat_TextBox.Name = "Straat_TextBox";
            this.Straat_TextBox.Size = new System.Drawing.Size(229, 32);
            this.Straat_TextBox.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(41, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 25);
            this.label14.TabIndex = 57;
            this.label14.Text = "Straat :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(41, 275);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 25);
            this.label15.TabIndex = 56;
            this.label15.Text = "Huisnummer :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(41, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(205, 25);
            this.label16.TabIndex = 55;
            this.label16.Text = "Te koop / Te huur :";
            // 
            // label_Wijk
            // 
            this.label_Wijk.AutoSize = true;
            this.label_Wijk.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Wijk.Location = new System.Drawing.Point(41, 167);
            this.label_Wijk.Name = "label_Wijk";
            this.label_Wijk.Size = new System.Drawing.Size(73, 25);
            this.label_Wijk.TabIndex = 54;
            this.label_Wijk.Text = "Wijk :";
            // 
            // label_stadsgebied
            // 
            this.label_stadsgebied.AutoSize = true;
            this.label_stadsgebied.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stadsgebied.Location = new System.Drawing.Point(41, 113);
            this.label_stadsgebied.Name = "label_stadsgebied";
            this.label_stadsgebied.Size = new System.Drawing.Size(150, 25);
            this.label_stadsgebied.TabIndex = 53;
            this.label_stadsgebied.Text = "Stadsgebied :";
            // 
            // Wijk_Dropdown
            // 
            this.Wijk_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Wijk_Dropdown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wijk_Dropdown.FormattingEnabled = true;
            this.Wijk_Dropdown.Location = new System.Drawing.Point(252, 164);
            this.Wijk_Dropdown.Name = "Wijk_Dropdown";
            this.Wijk_Dropdown.Size = new System.Drawing.Size(229, 33);
            this.Wijk_Dropdown.TabIndex = 52;
            // 
            // gebied_Dropdown
            // 
            this.gebied_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gebied_Dropdown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebied_Dropdown.FormattingEnabled = true;
            this.gebied_Dropdown.Location = new System.Drawing.Point(252, 110);
            this.gebied_Dropdown.Name = "gebied_Dropdown";
            this.gebied_Dropdown.Size = new System.Drawing.Size(229, 33);
            this.gebied_Dropdown.TabIndex = 50;
            this.gebied_Dropdown.SelectedIndexChanged += new System.EventHandler(this.Gebied_Dropdown_SelectedIndexChanged);
            this.gebied_Dropdown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gebied_Dropdown_MouseDown);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(932, -2);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(61, 53);
            this.Exit_btn.TabIndex = 75;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(803, 314);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(65, 41);
            this.clear_button.TabIndex = 76;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Show_btn
            // 
            this.Show_btn.Location = new System.Drawing.Point(874, 314);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(74, 41);
            this.Show_btn.TabIndex = 77;
            this.Show_btn.Text = "Show all";
            this.Show_btn.UseVisualStyleBackColor = true;
            this.Show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // Addhuis_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 716);
            this.Controls.Add(this.Show_btn);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.LongTextBox);
            this.Controls.Add(this.LatTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.HID_Lable);
            this.Controls.Add(this.HID_Textbox);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Prijs_Textbox);
            this.Controls.Add(this.Omschrijving_TextBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.dataGridView_HuisResults);
            this.Controls.Add(this.HuurKoop_Textbox);
            this.Controls.Add(this.Huisnum_Textbox);
            this.Controls.Add(this.Straat_TextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label_Wijk);
            this.Controls.Add(this.label_stadsgebied);
            this.Controls.Add(this.Wijk_Dropdown);
            this.Controls.Add(this.gebied_Dropdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Addhuis_UI";
            this.Text = "Addhuis_UI";
            this.Load += new System.EventHandler(this.Addhuis_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HuisResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LongTextBox;
        private System.Windows.Forms.TextBox LatTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label HID_Lable;
        private System.Windows.Forms.TextBox HID_Textbox;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Prijs_Textbox;
        private System.Windows.Forms.RichTextBox Omschrijving_TextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.DataGridView dataGridView_HuisResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn HID_Collumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Gebied;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Wijk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Straat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Huisnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_KoopHuur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Prijs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Long;
        private System.Windows.Forms.ComboBox HuurKoop_Textbox;
        private System.Windows.Forms.TextBox Huisnum_Textbox;
        private System.Windows.Forms.TextBox Straat_TextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_Wijk;
        private System.Windows.Forms.Label label_stadsgebied;
        private System.Windows.Forms.ComboBox Wijk_Dropdown;
        private System.Windows.Forms.ComboBox gebied_Dropdown;
        private System.Windows.Forms.PictureBox Exit_btn;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button Show_btn;
    }
}