using System.Text;

namespace Exercise_3
{
    public partial class Form1 : Form
    {
        public string TextBox_ReadFile
        {
            get { return textBoxReadFile.Text; }
            set { textBoxReadFile.Text = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All Files(*.*)|*.*|Txt files(*.txt)|*.txt";
            file.FilterIndex = 2;
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(file.FileName, Encoding.Default);
                textBoxReadFile.Clear();
                textBoxReadFile.Text = reader.ReadToEnd();
                reader.Close();
                btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
    }
}