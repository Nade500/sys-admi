using System.ComponentModel;

namespace _2._8_2._10
{
    public partial class Form1 : Form
    {
        private Color clr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             System.String FiveStar = new System.String('*', 5);
             textBox1.Text = FiveStar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            string AutoName;
            AutoName = "BMV";
            textBox3.Text =
                String.Format("Стоимость {0} равна {1:0.0;с}", AutoName, 12000);
            */
            string AutoName;
            AutoName = textBox2.Text;
            string str;
            str = textBox3.Text;
            textBox1.Text =
                String.Format("Стоимость {0} равна {1:0.0;с}", textBox2.Text, textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            Color clr = Color.Red;//имя которое выводится
            textBox1.Text =
                (TypeDescriptor.GetConverter(clr).ConvertToString(clr));
            clr = (Color)TypeDescriptor.GetConverter(
                typeof(Color)).ConvertFromString("Red");//сам цвет 
            this.BackColor = clr;*/

            clr = (Color)TypeDescriptor.GetConverter(typeof(Color)).ConvertFromString(textBox1.Text);
            this.BackColor = clr;
            textBox2.Text = (TypeDescriptor.GetConverter(TypeDescriptor.GetConverter(clr)).ConvertToString(clr));   

        }
    }
}