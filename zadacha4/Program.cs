using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;//сумма
            int n = 0;//количество проходов
            double temp;//предыдущий результат, для проверки точности
            do
            {
                temp = sum;
                sum += Math.Pow((-1), n) / (Factorial(n) * ((2*n) + 1));
                n++;
            }
            while (Math.Abs(sum - temp) > 0.001);
            Console.WriteLine("Сумма ряда: " + sum);
            Console.ReadLine();
        }
        private static double Factorial(int i)
        {
            if (i <= 1) return 1;
            else
                return Factorial(i - 1) * i;
        }
    }
}
