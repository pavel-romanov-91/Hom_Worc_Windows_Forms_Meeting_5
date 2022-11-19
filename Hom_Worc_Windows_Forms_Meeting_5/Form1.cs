namespace Hom_Worc_Windows_Forms_Meeting_5
{
    public partial class Form1 : Form
    {
        Form2? form2 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}