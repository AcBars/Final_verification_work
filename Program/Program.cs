using System;
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
string [] Array = Array(ArrayLength);
WriteLine($"[{String.Join(", ", Array)}]");
WriteLine("--------------------------------");
string [] NewArray= ThreeЕlements (Array)
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

string [] ThreeЕlements (string [] Array)
{
    int count=0;
    for(int i=0; i<Array.Length; i++)
    {
        int temp=Array[i].Length;
        if(temp<=3) count++;
    }
    string [] result=new string[count];
    for(int i=0; i<count; i++)
    {
        for(int j=i; j<Array.Length; j++)
        {
            if(Array[j].Length<=3) result[i]=Array[j];
        }
    }
    return result;
}