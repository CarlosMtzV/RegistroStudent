namespace RegistroStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Student StuA = new Student(Convert.ToDouble(numericUpDown.Text),Convert.ToString(txtCareer.Text),Convert.ToString(txtTuition.Text), Convert.ToString(txtName.Text),Convert.ToString(txtFather.Text), Convert.ToString(txtMother.Text), Convert.ToDateTime(dateTimePicker1.Text));
            LblStu.Text= StuA.ToString();

        }
    }
}
