/*
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте вьmолнения алгоритма. При решении не рекомендуетеся пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denrnark", "Кazan"] -> []
*/


using static System.Console;

Clear();
Write("Введите колличество элементов массива: ");
int ArrayLength=Convert.ToInt32(ReadLine());
WriteLine("--------------------------------");
WriteLine($"[{String.Join(", ", Array(ArrayLength))}]");



string [] Array(int ArrayL)
{
    string [] Array=new string[ArrayL];
    for(int i=0; i<ArrayL; i++)
    {
        Clear();
        Write($"Введите {i} строку массива: ");
        Array[i]=ReadLine();
    }
    return Array;
}

string [] 