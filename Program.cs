
using System;

namespace SkincareGuide
{
    internal class Program
    {
        static void Main(string [] args)
        {

            Console.WriteLine("5 Steps of Skin Care Guide!");

            Console.Write("\nPlease enter your name: ");
            string name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("\nPlease choose the number of your skin type:");
                Console.WriteLine("1 - Oily \n2 - Dry \n3 - Sensitive \n4 - Combination (Oily + Dry)");
                int st = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nHi {name}, based on your skin type, here are your recommended skin care routine:");

                switch (st)
                {
                    case 1: //for oily skin

                        Console.WriteLine("- STEP 1: Facial Foaming Cleanser");
                        Console.WriteLine("- STEP 2: Alcohol-Free Toner");
                        Console.WriteLine("- STEP 3: Niacinamide Serum");
                        Console.WriteLine("- STEP 4: Oil-free Moisturizer");
                        Console.WriteLine("- STEP 5: Matte-Finish Sunscreen");

                        break;

                    case 2: //for dry skin

                        Console.WriteLine("- STEP 1: Hydrating Cream Cleanser");
                        Console.WriteLine("- STEP 2: Hydrating Toner");
                        Console.WriteLine("- STEP 3: Hyaluronic Acid Serum");
                        Console.WriteLine("- STEP 4: Ceramide-rich Moisturizer");
                        Console.WriteLine("- STEP 5: Moisturizing Sunscreen with SPF 30+");

                        break;

                    case 3: //for sensitive skin

                        Console.WriteLine("- STEP 1: Gentle and Fragrance-free Cleanser");
                        Console.WriteLine("- STEP 2: Alcohol-Free and Soothing Toner");
                        Console.WriteLine("- STEP 3: Niacinamide or Centella Asiatica Serum");
                        Console.WriteLine("- STEP 4: Fragrance-free and Ceramide-rich Moisturizer");
                        Console.WriteLine("- STEP 5: Mineral (zinc oxide or titanium dioxide) Sunscreen");

                        break;

                    case 4: //for combi skin (oily and dry)

                        Console.WriteLine("- STEP 1: Gel-based or Foaming Cleanser");
                        Console.WriteLine("- STEP 2: Alcohol-Free and Balancing Toner");
                        Console.WriteLine("- STEP 3: Niacinamide or Hyaluronic Acid Serum");
                        Console.WriteLine("- STEP 4: Lightweight and Oil-free Gel Moisturizer");
                        Console.WriteLine("- STEP 5: Broad-spectrum and Lightweight Sunscreen");

                        break;

                    default:

                        Console.WriteLine("Invalid input! Please enter a number between 1 to 4 only.");

                        break;
                }

                Console.WriteLine("\nWould you like another guide? Yes or No?");
                string response = Console.ReadLine().ToLower();

                if (response != "YES")
                {
                    Console.WriteLine($"\nThank you, {name}! Keep slaying that glow!");
                    break;
                }

            }
        }
    }
}