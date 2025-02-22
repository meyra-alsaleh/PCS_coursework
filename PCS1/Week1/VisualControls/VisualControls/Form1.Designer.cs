namespace VisualControls
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
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMakeGreen = new System.Windows.Forms.RadioButton();
            this.rbMakeRed = new System.Windows.Forms.RadioButton();
            this.rbMakeYellow = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(415, 157);
            this.button1.TabIndex = 0;
            this.button1.Text = "About Me";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.trackBar1.Location = new System.Drawing.Point(43, 265);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(992, 114);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(43, 437);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(748, 134);
            this.progressBar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(880, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // rbMakeGreen
            // 
            this.rbMakeGreen.AutoSize = true;
            this.rbMakeGreen.Location = new System.Drawing.Point(1223, 71);
            this.rbMakeGreen.Name = "rbMakeGreen";
            this.rbMakeGreen.Size = new System.Drawing.Size(247, 36);
            this.rbMakeGreen.TabIndex = 4;
            this.rbMakeGreen.TabStop = true;
            this.rbMakeGreen.Text = "Make me green";
            this.rbMakeGreen.UseVisualStyleBackColor = true;
            this.rbMakeGreen.CheckedChanged += new System.EventHandler(this.rbMakeGreen_CheckedChanged);
            // 
            // rbMakeRed
            // 
            this.rbMakeRed.AutoSize = true;
            this.rbMakeRed.Location = new System.Drawing.Point(1223, 153);
            this.rbMakeRed.Name = "rbMakeRed";
            this.rbMakeRed.Size = new System.Drawing.Size(215, 36);
            this.rbMakeRed.TabIndex = 5;
            this.rbMakeRed.TabStop = true;
            this.rbMakeRed.Text = "Make me red";
            this.rbMakeRed.UseVisualStyleBackColor = true;
            this.rbMakeRed.CheckedChanged += new System.EventHandler(this.rbMakeRed_CheckedChanged);
            // 
            // rbMakeYellow
            // 
            this.rbMakeYellow.AutoSize = true;
            this.rbMakeYellow.Location = new System.Drawing.Point(1223, 234);
            this.rbMakeYellow.Name = "rbMakeYellow";
            this.rbMakeYellow.Size = new System.Drawing.Size(254, 36);
            this.rbMakeYellow.TabIndex = 6;
            this.rbMakeYellow.TabStop = true;
            this.rbMakeYellow.Text = "Make me yellow";
            this.rbMakeYellow.UseVisualStyleBackColor = true;
            this.rbMakeYellow.CheckedChanged += new System.EventHandler(this.rbMakeYellow_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VisualControls.Properties.Resources.IMG_2010;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1223, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 759);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbMakeYellow);
            this.Controls.Add(this.rbMakeRed);
            this.Controls.Add(this.rbMakeGreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Visual Controls";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMakeGreen;
        private System.Windows.Forms.RadioButton rbMakeRed;
        private System.Windows.Forms.RadioButton rbMakeYellow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

