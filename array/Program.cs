Console.WriteLine("Введите количество символов");
int m = int.Parse(Console.ReadLine());
string[] array = Getarray(m);
PrintArray(array);
PrintRandomArray(array);

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

// ------------------------

void PrintRandomArray(string[] newArray)
{
    int l = new Random().Next(1, 4);
    string[] randomArr = new string[l];
    Console.Write("[");
    for (int i = 0; i < l; i++)
    {
        randomArr[i] = newArray[new Random().Next(0, m - 1)];
        Console.Write($"{randomArr[i]} ");
    }
    Console.Write("]");
}