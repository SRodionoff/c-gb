// // Задача 19

// Console.Clear();
// Console.Write("Введите 5-ти значное число: ");
// string a = Convert.ToString(Console.ReadLine());
// if (a[0] != a[4] && a[1] != a[3])
//    Console.Write("Не палиндром");
// else Console.Write("Палиндром");


// // Задача 21

// Console.Clear();
// Console.Write("Введите первую координату X: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите первую координату Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите первую координату Z: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую координату X: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую координату Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую координату Z: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double s = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
// Console.Write(s);


// // Задача 23

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int x = 0;
// for (int i = 1; i <= n; i++)
// {
//    x = i * i * i;
//    if (i < n)
//    {
//       Console.Write(x + ", ");
//    }
//    else Console.Write(x + ".");
// }