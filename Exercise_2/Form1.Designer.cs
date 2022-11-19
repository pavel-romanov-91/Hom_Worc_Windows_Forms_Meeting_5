namespace Exercise_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.priceProduct = new System.Windows.Forms.TextBox();
            this.productStock = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.allPriceProduct = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.allPriceProductLabel = new System.Windows.Forms.Label();
            this.allPriceProductLabel2 = new System.Windows.Forms.Label();
            this.labelAllPriceProduct = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ProductList.ColumnWidth = 290;
            this.ProductList.FormattingEnabled = true;
            this.ProductList.IntegralHeight = false;
            this.ProductList.ItemHeight = 20;
            this.ProductList.Location = new System.Drawing.Point(0, 0);
            this.ProductList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(421, 444);
            this.ProductList.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 43);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(192, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить товар";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // priceProduct
            // 
            this.priceProduct.Enabled = false;
            this.priceProduct.Location = new System.Drawing.Point(28, 86);
            this.priceProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.ReadOnly = true;
            this.priceProduct.Size = new System.Drawing.Size(151, 27);
            this.priceProduct.TabIndex = 3;
            this.priceProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productStock
            // 
            this.productStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.productStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productStock.FormattingEnabled = true;
            this.productStock.Location = new System.Drawing.Point(28, 45);
            this.productStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productStock.Name = "productStock";
            this.productStock.Size = new System.Drawing.Size(191, 28);
            this.productStock.TabIndex = 4;
            this.productStock.SelectedIndexChanged += new System.EventHandler(this.productStock_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(28, 85);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(192, 32);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Редактировать товар";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(28, 126);
            this.btnAddList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(192, 32);
            this.btnAddList.TabIndex = 6;
            this.btnAddList.Text = "Добавить в список";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // allPriceProduct
            // 
            this.allPriceProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allPriceProduct.Location = new System.Drawing.Point(459, 43);
            this.allPriceProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allPriceProduct.Name = "allPriceProduct";
            this.allPriceProduct.ReadOnly = true;
            this.allPriceProduct.Size = new System.Drawing.Size(152, 20);
            this.allPriceProduct.TabIndex = 8;
            this.allPriceProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.allPriceProduct.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Location = new System.Drawing.Point(431, 295);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(245, 151);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.label1);
            this.groupBoxProduct.Controls.Add(this.productStock);
            this.groupBoxProduct.Controls.Add(this.priceProduct);
            this.groupBoxProduct.Controls.Add(this.btnAddList);
            this.groupBoxProduct.Location = new System.Drawing.Point(431, 83);
            this.groupBoxProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxProduct.Size = new System.Drawing.Size(245, 182);
            this.groupBoxProduct.TabIndex = 10;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Товары";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "руб.";
            // 
            // allPriceProductLabel
            // 
            this.allPriceProductLabel.AutoSize = true;
            this.allPriceProductLabel.Location = new System.Drawing.Point(472, 14);
            this.allPriceProductLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.allPriceProductLabel.Name = "allPriceProductLabel";
            this.allPriceProductLabel.Size = new System.Drawing.Size(169, 20);
            this.allPriceProductLabel.TabIndex = 11;
            this.allPriceProductLabel.Text = "Цена товаров в списке";
            this.allPriceProductLabel.Visible = false;
            // 
            // allPriceProductLabel2
            // 
            this.allPriceProductLabel2.AutoSize = true;
            this.allPriceProductLabel2.Location = new System.Drawing.Point(472, 34);
            this.allPriceProductLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.allPriceProductLabel2.Name = "allPriceProductLabel2";
            this.allPriceProductLabel2.Size = new System.Drawing.Size(158, 20);
            this.allPriceProductLabel2.TabIndex = 12;
            this.allPriceProductLabel2.Text = "Товаров в списке нет";
            // 
            // labelAllPriceProduct
            // 
            this.labelAllPriceProduct.AutoSize = true;
            this.labelAllPriceProduct.Location = new System.Drawing.Point(619, 48);
            this.labelAllPriceProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAllPriceProduct.Name = "labelAllPriceProduct";
            this.labelAllPriceProduct.Size = new System.Drawing.Size(37, 20);
            this.labelAllPriceProduct.TabIndex = 14;
            this.labelAllPriceProduct.Text = "руб.";
            this.labelAllPriceProduct.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 446);
            this.Controls.Add(this.labelAllPriceProduct);
            this.Controls.Add(this.allPriceProductLabel2);
            this.Controls.Add(this.allPriceProductLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.allPriceProduct);
            this.Controls.Add(this.ProductList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет продаж";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox priceProduct;
        private System.Windows.Forms.ComboBox productStock;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.TextBox allPriceProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.Label allPriceProductLabel;
        private System.Windows.Forms.Label allPriceProductLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAllPriceProduct;
    }
}