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
            textBox1.Text = Convert.ToString(myvalue, 2); // возвратит 100
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int myValue = 365;
            // Преобразуем в восьмеричное значение 
            MessageBox.Show(Convert.ToString(myValue, 8));
            // Преобразуем в шестнадцатеричное значение 
            MessageBox.Show(Convert.ToString(myValue, 16));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // введите в текстовое поле любое число или слово 
            string numstring = textBox1.Text;
            bool bResult1;
            bResult1 = Information.IsNumeric(numstring);
            MessageBox.Show("Является ли " + numstring + " числом: " + bResult1);
        }


        static bool IsNumeric(object Expression)
        {
            // Возвращаемое значение 
            bool isNum;
            // Переменная, используемая в качестве параметра 
            // в методе TryParse 
            double retNum;
            // Метод TryParse конвертирует строку в заданный стиль 
            // и локальный формат. 
            isNum = Double.TryParse(Convert.ToString(Expression),
            System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Является ли " + textBox1.Text +
            " числом: " + IsNumeric(textBox1.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Guid newGuid = Guid.NewGuid();
            // Уникальный идентификатор с дефисами 
            //MessageBox.Show(newGuid.ToString()); 
            // Уникальный идентификатор без дефисов 
            textBox1.Text = newGuid.ToString("N");

        }


        enum Cats { Рыжик = 3, Барсик = 5, Мурзик, Васька, Пушок };
        private void button7_Click(object sender, EventArgs e)
        {
            // Перечисляем все элементы перечисления 
            string[] catNames = Enum.GetNames(typeof(Cats));
            foreach (string s in catNames)
            {
                listBox1.Items.Add(s);
            }
            // Перечисляем все значения перечисления 
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
            // Получаем массив строк, содержащих все цвета в системе 
            string[] allcolors =
            Enum.GetNames(typeof(System.Drawing.KnownColor));
            listBox1.Items.Clear();
            // Выводим все имена в список 
            listBox1.Items.AddRange(allcolors);
            // Другой вариант 
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
                Console.Write("Введите первое число: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите третье число: ");
                z = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Наибольшее число из трех: " +
                FindMax3(x, y, z));
                Console.WriteLine("Наименьшее число из трех: " +
                FindMin3(x, y, z));
                Console.ReadLine();
            }

            // Метод для нахождения наибольшего значения из трех заданных чисел 
            public static int FindMax3(int a, int b, int c)
            {
                int max;
                max = Math.Max(a, Math.Max(b, c));
                return max;
            }

            // Метод для нахождения наименьшего значения из трех заданных чисел 
            public static int FindMin3(int a, int b, int c)
            {
                int min;
                min = Math.Min(a, Math.Min(b, c));
                return min;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String[] s = Regex.Split("Январь Февраль Март Апрель Май Июнь Июль Август Сентябрь Октябрь Ноябрь Декабрь", " ");
        }


        class ScopeDemo
        {
            private void button12_Click(object sender, EventArgs e)
            {
            }

            private static void Main()
            {
                String[] s = Regex.Split("Январь Февраль Март Апрель Май Июнь Июль Август Сентябрь Октябрь Ноябрь Декабрь", " ");
                // Выводим 12 элемент массива 
                MessageBox.Show(s[11].ToString());
            }
        }  
    } 
    }
}