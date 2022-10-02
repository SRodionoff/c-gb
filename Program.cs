// // Задача 34

// Console.Clear();
// Console.Write("Кол-во элем-ов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// int count = 0;
// void inputArray(int[] arr)
// {
//    for (int i = 0; i < arr.Length; i++)
//    {
//       arr[i] = new Random().Next(100, 1000);
//    }
//    Console.WriteLine("Сам массив: " + string.Join(", ", arr));
// }
// void counter(int[] arr, int count)
// {
//    for (int i = 0; i < arr.Length; i++)
//    {
//       if (arr[i] % 2 == 0)
//          count++;
//    }
//    Console.Write($"Четных чисел: {count}");
// }
// inputArray(arr);
// counter(arr, count);


// // Задача 36

// Console.Clear();
// Console.Write("Кол-во элем-ов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// int count = 0;
// void inputArray(int[] arr)
// {
//    for (int i = 0; i < arr.Length; i++)
//    {
//       arr[i] = new Random().Next(-100, 1000);
//    }
//    Console.WriteLine("Сам массив: " + string.Join(", ", arr));
// }
// void counter(int[] arr, int count)
// {
//    for (int i = 1; i < arr.Length; i = i + 2)
//       count = arr[i] + count;
//    Console.Write($"Сумма чисел, стоящих на нечетных позициях: {count}");
// }
// inputArray(arr);
// counter(arr, count);


// // Задача 38

// Console.Clear();
// Console.Write("Кол-во элем-ов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// int max = 0;
// int min = 0;
// void inputArray(int[] arr)
// {

//    for (int i = 0; i < arr.Length; i++)
//    {
//       arr[i] = new Random().Next(1, 100);
//       min = arr[i];
//       max = arr[i];
//    }
//    Console.WriteLine("Сам массив: " + string.Join(", ", arr));
// }
// inputArray(arr);
// for (int j = 0; j < arr.Length; j++)
// {
//    if (arr[j] > max) max = arr[j];
//    else if (arr[j] < min) min = arr[j];
// }
// int count = max - min;
// Console.WriteLine($"Максимальное: {max}");
// Console.WriteLine($"Минимальное: {min}");
// Console.WriteLine($"Разница максимального и минимального чисел: {count}");


// // Доп. задачка

// Console.Clear();
// int prime = 0;
// int primeCounter = 0;
// Console.Write("Введите количество чисел: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < arr.Length; i++)
// {
//    Console.Write($"Введите {(i + 1)}-е число: ");
//    int a = Convert.ToInt32(Console.ReadLine());
//    arr[i] = a;
//    void isPrime(int a)
//    {
//       for (int j = 2; j < a; j++)
//       {
//          if (arr[i] % j == 0)
//             break;
//          else if (arr[i] == 2 || arr[i] == 3 || arr[i] % j != 0)
//          {
//             prime = arr[i];
//          }
//          primeCounter = prime + primeCounter;
//          return;
//       }
//    }
//    isPrime(a);
// }
// if (primeCounter == 0)
//    Console.WriteLine("Нет простых чисел");
// else
//    Console.WriteLine($"Сумма простых чисел: {primeCounter}");
// Console.WriteLine("Введенные числа: [" + string.Join(", ", arr) + "]");
