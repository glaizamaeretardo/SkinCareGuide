using System;
using System.Collections.Generic;
using SCG_BusinessLogic;
using SCG_Common;
using SCG_DataLogic;

namespace SkinCareGuide
{
    internal class Program
    {
        static SCGData dataService = new SCGData();
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Welcome to the Basic 5-Step Skin Care Routine Guide!");

            while (true)
            {
                DisplayMainMenu();
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        SkinTypeTest();
                        break;

                    case "2":
                        GetUserSkinType();
                        break;

                    case "3":
                        ViewReference();
                        break;

                    case "4":
                        UpdateUserDetails();
                        break;

                    case "5":
                        DeleteUserDetails();
                        break;

                    case "6":
                        SearchUserDetails();
                        break;

                    default:
                        Console.WriteLine("Not a valid option! Please enter number between 1 to 5 only.");
                        break;
                }
                Console.WriteLine("\nDo you want to go back to the menu? Please type Yes or No:");
                string backToMenu = Console.ReadLine().Trim().ToLower();
                
                if (backToMenu != "yes")
                {
                    Console.WriteLine("\nThank you! Keep slaying that glow!");
                    break;
                }
            }
        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("\nPlease select an option: ");
            Console.WriteLine("[1] I don't know my skin type yet! (Take a quick test)");
            Console.WriteLine("[2] I already know my skin type! (Show the basic routine)");
            Console.WriteLine("[3] View reference (Check saved user details)");
            Console.WriteLine("[4] Update a saved user");
            Console.WriteLine("[5] Delete a saved user");
            Console.WriteLine("[6] Search a user by name");
        }

        static void SkinTypeTest()
        {
            int skinType = AskSkinType();
            DisplaySkinTypeResult(skinType);

            if (skinType == 5)
            {
                Console.WriteLine("Since you have NORMAL skin, all you need to do is maintain your current routine!");
            }

            else
            {
                Console.WriteLine("Do you want to know your recommended 5-step basic skin care routine? Please type Yes or No:");
                string displayRoutine = Console.ReadLine().Trim().ToLower();

                if (displayRoutine == "yes")
                {
                    DisplayFiveSteps(skinType);

                    Console.WriteLine("\nDo you want to save your details for reference? Please type Yes or No:");
                    string save = Console.ReadLine().Trim().ToLower();
                    if (save == "yes")
                    {
                        Console.WriteLine("-----------------------------------------------------------");
                        Console.WriteLine("Please type your name: ");
                        string nameToAdd = Console.ReadLine();

                        dataService.SaveUserDetails(nameToAdd, skinType);
                        Console.WriteLine("\nYour details have been saved!");
                    }
                }
            }
        }

        static int AskSkinType()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Answer these following questions with Yes or No only:");
            Console.WriteLine("\n1. Does your face appear oily or greasy a few hours after washing?");
            bool oilySkin = Console.ReadLine().Trim().ToLower() == "yes";

            Console.WriteLine("\n2. Does your skin frequently feel dry or rough?");
            bool drySkin = Console.ReadLine().Trim().ToLower() == "yes";

            Console.WriteLine("\n3. Does your skin become easily irritated by new products or changes in the weather?");
            bool sensitiveSkin = Console.ReadLine().Trim().ToLower() == "yes";

            Console.WriteLine("\n4. Does your skin feel balanced, not too oily or dry, throughout the day?");
            bool normalSkin = Console.ReadLine().Trim().ToLower() == "yes";

            return SCGProcess.FindOutSkinType(oilySkin, drySkin, sensitiveSkin, normalSkin);
        }

        static void DisplaySkinTypeResult(int skinType)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Your skin type is: ");
            Console.WriteLine(SCGProcess.GetSkinTypeName(skinType));
            Console.WriteLine("-----------------------------------------------------------");
        }

        static void DisplayFiveSteps(int skinType)
        {
            Console.WriteLine("\nHi! Based on your skin type, here's your recommended basic 5-step of skin care routine for you to try:\n");

            switch (skinType)
            {
                case 1: //for oily skin
                    Console.WriteLine("STEP 1: Start with a foaming cleanser to get rid of the grease and keep your skin nice and fresh.");
                    Console.WriteLine("STEP 2: Use an alcohol-free toner to gently balance your skin without drying it out.");
                    Console.WriteLine("STEP 3: Apply a niacinamide serum to help control the extra shine and calm redness.");
                    Console.WriteLine("STEP 4: Moisturize with an oil-free lotion to keep your skin hydrated without clogging your pores.");
                    Console.WriteLine("STEP 5: Finish with a matte sunscreen to keep your skin protected and looking smooth all day.");
                    break;

                case 2: //for dry skin
                    Console.WriteLine("STEP 1: Use a hydrating cream cleanser to wash your skin without drying it out.");
                    Console.WriteLine("STEP 2: Follow up with a hydrating toner to keep all that moisture locked in!");
                    Console.WriteLine("STEP 3: Apply hyaluronic acid serum to help your skin retain moisture and stay hydrated.");
                    Console.WriteLine("STEP 4: Put on a thick layer of moisturizer to keep your skin soft and comfy.");
                    Console.WriteLine("STEP 5: Make sure to use a moisturizing sunscreen, it will protect your skin while keeping it nice and dewy!");
                    break;

                case 3: //for sensitive skin
                    Console.WriteLine("STEP 1: Start with a mild, fragrance-free cleanser to keep your skin feeling good.");
                    Console.WriteLine("STEP 2: Go for an alcohol-free toner to keep your skin cool and calm.");
                    Console.WriteLine("STEP 3: Try a serum with niacinamide or centella asiatica, it’s great for calming irritation!");
                    Console.WriteLine("STEP 4: Use a fragrance-free moisturizer to keep your skin barrier strong and protected.");
                    Console.WriteLine("STEP 5: Finish with a mineral sunscreen for easy protection!");
                    break;

                case 4: //for combination skin (oily + dry)
                    Console.WriteLine("STEP 1: Cleanse your face using a gel or foaming cleanser that suits both oily and dry skin.");
                    Console.WriteLine("STEP 2: Use a balancing toner to keep your skin feeling fresh and even.");
                    Console.WriteLine("STEP 3: Apply a serum with niacinamide or hyaluronic acid to hydrate while controlling oil.");
                    Console.WriteLine("STEP 4: Use a lightweight gel moisturizer that hydrates without feeling heavy.");
                    Console.WriteLine("STEP 5: Finish with a broad-spectrum, lightweight sunscreen to protect your skin and keep it glowing.");
                    break;
            }
        }

        static void GetUserSkinType()
        {
            while (true)
            {
                Console.WriteLine("Type the number of your skin type: ");
                Console.WriteLine("1 - Oily \n2 - Dry \n3 - Sensitive \n4 - Combination (Oily + Dry)");

                if (int.TryParse(Console.ReadLine(), out int skinType) && skinType >= 1 && skinType <= 4)
                {
                    DisplayFiveSteps(skinType);
                    break;
                }
                else
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("Oops! Please type a number between 1 to 4 only.\n");
                }
            }
        }

        static void ViewReference() //view was implemented (the option 3)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Here are the user's saved details:");
            var viewUsers = dataService.GetAllUserDetails();

            if (viewUsers.Count == 0)
            {
                Console.WriteLine("There's no user information available!");
            }
            else
            {
                foreach (var reference in dataService.GetAllUserDetails())
                {
                    Console.WriteLine($"\nName: {reference.Name} \nUser's Skin Type: {(SkinType)reference.SkinType}");
                }
            }
        }

        //added other functionalities
        static void UpdateUserDetails()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Please type the name of the user you want to update: ");
            string userToUpdate = Console.ReadLine();

            Console.WriteLine("Type the number of your skin type: ");
            Console.WriteLine("1 - Oily \n2 - Dry \n3 - Sensitive \n4 - Combination (Oily + Dry)");

            if(int.TryParse(Console.ReadLine(), out int updatedSkinType) && updatedSkinType >= 1 && updatedSkinType <= 4)
            {
                if (dataService.UpdateUserDetails(userToUpdate, updatedSkinType, out string newUserSkinType))
                {
                    Console.WriteLine($"\nUser '{userToUpdate}' has been updated! \nThe new skin type: {newUserSkinType}");
                }
                else
                {
                    Console.WriteLine("\nNo matching name found in the saved reference!");
                }
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Oops! Please type a number between 1 to 4 only.\n");
            }
        }

        static void DeleteUserDetails()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Please type the name you want to delete: ");
            string nameToDelete = Console.ReadLine();

            if (dataService.DeleteUserDetails(nameToDelete))
            {
                Console.WriteLine($"User '{nameToDelete}' has been removed from the saved reference!");
            }
            else
            {
                Console.WriteLine("\nNo matching name found in the saved reference!");
            }
        }

        static void SearchUserDetails()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Please type the name you want to search: ");
            string nameToSearch = Console.ReadLine();

            if (dataService.SearchUserDetails(nameToSearch, out string skinType))
            {
                Console.WriteLine($"Name: {nameToSearch} \nUser's Skin Type: {skinType}");
            }
            else
            {
                Console.WriteLine("\nNo matching name found in the saved reference!");
            }
        }
    }
}