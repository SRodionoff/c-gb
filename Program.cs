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