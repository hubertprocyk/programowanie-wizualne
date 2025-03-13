using Calculation;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Calculate cal = new();
        //Addition Button click event
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //storing the result in int i
                int i = cal.Add(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox3.Text = i.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Subtraction button click event

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //storing the result in int i
                int i = cal.Subtract(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox3.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}