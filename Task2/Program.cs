// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

using System;
using System.Threading;

class Program
{
    static int AckFun(int m, int n) 
    { 
        if (m == 0) 
        {  
            return n + 1; 
        }  
        else if (n == 0) 
        {  
            return AckFun(m - 1, 1); 
        } 
        else 
        {  
            return AckFun(m - 1, AckFun(m, n - 1)); 
        }  
    } 
 
    static void Res() 
    { 
        int m = 2; 
        int n = 3; 
 
        int result = AckFun(m, n);  
        Console.WriteLine($"Функция Аккермана равна {result}");  
    } 

    static void Run()
    {
        Res();
    }

    static void Main(string[] args)
    {
        Thread thread = new Thread(Run, 1024 * 1024 * 64); // 64 MB stack size
        thread.Start();
        thread.Join();
    }
}