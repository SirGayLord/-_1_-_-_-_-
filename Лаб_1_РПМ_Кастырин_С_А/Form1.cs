using System.Numerics;

namespace Лаб_1_РПМ_Кастырин_С_А
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Проверка ввода числа
            if (!int.TryParse(textBox1.Text, out int inputNumber) || inputNumber < 0)
            {
                MessageBox.Show("Пожалуйста, введите целое неотрицательное число");
                return;
            }

            // Вычисление факториала с использованием BigInteger
            BigInteger result = CalculateFactorial(inputNumber);

            // Отображение результата
            textBox2.Text = result.ToString();
        }

        private BigInteger CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                BigInteger factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }
    }
}