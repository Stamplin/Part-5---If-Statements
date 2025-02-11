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

            int time, fee, totalFee;
            Console.WriteLine("Enter the number of hours parked: ");
            time = Convert.ToInt32(Console.ReadLine());
            fee = 4;
            //fix time to minutes???

            if (time > 1)
            {
                totalFee = fee + ((time - 4) * 2);
                Console.WriteLine("Total fee: " + totalFee.ToString("C"));
            }
            
            //make the adding work
            
            else
            {
                totalFee = fee;
                Console.WriteLine("Total fee: " + totalFee.ToString("C"));
            }
            



            Console.ReadLine();
        }
    }
}
