using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_3
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 f)
        {
            InitializeComponent();
            form1 = f;
         }

        private void btnSave_Click(object sender, EventArgs e)
        {
            form1.TextBox_ReadFile = textBoxWriterFile.Text;//изменяем значение текстового поля первой формы

            //сохраняем файл(если не нужно то закомментировать блок)
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All Files(*.*)|*.*|Txt files(*.txt)|*.txt";
            save.FilterIndex = 2;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName, false, Encoding.Default);
                writer.Write(textBoxWriterFile.Text);
                writer.Close();
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
