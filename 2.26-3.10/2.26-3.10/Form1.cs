using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace _2._26_3._10
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int parrots = 38;
            textBox1.Text = parrots.ToString("X8");
            /*
            int parrots = textBox1.Text;
            listBox1.Items.Add(parrots.ToString("X8"));
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int myvalue = 4;
            textBox1.Text = Convert.ToString(myvalue, 2); // ��������� 100
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int myValue = 365;
            // ����������� � ������������ �������� 
            MessageBox.Show(Convert.ToString(myValue, 8));
            // ����������� � ����������������� �������� 
            MessageBox.Show(Convert.ToString(myValue, 16));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ������� � ��������� ���� ����� ����� ��� ����� 
            string numstring = textBox1.Text;
            bool bResult1;
            bResult1 = Information.IsNumeric(numstring);
            MessageBox.Show("�������� �� " + numstring + " ������: " + bResult1);
        }


        static bool IsNumeric(object Expression)
        {
            // ������������ �������� 
            bool isNum;
            // ����������, ������������ � �������� ��������� 
            // � ������ TryParse 
            double retNum;
            // ����� TryParse ������������ ������ � �������� ����� 
            // � ��������� ������. 
            isNum = Double.TryParse(Convert.ToString(Expression),
            System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� �� " + textBox1.Text +
            " ������: " + IsNumeric(textBox1.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Guid newGuid = Guid.NewGuid();
            // ���������� ������������� � �������� 
            //MessageBox.Show(newGuid.ToString()); 
            // ���������� ������������� ��� ������� 
            textBox1.Text = newGuid.ToString("N");

        }


        enum Cats { ����� = 3, ������ = 5, ������, ������, ����� };
        private void button7_Click(object sender, EventArgs e)
        {
            // ����������� ��� �������� ������������ 
            string[] catNames = Enum.GetNames(typeof(Cats));
            foreach (string s in catNames)
            {
                listBox1.Items.Add(s);
            }
            // ����������� ��� �������� ������������ 
            int[] valCats = (int[])Enum.GetValues(typeof(Cats));
            foreach (int val in valCats)
            {
                listBox1.Items.Add(val.ToString());
            }
            MessageBox.Show(catNames[3].ToString());
            MessageBox.Show(valCats[3].ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // �������� ������ �����, ���������� ��� ����� � ������� 
            string[] allcolors =
            Enum.GetNames(typeof(System.Drawing.KnownColor));
            listBox1.Items.Clear();
            // ������� ��� ����� � ������ 
            listBox1.Items.AddRange(allcolors);
            // ������ ������� 
            //foreach (string s in allcolors) 
            //{ 
            // listBox1.Items.Add(s); 
            //}
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Object ColorEnum;
            ColorEnum = System.Enum.Parse(typeof(KnownColor), listBox1.Text);
            KnownColor SelectedColor = (KnownColor)ColorEnum;
            this.BackColor = System.Drawing.Color.FromKnownColor(SelectedColor);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        public class MaxMinDemo
        {
            public static void Main()
            {
                int x;
                int y;
                int z;
                Console.Write("������� ������ �����: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("������� ������ �����: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("������� ������ �����: ");
                z = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("���������� ����� �� ����: " +
                FindMax3(x, y, z));
                Console.WriteLine("���������� ����� �� ����: " +
                FindMin3(x, y, z));
                Console.ReadLine();
            }

            // ����� ��� ���������� ����������� �������� �� ���� �������� ����� 
            public static int FindMax3(int a, int b, int c)
            {
                int max;
                max = Math.Max(a, Math.Max(b, c));
                return max;
            }

            // ����� ��� ���������� ����������� �������� �� ���� �������� ����� 
            public static int FindMin3(int a, int b, int c)
            {
                int min;
                min = Math.Min(a, Math.Min(b, c));
                return min;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String[] s = Regex.Split("������ ������� ���� ������ ��� ���� ���� ������ �������� ������� ������ �������", " ");
        }


        class ScopeDemo
        {
            private void button12_Click(object sender, EventArgs e)
            {
            }

            private static void Main()
            {
                String[] s = Regex.Split("������ ������� ���� ������ ��� ���� ���� ������ �������� ������� ������ �������", " ");
                // ������� 12 ������� ������� 
                MessageBox.Show(s[11].ToString());
            }
        }  
    } 
    }
}