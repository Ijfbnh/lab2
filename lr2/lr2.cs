using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
        internal class Lr2
        {
            public void task1()
            {
                double a, b, c;
                Console.WriteLine("решите уравнение ax^2+bx+c=0");
                Console.WriteLine("Веддите а = ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите b = ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите с = ");
                c = double.Parse(Console.ReadLine());
                Console.WriteLine($"Получили уравнения {a}x^2+{b}x+{c}= 0");
                double x1, x2, d;
                d = b * b - 4 * a * c;
                if (d > 0)
                {
                    Console.WriteLine($"дискременат больше 0. два корня d={d}");
                    x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    x2 = (-b + Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine($"результат x1={x1} x2={x2}");
                }
                if (d == 0)
                {
                    Console.WriteLine($"дискременант равен 0. один корень D={d}");
                    x1 = -b / 2 * a;
                    Console.WriteLine($"результат x1={x1}");
                }
                if (d < 0)
                {
                    Console.WriteLine($"дискременант меньше 0.два мнимых корня d={d}");
                    d = Math.Abs(d);
                    x1 = -b / 2 * a;
                    Console.WriteLine($"Результат x1={x1}-{Math.Sqrt(d)}i, x2={x1}+{Math.Sqrt(d)}i");
                }
            }
            public void task2()
            {
                int count = 0;
                Console.WriteLine("введите кло-во слогаемых для вычисления pi");
                count = int.Parse(Console.ReadLine());
                if (count <= 0)
                {
                    Console.WriteLine("число слагаемых должно быть больше 0");
                    return;
                }
                double pi = 0;
                double tmp = 0;
                int step = 1;
                for (int i = 0; i < count; i++)
                {
                    if (i == 0)
                    {
                        tmp = 1;
                    }
                    else
                        tmp = (i % 2 == 0) ?
                            tmp + (double)(1.0 / step) :
                            tmp - (double)(1.0 / step);
                    Console.WriteLine($"#{i} tmp= {tmp} step= {step}");
                    step += 2;
                }
                pi = 4 * tmp;
                Console.WriteLine($"результат {pi}");
            }
            public void task3()
            {
                int count = 0;
                Console.WriteLine("введите число операций");
                count = int.Parse(Console.ReadLine());
                double[] f = new double[count];
                double count4 = 0;
                for (int i = 0; i < count; i++)
                {
                    if (i < 2)
                        f[i] = 1;
                    else
                        f[i] = f[i - 1] + f[i - 2];
                    if (f[i] >= 1000 && f[i] <= 9999)
                        count4++;
                    Console.WriteLine($"шаг {i} f= {f[i]}");
                }
                Console.WriteLine($"всего 4х значных элементов {count4}");
            }
            public void task4()
            {
                Console.Write("Введите значение x: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите значение q (точность): ");
                double q = double.Parse(Console.ReadLine());

                double cosX = 1;
                double term = 1;
                int n = 1;
                int count = 1;

                while (Math.Abs(term) > q)
                {
                    term *= -x * x / ((2 * n - 1) * (2 * n));
                    cosX += term;
                    n++;
                    count++;
                }

                Console.WriteLine($"Приближённое значение cos({x}) = {cosX}");
                Console.WriteLine($"Количество учтённых слагаемых: {count}");
            }
            public void task5()
            {
                int n;
                Console.WriteLine("введите N>0");
                n = int.Parse(Console.ReadLine());
                double result = 0;
                bool find = false;
                int x = 0, y = 0, z = 0;
                for (x = 0; x < n; x++)
                    for (y = 0; y < n; y++)
                        for (z = 0; z < n; z++)
                        {
                            result = Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3);
                            if (result == n)
                            {
                                Console.WriteLine("в ходе перебора нашли значение x^3+y^3+z^3=N");
                                Console.WriteLine($"{x}^3+{y}^3+{z}^3={n}");
                                find = true;
                            }
                        }

                if (!find)
                    Console.WriteLine("ничего не найдено");
            }
            public void task6()
            {
                int n;
                Console.WriteLine("введите N>0");
                n = int.Parse(Console.ReadLine());
                double result = 0;
                bool find = false;
                int x = 0, y = 0, z = 0;
                for (x = 0; x < n; x++)
                    for (y = 0; y < n; y++)
                        for (z = 0; z < n; z++)
                        {
                            result = Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3);
                            if (result == n)
                            {
                                Console.WriteLine("в ходе перебора нашли значение x^3+y^3+z^3=N");
                                Console.WriteLine($"{x}^3+{y}^3+{z}^3={n}");
                                find = true;
                            }
                        }

                if (!find)
                    Console.WriteLine("ничего не найдено");
            }
            public void task7()
            {
                int age = 0;
                Console.WriteLine("введите возраст");
                age = int.Parse(Console.ReadLine());
                if (age < 1 || age >= 100)
                {
                    Console.WriteLine("неверный ввод");
                    return;

                }
                string ageTmp = "";
                if (age == 0 || age % 10 == 0 || age >= 5 && age <= 19 || age % 10 >= 5)
                    ageTmp = "лет";
                if ((age % 10 == 1 || age == 1) && (age < 10 || age > 20)) ageTmp = "год";
                if (age % 10 == 2 || age % 10 == 3 || age % 10 == 4) ageTmp = "года";
                Console.WriteLine($"вам {age} {ageTmp}");
            }
            public void task8()
            {
                Console.Write("Введите первое число: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());

                if (num1 < 0 || num2 < 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    double minNum = Math.Min(num1, num2);
                    double sqrtResult = Math.Sqrt(minNum);
                    Console.WriteLine($"Квадратный корень меньшего числа ({minNum}) = {sqrtResult}");
                }
            }
        }
    }

