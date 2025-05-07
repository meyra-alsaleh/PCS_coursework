namespace BMICalculator
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
            lblWeightKg = new Label();
            lblHeightM = new Label();
            tbWeightKg = new TextBox();
            tbHeightM = new TextBox();
            btnCalculateBMI = new Button();
            lblBMI = new Label();
            lblResult = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblWeightKg
            // 
            lblWeightKg.AutoSize = true;
            lblWeightKg.Location = new Point(55, 75);
            lblWeightKg.Name = "lblWeightKg";
            lblWeightKg.Size = new Size(201, 41);
            lblWeightKg.TabIndex = 0;
            lblWeightKg.Text = "Weight in kg: ";
            // 
            // lblHeightM
            // 
            lblHeightM.AutoSize = true;
            lblHeightM.Location = new Point(55, 175);
            lblHeightM.Name = "lblHeightM";
            lblHeightM.Size = new Size(253, 41);
            lblHeightM.TabIndex = 1;
            lblHeightM.Text = "Height in meters: ";
            // 
            // tbWeightKg
            // 
            tbWeightKg.Location = new Point(352, 72);
            tbWeightKg.Name = "tbWeightKg";
            tbWeightKg.Size = new Size(274, 47);
            tbWeightKg.TabIndex = 2;
            // 
            // tbHeightM
            // 
            tbHeightM.Location = new Point(352, 169);
            tbHeightM.Name = "tbHeightM";
            tbHeightM.Size = new Size(274, 47);
            tbHeightM.TabIndex = 3;
            // 
            // btnCalculateBMI
            // 
            btnCalculateBMI.BackColor = Color.FromArgb(214, 230, 254);
            btnCalculateBMI.Location = new Point(55, 298);
            btnCalculateBMI.Name = "btnCalculateBMI";
            btnCalculateBMI.Size = new Size(571, 106);
            btnCalculateBMI.TabIndex = 4;
            btnCalculateBMI.Text = "Calculate Body Mass Index";
            btnCalculateBMI.UseVisualStyleBackColor = false;
            btnCalculateBMI.Click += btnCalculateBMI_Click;
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBMI.Location = new Point(55, 509);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(222, 50);
            lblBMI.TabIndex = 5;
            lblBMI.Text = "Your BMI is: ";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(55, 657);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(161, 50);
            lblResult.TabIndex = 6;
            lblResult.Text = "You are: ";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(55, 751);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 41);
            lblMessage.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 879);
            Controls.Add(lblMessage);
            Controls.Add(lblResult);
            Controls.Add(lblBMI);
            Controls.Add(btnCalculateBMI);
            Controls.Add(tbHeightM);
            Controls.Add(tbWeightKg);
            Controls.Add(lblHeightM);
            Controls.Add(lblWeightKg);
            Name = "Form1";
            Text = "BMI Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWeightKg;
        private Label lblHeightM;
        private TextBox tbWeightKg;
        private TextBox tbHeightM;
        private Button btnCalculateBMI;
        private Label lblBMI;
        private Label lblResult;
        private Label lblMessage;
    }
}
