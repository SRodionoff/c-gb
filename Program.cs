// // Задача 25

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите возводимую степень: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int deg = 1;
// for (int i = 1; i <= b; i++)
// {
//    deg = deg * a;
// }
// Console.Write(deg);


// // Задача 27

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int lastNum = 0;
// while (a != 0)
// {
//    lastNum = a % 10;
//    a = a / 10;
//    sum = lastNum + sum;
// }
// Console.Write(sum);

// // Задача 29

// Console.Clear();
// int[] arr = new int[8];
// for (int i = 0; i < arr.Length; i++)
// {
//    Console.Write("Введите " + (i + 1) + "-е число: ");
//    int a = Convert.ToInt32(Console.ReadLine());
//    arr[i] = a;
// }
// Console.WriteLine("[" + string.Join(", ", arr) + "]");


// // Доп. задача 1

// Console.Clear();
// Console.Write("Введите свой рост: ");
// int height = Convert.ToInt32(Console.ReadLine());
// int higherThan = 0;
// int[] classHeight = new int[20];
// for (int i = 0; i < classHeight.Length; i++)
// {
//    classHeight[i] = new Random().Next(150, 201);
// }
// Array.Sort(classHeight);
// for (int j = 0; j < classHeight.Length; j++)
// {
//    if (classHeight[j] < height)
//       higherThan++;
// }
// Console.WriteLine("Пересчет шпал: [" + string.Join(", ", classHeight) + "]");
// Console.WriteLine("Встань " + (higherThan + 1) + "-ым");


// // Доп. задача 2

// Console.Clear();
// Console.Write("Введите положительное или отрицательное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arrToSort = new int[10];
// for (int i = 0; i < arrToSort.Length; i++)
// {
//    arrToSort[i] = new Random().Next(1, 101);
// }
// Console.WriteLine("Изначальный массив: [" + string.Join(", ", arrToSort) + "]");
// for (int j = 0; j < arrToSort.Length - 2; j++)
// {
//    arrToSort[arrToSort.Length - 1] = arrToSort[1];
//    arrToSort[arrToSort.Length - 2] = arrToSort[0];
//    arrToSort[1] = arrToSort[arrToSort.Length - 1];
//    arrToSort[0] = arrToSort[arrToSort.Length - 2];
//    if (n < 0)
//    {
//       arrToSort[j] = arrToSort[j + 2];
//    }

//    // else
//    // {
//    //    arrToSort[arrToSort.Length - 1] = arrToSort[0];
//    //    arrToSort[arrToSort.Length - 2] = arrToSort[arrToSort.Length - 1];
//    //    arrToSort[arrToSort.Length - 3] = arrToSort[arrToSort.Length - 2];
//    // }
// }
// Console.WriteLine("Массив со сдвигом: [" + string.Join(", ", arrToSort) + "]");