using System.Drawing.Imaging;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }
     


        private void button1_Click(object sender, EventArgs e)
        {

            sum add = new sum();
            add.setplus(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox3.Text = ("" + add.getplus());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sub minus = new sub();
            minus.setplus(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox3.Text = ("" + minus.getplus());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mult timis = new mult();
            timis.setplus(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox3.Text = ("" + timis.getplus());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            div ed = new div();
            ed.setplus(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox3.Text = ("" + ed.getplus());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}