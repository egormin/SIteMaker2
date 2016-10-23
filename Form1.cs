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
    public partial class Form1 : Form
    {
        public string[] pathes_array;
        public Form1()
        {
            InitializeComponent();
            if (!System.IO.File.Exists("configuration.xml"))
            {
                //button_Settings.PerformClick();

                //MessageBox.Show("Не создан файл конфигурации, необходимо его создать", "Внимание!");

            }


           
        }

        //Проверка наличия конфигурационного файла
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists("configuration.xml"))
            {
                MessageBox.Show("Не создан файл конфигурации, необходимо его создать", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button_Settings.PerformClick();
            }
            //else
            //{
               
            //}
        }

      

        private void button2_Click(object sender, EventArgs e)
        {           
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MS Word 2003 (*.doc)|*.doc|MS Word 2007 (*.docx)|*.docx";
            dialog.Title = "Выберите документ для загрузки данных";
 
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                radioButton_allNew.Visible = true;
                radioButton_selectNumbers.Visible = true;
                label_sumOfNewItems.Visible = true;        

                label_path.Text = dialog.FileName;
                label_path.Visible = true;
                //По названию файла опредеяем, с чем имеем дело (марки, конверты и т.д.)
                string[] pathArray = label_path.Text.Split('\\');
                switch(pathArray[pathArray.Length-1])
                {
                    case "All_envelopes.doc":
                        {
                            label_WhatIsIt.Text = "Конверты";
                            label_WhatIsIt.Visible = true;
                            break;
                        }
                }


               





        


            }
        }

        private void radioButton_allNew_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_allNew.Checked == true)
            {
                panel_allNew.Visible = true;
                panel_selecting.Visible = false;

                Show_New_Items inst_Show_New_Items = new Show_New_Items();
                inst_Show_New_Items.meth_Show_New_Items(label_path.Text);
            }
            else
            { 
                panel_selecting.Visible = true;
                panel_allNew.Visible = false;
            }
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            Configuration inst_Configuration = new Configuration();
            inst_Configuration.meth_Configuration();
            Configuration_XML inst_Configuration_XML = new Configuration_XML();
        }

        private void button_CreateCode_Click(object sender, EventArgs e)
        {

            if (label_WhatIsIt.Text == "Конверты")
            {
                EnvelopesCodeCreation inst_EnvelopesCodeCreation = new EnvelopesCodeCreation();
                inst_EnvelopesCodeCreation.meth_EnvelopesCodeCreation();
            }
        }
    }
}
