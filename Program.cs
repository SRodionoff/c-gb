// // Задача 66


// int print(int n, int m)
// {
//    if (n == m)
//       return n;
//    return print(n - 1, m) + n;
// }
// Console.Clear();
// Console.Write("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(print(n, m));


// // Задача 68


// int print(int n, int m)
// {
//    if (n == 0)
//       return m + 1;
//    else if ((n != 0) && (m == 0))
//       return print(n - 1, 1);
//    else return print(n - 1, print(n, m - 1));
// }
// Console.Clear();
// Console.Write("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(print(n, m));
