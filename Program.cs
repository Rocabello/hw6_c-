Console.Write("Введите числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine(SumOfEven(array));

// ----------Метод---------------
int SumOfEven(int[] newArray)
{   
    int count =0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}