namespace SimpleCalculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbSecondNumber = new System.Windows.Forms.TextBox();
            this.tbFirstNumber = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btnHideInfo = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(196)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnDivide);
            this.panel1.Controls.Add(this.btnMultiply);
            this.panel1.Controls.Add(this.btnSubtract);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbSecondNumber);
            this.panel1.Controls.Add(this.tbFirstNumber);
            this.panel1.Controls.Add(this.lblAnswer);
            this.panel1.Controls.Add(this.lblSecondNumber);
            this.panel1.Controls.Add(this.lblFirstNumber);
            this.panel1.Location = new System.Drawing.Point(49, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 727);
            this.panel1.TabIndex = 0;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(737, 336);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(122, 89);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(537, 336);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(122, 89);
            this.btnMultiply.TabIndex = 7;
            this.btnMultiply.Text = "*";
            this.btnMultiply.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(337, 336);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(122, 89);
            this.btnSubtract.TabIndex = 6;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(137, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 89);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbSecondNumber
            // 
            this.tbSecondNumber.Location = new System.Drawing.Point(366, 203);
            this.tbSecondNumber.Name = "tbSecondNumber";
            this.tbSecondNumber.Size = new System.Drawing.Size(307, 38);
            this.tbSecondNumber.TabIndex = 4;
            // 
            // tbFirstNumber
            // 
            this.tbFirstNumber.Location = new System.Drawing.Point(366, 83);
            this.tbFirstNumber.Name = "tbFirstNumber";
            this.tbFirstNumber.Size = new System.Drawing.Size(307, 38);
            this.tbFirstNumber.TabIndex = 3;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(75, 575);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(175, 46);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer: ";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondNumber.Location = new System.Drawing.Point(76, 203);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(275, 39);
            this.lblSecondNumber.TabIndex = 1;
            this.lblSecondNumber.Text = "Second number: ";
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNumber.Location = new System.Drawing.Point(126, 83);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(225, 39);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "First number: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(222)))), ((int)(((byte)(184)))));
            this.panel2.Controls.Add(this.tbInfo);
            this.panel2.Controls.Add(this.btnHideInfo);
            this.panel2.Controls.Add(this.btnShowInfo);
            this.panel2.Location = new System.Drawing.Point(1084, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 726);
            this.panel2.TabIndex = 1;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(42, 225);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(527, 454);
            this.tbInfo.TabIndex = 2;
            this.tbInfo.Text = "This application is a simple calculator that has the features of adding, subtract" +
    "ing, multiplying and dividing two numbers.\r\n\r\nMade by Meyra!";
            this.tbInfo.Visible = false;
            // 
            // btnHideInfo
            // 
            this.btnHideInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideInfo.Location = new System.Drawing.Point(333, 69);
            this.btnHideInfo.Name = "btnHideInfo";
            this.btnHideInfo.Size = new System.Drawing.Size(236, 119);
            this.btnHideInfo.TabIndex = 1;
            this.btnHideInfo.Text = "Hide Info";
            this.btnHideInfo.UseVisualStyleBackColor = true;
            this.btnHideInfo.Visible = false;
            this.btnHideInfo.Click += new System.EventHandler(this.btnHideInfo_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.Location = new System.Drawing.Point(42, 69);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(236, 119);
            this.btnShowInfo.TabIndex = 0;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1766, 812);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbSecondNumber;
        private System.Windows.Forms.TextBox tbFirstNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btnHideInfo;
        private System.Windows.Forms.Button btnShowInfo;
    }
}

