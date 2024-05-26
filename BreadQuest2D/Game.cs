using System.Numerics;

namespace BreadQuest2Dv2
{
    public class Game
    {
        public Player Player { get; }

        public Game()
        {
            // setup defaults for game
            Player = new Player();
        }

        //Get choices and validate a good answer
        int GetGameDialogChoice(List<string> choices, params string[] openingDialog)
        {
            for (int i = 0; i < openingDialog.Length; i++)
            {
                if (i == openingDialog.Length - 1)
                {
                    // last item
                    Console.WriteLine($"{openingDialog[i]} Do you:");
                }
                else
                {
                    Console.WriteLine(openingDialog[i]);
                }
            }
            return Helpers.GetUserChoice("Enter the number of your choice: ", "You didn't provide a valid option. Please try again.", choices);
        }
        
        //Main menu, may need to be reworked depending on how game goes
        public void ShowMainMenu()
        {
            Console.Clear();
            int choice = Helpers.GetUserChoice("Menu: ", "You didn't provide a valid option. Please try again.", ["Inventory", "Base"]);
            switch (choice)
            {
                case 1:
                    Player.PrintInventory();
                    break;
                case 2:
                    Console.WriteLine("Returning to base...");
                    Thread.Sleep(1000);
                    ShowBaseMenu();
                    break;
            }
        }

        //Base menu, may need reworked depending on how the rest of the game goes. Maybe merge with Main Menu?
        public void ShowBaseMenu()
        {
            Console.Clear();
            Console.WriteLine("You return to your base");
            int choice = Helpers.GetUserChoice("What would you like to do: ", "You didn't provide a valid option. Please try again.", ["Sleep", "Make bread", "Call the Scavenger leader to your room", "Leave base", "Menu"]);
            switch (choice)
            {
                case 1: // Sleep
                    Thread.Sleep(3000);
                    ShowMainMenu();
                    break;
                case 2: //Make Bread
                    // 1 = Fight, 2 = Don't fight, 3 = return to base
                    int userChoice = Player.MakeBread();
                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine("Ready to fight");
                            break;
                        case 2:
                            Console.WriteLine("Not ready to fight");
                            break;
                        case 3:
                            ShowBaseMenu();
                            break;
                    }
                    Thread.Sleep(1000);
                    break;
                case 3: //Call Scav
                    Console.WriteLine();
                    break;
                case 4: //Leave base
                    Console.WriteLine();
                    break;
                case 5:
                    ShowMainMenu();
                    break;
            }
        }

        //First screen after Character Creator, the actual beginning of the game. Will very much need reworked as game expands.
        public void ShowInitialChoice()
        {
            Console.Clear();
            Console.WriteLine("You need to secure a safe base. Do you:");
            int userChoice = Helpers.GetUserChoice("Enter the number of your choice: ", "You didn't provide a valid option. Please try again.", ["Scout an abandoned bakery in the outskirts of the city.", "Collaborate with a rogue AI to find a hidden underground hideout.", "Make a deal with the devil for total control over bread."]);
            switch (userChoice)
            {
                case 1:
                    ScoutBakery();
                    break;
                case 2:
                    CollaborateWithRogueAI();
                    break;
                case 3:
                    MakeDealWithDevil();
                    break;
            }
        }

        //Tenatively called Bakery option, will likely be renamed as game expands
        public void ScoutBakery()
        {
            Console.Clear();
            int userChoice = GetGameDialogChoice(["Trade with scavengers for flour.", "Steal from the local grain mill."], "You scout an abandoned bakery and successfully secure it as your base.\n", "Now, you need to gather the ingredients.");
            switch (userChoice)
            {
                case 1:
                    TradeWithScavengers();
                    break;
                case 2:
                    StealFromGrainMill();
                    break;
            }
        }

        //Tenatively called AI option, will likely be renamed as game expands. NORKONSOLE will be in this section.
        public void CollaborateWithRogueAI()
        {
            Console.Clear();
            int userChoice = GetGameDialogChoice(["Barter with a powerful human faction for salt.", "Hack into the AI-controlled brewery for yeast."], "You collaborate with a rogue AI and find a hidden underground hideout.", "Now, you need to gather the ingredients.");
            switch (userChoice)
            {
                case 1:
                    BarterForSalt();
                    break;
                case 2:
                    HackBreweryForYeast();
                    break;
            }
        }

        //Least fleshed out at the moment, a lot of work needs done. 
        public void MakeDealWithDevil()
        {
            Console.Clear();
            int userChoice = GetGameDialogChoice(["Use fear and intimidation to rule.", "Manipulate and deceive to maintain your power."], "You make a deal with the devil, gaining total control over bread production.", "However, the cost is high, as you must corrupt others to maintain your power.", "Now, you need to enforce your control.");
            switch (userChoice)
            {
                case 1:
                    RuleWithFear();
                    break;
                case 2:
                    ManipulateAndDeceive();
                    break;
            }
        }

        //From Bakery option, Scavengers is Option #1.
        public void TradeWithScavengers()
        {
            Console.Clear();
            int userChoice = GetGameDialogChoice(["[FIGHT] (Draw weapon without saying a word)", "Discuss a trade with the Scavengers", "Ask for more information about the traders", "[FLIRT] Your eyes melt my yeasty soul... Pump and dump?", "Menu"], "The presumed leader of the Scavengers sees you walk toward their tent. He cautiously walks over to you, makeshift laser pistol in his hand.", "Hey there, I see you're in need of something. I'm willing to talk, but let's keep it friendly and straightforward. \nTrust is earned around here, so let's start with what you need and why you're here.");
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
                case 4:
                    Random random = new Random();
                    int nextRandom = random.Next(1, 20);
                    Console.WriteLine($"You rolled a {nextRandom}");
                    if (nextRandom >= 16)
                    {
                        int choice = GetGameDialogChoice(["Visit your new base"], "[SPEECH SUCCEEDED]", "Oh wow... I... uh.... thank you. Now give me a sloppy kiss. ", "Say, I suppose you can stick around here for while.", "[You now have a half-chub and a base you can return to at any time]");
                        switch (choice)
                        {
                            case 1:
                                ShowBaseMenu();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("[SPEECH FAILED]");
                        Console.WriteLine("Erm, what the sigma?");
                        Console.WriteLine("He shoots you 37 times in the chest, leaving nothing but crumbs");
                        Console.WriteLine("YOU ARE COOKED");
                        return;
                    }
                    break;
                case 5:
                    ShowMainMenu();
                    break;
            }
        }

        //Bakery Option #2
        public void StealFromGrainMill()
        {
            Console.Clear();
            Console.WriteLine("You steal from the local grain mill, causing tension with other humans.");
            Console.WriteLine("With all ingredients gathered, you bake the bread but are betrayed by those you wronged.");
            Console.WriteLine("Your actions lead to chaos and conflict, with dire consequences for your community.");
            FinalBossEvilPath();
        }

        //Bakery option #3
        public void BarterForSalt()
        {
            Console.Clear();
            Console.WriteLine("You barter with a powerful human faction for salt, gaining their support.");
            Console.WriteLine("With all ingredients gathered, you bake the bread and form an alliance with the faction.");
            Console.WriteLine("Your actions strengthen human resistance, paving the way for a hopeful future.");
            FinalBossGoodPath();
        }

        //Final Boss, currently linked to bartering but will need to change. 
        public void FinalBossGoodPath()
        {
            Console.Clear();
            int userChoice = GetGameDialogChoice(["Use the bread as a symbol to rally more humans.", "Attempt to hack the AI Overlord with the rogue AI's help."], "Final Boss: The AI Overlord", "The AI Overlord appears, intent on destroying the human resistance.");
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("You rally the humans, and with overwhelming numbers, the AI Overlord is defeated.");
                    Console.WriteLine("Congratulations! You've restored hope and freedom to humanity.");
                    return;
                case 2:
                    Console.WriteLine("With the rogue AI's help, you successfully hack the AI Overlord, shutting it down.");
                    Console.WriteLine("Congratulations! You've restored hope and freedom to humanity.");
                    return;
            }
        }

        //Final Boss, currently linked to bartering but will need to change. 
        public void FinalBossEvilPath()
        {
            Console.Clear();
            int userChoice = GetGameDialogChoice(["Fight the leader in a brutal combat.", "Attempt to negotiate a truce."], "Final Boss: The Human Rebellion Leader", "The Human Rebellion Leader confronts you, seeking to end your tyrannical rule.");
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("You defeat the leader in a fierce battle, but at great cost to your humanity.");
                    Console.WriteLine("Game Over. You rule over a broken and fearful community.");
                    return;
                case 2:
                    Console.WriteLine("You attempt to negotiate, but the leader sees through your deceit and overthrows you.");
                    Console.WriteLine("Game Over. Your tyranny ends, but so does your life.");
                    return;
            }
        }

        //AI ending
        public void HackBreweryForYeast()
        {
            Console.Clear();
            Console.WriteLine("You hack into the AI-controlled brewery for yeast, drawing the robots' attention.");
            Console.WriteLine("With all ingredients gathered, you bake the bread but are hunted by the robots.");
            Console.WriteLine("Your actions endanger your community, leading to a desperate struggle for survival.");
            FinalBossEvilPath();
        }

        //Bad ending
        public void RuleWithFear()
        {
            Console.Clear();
            Console.WriteLine("You use fear and intimidation to rule, becoming a tyrant.");
            Console.WriteLine("With total control over bread, you crush any resistance.");
            Console.WriteLine("Your reign is absolute, but your soul is damned, and your community lives in terror.");
            FinalBossDevilPath();
        }

        //Bad ending
        public void ManipulateAndDeceive()
        {
            Console.Clear();
            Console.WriteLine("You manipulate and deceive to maintain your power, ruling from the shadows.");
            Console.WriteLine("With total control over bread, you create a facade of benevolence while pulling the strings.");
            Console.WriteLine("Your reign is secure, but trust is shattered, and your soul is corrupted.");
            FinalBossDevilPath();
        }

        //Final Devil Boss
        public void FinalBossDevilPath()
        {
            Console.Clear();
            int userChoice = GetGameDialogChoice(["Attempt to outwit the devil and keep your power.", "Submit to the devil's terms, accepting eternal servitude."], "Final Boss: The Devil Himself", "The devil comes to collect his due, challenging your control.");
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("You manage to outwit the devil, securing your power but further damning your soul.");
                    Console.WriteLine("Game Over. You rule with unchallenged authority but at the cost of eternal torment.");
                    return;
                case 2:
                    Console.WriteLine("You submit to the devil, losing your power and freedom forever.");
                    Console.WriteLine("Game Over. Your reign ends, and you become the devil's eternal servant.");
                    return;
            }
        }
    }
}
