namespace CourseObject
{
    public partial class Form1 : Form
    {
        private Course course;
        public Form1()
        {
            InitializeComponent();
            course = new Course();
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            course.SetName(this.tbCourseName.Text);
            course.SetEc(Convert.ToInt32(this.tbCourseECs.Text));
        }

        private void btnShowCourseInfo_Click(object sender, EventArgs e)
        {
            this.lblDisplayInformation.Text = "Course " + course.GetName() + " offers " + course.GetEc() + " ECs.";
        }
    }
}
