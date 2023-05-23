namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;
            int attemptCount = 0;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }

            while (true)
            {
                string attempt = Console.ReadLine();

                if (attempt != password)
                {
                    attemptCount++;

                    if (attemptCount == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }

                    Console.WriteLine("Incorrect password. Try again.");
                }

                else
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
            }



        }
    }
}