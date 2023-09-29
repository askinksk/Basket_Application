namespace Project1
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
            lbxProducts = new ListBox();
            lblProducts = new Label();
            btnAddToCart = new Button();
            lbxCart = new ListBox();
            lblCart = new Label();
            btnRemoveFromCart = new Button();
            SuspendLayout();
            // 
            // lbxProducts
            // 
            lbxProducts.FormattingEnabled = true;
            lbxProducts.ItemHeight = 21;
            lbxProducts.Location = new Point(13, 46);
            lbxProducts.Margin = new Padding(4);
            lbxProducts.Name = "lbxProducts";
            lbxProducts.Size = new Size(206, 277);
            lbxProducts.TabIndex = 0;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(52, 21);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(0, 21);
            lblProducts.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(226, 46);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(122, 38);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "Ekle";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lbxCart
            // 
            lbxCart.FormattingEnabled = true;
            lbxCart.ItemHeight = 21;
            lbxCart.Location = new Point(354, 46);
            lbxCart.Name = "lbxCart";
            lbxCart.Size = new Size(169, 277);
            lbxCart.TabIndex = 3;
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.Location = new Point(430, 21);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(52, 21);
            lblCart.TabIndex = 4;
            lblCart.Text = "label1";
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new Point(529, 46);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(147, 38);
            btnRemoveFromCart.TabIndex = 5;
            btnRemoveFromCart.Text = "button1";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 476);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(lblCart);
            Controls.Add(lbxCart);
            Controls.Add(btnAddToCart);
            Controls.Add(lblProducts);
            Controls.Add(lbxProducts);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxProducts;
        private Label lblProducts;
        private Button btnAddToCart;
        private ListBox lbxCart;
        private Label lblCart;
        private Button btnRemoveFromCart;
    }
}