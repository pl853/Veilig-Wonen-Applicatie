namespace VeiligWonenNewUI
{
    partial class addData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addData));
            this.SCID_Text = new System.Windows.Forms.TextBox();
            this.Wijk_dropdown = new System.Windows.Forms.ComboBox();
            this.Hcategorie_Combobox = new System.Windows.Forms.ComboBox();
            this.SCategorie_Combobox = new System.Windows.Forms.ComboBox();
            this.scid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Perc2013 = new System.Windows.Forms.TextBox();
            this.Perc2015 = new System.Windows.Forms.TextBox();
            this.Perc2016 = new System.Windows.Forms.TextBox();
            this.Perc2014 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Addperc_Datagrid = new System.Windows.Forms.DataGridView();
            this.SCIDcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WijkCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HcatCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCatCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.per2013 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.per2014 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.per2015 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.per2016 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clear_button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gebied_Dropdown = new System.Windows.Forms.ComboBox();
            this.show_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Addperc_Datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // SCID_Text
            // 
            this.SCID_Text.Enabled = false;
            this.SCID_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCID_Text.Location = new System.Drawing.Point(265, 51);
            this.SCID_Text.Name = "SCID_Text";
            this.SCID_Text.ReadOnly = true;
            this.SCID_Text.Size = new System.Drawing.Size(100, 30);
            this.SCID_Text.TabIndex = 0;
            // 
            // Wijk_dropdown
            // 
            this.Wijk_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Wijk_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wijk_dropdown.FormattingEnabled = true;
            this.Wijk_dropdown.Location = new System.Drawing.Point(265, 159);
            this.Wijk_dropdown.Name = "Wijk_dropdown";
            this.Wijk_dropdown.Size = new System.Drawing.Size(217, 33);
            this.Wijk_dropdown.TabIndex = 2;
            // 
            // Hcategorie_Combobox
            // 
            this.Hcategorie_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Hcategorie_Combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hcategorie_Combobox.FormattingEnabled = true;
            this.Hcategorie_Combobox.Items.AddRange(new object[] {
            "Inbraak",
            "Geweld",
            "Vandalisme"});
            this.Hcategorie_Combobox.Location = new System.Drawing.Point(265, 215);
            this.Hcategorie_Combobox.Name = "Hcategorie_Combobox";
            this.Hcategorie_Combobox.Size = new System.Drawing.Size(217, 33);
            this.Hcategorie_Combobox.TabIndex = 3;
            this.Hcategorie_Combobox.DropDown += new System.EventHandler(this.Hcategorie_Combobox_DropDown);
            // 
            // SCategorie_Combobox
            // 
            this.SCategorie_Combobox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SCategorie_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SCategorie_Combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCategorie_Combobox.FormattingEnabled = true;
            this.SCategorie_Combobox.Location = new System.Drawing.Point(265, 274);
            this.SCategorie_Combobox.Name = "SCategorie_Combobox";
            this.SCategorie_Combobox.Size = new System.Drawing.Size(217, 33);
            this.SCategorie_Combobox.TabIndex = 4;
            this.SCategorie_Combobox.DropDown += new System.EventHandler(this.SCategorie_Combobox_DropDown);
            // 
            // scid
            // 
            this.scid.AutoSize = true;
            this.scid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scid.Location = new System.Drawing.Point(67, 60);
            this.scid.Name = "scid";
            this.scid.Size = new System.Drawing.Size(62, 24);
            this.scid.TabIndex = 5;
            this.scid.Text = "SCID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wijk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sub Categorie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hoofd Catergorie:";
            // 
            // Perc2013
            // 
            this.Perc2013.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perc2013.Location = new System.Drawing.Point(665, 63);
            this.Perc2013.Name = "Perc2013";
            this.Perc2013.Size = new System.Drawing.Size(100, 30);
            this.Perc2013.TabIndex = 10;
            // 
            // Perc2015
            // 
            this.Perc2015.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perc2015.Location = new System.Drawing.Point(665, 173);
            this.Perc2015.Name = "Perc2015";
            this.Perc2015.Size = new System.Drawing.Size(100, 30);
            this.Perc2015.TabIndex = 11;
            // 
            // Perc2016
            // 
            this.Perc2016.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perc2016.Location = new System.Drawing.Point(665, 235);
            this.Perc2016.Name = "Perc2016";
            this.Perc2016.Size = new System.Drawing.Size(100, 30);
            this.Perc2016.TabIndex = 12;
            // 
            // Perc2014
            // 
            this.Perc2014.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perc2014.Location = new System.Drawing.Point(665, 118);
            this.Perc2014.Name = "Perc2014";
            this.Perc2014.Size = new System.Drawing.Size(100, 30);
            this.Perc2014.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(561, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "% 2013 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(561, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "% 2016 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "% 2015 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(561, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "% 2014 :";
            // 
            // Addperc_Datagrid
            // 
            this.Addperc_Datagrid.AllowUserToAddRows = false;
            this.Addperc_Datagrid.AllowUserToDeleteRows = false;
            this.Addperc_Datagrid.BackgroundColor = System.Drawing.Color.White;
            this.Addperc_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Addperc_Datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SCIDcol,
            this.WijkCol,
            this.HcatCol,
            this.sCatCol,
            this.per2013,
            this.per2014,
            this.per2015,
            this.per2016});
            this.Addperc_Datagrid.Location = new System.Drawing.Point(23, 407);
            this.Addperc_Datagrid.Name = "Addperc_Datagrid";
            this.Addperc_Datagrid.RowTemplate.Height = 24;
            this.Addperc_Datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Addperc_Datagrid.Size = new System.Drawing.Size(940, 283);
            this.Addperc_Datagrid.TabIndex = 18;
            this.Addperc_Datagrid.DoubleClick += new System.EventHandler(this.Addperc_Datagrid_DoubleClick);
            // 
            // SCIDcol
            // 
            this.SCIDcol.HeaderText = "SCID";
            this.SCIDcol.Name = "SCIDcol";
            // 
            // WijkCol
            // 
            this.WijkCol.HeaderText = "Wijk";
            this.WijkCol.Name = "WijkCol";
            // 
            // HcatCol
            // 
            this.HcatCol.HeaderText = "Hoofdcat";
            this.HcatCol.Name = "HcatCol";
            // 
            // sCatCol
            // 
            this.sCatCol.HeaderText = "SubCat";
            this.sCatCol.Name = "sCatCol";
            // 
            // per2013
            // 
            this.per2013.HeaderText = "%2013";
            this.per2013.Name = "per2013";
            // 
            // per2014
            // 
            this.per2014.HeaderText = "%2014";
            this.per2014.Name = "per2014";
            // 
            // per2015
            // 
            this.per2015.HeaderText = "%2015";
            this.per2015.Name = "per2015";
            // 
            // per2016
            // 
            this.per2016.HeaderText = "%2016";
            this.per2016.Name = "per2016";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(762, 324);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(93, 64);
            this.clear_button.TabIndex = 81;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(663, 324);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(93, 64);
            this.Search_Button.TabIndex = 80;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(565, 324);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(93, 64);
            this.UpdateButton.TabIndex = 79;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(466, 324);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(93, 64);
            this.Delete_button.TabIndex = 78;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(367, 324);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(93, 64);
            this.Button_Add.TabIndex = 77;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click_1);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(930, -1);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(61, 53);
            this.Exit_btn.TabIndex = 82;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gebied:";
            // 
            // gebied_Dropdown
            // 
            this.gebied_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gebied_Dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebied_Dropdown.FormattingEnabled = true;
            this.gebied_Dropdown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.gebied_Dropdown.Location = new System.Drawing.Point(265, 104);
            this.gebied_Dropdown.Name = "gebied_Dropdown";
            this.gebied_Dropdown.Size = new System.Drawing.Size(217, 33);
            this.gebied_Dropdown.TabIndex = 1;
            this.gebied_Dropdown.SelectedIndexChanged += new System.EventHandler(this.gebied_Dropdown_SelectedIndexChanged);
            this.gebied_Dropdown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gebied_Dropdown_MouseDown);
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(861, 324);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(93, 64);
            this.show_btn.TabIndex = 83;
            this.show_btn.Text = "Clear";
            this.show_btn.UseVisualStyleBackColor = true;
            // 
            // addData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 716);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Addperc_Datagrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Perc2014);
            this.Controls.Add(this.Perc2016);
            this.Controls.Add(this.Perc2015);
            this.Controls.Add(this.Perc2013);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scid);
            this.Controls.Add(this.SCategorie_Combobox);
            this.Controls.Add(this.Hcategorie_Combobox);
            this.Controls.Add(this.Wijk_dropdown);
            this.Controls.Add(this.gebied_Dropdown);
            this.Controls.Add(this.SCID_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addData";
            this.Text = "addData";
            this.Load += new System.EventHandler(this.addData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Addperc_Datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SCID_Text;
        private System.Windows.Forms.ComboBox Wijk_dropdown;
        private System.Windows.Forms.ComboBox Hcategorie_Combobox;
        private System.Windows.Forms.ComboBox SCategorie_Combobox;
        private System.Windows.Forms.Label scid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Perc2013;
        private System.Windows.Forms.TextBox Perc2015;
        private System.Windows.Forms.TextBox Perc2016;
        private System.Windows.Forms.TextBox Perc2014;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Addperc_Datagrid;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.PictureBox Exit_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox gebied_Dropdown;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCIDcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WijkCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HcatCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCatCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn per2013;
        private System.Windows.Forms.DataGridViewTextBoxColumn per2014;
        private System.Windows.Forms.DataGridViewTextBoxColumn per2015;
        private System.Windows.Forms.DataGridViewTextBoxColumn per2016;
        private System.Windows.Forms.Button show_btn;
    }
}