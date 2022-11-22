// int [] array = new int [8]; // так создаем массив с количеством 8 элементов. 
// int [] arrayA = {3, 5, 7, 8, 6, 4}; // создание массива с цифрами
// int [] arrayB = new int [8] {4,5,6,7,8,9,6,4}; // создаем массив с известными эллементами

// array[0] = 34;
// array[1] = 36;
// array[2] = 74;
 

// Random rnd = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next();
// }

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int n = 8; // длинна массива
// int [] array = new int [8];
// int[] arr = new int[n];
// Random rnd = new Random();
int[] arr = new int[8];

void RandomAray (int[] array)
{
     Random rnd = new Random();
    for (int i =0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
}

void PrintArray (int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
}

RandomAray(arr);
PrintArray(arr);

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = rand.Next(0,2);
// }
// Console.WriteLine(string.Join(", ", arr));