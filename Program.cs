// // Задача 54


// Console.Clear();
// Console.Write("Введите кол-во строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];
// Console.WriteLine("Изначальный массив: ");
// InArr(array);
// PrintArr(array);
// Console.WriteLine("Отсортированный массив: ");
// SortArr(array);
// PrintArr(array);
// void InArr(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          array[i, j] = new Random().Next(-10, 11);
//       }
//    }
// }
// void SortArr(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          for (int k = 0; k < array.GetLength(1) - 1; k++)
//          {
//             if (array[i, k] < array[i, k + 1])
//             {
//                int temp = array[i, k + 1];
//                array[i, k + 1] = array[i, k];
//                array[i, k] = temp;
//             }
//          }
//       }
//    }
// }
// void PrintArr(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          Console.Write(array[i, j] + "\t");
//       }
//       Console.WriteLine();
//    }
// }



// // Задача 56


// Console.Clear();
// Console.Write("Введите количество строк и столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[n, n];
// Console.WriteLine("Сам массив: ");
// inArr(array);
// showArr(array);
// findMin(array);
// void inArr(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          array[i, j] = new Random().Next(1, 11);
//       }
//    }
// }
// void showArr(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          Console.Write(array[i, j] + "\t");
//       }
//       Console.WriteLine();
//    }
// }
// void findMin(int[,] array)
// {
//    int[] rowSum = new int[array.GetLength(0)];
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          rowSum[i] += array[i, j];
//       }
//    }
//    int sum = rowSum[0];
//    int k = 0;
//    for (int i = 0; i < array.GetLength(1); i++)
//    {
//       if (rowSum[i] < sum)
//       {
//          sum = rowSum[i];
//          k = i;
//       }
//       Console.WriteLine($"Сумма элементов в строке {i + 1} равна {rowSum[i]}");
//    }
//    Console.WriteLine($"Минимальная сумма находится в строке {k + 1}");
// }



// // Задача 58 Надеюсь, что задача была понята верно, но по примеру вообще не понял, как именно получается 18 из 2*3, 20 из 4*4 и т.д.


// Console.Clear();
// Console.Write("Введите количество строк и столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] arrayFirst = new int[n, n];
// int[,] arraySec = new int[n, n];
// Console.WriteLine("1-ый массив: ");
// inArr(arrayFirst);
// Console.WriteLine("2-ой массив: ");
// inArr(arraySec);
// Console.WriteLine("Произведение массивов: ");
// finalArr(arrayFirst, arraySec);
// void inArr(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          array[i, j] = new Random().Next(1, 11);
//          Console.Write(array[i, j] + "\t");
//       }
//       Console.WriteLine();
//    }
// }
// void finalArr(int[,] arrayFirst, int[,] arraySec)
// {
//    int[,] resultArr = new int[arrayFirst.GetLength(0), arraySec.GetLength(1)];
//    for (int i = 0; i < arrayFirst.GetLength(0); i++)
//    {
//       for (int j = 0; j < arraySec.GetLength(1); j++)
//       {
//          resultArr[i, j] = arrayFirst[i, j] * arraySec[i, j];
//          Console.Write(resultArr[i, j] + "\t");
//       }
//       Console.WriteLine();
//    }
// }


// // Задача 60


// Console.Clear();
// Console.Write("Введите Х: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Z: ");
// int z = Convert.ToInt32(Console.ReadLine());
// int[,,] array = new int[x, y, z];
// InArr(array);
// PrintArr(array);
// void PrintArr(int[,,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          for (int k = 0; k < array.GetLength(2); k++)
//          {
//             Console.WriteLine($"{array[i, j, k]} ({i}, {j}, {k})");
//          }
//       }
//       Console.WriteLine();
//    }
// }
// void InArr(int[,,] array)
// {
//    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
//    int number = 0;
//    for (int i = 0; i < temp.GetLength(0); i++)
//    {
//       temp[i] = new Random().Next(10, 100);
//       number = temp[i];
//       if (i >= 1)
//       {
//          for (int j = 0; j < i; j++)
//          {
//             while (temp[i] == temp[j])
//             {
//                temp[i] = new Random().Next(10, 100);
//                j = 0;
//                number = temp[i];
//             }
//             number = temp[i];
//          }
//       }
//    }
//    int count = 0;
//    for (int x = 0; x < array.GetLength(0); x++)
//    {
//       for (int y = 0; y < array.GetLength(1); y++)
//       {
//          for (int z = 0; z < array.GetLength(2); z++)
//          {
//             array[x, y, z] = temp[count];
//             count++;
//          }
//       }
//    }
// }