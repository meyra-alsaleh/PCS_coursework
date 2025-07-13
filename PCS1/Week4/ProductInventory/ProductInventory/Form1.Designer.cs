namespace ProductInventory
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
            gbInfo = new GroupBox();
            lblProductInfo = new Label();
            btnGetInfo = new Button();
            lblProductTitle = new Label();
            lblName = new Label();
            lblPrice = new Label();
            tbName = new TextBox();
            tbPrice = new TextBox();
            btnSetInStock = new Button();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            button1 = new Button();
            lblTotalPrice = new Label();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // gbInfo
            // 
            gbInfo.BackColor = SystemColors.ControlLight;
            gbInfo.Controls.Add(lblProductInfo);
            gbInfo.Location = new Point(624, 50);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(491, 469);
            gbInfo.TabIndex = 0;
            gbInfo.TabStop = false;
            // 
            // lblProductInfo
            // 
            lblProductInfo.AutoSize = true;
            lblProductInfo.Location = new Point(35, 63);
            lblProductInfo.Name = "lblProductInfo";
            lblProductInfo.Size = new Size(182, 41);
            lblProductInfo.TabIndex = 0;
            lblProductInfo.Text = "Product Info";
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(624, 546);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(491, 77);
            btnGetInfo.TabIndex = 1;
            btnGetInfo.Text = "Get Product Information";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // lblProductTitle
            // 
            lblProductTitle.AutoSize = true;
            lblProductTitle.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductTitle.Location = new Point(27, 50);
            lblProductTitle.Name = "lblProductTitle";
            lblProductTitle.Size = new Size(355, 50);
            lblProductTitle.TabIndex = 2;
            lblProductTitle.Text = "Product Information";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(53, 132);
            lblName.Name = "lblName";
            lblName.Size = new Size(112, 41);
            lblName.TabIndex = 3;
            lblName.Text = "Name: ";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(53, 217);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(97, 41);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price: ";
            // 
            // tbName
            // 
            tbName.Location = new Point(212, 132);
            tbName.Name = "tbName";
            tbName.Size = new Size(343, 47);
            tbName.TabIndex = 5;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(212, 217);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(343, 47);
            tbPrice.TabIndex = 6;
            // 
            // btnSetInStock
            // 
            btnSetInStock.Location = new Point(53, 296);
            btnSetInStock.Name = "btnSetInStock";
            btnSetInStock.Size = new Size(502, 71);
            btnSetInStock.TabIndex = 8;
            btnSetInStock.Text = "Set In-stock";
            btnSetInStock.UseVisualStyleBackColor = true;
            btnSetInStock.Click += btnSetInStock_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(59, 401);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(147, 41);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity: ";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(212, 401);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(125, 47);
            numQuantity.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(59, 477);
            button1.Name = "button1";
            button1.Size = new Size(502, 66);
            button1.TabIndex = 11;
            button1.Text = "Calculate Total Price";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(59, 582);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(168, 41);
            lblTotalPrice.TabIndex = 12;
            lblTotalPrice.Text = "Total Price: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 654);
            Controls.Add(lblTotalPrice);
            Controls.Add(button1);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(btnSetInStock);
            Controls.Add(tbPrice);
            Controls.Add(tbName);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(lblProductTitle);
            Controls.Add(btnGetInfo);
            Controls.Add(gbInfo);
            Name = "Form1";
            Text = "Inventory";
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbInfo;
        private Label lblProductInfo;
        private Button btnGetInfo;
        private Label lblProductTitle;
        private Label lblName;
        private Label lblPrice;
        private TextBox tbName;
        private TextBox tbPrice;
        private Button btnSetInStock;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Button button1;
        private Label lblTotalPrice;
    }
}
