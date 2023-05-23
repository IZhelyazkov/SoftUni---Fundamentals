namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string day = Console.ReadLine();
            double pricePerPerson = 0;
            double totalPrice = 0;

            switch (typeOfPeople)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                             pricePerPerson = 8.45;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.80;
                            break;
                        case "Sunday":
                             pricePerPerson = 10.46;
                            break;
                    }
                    
                    totalPrice = peopleCount * pricePerPerson;
         
                    if (peopleCount >= 30)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                             pricePerPerson = 10.90;
                            break;
                        case "Saturday":
                             pricePerPerson = 15.60;
                            break;
                        case "Sunday":
                             pricePerPerson = 16;
                            break;
                    }
                    totalPrice = peopleCount * pricePerPerson;

                    if (peopleCount >= 100)
                    {
                        peopleCount -= 10;
                        totalPrice = peopleCount * pricePerPerson;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                             pricePerPerson = 15;
                            break;
                        case "Saturday":
                             pricePerPerson = 20;
                            break;
                        case "Sunday":
                             pricePerPerson = 22.50;
                            break;
                            
                    }
                    totalPrice = peopleCount * pricePerPerson;

                    if (peopleCount >=10 && peopleCount <= 20)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }
                    break;

            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}