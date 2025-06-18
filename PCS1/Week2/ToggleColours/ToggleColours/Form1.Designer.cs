namespace ToggleColours
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
            this.btnSwitchColour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSwitchColour
            // 
            this.btnSwitchColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchColour.Location = new System.Drawing.Point(381, 276);
            this.btnSwitchColour.Name = "btnSwitchColour";
            this.btnSwitchColour.Size = new System.Drawing.Size(305, 147);
            this.btnSwitchColour.TabIndex = 0;
            this.btnSwitchColour.Text = "PRESS ME!!!";
            this.btnSwitchColour.UseVisualStyleBackColor = true;
            this.btnSwitchColour.Click += new System.EventHandler(this.btnSwitchColour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 699);
            this.Controls.Add(this.btnSwitchColour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwitchColour;
    }
}

