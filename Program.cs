
string[] CreateArray(int array)
{
    string [] newArray = new string[array];
    for (int i = 0; i < array; i++)
        {    
          Console.Write($"Input {i} element of the array: ");
          newArray[i] = Console.ReadLine();    
        }
    return newArray;
}
void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
string [] myArray = CreateArray (a);
ShowArray(myArray);


void PrintArray(string[] myArray)
{
    
    for (int i = 0; i < myArray.Length; i++)
    {
        if(myArray[i].Length <= 3)
        
        Console.Write($"{myArray[i]} ");
    }
    Console.WriteLine();
}

PrintArray(myArray);

