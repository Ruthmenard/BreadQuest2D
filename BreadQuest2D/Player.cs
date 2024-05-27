namespace BreadQuest2Dv2
{
    public class Player
    {
        #region Question Choices
        // lists of choices for character creator
        List<string> ComprehensionChoices1 = new List<string>()
        {
            "This bread represents sustenance and the comfort of a home-cooked meal. It reminds you of the warmth and care put into making food for loved ones.",                       // Comp | End            
            "The bread signifies abundance and prosperity, symbolizing a time when food was plentiful and life was easier. It's a reminder of better days and hope for the future.",    // Pure Comp Choice      
            "This loaf of bread stands for resistance and rebellion. In a world where bread is banned, it represents defiance against oppressive forces and the struggle for freedom.", // Comp | Hyperawareness 
            "The bread evokes feelings of isolation and longing. It’s a solitary object in a quiet room, reflecting the loneliness and desire for connection in a harsh world.",        // Comp | Rhetoric       
            "This scene evokes a figure standing in the shadows, hoarding all the bread while others starve outside."                                                                   // Comp | Str            
        };

        List<string> ComprehensionChoices2 = new List<string>()
        {
            "You patiently study the symbols, connecting them to your wasteland experiences, and unlock the tome’s secrets.",       // Pure Comp Choice      
            "You seek a nomadic scholar's help to decipher the text, working together to unravel its meaning.",                     // Comp | Hyperawareness 
            "You try to brute force the translation, matching symbols to known alphabets, but struggle to make sense of it.",       // Comp | Rhetoric       
            "Frustrated, you consider the book a meaningless relic and leave the library, abandoning the secrets within.",          // Comp | Agl            
            "Desperate, you tear out pages for kindling, destroying valuable knowledge and damaging the library irreparably."       // Comp | End            
        };

        List<string> ComprehensionChoices3 = new List<string>()
        {
            "You study the mural with a keen eye, using your knowledge of art history to analyze its symbols and themes.",          // Pure Comp Choice      
            "You enlist a local historian to help you decode the mural, using urban legends and folklore to uncover its meanings.", // Comp | Rhetoric            
            "You rely on intuition and gut instinct, letting the artwork evoke emotions and personal memories to find meaning.",    // Comp | Hype               
            "Frustrated, you consider defacing the mural in anger, but your actions only obscure its true significance.",           // Comp | Str               
            "You resort to spying on the artist or bribing locals, using manipulation to uncover the mural's secrets."              // Comp | Agl               

        };

        List<string> HyperawarenessChoices1 = new List<string>()
        {
            "You break the bread and share it with the family, ensuring everyone gets a piece.",                                              // Pure Hype Choice
            "You take a small piece for yourself and give the rest to the family.",                                                           // Hype | Str
            "You offer to trade the bread with the family for other resources, like medicine or water.",                                      // Hype | Rhetoric
            "You decide to keep the bread for yourself, reasoning that you'll need your strength to find more food for everyone later.",      // Hype | End
            "You take the bread and hide it, ensuring no one else can find it. You plan to hoard it and let the family fend for themselves."  // Hype | Agl
        };

        List<string> HyperawarenessChoices2 = new List<string>()
        {
            "You keenly observe the crowd, noting changes in body language and facial expressions to identify danger.",                       // Hype | Comp
            "You discreetly signal to nearby allies, forming a vigilant network to monitor the crowd and respond to threats.",                // Hype | Agl
            "Overwhelmed, you focus inward, filtering out distractions to attune your senses to subtle shifts in energy.",                    // Pure Hype Choice
            "Growing paranoid, you lash out at anyone nearby, escalating tensions and drawing unwanted attention.",                           // Hype | Str
            "You sense a speck of grime on your Black Air Chuck 1's, as you reach down to clean them, and narrowly avoid a shot to the head." // Hype | Luck
        };

        List<string> HyperawarenessChoices3 = new List<string>()
        {
            "You move cautiously, observing subtle distortions to discern reality and find the true path.",                                   // Hype | Agl
            "You use logic and reason to identify patterns and inconsistencies, plotting a safe course through the maze.",                    // Hype | Comp
            "Overwhelmed, you center yourself with mindful breathing, attuning your senses to subtle cues.",                                  // Pure Hype Choice
            "Paranoid, you lash out at phantoms, disrupting the balance and increasing danger.",                                              // Hype | Luck
            "Desperate, you sacrifice others and sabotage competitors to survive, causing chaos and danger."                                  // Hype | End
        };

        List<string> agilityChoices1 = new List<string>()
        {
            "You quietly and skillfully climb up to the shelf, grab the bread, and sneak out without being noticed.",                                                             // Pure Agl Choice                        
            "You create a distraction by knocking over some cans, then quickly grab the bread and escape while the robots investigate the noise.",                                // Agl | Hype                      
            "You use your deftness to parkour around the robots, grabbing the bread mid-move and exiting through a broken window.",                                               // Agl | Comp
            "You find a safe spot to hide and wait for the robots to pass, then swiftly move to grab the bread when the coast is clear.",                                         // Agl | End
            "You lure another scavenger into the supermarket, letting them draw the robots' attention. While the robots deal with the intruder, you grab the bread and escape."   // Agl | Rhet
        };

        List<string> agilityChoices2 = new List<string>()
        {
            "You leap rooftop to rooftop, using obstacles to your advantage, staying ahead of pursuers.",                                     // Agl | Luck
            "You scale buildings, using handholds to reach rooftops, planning your next move.",                                               // Agl | Hype
            "You navigate alleys and passages, using reflexes to stay ahead.",                                                                // Pure Agl Choice
            "Desperate, you resort to violence, hindering your ability to navigate with finesse.",                                            // Agl | Str
            "You sacrifice others to escape, causing chaos and danger."                                                                       // Agl | End
        };

        List<string> agilityChoices3 = new List<string>()
        {
            "You leap over rubble and gaps, navigating with nimble movements.",                                                               // Pure Agl Choice
            "You contort to squeeze through narrow gaps, adapting to the terrain.",                                                           // Agl | Luck
            "You focus inward to find hidden passages, maintaining clarity.",                                                                 // Agl | Hype
            "Frustrated, you use force to clear rubble, hindering your finesse.",                                                             // Agl | Str
            "You sacrifice a survivor, causing chaos and betrayal."                                                                           // Agl | Rhet 
        };

        List<string> rhetoricChoices1 = new List<string>()
        {
            "You share your struggles, appealing to empathy and unity.",                                                                      // Rhet | Hype
            "You argue for sharing, citing long-term benefits and survival.",                                                                 // Rhet | End  
            "You charm survivors, building rapport and trust",                                                                                // Pure Rhet Choice
            "You intimidate with threats, demanding compliance.",                                                                             // Rhet | Str
            "You manipulate with deceit, sowing discord among survivors."                                                                     // Rhet | Comp
        };

        List<string> rhetoricChoices2 = new List<string>()
        {
            "You charm the sentinel with friendly conversation, gradually earning their trust.",                                              // Pure Rhet Choice
            "You appeal to the sentinel's sense of duty, emphasizing the importance of your mission.",                                        // Rhet | Comp 
            "You deceive the sentinel with lies and manipulation, painting yourself as a powerful ally",                                      // Rhet | End
            "You resort to threats and intimidation, escalating tensions and risking your chances of access, but show your strength",         // Rhet | Str
            "You sacrifice bystanders to coerce the sentinel, compromising moral integrity."                                                  // Rhet | Luck

        };

        List<string> rhetoricChoices3 = new List<string>()
        {
            "You confidently present evidence and dismantle the case against you.",                                                           // Rhet | Comp
            "You share your personal story, evoking sympathy and casting doubt.",                                                             // Pure Rhet Choice
            "You manipulate with deceit, sowing doubt and confusion.",                                                                        // Rhet | End
            "You lash out, undermining credibility but intimidating the jury",                                                                // Rhet | Str
            "You offer bribes, compromising integrity and risking consequences."                                                              // Rhet | Luck
        };

        List<string> luckChoices3 = new List<string>()
        {
            "You embark optimistically, trusting your reasoning to guide you.",                                                               // Luck | Hype                              
            "You approach with caution, embracing uncertainty.",                                                                              // Luck | End
            "Confident, you rely on intuition and serendipity.",                                                                              // Pure Luck Choice
            "You're skeptical, preferring careful planning.",                                                                                 // Luck | Comp
            "Frustrated, you sabotage competitors for success."                                                                               // Luck | Str
        };

        List<string> luckChoices2 = new List<string>()
        {                                                                                                   
            "You cautiously assess the odds before placing your bet, embracing uncertainty and trusting in fate to favor your endeavors.",                                                                              // Luck | Comp
            "You skeptically eye the game, ready to challenge the fairness of the odds. With a critical mind and wary demeanor, you approach with caution, prepared to overcome any obstacles.",                        // Luck | End
            "Feeling adventurous, you eagerly dive into the excitement, fully embracing the unpredictability of the stakes. With a daring spirit, you revel in the thrill, ready to let fate guide your every move.",   // Pure Luck Choice
            "Growing frustrated with fate's fickleness, you demand clarity and control. Insisting on certainty may lead to missed opportunities and unintended consequences.",                                          // Luck | Rhet
            "In a bid to tilt odds, you consider cheating, risking consequences for victory."                                                                                                                           // Luck | Hype
        };

        List<string> luckChoices1 = new List<string>()
        {
            "Approaching the fortune teller with cautious optimism, you're willing to take a chance on their predictions. With hope and an open mind, you embrace fate's uncertainty, trusting in a positive outcome.", // Luck | Rhet
            "Engaging the fortune teller skeptically, you question their predictions' validity. With a critical eye, you approach cautiously, wary of mere chance or trickery.",                                        // Luck | End
            "Feeling daring, you embrace the chance to challenge fate, placing blind trust in predictions. With reckless abandon, you throw caution aside, eager to see destiny's path.",                               // Pure Luck Choice
            "Growing frustrated with fate's uncertainty, you demand concrete answers. Refusing vague predictions, you seek control, risking missed opportunities.",                                                     // Luck | Str
            "In a desperate bid to change fate, you resort to dishonest tactics. Attempting to manipulate predictions, you compromise your alignment with luck, risking backlash."                                      // Lck | Comp
        };

        List<string> enduranceChoices1 = new List<string>()
        {
            "You hastily construct a shelter from wreckage, securing it against the storm's fury. Determined, you brace for the ordeal, drawing on inner strength.",    // End | Str                    
            "With adrenaline surging, you seek refuge in a rumored underground bunker. Ignoring harsh conditions, you push limits, driven to survive.",                 // Pure End Choice
            "Legends of a hidden oasis spur you on a perilous quest. Trusting intuition, you endure to find sanctuary from the storm.",                                 // End | Hype
            "Fear grips as adversity looms, tempting surrender. Struggling against despair, you fight for the will to persevere.",                                      // End | Comp
            "Primal instinct reigns as morality fades. Ruthless, you seize survival, ambushing others for supplies, leaving them vulnerable."                           // End | Agl
        };

        List<string> enduranceChoices2 = new List<string>()
        {
            "You ration what little supplies you have, conserving energy and water for as long as possible. With discipline, you endure the gnawing hunger and parched throat.",    // End | Luck
            "You scavenge for edible plants and moisture, braving the harsh environment to sustain yourself. With resourcefulness, you endure the scarcity of resources.",          // End | Agl
            "You embrace fasting, believing it will strengthen your resolve and cleanse your body. With faith, you endure the hunger and thirst, trusting in your resilience.",     // Pure End Choice
            "Growing desperate, you steal from others to satisfy your cravings, disregarding the consequences. With selfishness, you endure at the expense of others.",             // End | Str
            "In a bid to survive, you resort to cannibalism, consuming the flesh of fallen companions. With depravity, you endure by preying on the weak."                          // End | Rhet
        };

        List<string> enduranceChoices3 = new List<string>()
        {
            "You ration your supplies, carefully managing your food and water to sustain yourself. With discipline, you endure the long hours in darkness, focusing on survival.",                  // End | Hype
            "You explore the bunker, searching for alternative sources of light and sustenance. With resourcefulness, you endure the darkness, finding creative solutions to survive.",             // End | Comp
            "You meditate to calm your mind and conserve energy, embracing the solitude as an opportunity for self-reflection. With mindfulness, you endure the isolation, finding peace within.",  // Pure End Choice
            "Growing desperate for company, you manipulate others in the bunker to alleviate your loneliness. With manipulation, you endure by exploiting the emotions of those around you.",       // End | Rhet
            "In a bid to escape, you sabotage the bunker's systems, endangering the lives of everyone inside. With recklessness, you endure by risking the safety of others for your own freedom."  // End | Str
        };

        List<string> strengthChoices1 = new List<string>()
        {
            "With keen observation and logic, you unravel each puzzle, some requiring much force, inching closer to the vault's chamber.",                                  // Str | Comp
            "Utilizing deftness, you navigate traps with grace, evading danger at every turn.",                                                                             // Str | Agl
            "Mastery of ancient languages unlocks temple secrets you have learned through training with various Masters, revealing the path to the vault.",                 // Str | Hype
            "Instinct guides through hidden dangers, navigating with confidence in innate abilities.",                                                                      // Str | Rhet
            "Driven by greed, brute force triggers chaos, risking all for vault's riches."                                                                                  // Pure Str Choice
        };

        List<string> strengthChoices2 = new List<string>()
        {
            "You clear a path through the undergrowth, pushing aside branches and obstacles with determined force.",                                                        // Str | Luck
            "Climbing a sturdy tree, you use your strong limbs to ascend swiftly, reaching the canopy to gain a vantage point and scan for landmarks.",                     // Str | Agl
            "With deft hands and sheer power, you gather branches and construct a sturdy shelter, fortifying it against the elements with your strength.",                  // Str | Comp
            "Frustrated by the dense vegetation, you unleash your anger on the surrounding foliage, tearing and breaking it in a fit of exhaustion-driven aggression.",     // Str | End
            "Ignoring caution, you charge through the dense foliage, risking injury but relying on your brute force to push forward."                                       // Pure Str Choice
        };

        List<string> strengthChoices3 = new List<string>()
        {
            "You push aside heavy stone blocks, revealing hidden passages and clearing a path through the maze with raw power.",                                            // Str | Hype
            "Using your brawn, you lift and move large debris blocking your way, creating openings and forging a path through the labyrinth.",                              // Str | Agl
            "With sheer force, you break through weakened walls, smashing obstacles in your path to carve a route through the maze.",                                       // Pure Str Choice
            "Growing frustrated by the maze's complexity, you vent your anger by smashing objects in your path, expending energy in a futile display of aggression.",       // Str | Comp
            "In a desperate bid to escape, you charge forward blindly, using brute force to push through obstacles without regard for your own safety or exhaustion."       // Str | Rhet
        };
        #endregion


        //Declaring all CHARLES stats
        public List<string> Inventory { get; }
        public int Comprehension { get; set; }
        public int Hyperawareness { get; set; }
        public int Agility { get; set; }
        public int Rhetoric { get; set; }
        public int Luck { get; set; }
        public int Endurance { get; set; }
        public int Strength { get; set; }
        public int StatTotal { get; set; }
        public int MaxHP { get; set; }


        //Initial Base Player Setup
        public Player()
        {
            // set default for a new player
            Inventory = new List<string>();
            Comprehension = 0;
            Hyperawareness = 0;
            Agility = 0;
            Rhetoric = 0;
            Luck = 0;
            Endurance = 0;
            Strength = 0;
            StatTotal = 0;
            MaxHP = 0;
            CreateCharacter();
        }

        public void AddItemToInventory(string name)
        {
            Inventory.Add(name);
        }

        public void RemoveItemFromInventory(string name)
        {
            Inventory.Remove(name);
        }

        public void PrintInventory()
        {
            if (Inventory.Count > 0)
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {Inventory[i]}");
                }
            }
            else
            {
                Console.WriteLine("You don't currently have anything in your inventory.");
            }

        }


        //Sequence to make bread in BASE
        public int MakeBread()
        {
            if (Inventory.Contains("Flour") && Inventory.Contains("Water") && Inventory.Contains("Salt") && Inventory.Contains("Yeast"))
            {
                Console.WriteLine("Looking over both shoulders, you attempt to make bread...");
                Thread.Sleep(2000);
                Console.WriteLine("You deftly place the flour in the bowl...");
                Thread.Sleep(4000);
                Console.WriteLine("You carefully pour the Purified water over the flour...");
                Thread.Sleep(4000);
                Console.WriteLine("You sprinkle the Salt into the bowl...");
                Thread.Sleep(4000);
                Console.WriteLine("With shaking hands, you pour your most prized posession, Yeast, into the bowl.");
                Thread.Sleep(2000);
                Console.WriteLine("It immediately begins to react to the other ingredients!");
                Thread.Sleep(4000);
                Console.WriteLine("You mix all the ingredients into one mound of dough...");
                Thread.Sleep(4000);
                Console.WriteLine("You fire up the oven, careful as to not attract any attention with the smoke...");
                Thread.Sleep(4000);
                Console.WriteLine("You place the bowl of dough into the oven...and wait...");
                Thread.Sleep(7000);
                Console.WriteLine("....");
                Thread.Sleep(6000);
                Console.WriteLine("...");
                Thread.Sleep(5000);
                Console.WriteLine("..");
                Thread.Sleep(4000);
                Console.WriteLine(".");
                Thread.Sleep(4000);
                Console.WriteLine("Ding!");
                Thread.Sleep(4000);
                Console.WriteLine("You reach into the oven, and stare awestruck at the newly made bread, the exotic aroma filling your nostrils like nothing else before.");
                Thread.Sleep(4000);
                int userChoice = Helpers.GetUserChoice("Only thing left to do is to take the enemy down with your newly acquired weapon. Are you ready to fight: ", "You didn't enter a valid choice", ["Yes", "No"]);
                switch (userChoice)
                {
                    case 1:
                        return 1;
                    case 2:
                        return 2;
                }
            }
            else if (!Inventory.Contains("Flour"))
            {
                Console.WriteLine("You dont have Flour!!!");
                Console.WriteLine("You might need to explore a little more...");
                Thread.Sleep(1000);
                return 3; // return to base
            }
            else if (!Inventory.Contains("Water"))
            {
                Console.WriteLine("You don't have water!!!");
                Console.WriteLine("You might need to explore a little more...");
                Thread.Sleep(1000);
                return 3; // return to base
            }
            else if (!Inventory.Contains("Salt"))
            {
                Console.WriteLine("You don't have salt!!!");
                Console.WriteLine("You might need to explore a little more...");
                Thread.Sleep(1000);
                return 3; // return to base
            }
            else if (!Inventory.Contains("Yeast"))
            {
                Console.WriteLine("You don't have yeast!!!");
                Console.WriteLine("You might need to explore a little more...");
                Thread.Sleep(1000);
                return 3; // return to base
            }
            return 3; // return to base
        }

        //Initial Character Creation, uses questions at the top of the page
        public void CreateCharacter()
        {
            Random random = new Random();
            int nextRandom = random.Next(1, 4);

            #region Assign Comprehension Stat

                #region First Comp Stat
            //First Comp Stat
            if (nextRandom == 1)
            {
                Console.WriteLine("We need to know what kind of Charles you are. \nLet's go through your personality and see if we can't understand you a little better. ");
                Console.WriteLine("A scenario will be given to you. Please choose the option that best represents how you feel about the scene.\n");
                Console.WriteLine("Question 1/7\n");
                Console.WriteLine("\nImagine a scene where a loaf of bread is placed on a table, sunlight streaming through a window, casting shadows across the room. The bread is freshly baked, with a golden crust and a warm, inviting aroma.");
                int userChoice1 = Helpers.GetUserChoice($"\nWhich option best represents how you feel? ", "You didn't provide a valid option. Please try again.", ComprehensionChoices1);
                switch (userChoice1)
                {
                    case 1:
                        Comprehension = Comprehension + 5;
                        Endurance = Endurance + 1;
                        break;
                    case 2:
                        Comprehension = Comprehension + 7;
                        break;
                    case 3:
                        Comprehension = Comprehension + 3;
                        Hyperawareness = Hyperawareness + 2;
                        break;
                    case 4:
                        Comprehension = Comprehension + 1;
                        Rhetoric = Rhetoric + 2;
                        break;
                    case 5:
                        Comprehension = Comprehension + 1;
                        Strength = Strength + 1;
                        break;
                }
            }
            #endregion
                #region Second Comp Stat
            else if (nextRandom == 2)
            {
                Console.WriteLine("We need to know what kind of Charles you are. \nLet's go through your personality and see if we can't understand you a little better. ");
                Console.WriteLine("A scenario will be given to you. Please choose the option that best represents how you feel about the scene.\n");
                Console.WriteLine("Question 1/7\n");
                Console.WriteLine("\n You find a hidden library in the wasteland, filled with ancient tomes. Among them is a peculiar book in an obscure language, containing secrets to unlock a forgotten power.");
                int userChoice2 = Helpers.GetUserChoice($"\nWhich option best represents how you feel? ", "You didn't provide a valid option. Please try again.", ComprehensionChoices2);
                switch (userChoice2)
                {
                    case 1:
                        Comprehension = Comprehension + 7;
                        break;
                    case 2:
                        Comprehension = Comprehension + 4;
                        Hyperawareness = Hyperawareness + 2;
                        break;
                    case 3:
                        Comprehension = Comprehension + 3;
                        Rhetoric = Rhetoric + 2;
                        break;
                    case 4:
                        Comprehension = Comprehension + 1;
                        Agility = Agility + 2;
                        break;
                    case 5:
                        Comprehension = Comprehension + 1;
                        Endurance = Endurance + 1;
                        break;
                }

            }
            #endregion
                #region Third Comp Stat
            else if (nextRandom == 3)
            {
                Console.WriteLine("We need to know what kind of Charles you are. \nLet's go through your personality and see if we can't understand you a little better. ");
                Console.WriteLine("A scenario will be given to you. Please choose the option that best represents how you feel about the scene.\n");
                Console.WriteLine("Question 1/7\n");
                Console.WriteLine("\nIn a bustling post-apocalyptic city, you find a mural filled with intricate symbols and hidden messages. Deciphering it could reveal valuable insights about the city's past and future. To uncover its meaning, you must understand the symbolism and interpret the visual storytelling.");
                int userChoice3 = Helpers.GetUserChoice($"\nWhich option best represents how you feel? ", "You didn't provide a valid option. Please try again.", ComprehensionChoices3);
                switch (userChoice3)
                {
                    case 1:
                        Comprehension = Comprehension + 7;
                        break;
                    case 2:
                        Comprehension = Comprehension + 3;
                        Rhetoric = Rhetoric + 3;
                        break;
                    case 3:
                        Comprehension = Comprehension + 2;
                        Hyperawareness = Hyperawareness + 3;
                        break;
                    case 4:
                        Comprehension = Comprehension + 1;
                        Strength = Strength + 1;
                        break;
                    case 5:
                        Comprehension = Comprehension + 1;
                        Agility = Agility + 1;
                        break;
                }
            }
                #endregion

            #endregion

            #region Assign Hyperawareness Stat
            nextRandom = random.Next(1, 4);
            Console.Clear();

                #region First Hyperawareness Stat
            if (nextRandom == 1)
            {
                Console.WriteLine("Interesting. Not the choice I would have picked, but that's what makes us all special I suppose.");
                Console.WriteLine("Next Question: ");
                Console.WriteLine("\nQuestion 2/7\n");
                Console.WriteLine("\nYou find a loaf of bread in a post-apocalyptic world. It looks fresh, and you're very hungry. Nearby, there’s a family with small children who are also starving.");
                int userChoice4 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", HyperawarenessChoices1);
                switch (userChoice4)
                {
                    case 1:
                        Hyperawareness = Hyperawareness + 7;
                        break;
                    case 2:
                        Hyperawareness = Hyperawareness + 4;
                        Strength = Strength + 2;
                        break;
                    case 3:
                        Hyperawareness = Hyperawareness + 1;
                        Rhetoric = Rhetoric + 2;
                        break;
                    case 4:
                        Hyperawareness = Hyperawareness + 3;
                        Endurance = Endurance + 2;
                        break;
                    case 5:
                        Hyperawareness = Hyperawareness + 1;
                        Agility = Agility + 1;

                        break;
                }
            }
            #endregion
                #region Second Hyperawareness Stat
            if (nextRandom == 2)
            {
                Console.WriteLine("Interesting. Not the choice I would have picked, but that's what makes us all special I suppose.");
                Console.WriteLine("Next Question: ");
                Console.WriteLine("\nQuestion 2/7\n");
                Console.WriteLine("In a bustling post-apocalyptic city, you sense a subtle shift in the atmosphere, indicating danger. To avert disaster, you must rely on your senses to decipher subtle cues and anticipate the threat.");
                int userChoice4 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", HyperawarenessChoices2);
                switch (userChoice4)
                {
                    case 1:
                        Hyperawareness = Hyperawareness + 5;
                        Comprehension = Comprehension + 1;
                        break;
                    case 2:
                        Hyperawareness = Hyperawareness + 3;
                        Agility = Agility + 2;
                        break;
                    case 3:
                        Hyperawareness = Hyperawareness + 7;
                        break;
                    case 4:
                        Hyperawareness = Hyperawareness + 1;
                        Strength = Strength + 1;
                        break;
                    case 5:
                        Hyperawareness = Hyperawareness + 1;
                        Luck = Luck + 2;
                        break;
                }
            }
            #endregion
                #region Third Hyperawareness Stat
            if (nextRandom == 3)
            {
                Console.WriteLine("Interesting. Not the choice I would have picked, but that's what makes us all special I suppose.");
                Console.WriteLine("Next Question: ");
                Console.WriteLine("\nQuestion 2/7\n");
                Console.WriteLine("While exploring an abandoned amusement park, you enter a haunted funhouse. You feel danger lurking and must rely on your senses to navigate the maze of illusions and traps.");
                int userChoice4 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", HyperawarenessChoices3);
                switch (userChoice4)
                {
                    case 1:
                        Hyperawareness = Hyperawareness + 3;
                        Agility = Agility + 2;
                        break;
                    case 2:
                        Hyperawareness = Hyperawareness + 5;
                        Comprehension = Comprehension + 1;
                        break;
                    case 3:
                        Hyperawareness = Hyperawareness + 7;
                        break;
                    case 4:
                        Hyperawareness = Hyperawareness + 1;
                        Luck = Luck + 1;
                        break;
                    case 5:
                        Hyperawareness = Hyperawareness + 2;
                        Endurance = Endurance + 1;
                        break;
                }
            }
            #endregion

            #endregion

            #region Assign Agility Stat
            nextRandom = random.Next(1, 4);

                #region First Agility Stat
            Console.Clear();
            if (nextRandom == 1)
            {
                Console.WriteLine("Understandable. Everyone needs to eat.");
                Console.WriteLine("Next Question: ");
                Console.WriteLine("\nQuestion 3/7\n");
                Console.WriteLine("\nYou see a loaf of bread on a high shelf in an abandoned supermarket. The place is crawling with robots that patrol the area, programmed to eliminate intruders.");
                int userChoice5 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", agilityChoices1);
                switch (userChoice5)
                {
                    case 1: //deft abilities, good stuff
                        Agility =  Agility + 7;
                        break;
                    case 2: //great choice as well, but has the chance to be spotted
                        Agility = Agility + 4;
                        Hyperawareness = Hyperawareness + 2;
                        break;
                    case 3: //neutral
                        Agility = Agility + 2;
                        Comprehension = Comprehension + 1;
                        break;
                    case 4: //charles might snore, alerting the guards
                        Agility = Agility + 2;
                        Endurance = Endurance + 3;
                        break;
                    case 5: //charles does not use agility at all
                        Agility = Agility + 1;
                        Rhetoric = Rhetoric + 1;
                        break;
                }
            }
            #endregion
                #region Second Agility Stat
            if (nextRandom == 2)
            {
                Console.WriteLine("Understandable. Everyone needs to eat.");
                Console.WriteLine("Next Question: ");
                Console.WriteLine("\nQuestion 3/7\n");
                Console.WriteLine("\nIn a post-apocalyptic city, you're pursued by scavengers through alleys and rooftops. To escape...");
                int userChoice5 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", agilityChoices2);
                switch (userChoice5)
                {
                    case 1: //deft abilities, good stuff
                        Agility = Agility + 5;
                        Luck = Luck + 1;
                        break;
                    case 2: //great choice as well, but has the chance to be spotted
                        Agility = Agility + 4;
                        Hyperawareness = Hyperawareness + 1;
                        break;
                    case 3: //neutral
                        Agility = Agility + 7;
                        break;
                    case 4: //charles might snore, alerting the guards
                        Agility = Agility + 2;
                        Strength = Strength + 1;
                        break;
                    case 5: //charles does not use agility at all
                        Agility = Agility + 1;
                        Endurance = Endurance + 1;
                        break;
                }
            }
            #endregion
                #region Third Agility Stat
            if (nextRandom == 3)
            {
                Console.WriteLine("Understandable. Everyone needs to eat.");
                Console.WriteLine("Next Question: ");
                Console.WriteLine("\nQuestion 3/7\n");
                Console.WriteLine("\nIn an ancient subway system, a collapsed tunnel blocks your path. To proceed...");
                int userChoice5 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", agilityChoices3);
                switch (userChoice5)
                {
                    case 1: //deft abilities, good stuff
                        Agility = Agility + 7;
                        break;
                    case 2: //great choice as well, but has the chance to be spotted
                        Agility = Agility + 4;
                        Luck = Luck + 1;
                        break;
                    case 3: //neutral
                        Agility = Agility + 4;
                        Hyperawareness = Hyperawareness + 2;
                        break;
                    case 4: //charles might snore, alerting the guards
                        Agility = Agility + 1;
                        Strength = Strength + 1;
                        break;
                    case 5: //charles does not use agility at all
                        Agility = Agility + 2;
                        Rhetoric = Rhetoric + 1;
                        break;
                }
            }
                #endregion  

            #endregion

            #region Assign Rhetoric Stat
            Console.Clear();
            nextRandom = random.Next(1, 4);

                #region First Rhetoric Stat

                if (nextRandom == 1)
                {
                    Console.WriteLine("Got it.");
                    Console.WriteLine("Next Question: ");
                    Console.WriteLine("\nQuestion 4/7\n");
                    Console.WriteLine("\nYou encounter a group of survivors who control access to a valuable bread supply. They are hesitant to share, citing their own survival needs and the scarcity of resources in the wasteland.");
                    int userChoice6 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", rhetoricChoices1);
                    switch (userChoice6)
                    {
                        case 1: //Heartfelt doesn't really mean truth though does it
                            Rhetoric = Rhetoric + 4;
                            Hyperawareness = Hyperawareness + 2;
                            break;
                        case 2: //Using facts and logic to OWN the Raiders
                            Rhetoric = Rhetoric + 2;
                            Endurance = Endurance + 1;
                            break;
                        case 3: //ayo? neutral
                            Rhetoric = Rhetoric + 7;
                            break;
                        case 4: //Ballsy, might not work though
                            Rhetoric = Rhetoric + 1;
                            Strength = Strength + 1;
                            break;
                        case 5: //Deceit is a big deal in the bakery wasteland
                            Rhetoric = Rhetoric + 3;
                            Comprehension = Comprehension + 2;
                            break;
                    }
                }
                #endregion
                #region Second Rhetoric Stat

            if (nextRandom == 2)
            {
                Console.WriteLine("Got it.");
                Console.WriteLine("Next Question: ");
                Console.WriteLine("\nQuestion 4/7\n");
                Console.WriteLine("\nYou find yourself standing before the entrance of a hidden underground bunker, guarded by a vigilant sentinel who demands a passphrase to grant you access. To gain entry and uncover the secrets hidden within the bunker's walls, you must rely on your speech skills to persuade or deceive the sentinel.");
                int userChoice6 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", rhetoricChoices2);
                switch (userChoice6)
                {
                    case 1: //Heartfelt doesn't really mean truth though does it
                        Rhetoric = Rhetoric + 7;
                        break;
                    case 2: //Using facts and logic to OWN the Raiders
                        Rhetoric = Rhetoric + 3;
                        Comprehension = Comprehension + 2;
                        break;
                    case 3: //ayo? neutral
                        Rhetoric = Rhetoric + 5;
                        Endurance = Endurance + 1;
                        break;
                    case 4: //Ballsy, might not work though
                        Rhetoric = Rhetoric + 1; 
                        Strength = Strength + 2;
                        break;
                    case 5: //Deceit is a big deal in the bakery wasteland
                        Rhetoric = Rhetoric + 1;
                        Luck = Luck + 1;
                        break;
                }
            }

            #endregion
                #region Third Rhetoric Stat

            if (nextRandom == 3)
            {
                Console.WriteLine("Got it.");
                Console.WriteLine("Next Question: ");
                Console.WriteLine("\nQuestion 4/7\n");
                Console.WriteLine("In a post-apocalyptic courtroom, you're accused of a crime you didn't commit. To prove your innocence...");
                int userChoice6 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", rhetoricChoices3);
                switch (userChoice6)
                {
                    case 1: //Heartfelt doesn't really mean truth though does it
                        Rhetoric = Rhetoric + 5;
                        Comprehension = Comprehension + 1;
                        break;
                    case 2: //Using facts and logic to OWN the Raiders
                        Rhetoric = Rhetoric + 7;
                        break;
                    case 3: //ayo? neutral
                        Rhetoric = Rhetoric + 4;
                        Endurance = Endurance + 1;
                        break;
                    case 4: //Ballsy, might not work though
                        Rhetoric = Rhetoric + 1;
                        Strength = Strength + 1;
                        break;
                    case 5: //Deceit is a big deal in the bakery wasteland
                        Rhetoric = Rhetoric + 1;
                        Luck = Luck + 2;
                        break;
                }
            }
            #endregion

            #endregion

            #region Assign Luck Stat
            Console.Clear();
            nextRandom = random.Next(1, 4);

                #region First Luck Stat

            if (nextRandom == 1)
            {
                Console.WriteLine("Got it.");
                Console.WriteLine("Next Question: ");
                Console.WriteLine("\nQuestion 5/7\n");
                Console.WriteLine("\nYou stumble upon a mysterious post-apocalyptic carnival, where a fortune teller offers to reveal glimpses of your fate. To uncover your destiny and potentially change your fortune, you must rely on your luck stat to guide you through a series of uncertain outcomes.");
                int userChoice6 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", luckChoices1);
                switch (userChoice6)
                {
                    case 1: //Heartfelt doesn't really mean truth though does it
                        Luck = Luck + 3;
                        Rhetoric = Rhetoric + 3;
                        break;
                    case 2: //Using facts and logic to OWN the Raiders
                        Luck = Luck + 3;
                        Endurance = Endurance + 2;
                        break;
                    case 3: //ayo? neutral
                        Luck = Luck + 7;
                        break;
                    case 4: //Ballsy, might not work though
                        Luck = Luck + 1;
                        Strength = Strength + 1;
                        break;
                    case 5: //Deceit is a big deal in the bakery wasteland
                        Luck = Luck + 1;
                        Comprehension = Comprehension + 2;
                        break;
                }
            }
            #endregion
                #region Second Luck Stat
            if (nextRandom == 2)
            {
                Console.WriteLine("Got it.");
                Console.WriteLine("Next Question: ");
                Console.WriteLine("\nQuestion 5/7\n");
                Console.WriteLine("\nYou stumble upon a forgotten post-apocalyptic casino buried beneath the rubble of a once-thriving city. Inside, a mysterious figure offers you a chance to play a game of chance with potentially life-altering consequences. To navigate the high-stakes game and emerge victorious, you must rely on your luck stat to guide you through a series of uncertain outcomes.");
                int userChoice6 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", luckChoices2);
                switch (userChoice6)
                {
                    case 1: //Heartfelt doesn't really mean truth though does it
                        Luck = Luck + 2;
                        Comprehension = Comprehension + 3;
                        break;
                    case 2: //Using facts and logic to OWN the Raiders
                        Luck = Luck + 5;
                        Endurance = Endurance + 1;
                        break;
                    case 3: //ayo? neutral
                        Luck = Luck + 7;
                        break;
                    case 4: //Ballsy, might not work though
                        Luck = Luck + 2;
                        Rhetoric = Rhetoric + 1;
                        break;
                    case 5: //Deceit is a big deal in the bakery wasteland
                        Luck = Luck + 1;
                        Hyperawareness = Hyperawareness + 1;
                        break;
                }
            }
            #endregion
                #region Third Luck Stat
            if (nextRandom == 3)
            {
                Console.WriteLine("Got it.");
                Console.WriteLine("Next Question: ");
                Console.WriteLine("\nQuestion 5/7\n");
                Console.WriteLine("\nYou find yourself in a post-apocalyptic courtroom, accused of a crime you didn't commit. The judge, an imposing figure with a reputation for harsh justice, demands your defense. To clear your name and avoid a severe punishment, you must rely on your speech skills to persuade the judge of your innocence.");
                int userChoice6 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", luckChoices3);
                switch (userChoice6)
                {
                    case 1: //Heartfelt doesn't really mean truth though does it
                        Luck = Luck + 4;
                        Hyperawareness = Hyperawareness + 2;
                        break;
                    case 2: //Using facts and logic to OWN the Raiders
                        Luck = Luck + 1;
                        Endurance = Endurance + 1;
                        break;
                    case 3: //ayo? neutral
                        Luck = Luck + 7;
                        break;
                    case 4: //Ballsy, might not work though
                        Luck = Luck + 2;
                        Comprehension = Comprehension + 1;
                        break;
                    case 5: //Deceit is a big deal in the bakery wasteland
                        Luck = Luck + 3;
                        Strength = Strength + 2;
                        break;
                }
            }
            #endregion

            #endregion

            #region Assign Endurance Stat
            Console.Clear();
            nextRandom = random.Next(1, 4);

                #region First Endurance Stat
                if (nextRandom == 1)
                {
                    Console.WriteLine("Got it.");
                    Console.WriteLine("Next Question: ");
                    Console.WriteLine("\nQuestion 6/7\n");
                    Console.WriteLine("\nYou find yourself stranded in a wasteland after a freak meteor shower destroys your vehicle, leaving you without transportation or supplies. As you survey the barren landscape, you notice a massive sandstorm brewing on the horizon, threatening to engulf everything in its path. You must decide how to endure the relentless onslaught of the storm.");
                    int userChoice8 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", enduranceChoices1);
                    switch (userChoice8)
                    {
                        case 1:
                            Endurance = Endurance + 3;
                            Strength = Strength + 3;
                            break;
                        case 2: //stupid
                            Endurance = Endurance + 7;
                             break;
                        case 3:
                            Endurance = Endurance + 4;
                            Hyperawareness = Hyperawareness + 1;
                            break;
                        case 4: //giving
                            Endurance = Endurance + 2;
                            Comprehension = Comprehension + 1;
                            break;
                        case 5: //sometimes it truly be like that
                            Endurance = Endurance + 1;
                            Agility = Agility + 1;
                            break;
                    }
                }
                #endregion
                #region Second Endurance Stat
            if (nextRandom == 2)
            {
                Console.WriteLine("Got it.");
                Console.WriteLine("\nNext Question: ");
                Console.WriteLine("\nQuestion 6/7\n");
                Console.WriteLine("Trapped in a barren wasteland with no sustenance, you must endure hunger and thirst until salvation arrives.");
                int userChoice8 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", enduranceChoices2);
                switch (userChoice8)
                {
                    case 1:
                        Endurance = Endurance + 5;
                        Luck = Luck + 1;
                        break;
                    case 2: //stupid
                        Endurance = Endurance + 4;
                        Agility = Agility + 1;
                        break;
                    case 3:
                        Endurance = Endurance + 7;
                        break;
                    case 4: //giving
                        Endurance = Endurance + 1;
                        Strength = Strength + 1;
                        break;
                    case 5: //sometimes it truly be like that
                        Endurance = Endurance + 2;
                        Rhetoric = Rhetoric + 1;
                        break;
                }
            }
            #endregion
                #region Third Endurance Stat
                if (nextRandom == 3)
                {
                    Console.WriteLine("Got it.");
                    Console.WriteLine("\nNext Question: ");
                    Console.WriteLine("\nQuestion 6/7\n");
                    Console.WriteLine("Trapped in an underground bunker after a catastrophic earthquake, you must endure the darkness and isolation until rescue arrives.");
                    int userChoice8 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", enduranceChoices3);
                    switch (userChoice8)
                    {
                        case 1:
                            Endurance = Endurance + 3;
                            Hyperawareness = Hyperawareness + 3;
                            break;
                        case 2: //stupid
                            Endurance = Endurance + 2;
                            Comprehension = Comprehension + 3;
                            break;
                    case 3:
                            Endurance = Endurance + 7;
                            break;
                    case 4: //giving
                            Endurance = Endurance + 2;
                            Rhetoric = Rhetoric + 1;
                            break;
                    case 5: //sometimes it truly be like that
                            Endurance = Endurance + 1;
                            Strength = Strength + 1;
                            break;
                }
                }
                #endregion

            #endregion

            #region Assign Strength Stat
            Console.Clear();
            nextRandom = random.Next(1, 4);

            #region First Strength Stat
            if (nextRandom == 1)
            {
                Console.WriteLine("Got it.");
                Console.WriteLine("Next Question: ");
                Console.WriteLine("\nQuestion 7/7\n");
                Console.WriteLine("\nIn the heart of the wasteland, you stumble upon an ancient temple hidden beneath the shifting sands. Inside, you discover a series of intricate puzzles guarding a vault rumored to hold invaluable treasures. Your survival depends on your ability to navigate these challenges.");
                int userChoice9 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", strengthChoices1);
                switch (userChoice9)
                {
                    case 1:
                        Strength = Strength + 3;
                        Comprehension = Comprehension + 3;
                        break;
                    case 2: //stupid
                        Strength = Strength + 1;
                        Agility = Agility + 4;
                        break;
                    case 3:
                        Strength = Strength + 1;
                        Hyperawareness = Hyperawareness + 2;
                        break;
                    case 4: //giving
                        Strength = Strength + 1;
                        Rhetoric = Rhetoric + 1;
                        break;
                    case 5: //sometimes it truly be like that
                        Strength = Strength + 7;
                        break;
                }
            }
            #endregion
            #region Second Strength Stat
            if (nextRandom == 2)
            {
                Console.WriteLine("Got it.");
                Console.WriteLine("Next Question: ");
                Console.WriteLine("\nQuestion 7/7\n");
                Console.WriteLine("\nLost in a dense forest shrouded in fog, you must rely on your strength to navigate the perilous terrain and find your way to safety.");
                int userChoice9 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", strengthChoices2);
                switch (userChoice9)
                {
                    case 1:
                        Strength = Strength + 1;
                        Luck = Luck + 1;
                        break;
                    case 2: //stupid
                        Strength = Strength + 4;
                        Agility = Agility + 1;
                        break;
                    case 3:
                        Strength = Strength + 2;
                        Comprehension = Comprehension + 1;
                        break;
                    case 4: //giving
                        Strength = Strength + 5;
                        Endurance = Endurance + 1;
                        break;
                    case 5: //sometimes it truly be like that
                        Strength = Strength + 7;
                        break;
                }
            }
            #endregion
            #region Third Strength Stat
            if (nextRandom == 3)
            {
                Console.WriteLine("Got it.");
                Console.WriteLine("Next Question: ");
                Console.WriteLine("\nQuestion 7/7\n");
                Console.WriteLine("\nTrapped in an underground labyrinth, you rely on your strength to navigate the maze and find an exit.");
                int userChoice9 = Helpers.GetUserChoice("Which option do you choose: ", "You didn't provide a valid option. Please try again.", strengthChoices3);
                switch (userChoice9)
                {
                    case 1:
                        Strength = Strength + 5;
                        Hyperawareness = Hyperawareness + 1;
                        break;
                    case 2: //stupid
                        Strength = Strength + 4;
                        Agility = Agility + 1;
                        break;
                    case 3:
                        Strength = Strength + 7;
                        break;
                    case 4: //giving
                        Strength = Strength + 2;
                        Comprehension = Comprehension + 1;
                        break;
                    case 5: //sometimes it truly be like that
                        Strength = Strength + 1;
                        Rhetoric = Rhetoric + 1;
                        break;
                }
            }
            #endregion

            #endregion

            // assign stat total + print
            Console.Clear();
            Console.WriteLine("\nWhelp, that's all I've got. Wanna see how you stack up?");
            StatTotal = Comprehension + Hyperawareness + Agility + Rhetoric + Luck + Strength;
            MaxHP = Endurance + 10;
            PrintStats();

            // ask user if they would like to re-assign stats or keep their current
            Console.WriteLine("\nHow'd I do?");
            Console.WriteLine("\nFeel free to change it up. If you decide to change you stats, you can't go over the total C.H.A.R.L.E.S. score you already have.");
            int userChoice10 = Helpers.GetUserChoice("\nWhich option do you choose: ", "You didn't provide a valid option. Please try again.", ["Edit your character", "Proceed with current stats"]);
            switch (userChoice10)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Right, you know better than me of course...");
                    ReassignStats();
                    break;
                case 2:
                    Console.WriteLine("Let's get going then...");
                    break;
            }
        }

        //Declaring StatTotal 
        int newStatTotal = 0;

        //Reassign Stats according to total CHARLES score.
        public void ReassignStats()
        {
            Console.WriteLine($"Total Points to Allocate: {StatTotal} ");
            newStatTotal += Comprehension = Helpers.GetNumber("Comprehension: ", "You didn't enter a valid number");
            PrintRunningTotal();
            Console.WriteLine($"Points left to allocate: {StatTotal - newStatTotal}");
            newStatTotal += Hyperawareness = Helpers.GetNumber("Hyperawareness: ", "You didn't enter a valid number");
            PrintRunningTotal();
            Console.WriteLine($"Points left to allocate: {StatTotal - newStatTotal}");
            newStatTotal += Agility = Helpers.GetNumber("Agility: ", "You didn't enter a valid number");
            PrintRunningTotal();
            Console.WriteLine($"Points left to allocate: {StatTotal - newStatTotal}");
            newStatTotal += Rhetoric = Helpers.GetNumber("Rhetoric: ", "You didn't enter a valid number");
            PrintRunningTotal();
            Console.WriteLine($"Points left to allocate: {StatTotal - newStatTotal}");
            newStatTotal += Luck = Helpers.GetNumber("Luck: ", "You didn't enter a valid number");
            PrintRunningTotal();
            Console.WriteLine($"Points left to allocate: {StatTotal - newStatTotal}");
            newStatTotal += Endurance = Helpers.GetNumber("Endurance: ", "You didn't enter a valid number");
            MaxHP = Endurance + 10;
            PrintRunningTotal();
            Console.WriteLine($"Points left to allocate: {StatTotal - newStatTotal}");
            newStatTotal += Strength = Helpers.GetNumber("Strength: ", "You didn't enter a valid number");
            PrintRunningTotal();
            Console.WriteLine($"Points left to allocate: {StatTotal - newStatTotal}");
            if (newStatTotal > StatTotal)
            {
                Console.Write($"You've assigned more stat points than are available. Please re-assign new stat point again. Press Enter to try again.");
                Console.ReadLine();
                ReassignStats(); // recursively call itself to start over
                StatTotal = newStatTotal;
            }
            else
            {
                Console.WriteLine("NEW STATS\n");
                Console.WriteLine();
                PrintStats();
            }

            // ask user if they would like to re-assign stats or keep their current
            Console.WriteLine("Happy?");
            int userChoice = Helpers.GetUserChoice("\nWhich option do you choose: ", "You didn't provide a valid option. Please try again.", ["Yes, let's get started", "No, redo the choices again"]);
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Let's get started, indeed...");
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Seriously?");
                    ReassignStats();
                    break;
            }

        }

        public void PrintStats()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Comprehension - {Comprehension}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Hyperawareness - {Hyperawareness}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Agility - {Agility}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Rhetoric - {Rhetoric}");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Luck - {Luck}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Endurance - {Endurance}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Strength - {Strength}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nTotal C.H.A.R.L.E.S. Score: {StatTotal}");
        }

        void PrintRunningTotal()
        {
            Console.WriteLine($"Running total: {newStatTotal}");
        }
    }
}

