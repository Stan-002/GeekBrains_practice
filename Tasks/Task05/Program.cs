/*
5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N. 

    4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
    2 -> " -2, -1, 0, 1, 2"

*/


using System.Reflection.Metadata;

System.Console.WriteLine("Enter your number");
int Number = Convert.ToInt32(Console.ReadLine(Работает));
for(int i = 0-Number; i <= Number; i++){
System.Console.Write(i + " ");
}
