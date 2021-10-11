namespace ConsoleApp.CSharpBasics
{
    using static ConsoleApp.CSharpBasics.IO.Output;

    class Program
    {
        static void Main(string[] args)
        {
            WriteNewLine();

            Out.WriteLine("Automation test simulation. Guess credentials");

            string[] expectedMessages =
            {
                "You are logged in.",
                "Good bye",
                "Password or login are wrong. Input them once more please."
             };

            foreach (string testCredentials in TestGuessCredentials)
            {
                string actualMessage = TestGuessCredentials(testCredentials[i]);
                PrintTestResults(testCredentials[i], actualMessage, expectedMessages[i]);
            }


            public static void WriteNewLine()
            {
                Out.WriteLine();
            }

            public static string TestGuessCredentials(string testCredentials)
            {
                const string userLogin = "Smb";
                const string userPassword = "12345";
                const string quitMarker = "Q";
                string login = "Smth";
                string password = "123";

                if (login == userLogin && password == userPassword)
                {
                    return "You are logged in.";
                }
                else
                {
                    if (login == quitMarker || password == quitMarker)
                    {
                        return "Good bye!";
                    }

                    else
                    {
                        return "Password or login are wrong.Input them once more please.";
                    }
                }
            }
        }

        public static void PrintTestResults(string testCredentials, string actualMessage, string expectedMessage)
        {
            if (actualMessage == expectedMessage)
            {
                Out.WriteLine($"Test value: {testCredentials}; Test: PASSED");
                Out.WriteLine($"Expected message: {expectedMessage}");
                Out.WriteLine($"Actual message: {actualMessage}");
            }
            else
            {
                Out.WriteLine($"Test value: {testCredentials}; Test: FAILED");
                Out.WriteLine($"Expected message: {expectedMessage}");
                Out.WriteLine($"Actual message: {actualMessage}");
            }
        }
    }
}
