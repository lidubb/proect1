using System;
using System.Globalization;

namespace z1
{
    internal class Program
    {
        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string s = (Console.ReadLine() ?? "").Trim().Replace(',', '.');
                if (double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out double v))
                    return v;
                Console.WriteLine("Ошибка: введите число.");
            }
        }

        static void Main(string[] args)
        {
            double a = ReadDouble("Введите длину стороны a: ");
            double b = ReadDouble("Введите длину стороны b: ");

            Console.WriteLine($"Площадь: {a * b}");
            Console.WriteLine($"Периметр: {2 * (a + b)}");
        }
    }
}

/*using System;
using System.Globalization;

namespace z2
{
    internal class Program
    {
        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string s = (Console.ReadLine() ?? "").Trim().Replace(',', '.');
                if (double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out double v))
                    return v;
                Console.WriteLine("Ошибка: введите число.");
            }
        }

        static void Main(string[] args)
        {
            double rate;
            do
            {
                rate = ReadDouble("Введите текущий курс (рублей за 1 доллар): ");
            } while (rate <= 0);

            double rubles = ReadDouble("Введите сумму в рублях: ");
            Console.WriteLine($"{rubles} руб. = {rubles / rate:F2} $");
        }
    }
}*/

/*using System;
using System.Globalization;

namespace z3
{
    internal class Program
    {
        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string s = (Console.ReadLine() ?? "").Trim().Replace(',', '.');
                if (double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out double v))
                    return v;
                Console.WriteLine("Ошибка: введите число.");
            }
        }

        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 1; i <= 7; i++)
            {
                sum += ReadDouble($"Температура за день {i}: ");
            }
            Console.WriteLine($"Средняя температура за неделю: {sum / 7:F2}");
        }
    }
}*/

/*using System;
using System.Globalization;

namespace z4
{
    internal class Program
    {
        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string s = (Console.ReadLine() ?? "").Trim().Replace(',', '.');
                if (double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out double v))
                    return v;
                Console.WriteLine("Ошибка: введите число.");
            }
        }

        static void Main(string[] args)
        {
            const int students = 3;
            const int gradesCount = 5;
            double[] averages = new double[students];

            for (int s = 0; s < students; s++)
            {
                Console.WriteLine($"Студент {s + 1}: введите {gradesCount} оценок");
                double sum = 0;
                for (int g = 1; g <= gradesCount; g++)
                {
                    sum += ReadDouble($"  Оценка {g}: ");
                }
                averages[s] = sum / gradesCount;
            }

            Console.WriteLine("Средние оценки:");
            for (int s = 0; s < students; s++)
            {
                Console.WriteLine($"Студент {s + 1}: {averages[s]:F2}");
            }
        }
    }
}*/


namespace z5
{
    internal class Program
    {
        static void PrintMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write(m[i, j] + " ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            const int n = 3;
            int[,] matrix = new int[n, n];

            Console.WriteLine("Введите матрицу 3x3: по 3 числа через пробел");
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"Строка {i + 1}: ");
                    string line = Console.ReadLine() ?? "";
                    string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length == n && parts.All(p => int.TryParse(p, out _)))
                    {
                        for (int j = 0; j < n; j++)
                            matrix[i, j] = int.Parse(parts[j]);
                        break;
                    }
                    Console.WriteLine("Ошибка: нужно ввести ровно 3 целых числа через пробел.");
                }
            }

            int[,] transposed = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    transposed[j, i] = matrix[i, j];

            Console.WriteLine("Было:");
            PrintMatrix(matrix);
            Console.WriteLine("Стало:");
            PrintMatrix(transposed);
        }
    }
}