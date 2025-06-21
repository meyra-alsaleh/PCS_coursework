namespace CarSimulation
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
            btnAccelerate = new Button();
            btnBreaks = new Button();
            lblCar1 = new Label();
            lblCar2 = new Label();
            gbActivity = new GroupBox();
            rbCar2 = new RadioButton();
            rbCar1 = new RadioButton();
            tbCar1Brand = new TextBox();
            lblCar1BrandMaxS = new Label();
            lblCar2Brand = new Label();
            tbCar2Brand = new TextBox();
            gbCarStatus = new GroupBox();
            numCar1MaxSpeed = new NumericUpDown();
            numCar2MaxSpeed = new NumericUpDown();
            gbActivity.SuspendLayout();
            gbCarStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCar1MaxSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCar2MaxSpeed).BeginInit();
            SuspendLayout();
            // 
            // btnAccelerate
            // 
            btnAccelerate.Location = new Point(41, 540);
            btnAccelerate.Name = "btnAccelerate";
            btnAccelerate.Size = new Size(374, 108);
            btnAccelerate.TabIndex = 0;
            btnAccelerate.Text = "Accelerate";
            btnAccelerate.UseVisualStyleBackColor = true;
            btnAccelerate.Click += btnAccelerate_Click;
            // 
            // btnBreaks
            // 
            btnBreaks.Location = new Point(474, 540);
            btnBreaks.Name = "btnBreaks";
            btnBreaks.Size = new Size(370, 107);
            btnBreaks.TabIndex = 1;
            btnBreaks.Text = "Use the breaks";
            btnBreaks.UseVisualStyleBackColor = true;
            // 
            // lblCar1
            // 
            lblCar1.AutoSize = true;
            lblCar1.Location = new Point(47, 55);
            lblCar1.Name = "lblCar1";
            lblCar1.Size = new Size(174, 41);
            lblCar1.TabIndex = 2;
            lblCar1.Text = "Car 1 Status";
            // 
            // lblCar2
            // 
            lblCar2.AutoSize = true;
            lblCar2.Location = new Point(47, 158);
            lblCar2.Name = "lblCar2";
            lblCar2.Size = new Size(174, 41);
            lblCar2.TabIndex = 3;
            lblCar2.Text = "Car 2 Status";
            // 
            // gbActivity
            // 
            gbActivity.BackColor = Color.FromArgb(252, 235, 248);
            gbActivity.Controls.Add(rbCar2);
            gbActivity.Controls.Add(rbCar1);
            gbActivity.Location = new Point(687, 36);
            gbActivity.Name = "gbActivity";
            gbActivity.Size = new Size(157, 174);
            gbActivity.TabIndex = 4;
            gbActivity.TabStop = false;
            gbActivity.Text = "Activity";
            // 
            // rbCar2
            // 
            rbCar2.AutoSize = true;
            rbCar2.Location = new Point(25, 111);
            rbCar2.Name = "rbCar2";
            rbCar2.Size = new Size(123, 45);
            rbCar2.TabIndex = 1;
            rbCar2.TabStop = true;
            rbCar2.Text = "Car 2";
            rbCar2.UseVisualStyleBackColor = true;
            // 
            // rbCar1
            // 
            rbCar1.AutoSize = true;
            rbCar1.Location = new Point(24, 60);
            rbCar1.Name = "rbCar1";
            rbCar1.Size = new Size(123, 45);
            rbCar1.TabIndex = 0;
            rbCar1.TabStop = true;
            rbCar1.Text = "Car 1";
            rbCar1.UseVisualStyleBackColor = true;
            // 
            // tbCar1Brand
            // 
            tbCar1Brand.Location = new Point(306, 46);
            tbCar1Brand.Name = "tbCar1Brand";
            tbCar1Brand.Size = new Size(194, 47);
            tbCar1Brand.TabIndex = 5;
            // 
            // lblCar1BrandMaxS
            // 
            lblCar1BrandMaxS.AutoSize = true;
            lblCar1BrandMaxS.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCar1BrandMaxS.Location = new Point(28, 52);
            lblCar1BrandMaxS.Name = "lblCar1BrandMaxS";
            lblCar1BrandMaxS.Size = new Size(272, 38);
            lblCar1BrandMaxS.TabIndex = 6;
            lblCar1BrandMaxS.Text = "C1 Brand / M. Speed";
            // 
            // lblCar2Brand
            // 
            lblCar2Brand.AutoSize = true;
            lblCar2Brand.Font = new Font("Segoe UI", 8.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCar2Brand.Location = new Point(28, 143);
            lblCar2Brand.Name = "lblCar2Brand";
            lblCar2Brand.Size = new Size(272, 38);
            lblCar2Brand.TabIndex = 7;
            lblCar2Brand.Text = "C2 Brand / M. Speed";
            // 
            // tbCar2Brand
            // 
            tbCar2Brand.Location = new Point(306, 143);
            tbCar2Brand.Name = "tbCar2Brand";
            tbCar2Brand.Size = new Size(194, 47);
            tbCar2Brand.TabIndex = 8;
            // 
            // gbCarStatus
            // 
            gbCarStatus.BackColor = Color.FromArgb(231, 239, 238);
            gbCarStatus.Controls.Add(lblCar2);
            gbCarStatus.Controls.Add(lblCar1);
            gbCarStatus.Location = new Point(41, 277);
            gbCarStatus.Name = "gbCarStatus";
            gbCarStatus.Size = new Size(803, 239);
            gbCarStatus.TabIndex = 9;
            gbCarStatus.TabStop = false;
            // 
            // numCar1MaxSpeed
            // 
            numCar1MaxSpeed.Location = new Point(522, 46);
            numCar1MaxSpeed.Name = "numCar1MaxSpeed";
            numCar1MaxSpeed.Size = new Size(118, 47);
            numCar1MaxSpeed.TabIndex = 10;
            // 
            // numCar2MaxSpeed
            // 
            numCar2MaxSpeed.Location = new Point(522, 143);
            numCar2MaxSpeed.Name = "numCar2MaxSpeed";
            numCar2MaxSpeed.Size = new Size(118, 47);
            numCar2MaxSpeed.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 244, 255);
            ClientSize = new Size(886, 687);
            Controls.Add(numCar2MaxSpeed);
            Controls.Add(numCar1MaxSpeed);
            Controls.Add(gbCarStatus);
            Controls.Add(tbCar2Brand);
            Controls.Add(lblCar2Brand);
            Controls.Add(lblCar1BrandMaxS);
            Controls.Add(tbCar1Brand);
            Controls.Add(gbActivity);
            Controls.Add(btnBreaks);
            Controls.Add(btnAccelerate);
            Name = "Form1";
            Text = "Car Simulation";
            gbActivity.ResumeLayout(false);
            gbActivity.PerformLayout();
            gbCarStatus.ResumeLayout(false);
            gbCarStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCar1MaxSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCar2MaxSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAccelerate;
        private Button btnBreaks;
        private Label lblCar1;
        private Label lblCar2;
        private GroupBox gbActivity;
        private RadioButton rbCar2;
        private RadioButton rbCar1;
        private TextBox tbCar1Brand;
        private Label lblCar1BrandMaxS;
        private Label lblCar2Brand;
        private TextBox tbCar2Brand;
        private GroupBox gbCarStatus;
        private NumericUpDown numCar1MaxSpeed;
        private NumericUpDown numCar2MaxSpeed;
    }
}
