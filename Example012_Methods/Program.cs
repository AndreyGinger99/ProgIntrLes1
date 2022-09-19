// // Вид 1
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// Method1();

// //Вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// // Вид 2.1
// void Method21(string msge, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msge);
//         i++;
//     }
// }
// Method21(msge: "Текст", count: 8);

// // Вид 3
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// // Вид 4
// string Method4(int count_new, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while (i < count_new)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(20, "Андрей");
// Console.WriteLine(res);
// Console.Write(" Цикл в цикле");


// for (int i=2; i <=10; i++)
// {
//     for (int j=2; j<=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }


string text =
    "- Я думаю, - сказал князь, улыбаясь, - что, "
    + "ежели бы вас послали вместо нашего милого Винценгероде,"
    + "вы бы взяли приступом согласие прусского короля."
    + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwert"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}";
        Console.WriteLine(result);
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

System.Console.Clear();

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 5, 6, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] > array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition]=temporary;
    }
}
SelectionSort(arr);
PrintArray(arr);
