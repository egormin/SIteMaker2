using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace Site_Maker_2
{
    class Show_New_Items
    {
        //Для доступа к элементам формы из этого класса
        public T GetForm<T>() where T : Form
        {
            return (T)Application.OpenForms[typeof(T).Name];
        }

        public void meth_Show_New_Items(string path)
        {
            //Для доступа к элементам формы из этого класса
            var frm = GetForm<Form1>();

            frm.dataGridView1.Rows.Clear();
            frm.dataGridView1.Visible = true;

            Word.Application wordap = new Word.Application();
            Word.Document doc = wordap.Documents.Open(path);
            Word.Document document = wordap.ActiveDocument;
            Word.Table table = document.Tables[1];
            int dd = table.Rows.Count;


            for (int i = table.Rows.Count - 5; i < table.Rows.Count; i++)
            {
                string value = "";
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    string fff = Convert.ToString(table.Cell(i + 1, j + 1).Range.Font.Color);
                    if (table.Cell(i+1, j+1).Range.Font.Color== Word.WdColor.wdColorRed)
                    {
                        value += table.Cell(i + 1, j + 1).Range.Text.Trim('\a', '\r', '\n', '\t') + "##";
                    }                   
                }

                if (value!="")
                  {       
                     string[] znacheniyaPoStolbcam = value.Split(new string[] { "##" }, StringSplitOptions.RemoveEmptyEntries);
                     frm.dataGridView1.Rows.Add(znacheniyaPoStolbcam[0], znacheniyaPoStolbcam[1], znacheniyaPoStolbcam[2], znacheniyaPoStolbcam[3], znacheniyaPoStolbcam[4]);
                  }

            }
              wordap.Quit();

            frm.label_sumOfNewItems.Text=frm.dataGridView1.RowCount + " новых конвертов";
            frm.button_CreateCode.Visible = true;

        }

    }
}
