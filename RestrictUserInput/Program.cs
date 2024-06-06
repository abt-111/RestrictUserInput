using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Limit1: ");
        int limit1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Limit2: ");
        int limit2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Veuillez entrer un nombre compris entre " + limit1 + " et " + limit2);
        int number = Convert.ToInt32(Console.ReadLine());

        if(number <= limit2 && number >= limit1)
        {
            Console.WriteLine("Resulting integer: " + number);
        }
        else if(number > limit2)
        {
            Console.WriteLine("You have entered " + number + " which is greater than " + limit2 + " which is the maximum");
            Console.WriteLine("Resulting integer: " + limit2);
        }
        else
        {
            Console.WriteLine("You have entered " + number + " which is lower than " + limit1 + " which is the minimum");
            Console.WriteLine("Resulting integer: " + limit1);
        }
    }
}