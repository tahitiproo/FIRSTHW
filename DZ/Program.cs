using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1");
            Console.Write("Введите своё имя: ");
            string a = Console.ReadLine();
            Console.WriteLine($"Приветствую вас, {a}");


            Console.WriteLine("Упражнение 2.2");
            try                                                     // использую try для обработки исключений
            {
                Console.WriteLine("Введите первое число");
                int firstnumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int secondnumber = int.Parse(Console.ReadLine());
                double del = firstnumber / secondnumber;            // числа могут быть не кратными друг другу
                Console.WriteLine($"Деление чисел равно: = {del}");
            }
            catch (OverflowException caught)                        // исключение от чрезмерных значений
            {
                Console.WriteLine(caught);
            }
            catch (DivideByZeroException caught)                    // исключение от деления на 0
            {
                Console.WriteLine(caught);
            }
            catch (System.Exception caught)                         // исключение от ошибок остального типа
            {
                Console.WriteLine(caught);
            }
            finally
            {
            }


            Console.WriteLine("Домашнее задание 2.1");
            try                                                                              // может быть некорректный ввод данных
            {
                Console.Write("Введите букву: ");
                var ascii = Console.ReadLine();
                var inprog = Convert.ToChar(ascii);                                          // считывается как строка и необходимо преобразование в чар
                var inprog2 = (int)inprog + 1;                                               // выбираю следующую по порядку букву
                if (inprog2 == 91 | inprog2 == 1072)                                         // числовое значение 'Z' и 'Я' соответственно
                {
                    var inprog3 = (char)((int)inprog2 - 1);                   // берется предыдущий символ поскольку уже взят следующий, условность кода
                    Console.WriteLine($"'{inprog3}' является последней буквой в алфавите");
                }
                else
                {
                    var itog = (char)inprog2;
                    Console.WriteLine($"{itog}");
                }
            }
            catch
            {
                                                                                              // чтобы обрабатывать ошибки любого типа
            }
            finally
            {

            }


            Console.WriteLine("Домашнее задание 2.2");
            try                                                                         // возможен ряд исключений
            {
                Console.Write("Введите коэффициент a: ");
                double firstkoeff = int.Parse(Console.ReadLine());
                Console.Write("Введите коэффициент b: ");
                double secondkoeff = int.Parse(Console.ReadLine());
                Console.Write("Введите коэффициент c: ");
                double thirdkoeff = int.Parse(Console.ReadLine());
                double D = secondkoeff * secondkoeff - 4 * firstkoeff * thirdkoeff;     // формула дискриминанта
                double SqrtD = Math.Sqrt(D);                                            // заранее пишу формулу чтобы не забивать код
                if (D < 0)
                {
                    Console.WriteLine("Корни принадлежат множеству комплексных чисел"); // не зря комплексные числа прошёл)
                }
                else if (firstkoeff == 0)                                               // существует частный случай
                {
                    double odinkorenb = -thirdkoeff / secondkoeff;
                    Console.WriteLine($"Единственный корень уравнения: {odinkorenb}");
                }
                else if (D == 0)
                {
                    double odinkorenb = ((-secondkoeff + SqrtD) / (2 * firstkoeff));    // формула корня квадр. уравн.
                    Console.WriteLine($"Единственный корень уравнения: {odinkorenb}");
                }
                else if (D > 0)
                {
                    double dvoistvkorenb1 = ((-secondkoeff + SqrtD) / (2 * firstkoeff));
                    double dvoistvkorenb2 = ((-secondkoeff - SqrtD) / (2 * firstkoeff));
                    Console.WriteLine($"Первый корень уравнения: {dvoistvkorenb1}");
                    Console.WriteLine($"Второй корень уравнения: {dvoistvkorenb2}");
                }
            }
            catch (OverflowException caught)                                            // исключение чрезмерных значений
            {
                Console.WriteLine(caught);
            }
            catch (SystemException caught)                                              // исключение остальных возможных ошибок
            {
                Console.WriteLine(caught);
            }
            finally
            {
            }
            Console.ReadKey();
        }

    }
}