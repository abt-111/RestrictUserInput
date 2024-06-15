using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    public static void Main(string[] args)
    {
        bool isValidInput = false;
        int limit1 = 0,
            limit2 = 0,
            number = 0;

        do
        {
            try
            {
                // Saisie de l'utilisateur
                Console.WriteLine("Entrez une première limite: ");
                limit1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Entrez une deuxième limite: ");
                limit2 = Convert.ToInt32(Console.ReadLine());

                // Si la première limite est supérieure à la deuxième…
                if (limit1 > limit2)
                {
                    // … on permute les valeurs;
                    int permutationVariable = limit1;
                    limit1 = limit2;
                    limit2 = permutationVariable;
                }

                Console.WriteLine("Veuillez entrer un nombre compris entre " + limit1 + " et " + limit2);
                number = Convert.ToInt32(Console.ReadLine());

                // Aucune exception n'a été levées
                isValidInput = true;
            }
            catch (Exception exception)
            {
                if (exception is FormatException || exception is OverflowException)
                {
                    Console.WriteLine($"Vous devez entrer des nombres entiers compris en {Int32.MinValue} et {Int32.MaxValue} \n");
                }
            }
        }
        while(!isValidInput);

        // Si number est compris dans l'intervalle [limit1;limit2]…
        if (number >= limit1 && number <= limit2)
        {
            // … on affiche sa valeur
            Console.WriteLine("Resulting integer: " + number);
        }
        // Si number est inférieur à limit1…
        else if (number < limit1)
        {
            // … on affiche un message le message idoine…
            Console.WriteLine("You have entered " + number + " which is lower than " + limit1 + " which is the minimum");
            // … on renvoie la valeur de limite1
            Console.WriteLine("Resulting integer: " + limit1);
        }
        // Si number est supérieur à limit2…
        else
        {
            // … on affiche un message le message idoine…
            Console.WriteLine("You have entered " + number + " which is greater than " + limit2 + " which is the maximum");
            // … on renvoie la valeur de limite2
            Console.WriteLine("Resulting integer: " + limit2);
        }
    }
}