﻿System.Console.WriteLine("Введите строки через ','");
string text = Console.ReadLine()!;
string[] array = GetString(text);
PrintArray(array);
System.Console.Write(" -> ");
PrintArray(GetArray(array));

//------------metods----------
string[] GetString(string text)
{
    string[] array = text.Split(',', StringSplitOptions.RemoveEmptyEntries);
    return array;
}

string[] GetArray(string[] array)
{
    int count = 0;
    int j = 0;
    foreach(var item in array)
    {
        if(item.Length<=3) count++;
    }
    string[] result = new string[count];
    for(int i = 0;i<array.Length;i++)
    {
        if(array[i].Length<=3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    System.Console.Write($"[{String.Join(",", array)}]");
}