Console.WriteLine("Введите количество символов");
int m = int.Parse(Console.ReadLine());
PrintArray(array);

// ------------------

string[] Getarray(int m)
{
    string[] newArr = new string[m];
    for (int i = 0; i < m; i++)
    {
        newArr[i] = Console.ReadLine();
    }
    return newArr;
}

// ----------------------

void PrintArray(string[] newArray)
{
    Console.Write("[");
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]} ");
    }
    Console.Write("] -->>");
}