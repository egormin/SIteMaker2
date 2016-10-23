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
    public partial class CodeEnvelopes : Form
    {


        public CodeEnvelopes()
        {
            InitializeComponent();
            
        }

        public T GetForm<T>() where T : Form
        {
            return (T)Application.OpenForms[typeof(T).Name];
        }       
        
        
        private void CodeForListCreation(string [] valArr)
        {
            //Код для всего списка
            CodeEnvelopesForm_textbox_list.Text += " <tr align=\"center\">\r\n";
            CodeEnvelopesForm_textbox_list.Text += "    <td width=\"70px\">" + valArr[0] + "</td>\r\n";
            CodeEnvelopesForm_textbox_list.Text += "    <td width=\"110px\">" + valArr[1] + "</td>\r\n";
            CodeEnvelopesForm_textbox_list.Text += "    <td width=\"110px\">" + valArr[2] + "</td>\r\n";
            CodeEnvelopesForm_textbox_list.Text += "    <td align=\"left\">" + valArr[3] + "</td>\r\n";
            CodeEnvelopesForm_textbox_list.Text += "    <td width=\"50px\">" + valArr[4] + "</td>\r\n";
            CodeEnvelopesForm_textbox_list.Text += " </tr>\r\n";
            CodeEnvelopesForm_textbox_list.Text += "\r\n";


        }

        private void CodeForYearsCreation(string[] valArr)
        {
            //Код для списка по годам
            CodeEnvelopesForm_textbox_year.Text += "  <tr align=\"center\">\r\n";
            CodeEnvelopesForm_textbox_year.Text += "    <td width=\"70px\">" + valArr[0] + "</td>\r\n";
            CodeEnvelopesForm_textbox_year.Text += "    <td width=\"110px\">" + valArr[1] + "</td>\r\n";
            CodeEnvelopesForm_textbox_year.Text += "    <td width=\"110px\">" + valArr[2] + "</td>\r\n";
            CodeEnvelopesForm_textbox_year.Text += "    <td align=\"left\">" + valArr[3] + "</td>\r\n";
            CodeEnvelopesForm_textbox_year.Text += "    <td width=\"50px\">" + valArr[4] + "</td>\r\n";
            CodeEnvelopesForm_textbox_year.Text += "    <td width=\"140\" align=\"center\">\r\n";
            CodeEnvelopesForm_textbox_year.Text += "       <a class=\"gallery2\" rel=\"group\" title=\"" + valArr[3] + "\" href=\"pic/" + valArr[2].Substring(6) + "/" + valArr[0] + ".jpg\">\r\n";
            CodeEnvelopesForm_textbox_year.Text += "       <img src=\"pic/" + valArr[2].Substring(6) + "/" + valArr[0] + ".jpg\"" + ImageSizer("конверты", valArr[0], valArr[2]) + " border=\"0\" alt=\"" + valArr[3] + "\"></a>\r\n";
            CodeEnvelopesForm_textbox_year.Text += "    </td>\r\n";
            CodeEnvelopesForm_textbox_year.Text += "  </tr>\r\n";
            CodeEnvelopesForm_textbox_year.Text += "\r\n";
        }


        //Рассчитывает нужные размеры для изображений
        static string ImageSizer(string tovar, string nomerPoKAt, string date)
        {
            int maxSize = 0;
            string imgPath;
            switch (tovar)
            {
                case "марки":
                    {
                        maxSize = 140;
                        break;
                    }
                case "главная":
                    {
                        maxSize = 80;
                        break;
                    }
                case "конверты":
                    {
                        //var frm2 = GetForm<Form2>();
                        LoadDataFromConfig inst_LoadDataFromConfig = new LoadDataFromConfig();
                        string pathes = inst_LoadDataFromConfig.meth_LoadDataFromConfig();
                        string[] pathes_array = pathes.Split('#');


                        imgPath = pathes_array[0] + "\\" + date.Substring(6) + "\\" + nomerPoKAt + ".jpg";
                        Image newImage = Image.FromFile(imgPath);
                        if (newImage.Width < 500)
                            return " width=\"140\" height=\"100\"";
                        else
                            return " width=\"140\" height=\"70\"";
                    }
            }

            imgPath = "d:/" + date.Substring(6) + "/" + nomerPoKAt + ".jpg";


                if (System.IO.File.Exists(imgPath)) 
            {
                Image newImage = Image.FromFile(imgPath);
                float verRes = newImage.Height;
                float horRes = newImage.Width;
                float rate = 0;
                float hor = 0;

                if (horRes >= verRes)
                {
                    rate = horRes / verRes;
                    hor = maxSize / rate;
                    return " width=\"" + maxSize + "\" height=\"" + (int)hor + "\"";
                }
                else
                {
                    rate = verRes / horRes;
                    float ver = maxSize / rate;
                    return " width=\"" + (int)ver + "\" height=\"" + maxSize + "\"";
                }
            }
            else
            {
                MessageBox.Show("Нет изображения");
                return "width=\"0\" height=\"0\"";
            }
        }



        private void CodeEnvelopes_Load(object sender, EventArgs e)
        {
            var frm = GetForm<Form1>();

            for (int i = 0; i < frm.dataGridView1.RowCount; i++)
            {
                string dataRow = "";
                for (int j = 0; j < frm.dataGridView1.ColumnCount; j++)
                {
                    dataRow += (frm.dataGridView1.Rows[i].Cells[j].Value.ToString()).Trim() + "##";
                }
                string[] valuesArray = dataRow.Split(new string[] { "##" }, StringSplitOptions.RemoveEmptyEntries);
                CodeForListCreation(valuesArray);
                CodeForYearsCreation(valuesArray);


            }
        }

       
        private void CodeEnvelopesForm_Button_ListCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CodeEnvelopesForm_textbox_list.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CodeEnvelopesForm_textbox_year.Text);
        }
    }
}
