System.Console.WriteLine("Введите строки через ','");
string text = Console.ReadLine()!;
string[] array = GetString(text);

//------------metods----------
string[] GetString(string text)
{
    string[] array = text.Split(',', StringSplitOptions.RemoveEmptyEntries);
    return array;
}

