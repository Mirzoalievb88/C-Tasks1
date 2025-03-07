//task1
// using System;

// class Program
// {
//     static void Main()
//     {
//         string input = Console.ReadLine();
//         double deposit = Convert.ToDouble(input);

//         double interestRate = 0;

//         if (deposit < 100)
//         {
//             interestRate = 0.05;
//         }
//         else if (deposit <= 200)
//         {
//             interestRate = 0.07;
//         }
//         else
//         {
//             interestRate = 0.10;
//         }

//         double interest = deposit * interestRate;
//         double totalAmount = deposit + interest;
 
//         Console.WriteLine(totalAmount);
//     }
// }

//task2 

// int n = int.Parse(System.Console.ReadLine());
// int z = 1;
// for(int i=n; i>0; i/=10)
// {
//     z *= i%10;
// }
// System.Console.WriteLine("Zarb: " + z);

//task3

// int n;
// n = int.Parse(System.Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(System.Console.ReadLine());
// }
// int max = -9999;
// for (int i = 0; i < n; i++)
// {
//     if (i > max)
//     {
//         max = i;
//     }
// }
// System.Console.WriteLine(max);

//task4

// int n = int.Parse(System.Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(System.Console.ReadLine());
// }
// for (int i = 0; i < n - 1; i++)
// {
//     if(arr[i] != arr[i+1])
//     {
//         System.Console.WriteLine(arr[i]);
//     }
// }

//task5

// int n;
// n = int.Parse(System.Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(System.Console.ReadLine());
// }
// int max = 9999;
// Array.Sort(arr);
// for (int i = 0; i < n; i++)
// {
//     if (arr[i] < max)
//     {
//         max = i;
//     }
// }
// System.Console.WriteLine(max);

//task6

/////

//task7

// int n;
// n = int.Parse(System.Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(System.Console.ReadLine());
// }
// Array.Sort(arr);
// for (int i = 0; i < n; i++)
// {
//     if ((arr[i] <= 0 && arr[i + 1] <= 0) || (arr[i] < 0 && arr[i + 1] < 0))
//     {
//         System.Console.WriteLine(arr[i]);
//         System.Console.WriteLine(arr[i+1]);
//         return;
//     }
// }

//task8

// int n;
// n = int.Parse(System.Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(System.Console.ReadLine());
// }
// for (int i = 0; i < n; i++)
// {
//     if(arr[i] % 2 != 0)
//     {
//         System.Console.Write(i + " ");
//     }
// }

//task9

int n,a,b;
n = int.Parse(System.Console.ReadLine());
a = int.Parse(System.Console.ReadLine());
b = int.Parse(System.Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(System.Console.ReadLine());
}
for (int i = a; i < b; i++)
{
    if (arr[i] % 2 != 0)
    {
        System.Console.WriteLine(arr[i]);
    }
}