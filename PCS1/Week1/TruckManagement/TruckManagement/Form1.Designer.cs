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
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.lblTruckCapacity = new System.Windows.Forms.Label();
            this.tbTruckCapacity = new System.Windows.Forms.TextBox();
            this.blbBoxesPerPallet = new System.Windows.Forms.Label();
            this.tbBoxesPerPallet = new System.Windows.Forms.TextBox();
            this.lblOrderedBoxes = new System.Windows.Forms.Label();
            this.tbOrderedBoxes = new System.Windows.Forms.TextBox();
            this.gbInfo.SuspendLayout();
            this.gbOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(215)))), ((int)(((byte)(211)))));
            this.gbInfo.Controls.Add(this.tbBoxesPerPallet);
            this.gbInfo.Controls.Add(this.blbBoxesPerPallet);
            this.gbInfo.Controls.Add(this.tbTruckCapacity);
            this.gbInfo.Controls.Add(this.lblTruckCapacity);
            this.gbInfo.Location = new System.Drawing.Point(30, 43);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(519, 549);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Truck and pallet information";
            // 
            // gbOrder
            // 
            this.gbOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(215)))), ((int)(((byte)(211)))));
            this.gbOrder.Controls.Add(this.tbOrderedBoxes);
            this.gbOrder.Controls.Add(this.lblOrderedBoxes);
            this.gbOrder.Location = new System.Drawing.Point(585, 43);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(522, 549);
            this.gbOrder.TabIndex = 1;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "About this order";
            // 
            // lblTruckCapacity
            // 
            this.lblTruckCapacity.AutoSize = true;
            this.lblTruckCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruckCapacity.Location = new System.Drawing.Point(24, 181);
            this.lblTruckCapacity.Name = "lblTruckCapacity";
            this.lblTruckCapacity.Size = new System.Drawing.Size(389, 36);
            this.lblTruckCapacity.TabIndex = 0;
            this.lblTruckCapacity.Text = "Truck capacity (nr of pallets)";
            // 
            // tbTruckCapacity
            // 
            this.tbTruckCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTruckCapacity.Location = new System.Drawing.Point(30, 232);
            this.tbTruckCapacity.Name = "tbTruckCapacity";
            this.tbTruckCapacity.Size = new System.Drawing.Size(283, 49);
            this.tbTruckCapacity.TabIndex = 0;
            // 
            // blbBoxesPerPallet
            // 
            this.blbBoxesPerPallet.AutoSize = true;
            this.blbBoxesPerPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbBoxesPerPallet.Location = new System.Drawing.Point(24, 343);
            this.blbBoxesPerPallet.Name = "blbBoxesPerPallet";
            this.blbBoxesPerPallet.Size = new System.Drawing.Size(338, 36);
            this.blbBoxesPerPallet.TabIndex = 0;
            this.blbBoxesPerPallet.Text = "Number boxes per pallet";
            // 
            // tbBoxesPerPallet
            // 
            this.tbBoxesPerPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBoxesPerPallet.Location = new System.Drawing.Point(30, 395);
            this.tbBoxesPerPallet.Name = "tbBoxesPerPallet";
            this.tbBoxesPerPallet.Size = new System.Drawing.Size(283, 49);
            this.tbBoxesPerPallet.TabIndex = 0;
            // 
            // lblOrderedBoxes
            // 
            this.lblOrderedBoxes.AutoSize = true;
            this.lblOrderedBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderedBoxes.Location = new System.Drawing.Point(71, 181);
            this.lblOrderedBoxes.Name = "lblOrderedBoxes";
            this.lblOrderedBoxes.Size = new System.Drawing.Size(352, 36);
            this.lblOrderedBoxes.TabIndex = 0;
            this.lblOrderedBoxes.Text = "Number of ordered boxes";
            // 
            // tbOrderedBoxes
            // 
            this.tbOrderedBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderedBoxes.Location = new System.Drawing.Point(77, 232);
            this.tbOrderedBoxes.Name = "tbOrderedBoxes";
            this.tbOrderedBoxes.Size = new System.Drawing.Size(283, 49);
            this.tbOrderedBoxes.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 636);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.gbInfo);
            this.Name = "Form1";
            this.Text = "Truck Management";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
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
    }
}

