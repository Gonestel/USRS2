using System;

namespace USRS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string chislo_1 = Console.ReadLine();
            double a = Convert.ToDouble(chislo_1);
            Console.WriteLine("Введите второе число");
            string chislo_2 = Console.ReadLine();
            double b = Convert.ToDouble(chislo_2);
            bool x = (a > b) & (a == b);
            bool y = (a < b) | (a > b);                                                    
            bool z = (chislo_1 == chislo_2) | (chislo_1 == chislo_2);  // При использовании строковых переменных очень сильно урезаются возможности проводимых операций (к строковым переменным невозможно применить знаки '>' или '<')
            bool w = (a > b);
            Console.WriteLine(a + " > " + b + " и " + a + " = " + b + " - " + x);
            Console.WriteLine(a + " < " + b + " или " + a + " > " + b + " - " + y);
            Console.WriteLine(chislo_1 + " = " + chislo_2 + " или " + chislo_1 + " = " + chislo_2 + " - " + z);
            Console.WriteLine(a + " > " + b + " - " + w);
            Console.ReadLine();
                
        }
    }
}