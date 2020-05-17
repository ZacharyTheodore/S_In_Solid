using System;


namespace S_In_Solid
{
    class StandardMessages
    {

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my Aplication!");
        }

        public static void ApplicationEnd()
        {
            Console.Write("Press enter to close...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not provide a valid {fieldName}...");
        } 
    }
}
