using System;

namespace Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Samurai!");

            // Ask for the player's name
            Console.Write("Enter your name, brave samurai: ");
            string playerName = Console.ReadLine();

            Console.WriteLine($"\nGreetings, {playerName}. Your journey as a samurai begins now.\n");

            // Store the player's answers
            string[] answers = new string[6];

            // Question 1
            Console.WriteLine("1. As you leave your village, you see a group of bandits attacking a merchant. Do you:");
            Console.WriteLine("A. Draw your blade and confront the bandits.");
            Console.WriteLine("B. Warn the villagers and rally them to defend the merchant.");
            Console.Write("Your choice: ");
            answers[0] = Console.ReadLine().ToUpper();

            // Question 2
            Console.WriteLine("\n2. After dealing with the bandits, you reach a shrine. The monk there asks for help rebuilding it. Do you:");
            Console.WriteLine("A. Offer to help rebuild the shrine.");
            Console.WriteLine("B. Politely decline and continue on your journey.");
            Console.Write("Your choice: ");
            answers[1] = Console.ReadLine().ToUpper();

            // Question 3
            Console.WriteLine("\n3. On your path, you encounter a wandering swordsman who challenges you to a duel. Do you:");
            Console.WriteLine("A. Accept the duel to prove your skill.");
            Console.WriteLine("B. Offer to spar peacefully to exchange techniques.");
            Console.Write("Your choice: ");
            answers[2] = Console.ReadLine().ToUpper();

            // Question 4
            Console.WriteLine("\n4. Night falls, and you hear whispers in the dark. A shadowy figure approaches. Do you:");
            Console.WriteLine("A. Confront the figure, prepared for combat.");
            Console.WriteLine("B. Stay silent and wait to see their intentions.");
            Console.Write("Your choice: ");
            answers[3] = Console.ReadLine().ToUpper();

            // Question 5
            Console.WriteLine("\n5. At sunrise, you arrive at a castle under siege. Do you:");
            Console.WriteLine("A. Join the defenders in protecting the castle.");
            Console.WriteLine("B. Try to sneak inside to speak with the lord.");
            Console.Write("Your choice: ");
            answers[4] = Console.ReadLine().ToUpper();

            // Question 6
            Console.WriteLine("\n6. At the climax of your journey, you face the warlord responsible for the chaos. Do you:");
            Console.WriteLine("A. Challenge the warlord to an honorable duel.");
            Console.WriteLine("B. Use strategy to ambush the warlord and his guards.");
            Console.Write("Your choice: ");
            answers[5] = Console.ReadLine().ToUpper();

            // Ending Remarks based on answers
            Console.WriteLine($"\nWell done, {playerName}! Here's how your journey unfolded:");

            // Dynamic story based on answers
            if (answers[0] == "A")
                Console.WriteLine("Your bravery against the bandits earned you the gratitude of the merchant.");
            else
                Console.WriteLine("Your careful observation allowed you to outsmart the bandits, saving the merchant without bloodshed.");

            if (answers[1] == "A")
                Console.WriteLine("Helping the monk brought you inner peace and blessings for your journey.");
            else
                Console.WriteLine("You continued with determination, though the shrine remained in disrepair.");

            if (answers[2] == "A")
                Console.WriteLine("You defeated the swordsman in a fierce duel, earning his respect.");
            else
                Console.WriteLine("You exchanged techniques with the swordsman, learning valuable skills for your journey.");

            if (answers[3] == "A")
                Console.WriteLine("The shadowy figure turned out to be an ally, impressed by your courage.");
            else
                Console.WriteLine("Your patience revealed the figure as a messenger with vital information.");

            if (answers[4] == "A")
                Console.WriteLine("Fighting alongside the defenders, you turned the tide of battle at the castle.");
            else
                Console.WriteLine("Your stealthy approach allowed you to warn the lord of an imminent attack.");

            if (answers[5] == "A")
                Console.WriteLine("You defeated the warlord in honorable combat, restoring peace to the land.");
            else
                Console.WriteLine("Your ambush was successful, ending the warlord's reign of terror with strategy and precision.");

            Console.WriteLine("\nYour legacy as a samurai will be remembered. Thank you for playing Samurai!");
        }
    }
}
