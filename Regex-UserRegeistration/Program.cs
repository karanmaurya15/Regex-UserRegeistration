namespace Regex_UserRegeistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Regex Program\n");

            User user = new User();
            user.FirstName();
            user.LastName();
            user.Email();
        }
    }
}