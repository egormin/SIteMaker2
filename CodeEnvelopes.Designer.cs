namespace Site_Maker_2
{
    partial class CodeEnvelopes
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
            this.codeEnvelopesForm_label_text_header = new System.Windows.Forms.Label();
            this.CodeEnvelopesForm_textbox_list = new System.Windows.Forms.TextBox();
            this.CodeEnvelopesForm_textbox_year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodeEnvelopesForm_Button_ListCopy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codeEnvelopesForm_label_text_header
            // 
            this.codeEnvelopesForm_label_text_header.AutoSize = true;
            this.codeEnvelopesForm_label_text_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeEnvelopesForm_label_text_header.ForeColor = System.Drawing.Color.Green;
            this.codeEnvelopesForm_label_text_header.Location = new System.Drawing.Point(157, 31);
            this.codeEnvelopesForm_label_text_header.Name = "codeEnvelopesForm_label_text_header";
            this.codeEnvelopesForm_label_text_header.Size = new System.Drawing.Size(422, 31);
            this.codeEnvelopesForm_label_text_header.TabIndex = 0;
            this.codeEnvelopesForm_label_text_header.Text = "Создание кода для конвертов";
            // 
            // CodeEnvelopesForm_textbox_list
            // 
            this.CodeEnvelopesForm_textbox_list.Location = new System.Drawing.Point(12, 82);
            this.CodeEnvelopesForm_textbox_list.Multiline = true;
            this.CodeEnvelopesForm_textbox_list.Name = "CodeEnvelopesForm_textbox_list";
            this.CodeEnvelopesForm_textbox_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CodeEnvelopesForm_textbox_list.Size = new System.Drawing.Size(798, 170);
            this.CodeEnvelopesForm_textbox_list.TabIndex = 1;
            // 
            // CodeEnvelopesForm_textbox_year
            // 
            this.CodeEnvelopesForm_textbox_year.Location = new System.Drawing.Point(12, 281);
            this.CodeEnvelopesForm_textbox_year.Multiline = true;
            this.CodeEnvelopesForm_textbox_year.Name = "CodeEnvelopesForm_textbox_year";
            this.CodeEnvelopesForm_textbox_year.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CodeEnvelopesForm_textbox_year.Size = new System.Drawing.Size(798, 358);
            this.CodeEnvelopesForm_textbox_year.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Код для файла List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(12, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Код для файла по годам";
            // 
            // CodeEnvelopesForm_Button_ListCopy
            // 
            this.CodeEnvelopesForm_Button_ListCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CodeEnvelopesForm_Button_ListCopy.Location = new System.Drawing.Point(708, 57);
            this.CodeEnvelopesForm_Button_ListCopy.Name = "CodeEnvelopesForm_Button_ListCopy";
            this.CodeEnvelopesForm_Button_ListCopy.Size = new System.Drawing.Size(100, 20);
            this.CodeEnvelopesForm_Button_ListCopy.TabIndex = 5;
            this.CodeEnvelopesForm_Button_ListCopy.Text = "Скопировать";
            this.CodeEnvelopesForm_Button_ListCopy.UseVisualStyleBackColor = false;
            this.CodeEnvelopesForm_Button_ListCopy.Click += new System.EventHandler(this.CodeEnvelopesForm_Button_ListCopy_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(709, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "Скопировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CodeEnvelopes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(822, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CodeEnvelopesForm_Button_ListCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodeEnvelopesForm_textbox_year);
            this.Controls.Add(this.CodeEnvelopesForm_textbox_list);
            this.Controls.Add(this.codeEnvelopesForm_label_text_header);
            this.Name = "CodeEnvelopes";
            this.Text = "Конструктор кода для конвертов";
            this.Load += new System.EventHandler(this.CodeEnvelopes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codeEnvelopesForm_label_text_header;
        private System.Windows.Forms.TextBox CodeEnvelopesForm_textbox_list;
        private System.Windows.Forms.TextBox CodeEnvelopesForm_textbox_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CodeEnvelopesForm_Button_ListCopy;
        private System.Windows.Forms.Button button1;
    }
}