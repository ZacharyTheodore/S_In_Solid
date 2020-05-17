using System;


namespace S_In_Solid
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            Console.WriteLine($"Your username is { user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}
