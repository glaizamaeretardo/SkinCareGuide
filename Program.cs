using System;

namespace SkinCareGuide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 5 Steps of Skin Care Routine Guide!");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Please type your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("----------------------------------------");

            while (true)
            {
                int skinType = GetUserSkinType();

                if (skinType == -1)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Oops! Please type a number between 1 to 4 only.");
                    continue;
                }

                DisplayFiveSteps(name, skinType);

                Console.WriteLine("----------------------------------------");
                bool continueGuide = AskForAnotherGuide(name);

                if (!continueGuide)
                {
                    break;
                }
            }
        }
        static int GetUserSkinType()
        {
            Console.WriteLine("Type the number of your skin type: ");
            Console.WriteLine("1 - Oily \n2 - Dry \n3 - Sensitive \n4 - Combination (Oily + Dry)");

            if (!int.TryParse(Console.ReadLine(), out int skinType) || skinType < 1 || skinType > 4)
            {
                return -1;
            }
            return skinType;
        }

        static void DisplayFiveSteps(string name, int skinType)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Hi {name}! based on your skin type, here is your recommended 5 Steps of Skin Care Routine:");

            switch (skinType)
            {
                case 1: //oily skin
                    Console.WriteLine("- STEP 1: Facial Foaming Cleanser");
                    Console.WriteLine("- STEP 2: Alcohol-Free Toner");
                    Console.WriteLine("- STEP 3: Niacinamide Serum");
                    Console.WriteLine("- STEP 4: Oil-free Moisturizer");
                    Console.WriteLine("- STEP 5: Matte-Finish Sunscreen");
                    break;

                case 2: //dry skin
                    Console.WriteLine("- STEP 1: Hydrating Cream Cleanser");
                    Console.WriteLine("- STEP 2: Hydrating Toner");
                    Console.WriteLine("- STEP 3: Hyaluronic Acid Serum");
                    Console.WriteLine("- STEP 4: Ceramide-rich Moisturizer");
                    Console.WriteLine("- STEP 5: Moisturizing Sunscreen with SPF 30+");
                    break;

                case 3: //sensitive skn
                    Console.WriteLine("- STEP 1: Gentle and Fragrance-free Cleanser");
                    Console.WriteLine("- STEP 2: Alcohol-Free and Soothing Toner");
                    Console.WriteLine("- STEP 3: Niacinamide or Centella Asiatica Serum");
                    Console.WriteLine("- STEP 4: Fragrance-free and Ceramide-rich Moisturizer");
                    Console.WriteLine("- STEP 5: Mineral (zinc oxide or titanium dioxide) Sunscreen");
                    break;

                case 4: // combi skin (oily and dry)
                    Console.WriteLine("- STEP 1: Gel-based or Foaming Cleanser");
                    Console.WriteLine("- STEP 2: Alcohol-Free and Balancing Toner");
                    Console.WriteLine("- STEP 3: Niacinamide or Hyaluronic Acid Serum");
                    Console.WriteLine("- STEP 4: Lightweight and Oil-free Gel Moisturizer");
                    Console.WriteLine("- STEP 5: Broad-spectrum and Lightweight Sunscreen");
                    break;
            }
        }

        static bool AskForAnotherGuide(string name)
        {
            Console.WriteLine("Would you like another guide? Please type Yes or No.");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                Console.WriteLine($"Thank you, {name}! Keep slaying that glow!");
                return false;
            }
            return true;
        }
    }
}