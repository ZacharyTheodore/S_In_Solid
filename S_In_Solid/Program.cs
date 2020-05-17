

namespace S_In_Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isPersonValid = PersonValidator.Validate(user);

            if(!isPersonValid)
            {
                StandardMessages.ApplicationEnd();
                return;
            }

            AccountGenerator.CreateAccount(user);

            StandardMessages.ApplicationEnd();

        }
    }
}
