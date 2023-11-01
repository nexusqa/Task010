using System;
using static System.Console;

Clear();

WriteLine("Введите числа через пробел: ");
int[] array1=GetArray(ReadLine());
Write($"[{String.Join(" ", array1)}]-->");
WriteLine($"{GetCount(array1)}");

int[] GetArray(string strArr)
{
    string[] numS = strArr.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[numS.Length];
    for (int i=0; i < res.Length; i++)
    {
        res[i] = int.Parse(numS[i]);
    }
    return res;
}

int GetCount(int[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {   
        if (arr[i] > 0) cnt+=1;
    }
    return cnt;
}


