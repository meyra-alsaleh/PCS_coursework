namespace TruckManagement
{
    partial class Form1
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbBoxesPerPallet = new System.Windows.Forms.TextBox();
            this.blbBoxesPerPallet = new System.Windows.Forms.Label();
            this.tbTruckCapacity = new System.Windows.Forms.TextBox();
            this.lblTruckCapacity = new System.Windows.Forms.Label();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.lblRemainingBoxes = new System.Windows.Forms.Label();
            this.lblRemainingPallets = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalTrucks = new System.Windows.Forms.Label();
            this.tbOrderedBoxes = new System.Windows.Forms.TextBox();
            this.lblOrderedBoxes = new System.Windows.Forms.Label();
            this.gbSelectCompany = new System.Windows.Forms.GroupBox();
            this.rbCompanyA = new System.Windows.Forms.RadioButton();
            this.rbCompanyB = new System.Windows.Forms.RadioButton();
            this.rbCompanyC = new System.Windows.Forms.RadioButton();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            this.gbOrder.SuspendLayout();
            this.gbSelectCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(215)))), ((int)(((byte)(211)))));
            this.gbInfo.Controls.Add(this.tbBoxesPerPallet);
            this.gbInfo.Controls.Add(this.blbBoxesPerPallet);
            this.gbInfo.Controls.Add(this.tbTruckCapacity);
            this.gbInfo.Controls.Add(this.lblTruckCapacity);
            this.gbInfo.Location = new System.Drawing.Point(531, 38);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(519, 662);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Truck and pallet information";
            // 
            // tbBoxesPerPallet
            // 
            this.tbBoxesPerPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBoxesPerPallet.Location = new System.Drawing.Point(48, 410);
            this.tbBoxesPerPallet.Name = "tbBoxesPerPallet";
            this.tbBoxesPerPallet.Size = new System.Drawing.Size(283, 49);
            this.tbBoxesPerPallet.TabIndex = 0;
            // 
            // blbBoxesPerPallet
            // 
            this.blbBoxesPerPallet.AutoSize = true;
            this.blbBoxesPerPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbBoxesPerPallet.Location = new System.Drawing.Point(42, 358);
            this.blbBoxesPerPallet.Name = "blbBoxesPerPallet";
            this.blbBoxesPerPallet.Size = new System.Drawing.Size(338, 36);
            this.blbBoxesPerPallet.TabIndex = 0;
            this.blbBoxesPerPallet.Text = "Number boxes per pallet";
            // 
            // tbTruckCapacity
            // 
            this.tbTruckCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTruckCapacity.Location = new System.Drawing.Point(48, 247);
            this.tbTruckCapacity.Name = "tbTruckCapacity";
            this.tbTruckCapacity.Size = new System.Drawing.Size(283, 49);
            this.tbTruckCapacity.TabIndex = 0;
            // 
            // lblTruckCapacity
            // 
            this.lblTruckCapacity.AutoSize = true;
            this.lblTruckCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruckCapacity.Location = new System.Drawing.Point(42, 196);
            this.lblTruckCapacity.Name = "lblTruckCapacity";
            this.lblTruckCapacity.Size = new System.Drawing.Size(389, 36);
            this.lblTruckCapacity.TabIndex = 0;
            this.lblTruckCapacity.Text = "Truck capacity (nr of pallets)";
            // 
            // gbOrder
            // 
            this.gbOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(215)))), ((int)(((byte)(211)))));
            this.gbOrder.Controls.Add(this.lblTotalPrice);
            this.gbOrder.Controls.Add(this.lblRemainingBoxes);
            this.gbOrder.Controls.Add(this.lblRemainingPallets);
            this.gbOrder.Controls.Add(this.btnCalculate);
            this.gbOrder.Controls.Add(this.lblTotalTrucks);
            this.gbOrder.Controls.Add(this.tbOrderedBoxes);
            this.gbOrder.Controls.Add(this.lblOrderedBoxes);
            this.gbOrder.Location = new System.Drawing.Point(1114, 38);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(522, 662);
            this.gbOrder.TabIndex = 1;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "About this order";
            // 
            // lblRemainingBoxes
            // 
            this.lblRemainingBoxes.AutoSize = true;
            this.lblRemainingBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingBoxes.Location = new System.Drawing.Point(17, 480);
            this.lblRemainingBoxes.Name = "lblRemainingBoxes";
            this.lblRemainingBoxes.Size = new System.Drawing.Size(303, 39);
            this.lblRemainingBoxes.TabIndex = 5;
            this.lblRemainingBoxes.Text = "Remaining Boxes: ";
            // 
            // lblRemainingPallets
            // 
            this.lblRemainingPallets.AutoSize = true;
            this.lblRemainingPallets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingPallets.Location = new System.Drawing.Point(17, 401);
            this.lblRemainingPallets.Name = "lblRemainingPallets";
            this.lblRemainingPallets.Size = new System.Drawing.Size(311, 39);
            this.lblRemainingPallets.TabIndex = 4;
            this.lblRemainingPallets.Text = "Remaining Pallets: ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(458, 79);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalTrucks
            // 
            this.lblTotalTrucks.AutoSize = true;
            this.lblTotalTrucks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTrucks.Location = new System.Drawing.Point(17, 322);
            this.lblTotalTrucks.Name = "lblTotalTrucks";
            this.lblTotalTrucks.Size = new System.Drawing.Size(222, 39);
            this.lblTotalTrucks.TabIndex = 2;
            this.lblTotalTrucks.Text = "Total Trucks: ";
            // 
            // tbOrderedBoxes
            // 
            this.tbOrderedBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderedBoxes.Location = new System.Drawing.Point(24, 124);
            this.tbOrderedBoxes.Name = "tbOrderedBoxes";
            this.tbOrderedBoxes.Size = new System.Drawing.Size(283, 49);
            this.tbOrderedBoxes.TabIndex = 1;
            // 
            // lblOrderedBoxes
            // 
            this.lblOrderedBoxes.AutoSize = true;
            this.lblOrderedBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderedBoxes.Location = new System.Drawing.Point(18, 73);
            this.lblOrderedBoxes.Name = "lblOrderedBoxes";
            this.lblOrderedBoxes.Size = new System.Drawing.Size(352, 36);
            this.lblOrderedBoxes.TabIndex = 0;
            this.lblOrderedBoxes.Text = "Number of ordered boxes";
            // 
            // gbSelectCompany
            // 
            this.gbSelectCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(248)))));
            this.gbSelectCompany.Controls.Add(this.tbDescription);
            this.gbSelectCompany.Controls.Add(this.rbCompanyC);
            this.gbSelectCompany.Controls.Add(this.rbCompanyB);
            this.gbSelectCompany.Controls.Add(this.rbCompanyA);
            this.gbSelectCompany.Location = new System.Drawing.Point(44, 38);
            this.gbSelectCompany.Name = "gbSelectCompany";
            this.gbSelectCompany.Size = new System.Drawing.Size(458, 661);
            this.gbSelectCompany.TabIndex = 2;
            this.gbSelectCompany.TabStop = false;
            this.gbSelectCompany.Text = "Select Company";
            // 
            // rbCompanyA
            // 
            this.rbCompanyA.AutoSize = true;
            this.rbCompanyA.Location = new System.Drawing.Point(23, 73);
            this.rbCompanyA.Name = "rbCompanyA";
            this.rbCompanyA.Size = new System.Drawing.Size(198, 36);
            this.rbCompanyA.TabIndex = 1;
            this.rbCompanyA.TabStop = true;
            this.rbCompanyA.Text = "Company A";
            this.rbCompanyA.UseVisualStyleBackColor = true;
            this.rbCompanyA.CheckedChanged += new System.EventHandler(this.rbCompanyA_CheckedChanged);
            // 
            // rbCompanyB
            // 
            this.rbCompanyB.AutoSize = true;
            this.rbCompanyB.Location = new System.Drawing.Point(23, 137);
            this.rbCompanyB.Name = "rbCompanyB";
            this.rbCompanyB.Size = new System.Drawing.Size(198, 36);
            this.rbCompanyB.TabIndex = 1;
            this.rbCompanyB.TabStop = true;
            this.rbCompanyB.Text = "Company B";
            this.rbCompanyB.UseVisualStyleBackColor = true;
            this.rbCompanyB.CheckedChanged += new System.EventHandler(this.rbCompanyB_CheckedChanged);
            // 
            // rbCompanyC
            // 
            this.rbCompanyC.AutoSize = true;
            this.rbCompanyC.Location = new System.Drawing.Point(23, 202);
            this.rbCompanyC.Name = "rbCompanyC";
            this.rbCompanyC.Size = new System.Drawing.Size(199, 36);
            this.rbCompanyC.TabIndex = 1;
            this.rbCompanyC.TabStop = true;
            this.rbCompanyC.Text = "Company C";
            this.rbCompanyC.UseVisualStyleBackColor = true;
            this.rbCompanyC.CheckedChanged += new System.EventHandler(this.rbCompanyC_CheckedChanged);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(23, 322);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(386, 257);
            this.tbDescription.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(17, 583);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(198, 39);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "Total Price: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1697, 766);
            this.Controls.Add(this.gbSelectCompany);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.gbInfo);
            this.Name = "Form1";
            this.Text = "Truck Management";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            this.gbSelectCompany.ResumeLayout(false);
            this.gbSelectCompany.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.TextBox tbBoxesPerPallet;
        private System.Windows.Forms.Label blbBoxesPerPallet;
        private System.Windows.Forms.TextBox tbTruckCapacity;
        private System.Windows.Forms.Label lblTruckCapacity;
        private System.Windows.Forms.TextBox tbOrderedBoxes;
        private System.Windows.Forms.Label lblOrderedBoxes;
        private System.Windows.Forms.Label lblTotalTrucks;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblRemainingBoxes;
        private System.Windows.Forms.Label lblRemainingPallets;
        private System.Windows.Forms.GroupBox gbSelectCompany;
        private System.Windows.Forms.RadioButton rbCompanyA;
        private System.Windows.Forms.RadioButton rbCompanyC;
        private System.Windows.Forms.RadioButton rbCompanyB;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}

