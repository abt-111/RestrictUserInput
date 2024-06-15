using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    public static void Main(string[] args)
    {
        bool isValidInput;
        int limit1 = 0,
            limit2 = 0,
            number = 0;

        do
        {
            isValidInput = true;
            try
            {
                Console.WriteLine("Entrez une première limite: ");
                limit1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Entrez une deuxième limite: ");
                limit2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Veuillez entrer un nombre compris entre " + limit1 + " et " + limit2);
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception exception)
            {
                if (exception is FormatException || exception is OverflowException)
                {
                    Console.WriteLine($"Vous devez entrer des nombres entiers compris en {Int32.MinValue} et {Int32.MaxValue}");
                    isValidInput = false;
                }
            }
        }
        while(!isValidInput);

        if (number <= limit2 && number >= limit1)
        {
            Console.WriteLine("Resulting integer: " + number);
        }
        else if (number > limit2)
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