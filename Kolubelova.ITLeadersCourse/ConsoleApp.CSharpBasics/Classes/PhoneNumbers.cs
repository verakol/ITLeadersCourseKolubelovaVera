namespace ConsoleApp.CSharpBasics.Classes
{
    public class PhoneNumbers
    {
        private string number;

        public PhoneNumbers(string number)
        {
            this.number = number;
        }

        public string GetPhoneNumber()
        {
            return $"My phone number is {number}";
        }
    }
}