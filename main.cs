using System;
// ************************ПРАКТИЧЕСКАЯ РАБОТА 1*******************************

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 1.Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. А программа сранивает два введенных числа и выводит на консоль результат сравнения (два числа равны, первое число больше второго или первое число меньше второго).
// class Program {
//   public static void Main (string[] args) {
//     Console.Write("Введите свое 1 число: ");
//     int ch1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите свое 2 число: ");
//     int ch2 = Convert.ToInt32(Console.ReadLine());
//     if (ch1 > ch2)
//     Console.WriteLine($"Число {ch1} больше числа {ch2}");
//     else if (ch1 < ch2)
//     Console.WriteLine($"Число {ch1} меньше числа {ch2}");
//     else
//     Console.WriteLine("Оба числа равны");

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2. Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10". Иначе программа выводит сообщение "Неизвестное число".
//   }
// }
// class Program {
//   public static void Main (string[] args) 
//   {
//   Console.WriteLine("Введите число: ");
//     int num1 = Convert.ToInt32(Console.ReadLine());
//     if (num1 > 5 && num1 < 10)
//     Console.WriteLine("Число больше 5 и меньше 10");
//     else
//     Console.WriteLine("Неизвестное число");
//   }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 3. Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число либо равно 5, либо равно 10, то программа выводит "Число либо равно 5, либо равно 10". Иначе программа выводит сообщение "Неизвестное число".
// class Program {
//   public static void Main (string[] args) 
//   {
//    Console.WriteLine("Введите число: ");
//     int num1 = Convert.ToInt32(Console.ReadLine());
//     if (num1 == 5 | num1 == 10)
//     Console.WriteLine("Число либо равно 5, либо равно 10");
//     else
//     Console.WriteLine("Неизвестное число");
//   }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 4. В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. Напишите консольную программу, в которую пользователь вводит сумму вклада. Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%. Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.
// class Program {
//   public static void Main (string[] args) 
//   {
//    Console.WriteLine("Введите сумму вклада: ");
//     double sum = Convert.ToDouble(Console.ReadLine());
//     if (sum < 100)
//     sum += sum * 0.05;
//     else if (sum <= 200)
//     sum += sum * 0.07;
//     else
//     sum += sum * 0.1;
//     Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");
//   }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 5. Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.
// class Program {
//   public static void Main (string[] args) 
//   {
//    Console.WriteLine("Введите сумму вклада: ");
//     double sum = Convert.ToDouble(Console.ReadLine());
//     double percent = 15;
//     if (sum < 100)
//     sum += sum * 0.05;
//     else if (sum <= 200)
//     sum += sum * 0.07;
//     else
//     sum += sum * 0.1;
//     Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");
//     sum += sum * percent + 15;
//     Console.WriteLine($"Сумма с ресентом {sum}");
//   }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 6. Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение". Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2. Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.
// class Program {
//     public static void Main(string[] args)
//     {
//       Console.WriteLine("Введите номер операции: 1.Сложение  2.Вычитание  3.Умножение");
//        int operation = Convert.ToInt32(Console.ReadLine());
//         switch (operation)
//             {
//             case 1:
//             Console.WriteLine("Сложение");
//             break;
//             case 2:
//             Console.WriteLine("Вычитание");
//             break;
//             case 3:
//             Console.WriteLine("Умножение");
//             break;
//             default:
//             Console.WriteLine("Неизвестная операция");
//             break;
//             }
//         }
//     }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 7. Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа, и в зависимости от номера операции с введенными числами выполняются определенные действия (например, при вводе числа 3 числа умножаются). Результа операции выводиться на консоль.
// class Program {
//   public static void Main(string[] args)
//     {
//       Console.WriteLine("Введите первое число: ");
//       int num1 = Convert.ToInt32(Console.ReadLine());
//       Console.WriteLine("Введите второе число: ");
//       int num2 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите номер операции: 1.Сложение  2.Вычитание  3.Умножение");
//          int operation = Convert.ToInt32(Console.ReadLine());
//          int result = 0;
//          switch (operation)
//           {
//           case 1:
//             result = num1 + num2;
//             Console.WriteLine($"Результат операции {result}");
//             break;
//           case 2:
//             result = num1 - num2;
//             Console.WriteLine($"Результат операции {result}");
//             break;
//           case 3:
//             result = num1 * num2;
//             Console.WriteLine($"Результат операции {result}");
//             break;
//           default:
//             Console.WriteLine("Неизвестная операция");
//             break;
//             }
//           } 
//         }
// ---------------------------ПРАКТИЧЕСКАЯ РАБОТА 2-------------------------------------------

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 1.1 Вывести на экран число с точностью до сотых.
// class Program {
//   public static void Main(string[] args)
//   {
//   double a = 54.654969845689;
//   a = Math.Round(a, 2);
//   Console.WriteLine(a);
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 1.2. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
// class Program {
//   public static void Main(string[] args)
//   {
//   Console.WriteLine(Math.Round(Math.E, 1));
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 1.3. Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».
// class Program {
//   public static void Main(string[] args)
//   {
//   int a = Int32.Parse(Console.ReadLine());
//   Console.Write($"Вы  ввели {a} ");
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 1.4Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение» — вот какое число Вы ввели».
//   class Program {
//   public static void Main(string[] args)
//   {
//   int a = Int32.Parse(Console.ReadLine());
//   Console.Write($"{a} — вот какое число Вы  ввели");
// }
//   }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 1.5. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.
// class Program {
//   public static void Main(string[] args)
//   {
// int a=1, b = 13, c = 49;
// Console.WriteLine($"{a} {b} {c}");
//   }
//   }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
// class Program {
//   public static void Main(string[] args)
//   {
//     Random rnd = new Random();
//     int a = rnd.Next(0, 1000);
//     int b = rnd.Next(0, 1000);
//     int c = rnd.Next(0, 1000);
//   Console.WriteLine($"{a}  {b}  {c}");
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 1.8. Составить программу вывода на экран в одну строку четырех любых чисел с одним пробелом между ними.
// class Program {
//   public static void Main(string[] args)
// {
//   Random rnd = new Random();
//   int a = rnd.Next(0,100000000);
//   int b = rnd.Next(0,100000000);
//   int c = rnd.Next(0,100000000);
//   int d = rnd.Next(0,100000000);
//   Console.WriteLine($"{a} {b} {c} {d}");
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 1.9. Вывести на экран числа 50 и 10 одно под другим.
// class Program {
//   public static void Main(string[] args)
// {
//     int a = 50, b = 10;
//     Console.WriteLine($"{a}\n{b}");
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.
// class Program {
//   public static void Main(string[] args)
// {
//   Random rnd = new Random();
//   int a = rnd.Next(0,100000000);
//   int b = rnd.Next(0,100000000);
//   int c = rnd.Next(0,100000000);
//   int d = rnd.Next(0,100000000);
//   Console.WriteLine($"{a}\n{b}\n{c}\n{d}");
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 1.12. Составить программу вывода на экран следующей информации:
// 5 10
// 7 см
// class Program {
//   public static void Main(string[] args)
// {
//   Console.WriteLine($"5 10\n7 cm");
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 1.13. Составить программу вывода на экран следующей информации:
// 2 кг
// 13 17
// class Program {
//   public static void Main(string[] args)
// {
//   Console.WriteLine($"2 кг\n13 17");
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.1. Составить программу:
// а) вычисления значения функции y=7x2+3x+6 при любом значении x;
// б) вычисления значения функции x=12a2+7a+12 при любом значении а.
// class Program {
//   public static void Main(string[] args)
// {
// Console.Write("Введите значение x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"y = {7*x*x + 3*x + 6}");
// Console.Write("Введите значение x: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"y = {x = 12*a*a+7*a+12}");
//   }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.2. Дана сторона квадрата. Найти его периметр.
// class Program {
//   public static void Main(string[] args)
// {
//   Console.Write("Введите значение x: ");
//   int x = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"P = {x * 4}");
//   }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.3 Дан радиус окружности. Найти ее диаметр.
// class Program {
// static void Main(string[] args)
// {
//   Console.Write("Введите значение R: ");
//   int R = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine($"L = { 2*3.14*R}");
//   Console.WriteLine($"S = { 3.14*Math.Pow(R,2)}");
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.5. Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности.
// class Program {
// static void Main(string[] args)
// {
//   Console.Write("Введите значение a: ");
//   int a = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine($"V = {a*a*a}");
//   Console.WriteLine($"S = { 3.14*Math.Pow(a,2)}");
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.6. Дан радиус окружности. Найти длину окружности и площадь круга.
// class Program {
// static void Main(string[] args)
// {
//   Console.Write("Введите значение R: ");
//   int R = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine($"L = { 2 * 3.14 * R}");
//   Console.WriteLine($"S = { 3.14*Math.Pow(R ,2)}");
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
 // 2.7. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
// class Program {
// static void Main(string[] args)
// {
//   Console.Write("Введите значение a ");
//   int a = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите значение b ");
//   int b = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(($"m = { (a + b) / 2}"));
//   Console.WriteLine(($"n = { Math.Sqrt(a*b)}"));
//   }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.8. Известны объем и масса тела. Определить плотность материала этого тела.
// class Program {
// static void Main(string[] args)
// {
//   Console.Write("Введите значение m ");
//   int m = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите значение v ");
//   int v = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(($"S = { m / v}"));
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.9. Известны количество жителей в государстве и площадь его территории. Определить плотность населения в этом государстве.
// class Program {
// static void Main(string[] args)
// {
//   Console.Write("Введите значение кол-во жителей: ");
//   int q = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите значение S: ");
//   int s = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(($"p = { q / s}"));
//   }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.10. Составить программу решения линейного уравнения ax+b=0 (a ≠ 0).
// class Program {
// static void Main(string[] args)
// {
//   Console.Write("Введите a: ");
//   int a = Convert.ToInt32(Console.ReadLine());
//   if (a == 0)
//   {
//     Console.WriteLine("a = 0, программа завершена");
//   }
//   else
//   {
//     Console.Write("Введите значение x: ");
//     int x = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите b: ");
//     int b = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(($"ax+b=0 = {a * x + b}"));
//   }
//   }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.11. Даны катеты прямоугольного треугольника. Найти его гипотенузу.
// class Program {
// static void Main(string[] args)
// {
//   Console.Write("Введите первый катет: ");
//   int a = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите второй катет: ");
//   int b = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(($"гипотенуза = {a*a+b*b}"));
//   }
//   }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.12. Найти площадь кольца по заданным внешнему и внутреннему радиусам.
// class Program {
// static void Main(string[] args)
// {
//   Console.Write("Введите внешний радиус: ");
//   int a = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите внутренний радиус: ");
//   int b = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(($"площадь кольца = {3.14*(a*a+b*b)}"));
//   }
//   }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.13.  Даны катеты прямоугольного треугольника. Найти его периметр.
// class Program {
// static void Main(string[] args)
// {
//   Console.Write("Введите первый катет: ");
//   int a = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите второй катет: ");
//   int b = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите третий катет: ");
//   int c = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(($"периметр = {a+b+c}"));
//   }
//   }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.13А. Даны два числа. Найти среднее арифметическое и среднее геометрическое их модулей.
// class Program {
// static void Main(string[] args)
// {
//   Console.Write("Введите значение a ");
//   int a = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите значение b ");
//   int b = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(($"m = { (Math.Abs(a) + Math.Abs(b)) / 2}"));
//   Console.WriteLine(($"n = { Math.Sqrt(Math.Abs(a)*Math.Abs(b))}"));
//   }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.14. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
// class Program {
// static void Main(string[] args)
// {
//   Console.Write("Введите первое основание: ");
//   int a = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите второе основание: ");
//   int b = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите первая высота: ");
//   int c = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите вторая высота: ");
//   int d = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(($"периметр = {a+b+c+d}"));
//   }
//   }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.14А. Даны стороны прямоугольника. Найти его периметр и длину диагонали.// 
// class Program {
// static void Main(string[] args)
// {
//   Console.Write("Введите первая сторона: ");
//   int a = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите вторая сторона: ");
//   int b = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите третья сторона: ");
//   int c = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите четвертая сторона: ");
//   int d = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(($"периметр = {a+b+c+d}"));
//   Console.WriteLine(($"длина диагонали = {a*a+b*b}"));
//   }
//   }
// -------------------------ПРАКТИЧЕСКАЯ РАБОТА 3------------------------------------

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.23. Известна стоимость монитора, системного блока, клавиатуры и мыши. Сколько будут стоить 3 компьютера из этих элементов? N компьютеров? N компьютеров?
// class Program {
// static void Main(string[] args)
// {
//   Console.Write("цена монитора: ");
//   int a = Convert.ToInt32(Console.ReadLine());
//   Console.Write("цена системного блока: ");
//   int b = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Цена клавиатуры: ");
//   int c = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Цена мыши: ");
//   int d = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Кол-во пк: ");
//   int e = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(($"Общая цена = {e*(a+b+c+d)}"));
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.24. Возраст Тани — X лет, а возраст Мити — Y лет. Найти их средний возраст, а также определить, на сколько отличается возраст каждого ребенка от среднего значения.
// class Program {
// static void Main(string[] args)
// {  
//   Console.Write("Возраст Тани: ");
//   int a = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Возраст Мити: ");
//   int b = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(($"Средний возраст = {(Math.Abs(a) + Math.Abs(b)) / 2}"));
//   int c = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(($"Разница Мити = {b-c}"));
//   Console.WriteLine(($"Разница Тани = {a-c}"));
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.25. Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и V2 км/час. Определить, через какое время автомобили встретятся, если расстояние между ними было S км.
// class Program {
// static void Main(string[] args)
// {  
//   Console.Write("Скорость первой машины: ");
//   float v1 = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Скорость второй машины: ");
//   float v2 = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Расстояние:");
//   float s = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(($"Время = {s/(v1+v2)} ч"));
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.26. Два автомобиля едут друг за другом с постоянными скоростями V1 и V2 км/час (V1> V2). Определить, какое расстояние будет между ними через 30 минут после того, как первый автомобиль опередил второй на S км.
// class Program {
// static void Main(string[] args)
// {  
//   Console.Write("Скорость первой машины: ");
//   float v1 = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Скорость второй машины: ");
//   float v2 = Convert.ToInt32(Console.ReadLine());
//   if (v1<v2){
//     Console.WriteLine("По условию скорость первой должна быть больше второй");
//   }
//   else{
//     Console.Write("растояние:");
//     float s = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(($"Расстояние = {s + ((v1-v2)*0.5)}"));
//   }
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.27. Известно значение температуры по шкале Цельсия. Найти соответствующее значение температуры по шкале: а) Фаренгейта; б) Кельвина. Для пересчета по шкале Фаренгейта необходимо исходное значение температуры умножить на 1,8 и к результату прибавить 32, а по шкале Кельвина абсолютное значение нуля соответствует 273,15 градуса по шкале Цельсия.
// class Program {
// static void Main(string[] args)
// {  
//   Console.Write("Введите градусы: ");
//   float t = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine("1. по Фаренгейту 2. по Кельвину");
//   float b = Convert.ToInt32(Console.ReadLine());
//   if (b == 1){
//     Console.WriteLine(($"По Фаренгейту {(t*1.8)+32}"));
//   }
//   else if (b == 2){
//     Console.WriteLine(($"По Кельвину {t-273.15}"));
//   }
//   else{
//     Console.WriteLine("Неправильно");
//   }
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2.28. У американского писателя-фантаста Рэя Бредбери есть роман «451 градус по Фаренгейту». Какой температуре по шкале Цельсия соответствует указанное в названии значение? (См. предыдущую задачу).
// class Program {
// static void Main(string[] args)
// {  
//   Console.Write("Введите градусы: ");
//   float t = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine(($"По цельсию - {(t-32)/1.8}"));
//   }
// }

// -------------------------------ПРАКТИЧЕСКАЯ РАБОТА 4------------------------------------

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 1.За каждый месяц банк начисляет к сумме вклада 14% от суммы. Напишите программу, в которую пользователь вводит сумму вклада и количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
// Для вычисления суммы с учетом процентов используйте цикл for. Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine()) (сумма вклада будет представлять тип decimal).
// class Program {
//   public static void Main (string[] args) 
//   {
//     Console.WriteLine("введите сумму вклада: ");
//     double sum = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("количество месяцев: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     for(int k = 1; k<=m; k++)
//   {
//     sum = sum * 1.14;
//   }
//   Console.WriteLine(sum);
//   }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 2. Перепишите предыдущую программу, только вместо цикла for используйте цикл while.
// class Program {
//   public static void Main (string[] args) 
//   {
//     int k = 1;
//     Console.WriteLine("введите сумму вклада: ");
//     double sum = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("количество месяцев: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     while(k<=m)
//   {
//     sum = sum * 1.14;
//     k = k + 1;
//   }
//   Console.WriteLine(sum);
//   }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 3. Напишите программу, которая выводит на консоль таблицу умножения
// class Program {
//   public static void Main (string[] args) 
//   {
//     for (int i = 1; i <=10; i++)
//                 for (int j = 1; j <= 10; j++)
//                     Console.WriteLine(i*j);
//   }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 4. Напишите программу, в которую пользователь вводит два числа и выводит результат их умножения. При этом программа должны запрашивать у пользователя ввод чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10. Если введенные числа окажутся больше 10 или меньше 0, то программа должна вывести пользователю о том, что введенные числа недопустимы, и повторно запросить у пользователя ввод двух чисел. Если введенные числа принадлежат диапазону от 0 до 10, то программа выводит результат умножения.
// Для организации ввода чисел используйте бесконечный цикл while и оператор break.
// class HelloWorld {
// static void Main() {
//     bool flag = false;
//     int num1 = 1;
//     int num2 = 1;
//     while (flag != true){
//         num1 = Convert.ToInt32(Console.ReadLine());
//         num2 = Convert.ToInt32(Console.ReadLine());
//         if((num1 > 10 | num1 < 0 ) | (num2 > 10 | num2 < 0 )){
//             Console.WriteLine("Введенные чисоа недопустимы");
//         }
//         else{ 
//             int res = num1 * num2;
//             Console.WriteLine(res);
//             flag = true;
//         }
//     }
//     }   
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 5. Имеется фрагмент программы в виде оператора цикла с параметром, обеспечивающий вывод на экран «столбиком» всех целых чисел от 10 до 30. Оформить этот фрагмент в виде:

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// а) оператора цикла с предусловием;
// class program{
// static void Main(){
//     int i = 11;
//     while(i<30 & i > 10){
//         Console.WriteLine(i);
//         i += 1;
//     }
// }
// }
// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// б) оператора цикла с постусловием.
// class program{
// static void Main(){
//     int i = 11;
//     do{
//         Console.WriteLine(i);
//         i += 1;
//     }
//     while(i<30);
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 6. Имеется фрагмент программы в виде оператора цикла с параметром, обеспечивающий вывод на экран «столбиком» квадратного корня из всех целых чисел от a до b (a > b). Оформить этот фрагмент в виде:

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// а) оператора цикла с предусловием;
// class program{
// static void Main(){
//   int a = Convert.ToInt32(Console.ReadLine());
//   int b = Convert.ToInt32(Console.ReadLine());
//   int i = a +1;
//   while(i < b + 1){
//         Console.WriteLine(Math.Sqrt(i));
//         i += 1; 
//   }
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// б) оператора цикла с постусловием.
// class program{
// static void Main(){
//   int a = Convert.ToInt32(Console.ReadLine());
//   int b = Convert.ToInt32(Console.ReadLine());
//   int i = a +1;
//   do{
//         Console.WriteLine(Math.Sqrt(i));
//         i += 1; 
//   }
//   while(i<b+1);
// }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 7. Дано натуральное число. Определить:
// а) количество цифр в нем;
// б) сумму его цифр;
// в) произведение его цифр;
// г) среднее арифметическое его цифр;
// д) сумму квадратов его цифр;
// е) сумму кубов его цифр;
// ж) его первую цифру;
// з) сумму его первой и последней цифр.

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// class program{
// static void Main() {
//     int count = 0;
//     int sum = 0;
//     int pr  = 1;
//     int sum_pow2  = 0;
//     int sum_pow3  = 0;
//     int num = Convert.ToInt32(Console.ReadLine());
//     int copy_num = num; 
//     while(num != 0){
//         int n = num%10;
//         sum += n; 
//         sum_pow2 += n * n;
//         sum_pow3 += n * n * n;
//         pr *= n;
//         num /= 10;
//         count++;
//     }
//     double arf = sum / count;
//     int pow1 = count - 1;
//     double n1 = copy_num/ Math.Pow(10, pow1);
//     double n_end = copy_num % 1;
//     Console.WriteLine("число цифр: {0}", count);
//     Console.WriteLine("Сумма цифр: {0}", sum);
//     Console.WriteLine("произведение цифр: {0}", pr);
//     Console.WriteLine("первая цифра: {0}", Math.Round(n1));
//     Console.WriteLine($"сумма ппервой и последней цифры: {Math.Round(n1)+Math.Round(n_end)}");
//     Console.WriteLine("среднее арифметическое цифр: {0}", arf);
//     Console.WriteLine("сумма квадратов цифр: {0}", sum_pow2);
//     Console.WriteLine("сумма квбов цифр: {0}", sum_pow3);
//     }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 8. Известны оценки по информатике каждого из 20 учеников класса. В начале списка перечислены все пятерки, затем все остальные оценки. Сколько учеников имеют по информатике оценку «5»? Условный оператор не использовать. Рассмотреть два случая:
// 1) известно, что пятерки имеют не все ученики класса;
// 2) допускается, что пятерки могут иметь все ученики класса.
// class HelloWorld { 
//     static void Main() {   
//         int[] arr = new int[20] {5,5,5,5,5,5,5,5,5,4,4,4,4,4,4,4,4,4,4,4};
//         int count = 0, i = 0;
//         while(i < arr.Length && arr[i] == 5) {
//             count++;
//             i++;
//         }
//     Console.WriteLine("Количетво пятёрок: " + count);
//         }
//     }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 9. Найти максимальное из натуральных чисел, не превышающих 5000, которое нацело делится на 39.
// class HelloWorld {
//     static void Main() {
//         int div = 39; 
//         int lim = 5000;
//         int max_div = 0;
//         for (int i = 1; i < lim; i++){
//             if(i % div ==0){
//                 if(max_div <=i){
//                     max_div = i;
//                 }
//             }
//         }
//     Console.WriteLine(max_div);
//     }
// }

// LunexCoding, Sladkii, Dimas_Zer0, Qsiber
// 10. В некотором году (назовем его условно первым) на участке в 100 гектаров средняя урожайность ячменя составила 20 центнеров с гектара. После этого каждый год площадь участка увеличивалась на 5%, а средняя урожайность на 2%. Определить:
// а) в каком году урожайность превысит 22 центнера с гектара;
// б) в каком году площадь участка станет больше 120 гектаров;
// в) в каком году общий урожай, собранный за все время, начиная с первого года, превысит 800 центнеров.
//  class HelloWorld {
//      static void Main() {
//          double area = 100;
//          double yield = 20;
//          double pr_yield = 0.02;
//          double pr_area = 0.05;
//          int year = 1;
//          while(yield < 22){ 
//              yield += yield * pr_yield;
//              year += 1;   
//          }
//          Console.WriteLine("Урожайность превысит 22 центнера с 1 гектара в {0} году",year);
//          year = 1;
//          while(area < 120){
//              area += area * pr_area;
//              year += 1;
//          }
//          Console.WriteLine("Учасирк превысит 120 гектаров в {0} году", year);
//          }
//      }