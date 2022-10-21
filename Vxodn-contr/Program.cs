using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vxodn_contr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ExerciseDegree();
            program.ExerciseRemainder();
            program.ExerciseDegreeTen();
            program.ExerciseEquation();
            program.ExerciseFibonacci();
            program.ExerciseSubsequence();
            program.ExerciseSwim();
            Console.ReadKey();

        }

        public void ExerciseDegree()
        {
            Console.WriteLine("Возведение в степень\n");
            Console.Write("Введите первое число = ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число = ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Полученный результат возведения первого числа в степень второго числа = ");
            double answer = Math.Pow(a, b);
            Console.WriteLine($"{answer}\n");
           
        }

        public void ExerciseRemainder()
        {
            Console.WriteLine("Сравнение остатков от деления на 2 и 3\n");

            Console.Write("Введите число = ");
            double a = Double.Parse(Console.ReadLine());
            double answer_one = a % 2;
            double answer_two = a % 3;
            if (answer_one == answer_two)
            {
                Console.WriteLine("Остатки равны\n");
            }
            else
            {
                Console.WriteLine("Остатки не равны\n");
            }

        }

        public void ExerciseDegreeTen()
        {
            Console.WriteLine("Возведение в степень 10\n");

            Console.Write("Введите число = ");
            int a = int.Parse(Console.ReadLine());
            int answer;
            for (int b = 1; b <= 10; b++)
            {
                answer = Convert.ToInt32(Math.Pow(a, b));
                Console.WriteLine(answer);          
            }
            Console.WriteLine();
        }

        public void ExerciseEquation()
        {
            Console.Write("Введите x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите y = ");
            int y = int.Parse(Console.ReadLine());
            double answer = (1 + Math.Sin(Math.Sqrt(x + 1))) / (Math.Cos(12 * y - 4));
            Console.WriteLine($"{answer}\n");
        }

        public void ExerciseFibonacci()
        {
            Console.Write("Введите количество чисел = ");
            int feb = int.Parse(Console.ReadLine());
            int feb_two = 0;
            int feb_thre = 1;
            Console.WriteLine("Числа Фибоначи");
            for (int i = 2; i < feb * 2; i++)
            {
                feb_two = feb_two + feb_thre;
                if (i % 2 != 0)
                {
                    int indeks = i + 1;
                    Console.WriteLine($"{feb_two} Индекс {indeks}");
                }
            }
            Console.WriteLine();
        }

        public void ExerciseSubsequence()
        {
            Console.Write("Введите количество чисел = ");
            double n = double.Parse(Console.ReadLine());
            double answer = 0;
            double c = 1;
            double v = 2;
            for (int i = 0; i < n; i++)
            {
                answer += c / v;
                c++;
                v++;

            }
            Console.WriteLine($"Результат {answer} \n");
        }
        public void ExerciseSwim()
        {
            Console.WriteLine("Введите результаты первого плавца (в секундах)");
            double first = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите результаты второго плавца (в секундах)");
            double second = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите результаты третьего плавца (в секундах)");
            double third = Double.Parse(Console.ReadLine());

            if (first < second & first < third)
            {
                Console.WriteLine($"Первый плавец быстрее остальных с результатом {first} сек.");
            }
            else if (second < first & second < third)
            {
                Console.WriteLine($"Второй плавец быстрее остальных с результатом {second} сек.");
            }
            else
            {
                Console.WriteLine($"Третий плавец быстрее остальных с результатом {third} сек.");
            }
        }
    }
}
