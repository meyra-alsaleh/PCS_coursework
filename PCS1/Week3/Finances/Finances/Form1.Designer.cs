namespace Finances
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
            btnShowInfo = new Button();
            gbData = new GroupBox();
            tbOwnerName = new TextBox();
            btnSetOwner = new Button();
            numAddMoney = new NumericUpDown();
            lblAmountToAdd = new Label();
            btnAddMoney = new Button();
            button1 = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            gbInfo.SuspendLayout();
            gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAddMoney).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // gbInfo
            // 
            gbInfo.BackColor = Color.FromArgb(249, 215, 210);
            gbInfo.Controls.Add(btnShowInfo);
            gbInfo.Location = new Point(39, 37);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(867, 248);
            gbInfo.TabIndex = 0;
            gbInfo.TabStop = false;
            // 
            // btnShowInfo
            // 
            btnShowInfo.FlatStyle = FlatStyle.System;
            btnShowInfo.Location = new Point(50, 75);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(176, 94);
            btnShowInfo.TabIndex = 0;
            btnShowInfo.Text = "Show Info";
            btnShowInfo.UseVisualStyleBackColor = true;
            // 
            // gbData
            // 
            gbData.BackColor = Color.FromArgb(203, 220, 237);
            gbData.Controls.Add(btnAddMoney);
            gbData.Controls.Add(lblAmountToAdd);
            gbData.Controls.Add(numAddMoney);
            gbData.Controls.Add(btnSetOwner);
            gbData.Controls.Add(tbOwnerName);
            gbData.Location = new Point(39, 316);
            gbData.Name = "gbData";
            gbData.Size = new Size(644, 469);
            gbData.TabIndex = 1;
            gbData.TabStop = false;
            // 
            // tbOwnerName
            // 
            tbOwnerName.Location = new Point(30, 69);
            tbOwnerName.Name = "tbOwnerName";
            tbOwnerName.Size = new Size(572, 47);
            tbOwnerName.TabIndex = 0;
            // 
            // btnSetOwner
            // 
            btnSetOwner.Location = new Point(30, 136);
            btnSetOwner.Name = "btnSetOwner";
            btnSetOwner.Size = new Size(187, 60);
            btnSetOwner.TabIndex = 1;
            btnSetOwner.Text = "Set Owner";
            btnSetOwner.UseVisualStyleBackColor = true;
            // 
            // numAddMoney
            // 
            numAddMoney.Location = new Point(308, 283);
            numAddMoney.Maximum = new decimal(new int[] { -1981284352, -1966660860, 0, 0 });
            numAddMoney.Name = "numAddMoney";
            numAddMoney.Size = new Size(294, 47);
            numAddMoney.TabIndex = 2;
            // 
            // lblAmountToAdd
            // 
            lblAmountToAdd.AutoSize = true;
            lblAmountToAdd.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmountToAdd.Location = new Point(30, 282);
            lblAmountToAdd.Name = "lblAmountToAdd";
            lblAmountToAdd.Size = new Size(255, 46);
            lblAmountToAdd.TabIndex = 3;
            lblAmountToAdd.Text = "Amount to add:";
            // 
            // btnAddMoney
            // 
            btnAddMoney.FlatStyle = FlatStyle.System;
            btnAddMoney.Location = new Point(30, 358);
            btnAddMoney.Name = "btnAddMoney";
            btnAddMoney.Size = new Size(187, 60);
            btnAddMoney.TabIndex = 4;
            btnAddMoney.Text = "Add Money";
            btnAddMoney.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(712, 385);
            button1.Name = "button1";
            button1.Size = new Size(194, 103);
            button1.TabIndex = 2;
            button1.Text = ">>";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(712, 610);
            button2.Name = "button2";
            button2.Size = new Size(194, 103);
            button2.TabIndex = 3;
            button2.Text = "<<";
            button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(712, 523);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(194, 47);
            numericUpDown1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 816);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(gbData);
            Controls.Add(gbInfo);
            Name = "Form1";
            Text = "Form1";
            gbInfo.ResumeLayout(false);
            gbData.ResumeLayout(false);
            gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAddMoney).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbInfo;
        private Button btnShowInfo;
        private GroupBox gbData;
        private Button btnSetOwner;
        private TextBox tbOwnerName;
        private Button btnAddMoney;
        private Label lblAmountToAdd;
        private NumericUpDown numAddMoney;
        private Button button1;
        private Button button2;
        private NumericUpDown numericUpDown1;
    }
}
