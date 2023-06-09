using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace _2._11_2._25_прод
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                throw new ArgumentNullException("textBox1.Text");
            listBox1.Items.Add(string.Concat("Hello, ", textBox1.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Взять текст из текстового поля
            // Например, А роза упала на лапу Азора
            string myString = textBox1.Text;
            // Используем встроенную функцию Visual Basic
            textBox1.Text = Strings.StrReverse(myString);
        }

        public static string ReverseString(string str)
        {
            // Проверка на непустоту строки.
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            // Создадим объект StringBuilder с нужной длиной.
            StringBuilder revStr = new StringBuilder(str.Length);
            // Перебираем в цикле все символы
            // и присоединяем каждый символ к StringBuilder
            for (int count = str.Length - 1; count > -1; count--)
            {
                revStr.Append(str[count]);
            }
            // Возвращаем перевернутую строку
            return revStr.ToString();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = ReverseString(textBox1.Text);
        }


        [DllImport("shlwapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool PathCompactPathEx(
        System.Text.StringBuilder pszOut,
        string pszSrc,
        Int32 cchMax,
        Int32 dwFlags);
        private void button10_Click(object sender, EventArgs e)
        {
            // длинный путь к файлу
            string strPathFile =
            "c:/program files/My SuperProgram/skins/sample.txt";
            StringBuilder sb = new StringBuilder(260);
            // оставляем 20 символов, остальное заменяем многоточием
            bool b = PathCompactPathEx(sb, strPathFile, 20 + 1, 0);
            // Выводим результат в текстовое поле
            textBox1.Text = sb.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button111.Text == "Старт")
            {
                timer1.Enabled = true;
                button111.Text = "Стоп";
            }
            else
            {
                timer1.Enabled = false;
                button111.Text = "Старт";
            }
        }
        public static int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string typingText = "C#.Народные советы";

            this.Text = typingText.Substring(0, counter);
            counter++;
            if (counter > typingText.Length)
                counter = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }
        private string scrollText = "C#.Народные советы ";
      
        private void timer2_Tick_1(object sender, EventArgs e)
        {
 // Удаляем один символ слева и прибавляем его с правой стороны
            scrollText = scrollText.Substring(1, (scrollText.Length - 1)) + scrollText.Substring(0, 1);
            this.Text = scrollText;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            /*
            StringBuilder sb = new StringBuilder();
            sb.Append("строка 1");
            sb.Append("строка 2");
            this.Text = sb.ToString();
            */
            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text);
            sb.Append(textBox2.Text);
            this.Text = sb.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.UtcNow;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    if (DateTime.UtcNow == dt)
                    {
                        MessageBox.Show("Привет");
                        /* do action */
                    }
                }
                MessageBox.Show(sw.ElapsedTicks.ToString());
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(1945, 5, 9); // Первая дата
            DateTime date2 = new DateTime(2007, 8, 21); // Вторая дата
                                                        // Вычисляем разницу в днях при помощи перечисления DateInterval.Day
            long diff = DateAndTime.DateDiff(DateInterval.Day, date1, date2,
            FirstDayOfWeek.Monday, FirstWeekOfYear.System);
            // Выводим результат в заголовке формы
            this.Text = diff.ToString();
        }


        public static int DaysDiff(DateTime date1, DateTime date2)
        {
            return date1.Subtract(date2.Date).Days;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string howdays = DaysDiff(DateTime.Today, new DateTime(2007, 08, 21)).ToString();
            MessageBox.Show("Со дня моего дня рождения прошло: " + howdays);
            //listBox1.Items.Add("Со дня моего дня рождения прошло: " + howdays);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Измеряем производительность для UtsNow 
            DateTime dt = DateTime.UtcNow;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    if (DateTime.UtcNow == dt)
                    {
                        /* do action */
                    }
                }
                MessageBox.Show(sw.ElapsedTicks.ToString());
            }
            // Аналогичная проверка производительности для Now 
            DateTime dt1 = DateTime.Now;
            Stopwatch sw1 = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    if (DateTime.Now == dt1)
                    {
                        /* do action */
                    }
                }
                MessageBox.Show(sw1.ElapsedTicks.ToString());
            }

            /*
            DateTime dt = DateTime.Now;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    if (DateTime.Now == dt)
                    {
                        MessageBox.Show("Пока");
                    }
                }
                MessageBox.Show(sw.ElapsedTicks.ToString());
            */
        }



        }
    }
}