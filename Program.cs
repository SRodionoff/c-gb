// // Задача 47

// Console.Clear();
// Console.Write("Введите кол-во строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[n, m];
// Console.Write("Введите диапазон чисел (от): ");
// int from = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите диапазон чисел (до): ");
// int to = Convert.ToInt32(Console.ReadLine());

// void inputMatrix(double[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          matrix[i, j] = Math.Round(new Random().NextDouble() * (to - from) + from, 1);
//          Console.Write(matrix[i, j] + " \t");
//       }
//       Console.WriteLine();
//    }
// }
// inputMatrix(matrix);


// // Задача 50

// Console.Clear();
// Console.Write("Введите кол-во строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер строки: ");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, m];
// int elem = 0;
// void inputMatrix(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          matrix[i, j] = new Random().Next(-100, 101);
//          Console.Write(matrix[i, j] + " \t");
//       }
//       Console.WriteLine();
//    }
//    if (c <= n && x <= m)
//    {
//       elem = matrix[(c - 1), (x - 1)];
//       Console.WriteLine($"Указанный элемент равен: {elem}");
//    }
//    else Console.WriteLine("Нет такого элемента");
// }
// inputMatrix(matrix);


// // Задача 52


// Console.Clear();
// Console.Write("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, m];
// double sum = 0;
// double avg = 0;
// void InputMatrix(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          matrix[i, j] = new Random().Next(-10, 11);
//          Console.Write(matrix[i, j] + "\t");
//       }
//       Console.WriteLine();
//    }
// }
// InputMatrix(matrix);
// for (int i = 0; i < matrix.GetLength(1); i++)
// {
//    sum = 0;
//    for (int j = 0; j < matrix.GetLength(0); j++)
//    {
//       sum = sum + matrix[j, i];
//    }
//    avg = sum / n;
//    Console.WriteLine($"Среднее арифметическое {i + 1} столбца равно: {avg}");
// }
