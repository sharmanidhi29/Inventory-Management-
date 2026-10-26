namespace InventoryManagement
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
            label1 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            txtQuantity = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            btnAddProduct = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(136, 33);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(309, 23);
            txtProductName.TabIndex = 1;
            txtProductName.Text = "f4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 72);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(136, 72);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(309, 23);
            txtQuantity.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 119);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(136, 119);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(309, 23);
            txtPrice.TabIndex = 5;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(206, 181);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 23);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(316, 181);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnAddProduct);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private Label label2;
        private TextBox txtQuantity;
        private Label label3;
        private TextBox txtPrice;
        private Button btnAddProduct;
        private Button btnClear;
    }
}
