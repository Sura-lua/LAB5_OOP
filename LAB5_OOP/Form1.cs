namespace LAB5_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputName = textBoxFullName.Text.Trim();

            // ใช้ Constructor แบบ Overload
            PersonName person = new PersonName(inputName);

            textBoxTitle.Text = person.title;
            textBoxFirstName.Text = person.firstName;
            textBoxLastName.Text = person.lastName;
        }
    }
}
