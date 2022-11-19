namespace Hom_Worc_Windows_Forms_Meeting_5
{
    partial class Form2
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
            this.btnSearchF2 = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBoxF2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchF2
            // 
            this.btnSearchF2.Location = new System.Drawing.Point(263, 348);
            this.btnSearchF2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchF2.Name = "btnSearchF2";
            this.btnSearchF2.Size = new System.Drawing.Size(100, 35);
            this.btnSearchF2.TabIndex = 1;
            this.btnSearchF2.Text = "Поиск";
            this.btnSearchF2.UseMnemonic = false;
            this.btnSearchF2.UseVisualStyleBackColor = true;
            this.btnSearchF2.Click += new System.EventHandler(this.btnSearchF2_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(377, 304);
            this.listBox.TabIndex = 2;
            // 
            // textBoxF2
            // 
            this.textBoxF2.Location = new System.Drawing.Point(17, 351);
            this.textBoxF2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxF2.Name = "textBoxF2";
            this.textBoxF2.Size = new System.Drawing.Size(236, 27);
            this.textBoxF2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вводите маску поиска, например «*.doc».";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxF2);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnSearchF2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно поиска";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchF2;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBoxF2;
        private System.Windows.Forms.Label label1;
    }
}