﻿// #1 the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";
decimal decimalDonation;

// #2 variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// #3 array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 7];

// #4 create sample data ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            suggestedDonation = "49.99";
            break;
        
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "snow";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "3";
            animalPhysicalDescription = "Medium sized, long hair, yellow, female, about 10 pounds. Uses litter box.";
            animalPersonalityDescription = "A people loving cat that likes to sit on your lap.";
            animalNickname = "Lion";
            suggestedDonation = "";

            break;
        
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;

    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
    
    if (!decimal.TryParse(suggestedDonation, out decimalDonation)){
        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
        ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
    } else {
        ourAnimals[i, 6] = "Suggested Donation: "  + suggestedDonation;
    }
}

// #5 display the top-level menu options
do
{
    // NOTE: the Console.Clear method is throwing an exception in debug sessions
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Display all dogs with a specified characteristic
            // Display all dogs with a specified characteristic
            string[] dogCharacteristics = {"","","","","",""};
            string[] searchingIcons = {". ", ".. ", "..."};
            string[] loadingIcons = {"\\", "/", "--", "\\", "/", "--"}

            while (dogCharacteristics[0] == "")
            {
                // have the user enter physical characteristics to search for
                Console.WriteLine($"\nEnter one desired dog characteristics to search for");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    dogCharacteristics = readResult.ToLower().Trim().Split(',');
                }
            } 

            bool dogMatch = false;

            for (int i = 0; i < maxPets; i++) {

                if (ourAnimals[i, 1].Contains("dog"))
                {
                    int matches = 0;
                    string dogDescription = ourAnimals[i, 3] + $"({ourAnimals[i, 0]})\n" + ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];

                    

                    for (int j = 0; j < (dogCharacteristics.Length)-1; j++){

                        if (dogDescription.Contains(dogCharacteristics[j])) {
                            Console.WriteLine($"\nOur {ourAnimals[i, 1]} {ourAnimals[i, 3]} is a {dogCharacteristics[j]} match!");
                            matches++;
                            dogMatch = true;
                        }
                    }
                    Console.WriteLine();

                    if (matches > 0) {
                        Console.WriteLine(dogDescription);
                        Console.WriteLine("-------------------------------------");
                    }   
                }

            }

            if (!dogMatch)
                Console.WriteLine("No se encontraron coincidencias para los perros disponibles");


            Console.WriteLine("\nPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");
