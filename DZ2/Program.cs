using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 1");
            double exponenta = Math.Exp(1);
            double exp = Math.Round(exponenta, 1);
            Console.WriteLine(exp);
            Console.ReadKey();


            Console.WriteLine("Упражнение 2");
            Console.WriteLine("50");
            Console.WriteLine("10");

            
            Console.WriteLine("Упражнение 3");
            Console.WriteLine("Введите первое число:");
            double pervoechislo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double vtoroechislo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            double tretbechislo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите четвертое число:");
            double chetvertoechislo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(pervoechislo);
            Console.WriteLine(vtoroechislo);
            Console.WriteLine(tretbechislo);
            Console.WriteLine(chetvertoechislo);
            


            Console.WriteLine("Упражнение 4");
            double vvod = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{vvod + 10}");
            

            Console.WriteLine("Упражнение 5");
            Console.Write("Дана сторона квадрата: ");
            double kvadrat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Периметр равен: {4 * kvadrat}");
            

            Console.WriteLine("Упражнение 6");
            Console.WriteLine("Дан радиус окружности: ");
            double krug = Convert.ToDouble(Console.ReadLine());
            double dlinokr = 2 * Math.PI * krug;
            double ploshzadbokr = Math.PI * krug * krug;
            Console.WriteLine($"Длина окружности: {dlinokr}; Площадь круга: {ploshzadbokr}");
            


            Console.WriteLine("Упражнение 7");
            double cosinus = Math.Cos(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(cosinus);
            


            Console.WriteLine("Упражнение 8");
            Console.Write("Введите длину первого основания ");
            double pervoeost = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второго основания: ");
            double vtoroeost = Convert.ToDouble(Console.ReadLine());
            double razn = (Math.Abs(pervoeost - vtoroeost)) / 2;
            Console.Write("Введите высоту: ");
            double visota = Convert.ToDouble(Console.ReadLine());
            double bokovayastorona = Math.Sqrt(razn * razn + visota * visota);
            Console.WriteLine($"{pervoeost + vtoroeost + 2 * bokovayastorona}");


            Console.WriteLine("Упражнение 9");
            Console.Write("Введите стоимость 1 кг конфет: ");
            double stoimostbkonfet = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость 1 кг печенья: ");
            double stoimostbpecheniya = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость 1 кг яблок: ");
            double stoimostbyablok = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки: {stoimostbkonfet + "x"  + "+" + stoimostbpecheniya + "y" + "+" +  stoimostbyablok + "z"}");


            Console.WriteLine("Упражнение 10");
            Console.WriteLine("Мир" + " " + "Труд" + " " + "Май");
            Console.WriteLine("Мир");
            Console.WriteLine("{0,9}", "Труд");
            Console.WriteLine("{0,14}","Май");
            
            Console.WriteLine("Упражнение 11");
            try
            {
                Console.WriteLine("Введите первое число: ");
                string firstnumber = Console.ReadLine();
                firstnumber = firstnumber.Replace('.', ',');
                Console.WriteLine($"{firstnumber}");
                double firstnumber1 = Convert.ToDouble(firstnumber);
                Console.WriteLine("Введите второе число: ");
                string secondnumber = Console.ReadLine();
                secondnumber = secondnumber.Replace('.', ',');
                double secondnumber1 = Convert.ToDouble(secondnumber);
                (firstnumber1, secondnumber1) = (secondnumber1, firstnumber1);
                Console.WriteLine($"{firstnumber1} {secondnumber1}");
            }
            catch(FormatException caught)
            {
                Console.WriteLine(caught);
            }
            catch(OverflowException oshibka)
            {
                Console.WriteLine(oshibka);
            }
            finally
            {
                Console.ReadKey();
            }
            

            Console.WriteLine("Упражнение 12");
            Console.WriteLine("Введите, какая фигура вас интересует: круг,четырёхугольник или треугольник ");
            string figura = Console.ReadLine();
            Console.WriteLine("Выберите что считать: периметр или площадь");
            string parametr = Console.ReadLine();
            if (figura == "круг" | figura == "Круг")
            {
                Console.WriteLine("Введите радиус круга");
                int radius = Convert.ToInt32(Console.ReadLine());
                if (parametr == "периметр" | parametr == "Периметр")
                {

                    Console.WriteLine($"Длина окружности равна {2 * Math.PI * radius}");
                }
                else
                {
                    Console.WriteLine($"Площадь круга равна {Math.PI * Math.Pow(radius, 2)}");
                }
            }
            else if (figura == "треугольник" | figura == "Треугольник")
            {
                Console.WriteLine("Введите стороны треугольника через пробел: ");
                int[] stortr = Console.ReadLine().Split(' ').Select(m => int.Parse(m)).ToArray();
                if (parametr == "Периметр" | parametr == "периметр")
                {
                    Console.WriteLine($"Периметр равен: {stortr[0] + stortr[1] + stortr[2]}");
                }
                else
                {
                    double p = (stortr[0] + stortr[1] + stortr[2]) / 2;
                    Console.WriteLine($"Площадь равна: {Math.Sqrt(p * (p - stortr[0]) * (p - stortr[1]) * (p - stortr[2]))}");
                }
            }
            else if (figura == "Четырёхугольник" | figura == "четырёхугольник")
            {
                Console.WriteLine("Введите стороны четырёхугольника через пробел: ");
                int[] storchet = Console.ReadLine().Split(' ').Select(m => int.Parse(m)).ToArray();
                if(parametr == "Периметр" | parametr == "периметр")
                {
                    Console.WriteLine($"Периметр четырёхугольника равен {storchet[0] + storchet[1] + storchet[2] + storchet[3]}");
                }
                else
                {
                    Console.WriteLine($"Площадь четырёхугольника равна {storchet[0] * storchet[1]}");
                }
            }
            Console.ReadKey();
            

            Console.WriteLine("Упражнение 13");
            Console.Write("Введите число: ");
            double chislo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Вы ввели число: {chislo}");
            Console.ReadKey();
            

            Console.WriteLine("Упражнение 14");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");
            

            Console.WriteLine("Упражнение 15");
            Console.Write("Введите первое число: ");
            double pervoechislo1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double vtoroechislo2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double tretbechislo3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите четвертое число: ");
            double chetvertoechislo4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{pervoechislo1}");
            Console.WriteLine($"{vtoroechislo2}");
            Console.WriteLine($"{tretbechislo3}");
            Console.WriteLine($"{chetvertoechislo4}");


            Console.WriteLine("Упражнение 16");
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

            Console.WriteLine("Упражнение 17");
            Console.WriteLine("Введите целое число: ");
            int czeloe1chislo = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число: ");
            int czeloe2chislo = int.Parse(Console.ReadLine());
            double srarifm = (czeloe1chislo + czeloe2chislo) / 2;
            double srgeometr = Math.Sqrt(czeloe1chislo * czeloe2chislo);
            Console.WriteLine($"Среднее арифметическое двух чисел: {srarifm}");
            Console.WriteLine($"Среднее геометрическое двух чисел: {srgeometr}");
            

            Console.WriteLine("Упражнение 18");
            Console.Write("Введите x координату точки А: ");
            double coordinatax1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y координату точки A: ");
            double coordinatay1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x координату точки B: ");
            double coordinatax2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y координату точки B: ");
            double coordinatay2 = Convert.ToDouble(Console.ReadLine());
            double raznichzax = Math.Abs(coordinatax2 - coordinatax1);
            double raznichzay = Math.Abs(coordinatay2 - coordinatay1);
            double rasstoyanie = Math.Sqrt(Math.Pow(raznichzax, 2) + Math.Pow(raznichzay, 2));
            Console.WriteLine($"Расстояние между точками: {rasstoyanie}");

            Console.WriteLine("Упражнение 19");
            double a19 = Convert.ToDouble(Console.ReadLine());
            double b19 = Convert.ToDouble(Console.ReadLine());
            double c19 = Convert.ToDouble(Console.ReadLine());
            (a19, b19, c19) = (b19, c19, a19);
            Console.WriteLine($"Схема а: {a19} {b19} {c19}");
            (b19, c19, a19) = (a19, b19, c19);
            (a19, b19, c19) = (c19, a19, b19);
            Console.WriteLine($"Схема б: {a19} {b19} {c19}");
            

            Console.WriteLine("Упражнение 20");
            Console.Write("Прошло секунд: ");
            Int64 sekyndi = Int64.Parse(Console.ReadLine());
            long chasi = (sekyndi / 3600)%24;
            Console.WriteLine($"Прошло {chasi} полных часов");
            long minuti = (sekyndi % 3600)/60;
            Console.WriteLine($"C начала очередного часа прошло {minuti} полных минут");
            sekyndi %= 60;
            Console.WriteLine($"С начала очередной минуты прошло {sekyndi} полных секунд");
            Console.WriteLine($"Текущее время: {chasi}:{minuti}:{sekyndi}");
            

            Console.WriteLine("Упражнение 21");
            Console.Write("Введите длину прямоугольника: ");
            long dlinapryamougol = Int64.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            long shirinapryamougol = Int64.Parse(Console.ReadLine());
            Console.Write("Введите значение стороны квадрата: ");
            long storonakvadrata = Int64.Parse(Console.ReadLine());
            dlinapryamougol /= storonakvadrata;
            shirinapryamougol /= storonakvadrata;
            long skolbko = dlinapryamougol * shirinapryamougol;
            Console.WriteLine($"Можно отрезать {skolbko} квадратов ");
            Console.ReadKey();
            

            Console.WriteLine("Упражнение 22");
            int trehznachnoechislo = int.Parse(Console.ReadLine());
            int iirazryad = trehznachnoechislo % 10;
            Console.WriteLine($"{iirazryad}");
            trehznachnoechislo /= 10;
            Console.WriteLine($"{trehznachnoechislo}");
            trehznachnoechislo = iirazryad * 100 + trehznachnoechislo;
            Console.WriteLine($"{trehznachnoechislo}");
            

            Console.WriteLine("Упражнение 23");
            int tisechnoechislo = int.Parse(Console.ReadLine());
            int chislosotenchisla = (tisechnoechislo % 1000) / 100;
            int chiclotisyachchisla = (tisechnoechislo % 10000) / 1000;
            Console.WriteLine($"В числе {chislosotenchisla} сотен");
            Console.WriteLine($"В числе {chiclotisyachchisla} тысяч");
            Console.ReadKey();
            

            Console.WriteLine("Упражнение 24");
            int chetirehznachnoechislo = int.Parse(Console.ReadLine());
            string chetirehznachnoechislo1 = Convert.ToString(chetirehznachnoechislo);
            int s = 0;
            while (chetirehznachnoechislo > 0)
            {
                s *= 10;
                s += chetirehznachnoechislo % 10;
                chetirehznachnoechislo /= 10;
            }
            string chet = Convert.ToString(chetirehznachnoechislo1[1])
                        + Convert.ToString(chetirehznachnoechislo1[0])
                        + Convert.ToString(chetirehznachnoechislo1[3])
                        + Convert.ToString(chetirehznachnoechislo1[2]);
            string chelt = Convert.ToString(chetirehznachnoechislo1[0])
                         + Convert.ToString(chetirehznachnoechislo1[2])
                         + Convert.ToString(chetirehznachnoechislo1[1])
                         + Convert.ToString(chetirehznachnoechislo1[3]);
            string chemt = Convert.ToString(chetirehznachnoechislo1[2])
                         + Convert.ToString(chetirehznachnoechislo1[3])
                         + Convert.ToString(chetirehznachnoechislo1[0])
                         + Convert.ToString(chetirehznachnoechislo1[1]);
            Console.WriteLine($"a) perevertish: {s}");
            Console.WriteLine($"b) {int.Parse(chet)}");
            Console.WriteLine($"c) {int.Parse(chelt)}");
            Console.WriteLine($"c) {int.Parse(chemt)}");
            Console.ReadKey();
            

            Console.WriteLine("Упражнение 25");
            Console.WriteLine("Введите число 100 <= n =< 999");
            string inpt3 = Console.ReadLine();
            if ((int.Parse(inpt3) / 10) % 10 == 0)
            {
               Console.WriteLine("Введите другое число");
            }
            else
            {
               Console.WriteLine("x = " + inpt3[1] + inpt3[2] + inpt3[0]);
            }


            Console.WriteLine("Упражнение 26");
            Console.WriteLine("Введите время: часы, минуты, секунды по очереди");
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            if (hour > 11)
            {
                hour -= 12;
            }
            Console.WriteLine("Угол между положением стрелки на началr дня и временем ввреденным вами равен: " + ((360 / 12) * hour + (0.5 * minutes) + (0.0083 * seconds)));


            Console.WriteLine("Упражнение 28");
            double veschchislo1 = double.Parse(Console.ReadLine());
            double veschchislo2 = double.Parse(Console.ReadLine());
            double veschchislo3 = double.Parse(Console.ReadLine());
            double min = Math.Min(Math.Abs(veschchislo3), Math.Abs(veschchislo2));
            min = Math.Min(min, Math.Abs(veschchislo1));
            Console.WriteLine($"Наименьшее по модулю: {min}");
            Console.ReadKey();


            Console.WriteLine("Упражнение 29");
            Console.Write("Введите первое число: ");
            double prostochislo1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double prostochislo2 = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double prostochislo3 = double.Parse(Console.ReadLine());
            if (prostochislo1 > prostochislo2)
            {
                if (prostochislo2 > prostochislo3)
                {
                    Console.Write($"{prostochislo1 + prostochislo3}");      // 123 
                }
                else 
                {
                    if (prostochislo1>prostochislo3)
                    {
                        Console.Write($"{prostochislo1 + prostochislo2}");  // 132
                    }
                    else
                    {
                        Console.Write($"{prostochislo3 + prostochislo2}");  // 312
                    }
                }
            }
            else if (prostochislo2>prostochislo1)
            {
                if (prostochislo1>prostochislo3)
                {
                    Console.Write($"{prostochislo2 + prostochislo3}");      // 213
                }
                else // prostochislo3 > prostochislo 1
                {
                    if (prostochislo2>prostochislo3)
                    {
                        Console.Write($"{prostochislo2 + prostochislo1}");  // 231
                    }
                    else // prostochislo3 > prostochislo2
                    {
                        Console.Write($"{prostochislo3 + prostochislo1}");  // 321
                    }
                }
            }
            Console.ReadKey();
            

            Console.WriteLine("Упражнение 30");
            int schetchik = 0;
            int naturalbnoe = int.Parse(Console.ReadLine());
            int delitelb = 1;
            while (delitelb<=naturalbnoe)
            {
                if(naturalbnoe%delitelb==0)
                {
                    schetchik++;
                    delitelb++;

                }
                else
                {
                    delitelb++;
                }
            }
            Console.WriteLine($"У числа {naturalbnoe} существует {schetchik} делителей");
            Console.ReadKey();


            Console.WriteLine("Упражнение 31");
            Console.Write("Введите коэффициент A: ");
            double kubA = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент B: ");
            double kubB = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент C: ");
            double kubC = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент D: ");
            double kubD = double.Parse(Console.ReadLine());
            int Xi = -100;
            Console.WriteLine("У уравнения с данными коэффициентами следующие корни: ");
            while (Xi != 100)
            {
                if (kubA * (Xi * Xi * Xi)+ kubB * (Xi * Xi)+ kubC * Xi + kubD==0)
                {
                    Console.WriteLine($"{Xi}");
                    Xi++;
                }
                else
                {
                    Xi++;
                }
            }
            Console.ReadKey();
            
            Console.WriteLine("Упражнение 32");
            Console.WriteLine("Введите первый элемент последовательности");
            double seq1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй элемент последовательности");
            double seq2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер элемента последовательности, который желаете найти");
            double NumOfSeq = double.Parse(Console.ReadLine());
            double elemen = seq1 + ((seq2 - seq1) * (NumOfSeq - 1));
            Console.WriteLine($"Элемент последовательности с номером {NumOfSeq} равен {elemen}");

            Console.WriteLine("Упражнение 33");
            Console.WriteLine("Здравствуйте. Для предоставления вам кредита мы вынуждены провести краткий опрос. Отвечайте да/нет. Итак, являетесь ли вы студентом?");
            try
            {
                string otvet1 = Console.ReadLine();
                if ((otvet1 == "Да") | (otvet1 == "да")|(otvet1 == "Yes")|(otvet1 == "yes"))
                {
                    Console.WriteLine("Хорошо, вы являетесь гражданином пенсионного возраста?");
                    string otvet2 = Console.ReadLine();
                    if ((otvet2 == "Да") | (otvet2 == "да") | (otvet2 == "Yes") | (otvet2 == "yes"))
                    {
                        Console.WriteLine("В получении кредита вам отказано.");
                    }
                    else if ((otvet2 == "Нет") | (otvet2 == "нет") | (otvet2 == "No") | (otvet2 == "no"))        // Вы не являетесь пенсионером 
                    {
                        Console.WriteLine("Вы трудоустроены?");
                        string otvet3 = Console.ReadLine();
                        if ((otvet3 == "Да") | (otvet3 == "да") | (otvet3 == "Yes") | (otvet3 == "yes"))
                        {
                            Console.WriteLine("В получении кредита вам отказано.");
                        }
                        else if ((otvet3 == "Нет") | (otvet3 == "нет") | (otvet3 == "No") | (otvet3 == "no"))
                        {
                            Console.WriteLine("Предоставление кредита одобрено");
                        }
                        else
                        {
                            Console.WriteLine("Повторите попытку");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Повторите попытку");
                        return;
                    }
                }
                else if ((otvet1 == "Нет") | (otvet1 == "нет") | (otvet1 == "No") | (otvet1 == "no"))
                {
                    Console.WriteLine("Может быть, вы являетесь пенсионером?");
                    string otvet2 = Console.ReadLine();
                    if ((otvet2 == "Да") | (otvet2 == "да") | (otvet2 == "Yes") | (otvet2 == "yes"))
                    {
                        Console.WriteLine("Вы трудоустроены?");
                        string otvet3 = Console.ReadLine();
                        if ((otvet3 == "Да") | (otvet3 == "да") | (otvet3 == "Yes") | (otvet3 == "yes"))
                        {
                            Console.WriteLine("В получении кредита вам отказано.");
                        }
                        else if ((otvet3 == "Нет") | (otvet3 == "нет") | (otvet3 == "No") | (otvet3 == "no"))
                        {
                            Console.WriteLine("Предоставление кредита одобрено");
                        }
                        else
                        {
                            Console.WriteLine("Повторите попытку");
                            return;
                        }
                    }
                    else if ((otvet2 == "Нет") | (otvet2 == "нет") | (otvet2 == "No") | (otvet2 == "no"))
                    {
                        Console.WriteLine("Тогда чё пришёл то сюда"); 
                    }
                    else
                    {
                        Console.WriteLine("Повторите попытку");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Повторите попытку");
                    return;
                }
            }
            catch(OutOfMemoryException caught)
            {
                Console.WriteLine(caught);
            }
            catch(ArgumentOutOfRangeException caught)
            {
                Console.WriteLine(caught);
            }
            catch(SystemException caught)
            {
                Console.WriteLine(caught);
            }
            finally
            {
                Console.ReadKey();
            }


            Console.WriteLine("Упражнение 34");
            Console.Write("a) Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"{name}");
            Console.Write($"b) Приветствую Вас, {name}");
            Console.ReadKey();
            


            Console.WriteLine("Упражнение 35. Разговор Гарри и дневника");
            Random color = new Random();
            Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            string name3 = Console.ReadLine();
            Console.WriteLine($"Привет, {name3}");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            int color1 = color.Next(1, 15);
            if (color1 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (color1 == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else if (color1 == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            else if (color1 == 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
            }
            else if (color1 == 4)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            else if (color1 == 5)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
            }
            else if (color1 == 6)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            else if (color1 == 7)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            else if (color1 == 8)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            else if (color1 == 9)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else if (color1 == 10)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else if (color1 == 11)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            else if (color1 == 12)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (color1 == 13)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            else if (color1 == 14)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            else if (color1 == 15)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            Console.ReadKey();


            Console.WriteLine("Упражнение 36а");
            int[] mas = new int[12];
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(0, 10);
                Console.Write($"{mas[i]} ");
            }
            int scht = 0;
            for (int i = 1; i < mas.Length; i += 2)
                scht += mas[i]*3;
            Console.WriteLine();
            Console.WriteLine($"{scht}");
            for (int i = 0; i < mas.Length; i += 2)
                scht += mas[i];
            Console.WriteLine($"{scht}");
            if (scht%10!=0)
            {
                scht = ((scht + 10) - (scht % 10))-scht;
                Console.WriteLine($"{scht}");
            }
            else
            {
                Console.WriteLine($"{0}");
            }

            Console.WriteLine("Упражнение 36b");
            Console.WriteLine("Введите 12 цифр");
            int[] mass = new int[12];
            for (int i = 0; i < mass.Length; i++)
                mass[i] = int.Parse(Console.ReadLine());
            int sncht = 0;
            for (int i = 1; i < mass.Length; i += 2)
                sncht += mass[i] * 3;
            Console.WriteLine($"{sncht}");
            for (int i = 0; i < mass.Length; i += 2)
                sncht += mass[i];
            Console.WriteLine($"{sncht}");
            if (sncht%10!=0)
            {
                sncht = ((sncht + 10) - (sncht % 10)) - sncht;
                Console.WriteLine($"{sncht}");
            }
            else
            {
                Console.WriteLine($"{0}");
            }
        }




    }
}
