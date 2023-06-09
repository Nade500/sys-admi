namespace n2._8_2._10
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

        private void button1_Click(object sender, EventArgs e)
        {
            System.String FiveStar = new System.String('*', 5);
            textBox1.Text = FiveStar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string AutoName;
            AutoName = "BMV";
            textBox1.Text =
                String.Format("Стоимость {0} равна {1:0.0;с}", AutoName, 12000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color clr = Color.Gray;
            textBox1.Text =
                (TypeDescriptor.GetConverter(clr).ConvertToString(clr));
            clr = (Color)TypeDescriptor.GetConverter(
                typeof(Color)).ConvertFromString("Green");
            this.BackColor = clr;
        }
    }
}