using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Exercise_2
{
    public partial class Form1 : Form
    {
        public double AllPrise { get; set; } = 0;
        List<Product>? product = null;
        public Form1()
        {
            InitializeComponent();
            product = new List<Product>();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            try
            {
                ProductList.Items.Add(((Product)productStock.Items[productStock.SelectedIndex]).ToString());
                AllPrise += ((Product)productStock.Items[productStock.SelectedIndex]).Price;
                if (ProductList.Items.Count > 0)
                {
                    allPriceProductLabel2.Visible = false;
                    allPriceProductLabel.Visible = true;
                    allPriceProduct.Visible = true;
                    labelAllPriceProduct.Visible = true;
                }
                allPriceProduct.Text = AllPrise.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали товар!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void productStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceProduct.Text = ((Product)productStock.Items[productStock.SelectedIndex]).Price.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            product.Add(new Product());
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            Form2 form2 = new Form2(true, product[product.Count - 1]);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                productStock.Items.Add(product[product.Count - 1]);
                groupBoxProduct.Text = $"Товары в наличии {productStock.Items.Count}";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int tempNum = productStock.SelectedIndex;
                Product tempProduct = (Product)productStock.Items[tempNum];
                Form2 form2 = new Form2(false, tempProduct);
                form2.ShowDialog();
                productStock.Items.RemoveAt(tempNum);
                productStock.Items.Insert(tempNum, tempProduct);
                productStock.SelectedIndex = tempNum;
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали товар!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}