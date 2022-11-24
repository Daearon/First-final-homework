int RetrieveInteger (string msg)
{
    Console.WriteLine(msg);
    while (true)
    {
        if(int.TryParse(Console.ReadLine(), out var correctnumber))
        {
            Console.WriteLine($"Good, your number is {correctnumber}");
            return correctnumber;
        }
        else
        {
            Console.WriteLine("Input is not integer, retry, please");
        }
    }
}

string[] CreateArray ()
{
    int size = Math.Abs(RetrieveInteger("Input size of your array: "));
    Console.WriteLine("Creating array");
    
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
            {
                Console.Write($"Input a {i + 1} element of array: ");
                array[i] = Console.ReadLine();
            }

    return array;
}


string[] arrayInitial = CreateArray();
string[] arrayFinal = new string[arrayInitial.Length];
void DeterminateOfArrayFinal(string[] arrayInitial, string[] arrayFinal)
{
    int count = 0;
    for (int i = 0; i < arrayInitial.Length; i++)
    {
    if(arrayInitial[i].Length <= 3)
        {
        arrayFinal[count] = arrayInitial[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
DeterminateOfArrayFinal(arrayInitial, arrayFinal);
PrintArray(arrayFinal);
