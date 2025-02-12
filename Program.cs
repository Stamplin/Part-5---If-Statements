namespace Part_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1 - Compass Bearing
            int input, bearing;
            Console.WriteLine("Enter a bearing in degrees (0-360): ");
            input = Convert.ToInt32(Console.ReadLine());
            bearing = input % 360;
            //bearing north between 315 and 45
            if (bearing >= 315 || bearing <= 45)
            {
                Console.WriteLine("North");
            }
            //bearing east between 45 and 135
            else if (bearing >= 45 && bearing <= 135)
            {
                Console.WriteLine("East");
            }
            //bearing south between 135 and 225
            else if (bearing >= 135 && bearing <= 225)
            {
                Console.WriteLine("South");
            }
            //bearing west between 225 and 315
            else if (bearing >= 225 && bearing <= 315)
            {
                Console.WriteLine("West");
            }
            else
            {
                Console.WriteLine("Invalid bearing, read the instructions again BRROOOOOO!");
            }
            //press enter to go to part 2
            Console.WriteLine("Press enter to continue to part 2");
            Console.ReadLine();
            Console.Clear();

            //Part 2 - Parking Garage

            //min fee for parking is 4$ for first hour
            //each hour is +2$
            //max free for the day is 20$ for the day

            int minutes, addionalHours, totalCost;
            Console.WriteLine("Enter the number of minutes you have parked: ");
            minutes = Convert.ToInt32(Console.ReadLine());
            //round to closest hour
            addionalHours = Convert.ToInt32(Math.Ceiling((double)minutes / 60));
            //the (-1) make it so it dont count the first hour
            totalCost = 4 + ((addionalHours - 1) * 2);
            if (minutes < 60)
            {
                totalCost = 4;
            }
            else if (totalCost > 60)
            {
                totalCost = totalCost;
            }
            Console.WriteLine("Your total cost is: " + totalCost + "$");

            //press enter to go to part 3
            Console.WriteLine("Press enter to continue to part 3");
            Console.ReadLine();
            Console.Clear();

            //part 3 - Hurricane
            //use switch statement instead of if statement
            int category;
            Console.WriteLine("Enter the category of the hurricane (input 1-5): ");
            category = Convert.ToInt32(Console.ReadLine());
            switch (category)
            {
                case 1:
                    Console.WriteLine("Category 1: Tropical");
                    Console.WriteLine("Winds 74-95 mph (64-82 kt or 119-153 km/hr).");
                    break;
                case 2:
                    Console.WriteLine("Category 2: Tropical");
                    Console.WriteLine("Winds 96-110 mph (83-95 kt or 154-177 km/hr).");
                    break;
                case 3:
                    Console.WriteLine("Category 3: Tropical");
                    Console.WriteLine("Winds 111-129 mph (96-112 kt or 178-208 km/hr).");
                    break;
                case 4:
                    Console.WriteLine("Category 4: Tropical");
                    Console.WriteLine("  Winds 130-156 mph (113-136 kt or 209-251 km/hr).");
                    break;
                case 5:
                    Console.WriteLine("Category 5: Tropical");
                    Console.WriteLine(" Winds 157 mph or higher (137 kt or higher or 252 km/hr or higher).");
                    break;

                    
            }
            Console.ReadLine();
        }
    }
}
