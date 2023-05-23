namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = numberOfPeople / capacity;
            if (numberOfPeople % capacity != 0)
            {
                double personToRemainder = numberOfPeople % capacity;
            }
            else
            {
                Console.WriteLine("All the persons fit inside in the elevator.\r\nOnly one course is needed.");
            }
        }
    }
}