// See https://aka.ms/new-console-template for more information


using System.Runtime.InteropServices;

Console.Write("English    :  ");
int english = Convert.ToInt32(Console.ReadLine());
Console.Write("Math       :  ");
int math = Convert.ToInt32(Console.ReadLine());
Console.Write("Science    :  ");
int science = Convert.ToInt32(Console.ReadLine());
Console.Write("Computer   :  ");
float computer = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("");

float average = (english + math + science + computer) / 4;
Console.Write("Average is :  " + average);
