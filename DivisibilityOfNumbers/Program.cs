﻿/* Группа начинающих программистов решила поучаствовать в хакатоне с целью демонстрации
своих навыков.

Немного подумав они вспомнили, что не так давно на занятиях по математике
они проходили тему "свойства делимости целых чисел".На этом занятии преподаватель показывал
пример с использованием фактов делимости.
Пример заключался в следующем:
Написав на доске все числа от 1 до N, N = 50, преподаватель разделил числа на несколько групп
так, что если одно число делится на другое, то эти числа попадают в разные руппы.
В результате этого разбиения получилось M групп, для N = 50, M = 6
N = 50
Группы получились такими:

Группа 1: 1
Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
Группа 4: 8 12 18 20 27 28 30 42 44 45 50
Группа 5: 16 24 36 40
Группа 6: 32 48

Задача: найти M при заданном N.
И получить разбиение на группы*/
int EnterNumber()
{
    Console.Write("Введите число :");
    int Number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    return Number;
}
int[] FillArrayTillN(int Number)
{
    int[] Array = new int[Number];
    for(int i=1;i<=Number;i++)
    {
        Array[i-1] = i;
    }
    return Array;
}
void ShowArray(int[] Array)
{
    for(int i =0; i<Array.Length;i++)
    {
        Console.Write(Array[i]);
        Console.Write(" ");
    }
    Console.WriteLine(" ");
}
int FoundNewI(int[] Array)
{
    int key = 0;
    for(int i=1; i<Array.Length; i++)
    {
        if(Array[i]%Array[0]==0)
        {
            key++;
        }  
    }
    return key;
}
int[] CreateGroup(int[] Array, int NewKey)
{
    int[] NewArray = new int[NewKey];
    int j = 0;
    for(int i = 1; i<=NewArray.Length;i++)
    {
        if(Array[i]%Array[0]==0)
        {
            NewArray[j]=Array[i];
            j++;
        }
    }
    return NewArray;
}
int UserNumberN = EnterNumber();
int[] WholeArray = FillArrayTillN(UserNumberN);
int NewKey = FoundNewI(WholeArray);
int[] NewArray = CreateGroup(WholeArray, NewKey);
ShowArray(WholeArray);
Console.WriteLine(NewKey);
ShowArray(NewArray);