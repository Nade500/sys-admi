namespace _2._3_2._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partBookTitle = textBox1.Text;
            string insertText = textBox2.Text;
            string bookTitle = partBookTitle.Insert(3, insertText);
            MessageBox.Show(bookTitle);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookTitle = textBox1.Text;
            bookTitle = bookTitle.Remove(2);
            MessageBox.Show(bookTitle);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            int charCode = 0x00AE;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text += specialChar.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string wstr = textBox1.Text;
            string strWstr = textBox2.Text;
            int i = wstr.IndexOf(strWstr);
            if (i == -1)
            {
                MessageBox.Show("Не найдено");
            }
            else
            {
                MessageBox.Show($"Найдено на {i + 1} символе");
            }
              
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            string tankman = "4";
            string dog = "1";
            textBox1.Text = tankman + dog; //=41
            int all = int.Parse(tankman) + int.Parse(dog);
            textBox1.Text += Environment.NewLine + all.ToString(); //=5
            */



            // писать числа
            string firstStr = textBox1.Text;
            string twoStr = textBox2.Text;
            textBox1.Text = firstStr + twoStr; //
            int all = int.Parse(firstStr) + int.Parse(twoStr);
            textBox1.Text += Environment.NewLine + all.ToString(); //

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int charCode = 169;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text = specialChar.ToString();
        }


























        private void button7_Click(object sender, EventArgs e)
        {
            System.String FiveStar = new System.String('*', 5);
            textBox3.Text = FiveStar;
        }

        private void butFormatStr_Click(object sender, EventArgs e)
        {
            string AutoName;
            AutoName = "BMV";
            textBox3.Text =
                String.Format("Стоимость {0} равна {1:0.0;с}", AutoName, 12000);
        }


        private void butColorName_Click(object sender, EventArgs e)
        {
            Color clr = Color.Gray;
            textBox3.Text =
                (TypeDescriptor.GetConverter(clr).ConvertToString(clr));
            clr = (Color)TypeDescriptor.GetConverter(
                typeof(Color)).ConvertFromString("Green");
            this.BackColor = clr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}