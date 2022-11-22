// Напишите программу, которая задает массив из 8 элементов заполненый псевдослучайными числами 
// и выводит из на экран . 

int [] array = new int[8];

void RandomArray (int [] arrayA)
{
    Random rndm = new Random();
    for ( int i = 0; i < arrayA.Length; i++)
    {
        arrayA[i] = rndm.Next(0, 999);
    }
}

void PrintArray(int[] arrayB)
{
    for (int i = 0; i < arrayB.Length; i++)
{
    Console.Write($" {arrayB[i]} ");
}
}

RandomArray(array);
PrintArray(array);