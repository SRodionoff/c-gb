// // Задача 41

// Console.Clear();
// Console.Write("Введите количество чисел: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int pos = 0;
// for (int i = 0; i < n; i++)
// {
//    Console.Write($"Введите {(i + 1)}-е число: ");
//    int a = Convert.ToInt32(Console.ReadLine());
//    if (a > 0)
//       pos++;
// }
// Console.Write($"Количество положительных чисел: {pos}");


// // // Задача 43


// Console.Clear();
// Console.Write("Введите B1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите K1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите B2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите K2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;
// if (k1 == k2) Console.Write("Не пересекутся");
// else
//    Console.Write($"Точка пересечения: ({x}; {y})");
