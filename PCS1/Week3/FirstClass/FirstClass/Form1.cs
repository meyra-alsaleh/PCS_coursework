namespace FirstClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.SetName("Nana");
            person.SetAge(27);

            MessageBox.Show("My name is " + person.GetName() + " and I am " + person.GetAge() + " years old.");
        }
    }
}
