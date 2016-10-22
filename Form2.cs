using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Site_Maker_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Checking_Procession(int value)
        {
            List<CheckBox> CB_list = new List<CheckBox>();
            CB_list.Add(checkBox1);
            CB_list.Add(checkBox2);
            CB_list.Add(checkBox3);

            List<TextBox> TB_list = new List<TextBox>();
            TB_list.Add(textBox1);
            TB_list.Add(textBox2);
            TB_list.Add(textBox3);


            if (CB_list[value - 1].CheckState == CheckState.Checked)
            {
                TB_list[value - 1].BackColor = System.Drawing.SystemColors.Window;
                TB_list[value - 1].ReadOnly = false;

                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "Выберите папку с изображениями";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    TB_list[value - 1].Text = dialog.SelectedPath;
                }
            }
            else
            {
                TB_list[value - 1].BackColor = System.Drawing.SystemColors.ScrollBar;
                TB_list[value - 1].ReadOnly = true;
            }


         

           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Checking_Procession(1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Checking_Procession(2);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Checking_Procession(3);
        }



private void frm2_button_Save_Click(object sender, EventArgs e)
        {
            Configuration_XML inst_Configuration_XML = new Configuration_XML();
            inst_Configuration_XML.meth_Configuration_XML(textBox1.Text,textBox2.Text,textBox3.Text);
        }
    }
}
