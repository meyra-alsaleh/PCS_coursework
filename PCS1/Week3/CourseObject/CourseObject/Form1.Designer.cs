namespace CourseObject
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
            lblCourseName = new Label();
            lblCourseECs = new Label();
            tbCourseName = new TextBox();
            tbCourseECs = new TextBox();
            btnCreateCourse = new Button();
            btnShowCourseInfo = new Button();
            lblDisplayInformation = new Label();
            SuspendLayout();
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(62, 52);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(208, 41);
            lblCourseName.TabIndex = 0;
            lblCourseName.Text = "Course name: ";
            // 
            // lblCourseECs
            // 
            lblCourseECs.AutoSize = true;
            lblCourseECs.Location = new Point(62, 135);
            lblCourseECs.Name = "lblCourseECs";
            lblCourseECs.Size = new Size(173, 41);
            lblCourseECs.TabIndex = 1;
            lblCourseECs.Text = "Course ECs:";
            // 
            // tbCourseName
            // 
            tbCourseName.Location = new Point(297, 52);
            tbCourseName.Name = "tbCourseName";
            tbCourseName.Size = new Size(288, 47);
            tbCourseName.TabIndex = 2;
            // 
            // tbCourseECs
            // 
            tbCourseECs.Location = new Point(297, 135);
            tbCourseECs.Name = "tbCourseECs";
            tbCourseECs.Size = new Size(180, 47);
            tbCourseECs.TabIndex = 3;
            // 
            // btnCreateCourse
            // 
            btnCreateCourse.Location = new Point(151, 246);
            btnCreateCourse.Name = "btnCreateCourse";
            btnCreateCourse.Size = new Size(482, 60);
            btnCreateCourse.TabIndex = 4;
            btnCreateCourse.Text = "Create Course";
            btnCreateCourse.UseVisualStyleBackColor = true;
            btnCreateCourse.Click += btnCreateCourse_Click;
            // 
            // btnShowCourseInfo
            // 
            btnShowCourseInfo.Location = new Point(151, 331);
            btnShowCourseInfo.Name = "btnShowCourseInfo";
            btnShowCourseInfo.Size = new Size(482, 59);
            btnShowCourseInfo.TabIndex = 5;
            btnShowCourseInfo.Text = "Show Course Information";
            btnShowCourseInfo.UseVisualStyleBackColor = true;
            btnShowCourseInfo.Click += btnShowCourseInfo_Click;
            // 
            // lblDisplayInformation
            // 
            lblDisplayInformation.AutoSize = true;
            lblDisplayInformation.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDisplayInformation.ImageAlign = ContentAlignment.MiddleLeft;
            lblDisplayInformation.Location = new Point(62, 471);
            lblDisplayInformation.Name = "lblDisplayInformation";
            lblDisplayInformation.Size = new Size(0, 41);
            lblDisplayInformation.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 244, 248);
            ClientSize = new Size(800, 569);
            Controls.Add(lblDisplayInformation);
            Controls.Add(btnShowCourseInfo);
            Controls.Add(btnCreateCourse);
            Controls.Add(tbCourseECs);
            Controls.Add(tbCourseName);
            Controls.Add(lblCourseECs);
            Controls.Add(lblCourseName);
            Name = "Form1";
            Text = "Courses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCourseName;
        private Label lblCourseECs;
        private TextBox tbCourseName;
        private TextBox tbCourseECs;
        private Button btnCreateCourse;
        private Button btnShowCourseInfo;
        private Label lblDisplayInformation;
    }
}
