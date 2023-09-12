// See https://aka.ms/new-console-template for more information

// Example of Average Calculator. in c#

Console.Write("English    :  ");
float english = Convert.ToSingle(Console.ReadLine());
Console.Write("Math       :  ");
float math = Convert.ToSingle(Console.ReadLine());
Console.Write("Science    :  ");
float science = Convert.ToSingle(Console.ReadLine());
Console.Write("Computer   :  ");
float computer = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("");

float average = (english + math + science + computer) / 4;
Console.Write("Average is :  " + average);


