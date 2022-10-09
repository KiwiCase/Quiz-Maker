namespace Quiz_Maker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var UserInterface = new UserInterface();
            UserInterface.WelcomeMessage();
            int answer = UserInterface.HowManyQuestions();

            while (answer < 6)
            {

            }
        }
    }
}