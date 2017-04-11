namespace VeiligWonenLoginUI
{
    partial class Child_AddHuis
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
            this.Gebied_Dropdown = new System.Windows.Forms.ComboBox();
            this.Wijk_Dropdown = new System.Windows.Forms.ComboBox();
            this.label_stadsgebied = new System.Windows.Forms.Label();
            this.label_Wijk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Straat_TextBox = new System.Windows.Forms.TextBox();
            this.Huisnum_Textbox = new System.Windows.Forms.TextBox();
            this.HuurKoop_Textbox = new System.Windows.Forms.ComboBox();
            this.dataGridView_HuisResults = new System.Windows.Forms.DataGridView();
            this.HID_Collumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Gebied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Wijk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Straat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Huisnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_KoopHuur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Prijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.Omschrijving_TextBox = new System.Windows.Forms.RichTextBox();
            this.Prijs_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_Button = new System.Windows.Forms.Button();
            this.HID_Textbox = new System.Windows.Forms.TextBox();
            this.HID_Lable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LatTextBox = new System.Windows.Forms.TextBox();
            this.LongTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HuisResults)).BeginInit();
            this.SuspendLayout();
            // 
            // Gebied_Dropdown
            // 
            this.Gebied_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gebied_Dropdown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gebied_Dropdown.FormattingEnabled = true;
            this.Gebied_Dropdown.Location = new System.Drawing.Point(225, 110);
            this.Gebied_Dropdown.Name = "Gebied_Dropdown";
            this.Gebied_Dropdown.Size = new System.Drawing.Size(229, 33);
            this.Gebied_Dropdown.TabIndex = 0;
            this.Gebied_Dropdown.SelectedIndexChanged += new System.EventHandler(this.Gebied_Dropdown_SelectedIndexChanged);
            // 
            // Wijk_Dropdown
            // 
            this.Wijk_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Wijk_Dropdown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wijk_Dropdown.FormattingEnabled = true;
            this.Wijk_Dropdown.Location = new System.Drawing.Point(225, 164);
            this.Wijk_Dropdown.Name = "Wijk_Dropdown";
            this.Wijk_Dropdown.Size = new System.Drawing.Size(229, 33);
            this.Wijk_Dropdown.TabIndex = 1;
            this.Wijk_Dropdown.SelectedIndexChanged += new System.EventHandler(this.Wijk_Dropdown_SelectedIndexChanged);
            // 
            // label_stadsgebied
            // 
            this.label_stadsgebied.AutoSize = true;
            this.label_stadsgebied.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stadsgebied.Location = new System.Drawing.Point(19, 113);
            this.label_stadsgebied.Name = "label_stadsgebied";
            this.label_stadsgebied.Size = new System.Drawing.Size(150, 25);
            this.label_stadsgebied.TabIndex = 2;
            this.label_stadsgebied.Text = "Stadsgebied :";
            // 
            // label_Wijk
            // 
            this.label_Wijk.AutoSize = true;
            this.label_Wijk.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Wijk.Location = new System.Drawing.Point(19, 167);
            this.label_Wijk.Name = "label_Wijk";
            this.label_Wijk.Size = new System.Drawing.Size(73, 25);
            this.label_Wijk.TabIndex = 3;
            this.label_Wijk.Text = "Wijk :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Te koop / Te huur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Huisnummer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Straat :";
            // 
            // Straat_TextBox
            // 
            this.Straat_TextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Straat_TextBox.Location = new System.Drawing.Point(225, 214);
            this.Straat_TextBox.Name = "Straat_TextBox";
            this.Straat_TextBox.Size = new System.Drawing.Size(229, 32);
            this.Straat_TextBox.TabIndex = 1;
            // 
            // Huisnum_Textbox
            // 
            this.Huisnum_Textbox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Huisnum_Textbox.Location = new System.Drawing.Point(225, 268);
            this.Huisnum_Textbox.Name = "Huisnum_Textbox";
            this.Huisnum_Textbox.Size = new System.Drawing.Size(76, 32);
            this.Huisnum_Textbox.TabIndex = 8;
            // 
            // HuurKoop_Textbox
            // 
            this.HuurKoop_Textbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HuurKoop_Textbox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuurKoop_Textbox.FormattingEnabled = true;
            this.HuurKoop_Textbox.Items.AddRange(new object[] {
            "Te koop",
            "Te huur"});
            this.HuurKoop_Textbox.Location = new System.Drawing.Point(225, 322);
            this.HuurKoop_Textbox.Name = "HuurKoop_Textbox";
            this.HuurKoop_Textbox.Size = new System.Drawing.Size(229, 33);
            this.HuurKoop_Textbox.TabIndex = 9;
            // 
            // dataGridView_HuisResults
            // 
            this.dataGridView_HuisResults.AllowUserToAddRows = false;
            this.dataGridView_HuisResults.AllowUserToDeleteRows = false;
            this.dataGridView_HuisResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HuisResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HID_Collumn,
            this.Column_Gebied,
            this.Column_Wijk,
            this.Column_Straat,
            this.Column_Huisnum,
            this.Column_KoopHuur,
            this.Column_Prijs,
            this.Column_Description});
            this.dataGridView_HuisResults.Location = new System.Drawing.Point(24, 393);
            this.dataGridView_HuisResults.Name = "dataGridView_HuisResults";
            this.dataGridView_HuisResults.ReadOnly = true;
            this.dataGridView_HuisResults.RowTemplate.Height = 24;
            this.dataGridView_HuisResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_HuisResults.Size = new System.Drawing.Size(893, 267);
            this.dataGridView_HuisResults.StandardTab = true;
            this.dataGridView_HuisResults.TabIndex = 10;
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
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(545, 314);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(79, 41);
            this.Button_Add.TabIndex = 11;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(647, 314);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(79, 41);
            this.Delete_button.TabIndex = 12;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(743, 314);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(79, 41);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Omschrijving_TextBox
            // 
            this.Omschrijving_TextBox.Location = new System.Drawing.Point(676, 118);
            this.Omschrijving_TextBox.Name = "Omschrijving_TextBox";
            this.Omschrijving_TextBox.Size = new System.Drawing.Size(241, 107);
            this.Omschrijving_TextBox.TabIndex = 14;
            this.Omschrijving_TextBox.Text = "";
            // 
            // Prijs_Textbox
            // 
            this.Prijs_Textbox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prijs_Textbox.Location = new System.Drawing.Point(676, 57);
            this.Prijs_Textbox.Name = "Prijs_Textbox";
            this.Prijs_Textbox.Size = new System.Drawing.Size(241, 32);
            this.Prijs_Textbox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vraag prijs :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Omschrijving :";
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(838, 314);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(79, 41);
            this.Search_Button.TabIndex = 18;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // HID_Textbox
            // 
            this.HID_Textbox.Enabled = false;
            this.HID_Textbox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HID_Textbox.Location = new System.Drawing.Point(225, 57);
            this.HID_Textbox.Name = "HID_Textbox";
            this.HID_Textbox.ReadOnly = true;
            this.HID_Textbox.Size = new System.Drawing.Size(98, 32);
            this.HID_Textbox.TabIndex = 19;
            // 
            // HID_Lable
            // 
            this.HID_Lable.AutoSize = true;
            this.HID_Lable.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HID_Lable.Location = new System.Drawing.Point(19, 60);
            this.HID_Lable.Name = "HID_Lable";
            this.HID_Lable.Size = new System.Drawing.Size(66, 25);
            this.HID_Lable.TabIndex = 20;
            this.HID_Lable.Text = "HID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Position  Latitude :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(728, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Longditute :";
            // 
            // LatTextBox
            // 
            this.LatTextBox.Location = new System.Drawing.Point(614, 251);
            this.LatTextBox.Name = "LatTextBox";
            this.LatTextBox.Size = new System.Drawing.Size(100, 22);
            this.LatTextBox.TabIndex = 23;
            // 
            // LongTextBox
            // 
            this.LongTextBox.Location = new System.Drawing.Point(809, 251);
            this.LongTextBox.Name = "LongTextBox";
            this.LongTextBox.Size = new System.Drawing.Size(100, 22);
            this.LongTextBox.TabIndex = 24;
            // 
            // Child_AddHuis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(943, 700);
            this.Controls.Add(this.LongTextBox);
            this.Controls.Add(this.LatTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HID_Lable);
            this.Controls.Add(this.HID_Textbox);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prijs_Textbox);
            this.Controls.Add(this.Omschrijving_TextBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.dataGridView_HuisResults);
            this.Controls.Add(this.HuurKoop_Textbox);
            this.Controls.Add(this.Huisnum_Textbox);
            this.Controls.Add(this.Straat_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Wijk);
            this.Controls.Add(this.label_stadsgebied);
            this.Controls.Add(this.Wijk_Dropdown);
            this.Controls.Add(this.Gebied_Dropdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Child_AddHuis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Child_AddHuis";
            this.Load += new System.EventHandler(this.Child_AddHuis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HuisResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Gebied_Dropdown;
        private System.Windows.Forms.ComboBox Wijk_Dropdown;
        private System.Windows.Forms.Label label_stadsgebied;
        private System.Windows.Forms.Label label_Wijk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Straat_TextBox;
        private System.Windows.Forms.TextBox Huisnum_Textbox;
        private System.Windows.Forms.ComboBox HuurKoop_Textbox;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.RichTextBox Omschrijving_TextBox;
        private System.Windows.Forms.TextBox Prijs_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_HuisResults;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn HID_Collumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Gebied;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Wijk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Straat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Huisnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_KoopHuur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Prijs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Description;
        private System.Windows.Forms.TextBox HID_Textbox;
        private System.Windows.Forms.Label HID_Lable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LatTextBox;
        private System.Windows.Forms.TextBox LongTextBox;
    }
}