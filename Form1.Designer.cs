namespace Site_Maker_2
{
    partial class Form1
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
            this.button_CreateCode = new System.Windows.Forms.Button();
            this.button_chooseFile = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.label_path = new System.Windows.Forms.Label();
            this.label_WhatIsIt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomPoKat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NominalMarki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVvoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opisanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton_allNew = new System.Windows.Forms.RadioButton();
            this.radioButton_selectNumbers = new System.Windows.Forms.RadioButton();
            this.panel_allNew = new System.Windows.Forms.Panel();
            this.panel_selecting = new System.Windows.Forms.Panel();
            this.label_sumOfNewItems = new System.Windows.Forms.Label();
            this.button_Settings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_allNew.SuspendLayout();
            this.panel_selecting.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CreateCode
            // 
            this.button_CreateCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CreateCode.Location = new System.Drawing.Point(378, 533);
            this.button_CreateCode.Name = "button_CreateCode";
            this.button_CreateCode.Size = new System.Drawing.Size(145, 27);
            this.button_CreateCode.TabIndex = 0;
            this.button_CreateCode.Text = "Создать код";
            this.button_CreateCode.UseVisualStyleBackColor = true;
            this.button_CreateCode.Visible = false;
            this.button_CreateCode.Click += new System.EventHandler(this.button_CreateCode_Click);
            // 
            // button_chooseFile
            // 
            this.button_chooseFile.BackColor = System.Drawing.Color.Green;
            this.button_chooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_chooseFile.Location = new System.Drawing.Point(21, 42);
            this.button_chooseFile.Name = "button_chooseFile";
            this.button_chooseFile.Size = new System.Drawing.Size(235, 37);
            this.button_chooseFile.TabIndex = 1;
            this.button_chooseFile.Text = "Выберите необходимый файл";
            this.button_chooseFile.UseVisualStyleBackColor = false;
            this.button_chooseFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_path.ForeColor = System.Drawing.Color.Green;
            this.label_path.Location = new System.Drawing.Point(28, 90);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(47, 15);
            this.label_path.TabIndex = 2;
            this.label_path.Text = "label1";
            this.label_path.Visible = false;
            // 
            // label_WhatIsIt
            // 
            this.label_WhatIsIt.AutoSize = true;
            this.label_WhatIsIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_WhatIsIt.ForeColor = System.Drawing.Color.Green;
            this.label_WhatIsIt.Location = new System.Drawing.Point(366, 150);
            this.label_WhatIsIt.Name = "label_WhatIsIt";
            this.label_WhatIsIt.Size = new System.Drawing.Size(166, 31);
            this.label_WhatIsIt.TabIndex = 3;
            this.label_WhatIsIt.Text = "КонвМарки";
            this.label_WhatIsIt.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomPoKat,
            this.NominalMarki,
            this.DataVvoda,
            this.Opisanie,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(12, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 319);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // NomPoKat
            // 
            this.NomPoKat.HeaderText = "№ по кат.";
            this.NomPoKat.Name = "NomPoKat";
            this.NomPoKat.Width = 70;
            // 
            // NominalMarki
            // 
            this.NominalMarki.HeaderText = "Номинал марки";
            this.NominalMarki.Name = "NominalMarki";
            this.NominalMarki.Width = 70;
            // 
            // DataVvoda
            // 
            this.DataVvoda.HeaderText = "Дата ввода в обр.";
            this.DataVvoda.Name = "DataVvoda";
            // 
            // Opisanie
            // 
            this.Opisanie.HeaderText = "Краткое описание";
            this.Opisanie.Name = "Opisanie";
            this.Opisanie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Opisanie.Width = 500;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена, $США";
            this.Price.Name = "Price";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(14, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // radioButton_allNew
            // 
            this.radioButton_allNew.AutoSize = true;
            this.radioButton_allNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_allNew.ForeColor = System.Drawing.Color.Green;
            this.radioButton_allNew.Location = new System.Drawing.Point(372, 52);
            this.radioButton_allNew.Name = "radioButton_allNew";
            this.radioButton_allNew.Size = new System.Drawing.Size(88, 17);
            this.radioButton_allNew.TabIndex = 6;
            this.radioButton_allNew.Text = "Все новые";
            this.radioButton_allNew.UseVisualStyleBackColor = true;
            this.radioButton_allNew.Visible = false;
            this.radioButton_allNew.CheckedChanged += new System.EventHandler(this.radioButton_allNew_CheckedChanged);
            // 
            // radioButton_selectNumbers
            // 
            this.radioButton_selectNumbers.AutoSize = true;
            this.radioButton_selectNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_selectNumbers.ForeColor = System.Drawing.Color.Green;
            this.radioButton_selectNumbers.Location = new System.Drawing.Point(466, 53);
            this.radioButton_selectNumbers.Name = "radioButton_selectNumbers";
            this.radioButton_selectNumbers.Size = new System.Drawing.Size(90, 17);
            this.radioButton_selectNumbers.TabIndex = 7;
            this.radioButton_selectNumbers.Text = "Выборочно";
            this.radioButton_selectNumbers.UseVisualStyleBackColor = true;
            this.radioButton_selectNumbers.Visible = false;
            // 
            // panel_allNew
            // 
            this.panel_allNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_allNew.Controls.Add(this.panel_selecting);
            this.panel_allNew.Controls.Add(this.label_sumOfNewItems);
            this.panel_allNew.Location = new System.Drawing.Point(372, 75);
            this.panel_allNew.Name = "panel_allNew";
            this.panel_allNew.Size = new System.Drawing.Size(200, 80);
            this.panel_allNew.TabIndex = 8;
            this.panel_allNew.Visible = false;
            // 
            // panel_selecting
            // 
            this.panel_selecting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_selecting.Controls.Add(this.textBox1);
            this.panel_selecting.Location = new System.Drawing.Point(157, 3);
            this.panel_selecting.Name = "panel_selecting";
            this.panel_selecting.Size = new System.Drawing.Size(200, 80);
            this.panel_selecting.TabIndex = 9;
            this.panel_selecting.Visible = false;
            // 
            // label_sumOfNewItems
            // 
            this.label_sumOfNewItems.AutoSize = true;
            this.label_sumOfNewItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sumOfNewItems.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_sumOfNewItems.Location = new System.Drawing.Point(3, 3);
            this.label_sumOfNewItems.Name = "label_sumOfNewItems";
            this.label_sumOfNewItems.Size = new System.Drawing.Size(0, 13);
            this.label_sumOfNewItems.TabIndex = 9;
            // 
            // button_Settings
            // 
            this.button_Settings.BackgroundImage = global::Site_Maker_2.Properties.Resources.settings;
            this.button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings.Location = new System.Drawing.Point(851, 12);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(45, 45);
            this.button_Settings.TabIndex = 9;
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(908, 585);
            this.Controls.Add(this.button_Settings);
            this.Controls.Add(this.panel_allNew);
            this.Controls.Add(this.radioButton_selectNumbers);
            this.Controls.Add(this.radioButton_allNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_WhatIsIt);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.button_chooseFile);
            this.Controls.Add(this.button_CreateCode);
            this.Name = "Form1";
            this.Text = "Professional site creation tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_allNew.ResumeLayout(false);
            this.panel_allNew.PerformLayout();
            this.panel_selecting.ResumeLayout(false);
            this.panel_selecting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_chooseFile;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.Label label_WhatIsIt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton_allNew;
        private System.Windows.Forms.RadioButton radioButton_selectNumbers;
        private System.Windows.Forms.Panel panel_allNew;
        private System.Windows.Forms.Panel panel_selecting;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label_sumOfNewItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPoKat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NominalMarki;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVvoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opisanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        public System.Windows.Forms.Button button_CreateCode;
        private System.Windows.Forms.Button button_Settings;
    }
}

