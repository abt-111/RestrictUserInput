class MainClass
{
    public static void Main(string[] args)
    {
        bool isValidInput = false;
        // Pour éviter d'avoir à retaper lorsqu'une exception est levée par la suite
        bool[] isAlreadyAssign = { false, false };
        int[] limit = { 0, 0 };
        int number = 0;

        do
        {
            try
            {
                // Saisie de l'utilisateur
                SetUserInputs(isAlreadyAssign, limit, out number);

                // Aucune exception n'a été levées
                isValidInput = true;
            }
            catch (Exception exception)
            {
                if (exception is FormatException || exception is OverflowException)
                {
                    Console.WriteLine($"You must enter integers between {Int32.MinValue} and {Int32.MaxValue} \n");
                }
            }
        }
        while(!isValidInput);

        RestrictAndDisplay(limit, number);
    }

    public static void SetLimit(bool[] isAlreadyAssign, int[] limit, int index)
    {
        if (!isAlreadyAssign[index])
        {
            Console.WriteLine($"Limit{index + 1}: ");
            limit[index] = Convert.ToInt32(Console.ReadLine());
            isAlreadyAssign[index] = true;
        }
    }

    public static void SwapLimits(int[] limit)
    {
        // Si la première limite est supérieure à la deuxième…
        if (limit[0] > limit[1])
        {
            // … on permute les valeurs;
            int swapVariable = limit[0];
            limit[0] = limit[1];
            limit[1] = swapVariable;
        }
    }

    public static void SetUserInputs(bool[] isAlreadyAssign, int[] limit, out int number)
    {
        for (int i = 0; i < limit.Length; i++)
        {
            if (!isAlreadyAssign[i])
            {
                SetLimit(isAlreadyAssign, limit, i);
            }
        }

        SwapLimits(limit);

        Console.WriteLine("Integer: ");
        number = Convert.ToInt32(Console.ReadLine());
    }

    public static void RestrictAndDisplay(int[] limit, int number)
    {
        // Si number est compris dans l'intervalle [limit[0];limit[1]]…
        if (number >= limit[0] && number <= limit[1])
        {
            // … on affiche sa valeur
            Console.WriteLine("Resulting integer: " + number);
        }
        // Si number est inférieur à limit[0]…
        else if (number < limit[0])
        {
            // … on affiche un message le message idoine…
            Console.WriteLine("You have entered " + number + " which is lower than " + limit[0] + " which is the minimum");
            // … on renvoie la valeur de limite1
            Console.WriteLine("Resulting integer: " + limit[0]);
        }
        // Si number est supérieur à limit[1]…
        else
        {
            // … on affiche un message le message idoine…
            Console.WriteLine("You have entered " + number + " which is greater than " + limit[1] + " which is the maximum");
            // … on renvoie la valeur de limite2
            Console.WriteLine("Resulting integer: " + limit[1]);
        }
    }
}