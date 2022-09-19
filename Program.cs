// // Доп задачка из 1-го дз

// Console.Clear();
// Console.Write("Введите выборку чисел поочередно, для завершения ввода - введите 0: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int max = 0;
// int preMax = 0;
// while (a != 0)
// {
//    Console.Write("Введите число: ");
//    a = Convert.ToInt32(Console.ReadLine());
//    if (a > max)
//    {
//       preMax = max;
//       max = a;
//    }
//    else if (a > preMax) preMax = a;
// }
// Console.Write("Самое большое число: " + max + ", ");
// Console.Write("Второе по величине число: " + preMax);


// // Задача 10

// Console.Clear();
// string a = Convert.ToString(new Random().Next(100, 1000));
// Console.WriteLine(a);
// Console.Write(a[1]);


// // Задача 13 

// Console.Clear();
// string a = Convert.ToString(new Random().Next());
// if (Convert.ToInt32(a) % 100 >= 0)
// {
//    Convert.ToString(a);
//    Console.WriteLine("Третья цифра: " + a[2]);
// }
// else Console.WriteLine("3-ей цифры нет");
// Console.WriteLine("Зарандомленное число: " + a);


// // Задача 15

// Console.Clear();
// Console.Write("Введите цифру дня недели: ");
// int s = Convert.ToInt32(Console.ReadLine());
// if (s == 6 || s == 7) Console.Write("Выходной");
// else Console.Write("Работаем пока");

// // Доп задачка из дз 2

// // Верное решение, которое, предположительно, ожидалось после разговора в тг

// Console.Clear();
// Console.Write("Введите число кустов от 3 до 1000: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int max = 0;
// for (int i = 0; i < array.Length; i++)
//    array[i] = new Random().Next(3, 1001);
// Console.WriteLine("Всего кустов: " + n + ", количество ягод на каждом: " + string.Join(", ", array));
// for (int c = 1; c < n - 1; c++)
// {
//    int sum = array[c] + array[c + 1] + array[c - 1];
//    if (sum > max) max = sum;
// }
// Console.Write("Максимальное количество ягод, которое сборщик может собрать: " + max);

// // Но по условиям задачи в целом могло бы подойти, наверное, и вот это, т.к. указано "... На i-ом кусте растет a(i) ягод", т.е. от номера куста зависит количество ягод на нем, но это было бы слишком просто, полагаю:)

// Console.Clear();
// int a = Convert.ToInt32(new Random().Next(3, 1000));
// int sum = a + (a + 1) + (a - 1);
// Console.WriteLine("Один собирающий модуль соберет: " + sum + " ягод");
// Console.Write("На кусте, на котором стоит собирающий модуль: " + a + " ягод");