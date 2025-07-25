namespace SnackBar
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
            gbInformation = new GroupBox();
            rbCajunFries = new RadioButton();
            rbKibbeling = new RadioButton();
            rbGimbap = new RadioButton();
            numCajunFries = new NumericUpDown();
            numKibbeling = new NumericUpDown();
            numGimbap = new NumericUpDown();
            btnGetInfo = new Button();
            lblSnackInfo = new Label();
            gbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCajunFries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKibbeling).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGimbap).BeginInit();
            SuspendLayout();
            // 
            // gbInformation
            // 
            gbInformation.BackColor = Color.FromArgb(217, 232, 224);
            gbInformation.Controls.Add(lblSnackInfo);
            gbInformation.Location = new Point(696, 34);
            gbInformation.Name = "gbInformation";
            gbInformation.Size = new Size(462, 483);
            gbInformation.TabIndex = 0;
            gbInformation.TabStop = false;
            gbInformation.Text = "Snacks Information";
            // 
            // rbCajunFries
            // 
            rbCajunFries.AutoSize = true;
            rbCajunFries.Location = new Point(49, 70);
            rbCajunFries.Name = "rbCajunFries";
            rbCajunFries.Size = new Size(199, 45);
            rbCajunFries.TabIndex = 1;
            rbCajunFries.TabStop = true;
            rbCajunFries.Text = "Cajun Fries";
            rbCajunFries.UseVisualStyleBackColor = true;
            // 
            // rbKibbeling
            // 
            rbKibbeling.AutoSize = true;
            rbKibbeling.Location = new Point(49, 152);
            rbKibbeling.Name = "rbKibbeling";
            rbKibbeling.Size = new Size(180, 45);
            rbKibbeling.TabIndex = 2;
            rbKibbeling.TabStop = true;
            rbKibbeling.Text = "Kibbeling";
            rbKibbeling.UseVisualStyleBackColor = true;
            // 
            // rbGimbap
            // 
            rbGimbap.AutoSize = true;
            rbGimbap.Location = new Point(49, 236);
            rbGimbap.Name = "rbGimbap";
            rbGimbap.Size = new Size(160, 45);
            rbGimbap.TabIndex = 3;
            rbGimbap.TabStop = true;
            rbGimbap.Text = "Gimbap";
            rbGimbap.UseVisualStyleBackColor = true;
            // 
            // numCajunFries
            // 
            numCajunFries.Location = new Point(295, 70);
            numCajunFries.Name = "numCajunFries";
            numCajunFries.Size = new Size(170, 47);
            numCajunFries.TabIndex = 4;
            // 
            // numKibbeling
            // 
            numKibbeling.Location = new Point(295, 153);
            numKibbeling.Name = "numKibbeling";
            numKibbeling.Size = new Size(170, 47);
            numKibbeling.TabIndex = 5;
            // 
            // numGimbap
            // 
            numGimbap.Location = new Point(295, 236);
            numGimbap.Name = "numGimbap";
            numGimbap.Size = new Size(170, 47);
            numGimbap.TabIndex = 6;
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(696, 548);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(462, 69);
            btnGetInfo.TabIndex = 7;
            btnGetInfo.Text = "Get Information";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // lblSnackInfo
            // 
            lblSnackInfo.AutoSize = true;
            lblSnackInfo.Location = new Point(35, 79);
            lblSnackInfo.Name = "lblSnackInfo";
            lblSnackInfo.Size = new Size(39, 41);
            lblSnackInfo.TabIndex = 0;
            lblSnackInfo.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 638);
            Controls.Add(btnGetInfo);
            Controls.Add(numGimbap);
            Controls.Add(numKibbeling);
            Controls.Add(numCajunFries);
            Controls.Add(rbGimbap);
            Controls.Add(rbKibbeling);
            Controls.Add(rbCajunFries);
            Controls.Add(gbInformation);
            Name = "Form1";
            Text = "MacSnack";
            gbInformation.ResumeLayout(false);
            gbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCajunFries).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKibbeling).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGimbap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbInformation;
        private RadioButton rbCajunFries;
        private RadioButton rbKibbeling;
        private RadioButton rbGimbap;
        private NumericUpDown numCajunFries;
        private NumericUpDown numKibbeling;
        private NumericUpDown numGimbap;
        private Button btnGetInfo;
        private Label lblSnackInfo;
    }
}
