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
            totalCost = 4 + ((addionalHours * 2));//make it so it dont count the first hour
            if (minutes < 60)
            {
                totalCost = 4;
            }
            else if (totalCost > 60)
            {
                totalCost = totalCost;
            }
            Console.WriteLine("Your total cost is: " + totalCost + "$");

            Console.ReadLine();
        }
    }
}
