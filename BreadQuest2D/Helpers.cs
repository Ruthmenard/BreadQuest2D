namespace BreadQuest2Dv2
{
    public static class Helpers
        //All answers to questions. Possibly can be deleted. 
    {

        static readonly string[] menuOptions = { "Inventory", "Base" };
        static readonly string[] baseMenuOptions = { "Sleep", "Make bread", "Call the Scavenger leader to your room", "Leave base", "Menu" };
        static readonly string[] ccSection1 = {
            "This bread represents sustenance and the comfort of a home-cooked meal. It reminds you of the warmth and care put into making food for loved ones.",
            "The bread signifies abundance and prosperity, symbolizing a time when food was plentiful and life was easier. It's a reminder of better days and hope for the future.",
            "This loaf of bread stands for resistance and rebellion. In a world where bread is banned, it represents defiance against oppressive forces and the struggle for freedom.",
            "The bread evokes feelings of isolation and longing. It’s a solitary object in a quiet room, reflecting the loneliness and desire for connection in a harsh world.",
            "This scene evokes a figure standing in the shadows, hoarding all the bread while others starve outside."
        };
        static readonly string[] ccSection2 = {
            "This bread represents sustenance and the comfort of a home-cooked meal. It reminds you of the warmth and care put into making food for loved ones.",
            "The bread signifies abundance and prosperity, symbolizing a time when food was plentiful and life was easier. It's a reminder of better days and hope for the future.",
            "This loaf of bread stands for resistance and rebellion. In a world where bread is banned, it represents defiance against oppressive forces and the struggle for freedom.",
            "The bread evokes feelings of isolation and longing. It’s a solitary object in a quiet room, reflecting the loneliness and desire for connection in a harsh world.",
            "This scene evokes a figure standing in the shadows, hoarding all the bread while others starve outside."
        };
        static readonly string[] ccSection3 = {
            "This bread represents sustenance and the comfort of a home-cooked meal. It reminds you of the warmth and care put into making food for loved ones.",
            "The bread signifies abundance and prosperity, symbolizing a time when food was plentiful and life was easier. It's a reminder of better days and hope for the future.",
            "This loaf of bread stands for resistance and rebellion. In a world where bread is banned, it represents defiance against oppressive forces and the struggle for freedom.",
            "The bread evokes feelings of isolation and longing. It’s a solitary object in a quiet room, reflecting the loneliness and desire for connection in a harsh world.",
            "This scene evokes a figure standing in the shadows, hoarding all the bread while others starve outside."
        };
        static readonly string[] ccSection4 = {
            "This bread represents sustenance and the comfort of a home-cooked meal. It reminds you of the warmth and care put into making food for loved ones.",
            "The bread signifies abundance and prosperity, symbolizing a time when food was plentiful and life was easier. It's a reminder of better days and hope for the future.",
            "This loaf of bread stands for resistance and rebellion. In a world where bread is banned, it represents defiance against oppressive forces and the struggle for freedom.",
            "The bread evokes feelings of isolation and longing. It’s a solitary object in a quiet room, reflecting the loneliness and desire for connection in a harsh world.",
            "This scene evokes a figure standing in the shadows, hoarding all the bread while others starve outside."
        };
        static readonly string[] ccSection5 = {
            "This bread represents sustenance and the comfort of a home-cooked meal. It reminds you of the warmth and care put into making food for loved ones.",
            "The bread signifies abundance and prosperity, symbolizing a time when food was plentiful and life was easier. It's a reminder of better days and hope for the future.",
            "This loaf of bread stands for resistance and rebellion. In a world where bread is banned, it represents defiance against oppressive forces and the struggle for freedom.",
            "The bread evokes feelings of isolation and longing. It’s a solitary object in a quiet room, reflecting the loneliness and desire for connection in a harsh world.",
            "This scene evokes a figure standing in the shadows, hoarding all the bread while others starve outside."
        };
        static readonly string[] ccSection6 = {
            "This bread represents sustenance and the comfort of a home-cooked meal. It reminds you of the warmth and care put into making food for loved ones.",
            "The bread signifies abundance and prosperity, symbolizing a time when food was plentiful and life was easier. It's a reminder of better days and hope for the future.",
            "This loaf of bread stands for resistance and rebellion. In a world where bread is banned, it represents defiance against oppressive forces and the struggle for freedom.",
            "The bread evokes feelings of isolation and longing. It’s a solitary object in a quiet room, reflecting the loneliness and desire for connection in a harsh world.",
            "This scene evokes a figure standing in the shadows, hoarding all the bread while others starve outside."
        };
        static readonly string[] ccSection7 = {
            "This bread represents sustenance and the comfort of a home-cooked meal. It reminds you of the warmth and care put into making food for loved ones.",
            "The bread signifies abundance and prosperity, symbolizing a time when food was plentiful and life was easier. It's a reminder of better days and hope for the future.",
            "This loaf of bread stands for resistance and rebellion. In a world where bread is banned, it represents defiance against oppressive forces and the struggle for freedom.",
            "The bread evokes feelings of isolation and longing. It’s a solitary object in a quiet room, reflecting the loneliness and desire for connection in a harsh world.",
            "This scene evokes a figure standing in the shadows, hoarding all the bread while others starve outside."
        };



        //Good String check
        public static int GetNumber(string inputMessage, string errorMessage)
        {
            bool isValid = false;
            int userSelection = 0;
            while (!isValid)
            {
                Console.Write(inputMessage);
                try
                {
                    userSelection = Convert.ToInt32(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {

                    Console.WriteLine($"{errorMessage}.\nPress Enter to try again.");
                    Console.ReadLine();
                }
            }
            return userSelection;
        }

        //Good Int Check
        public static int GetNumberBetweenMinAndMax(string inputMessage, string errorMessage, int min, int max)
        {
            bool isValid = false;
            int userSelection = 0;
            while (!isValid)
            {
                Console.Write(inputMessage);
                try
                {
                    userSelection = Convert.ToInt32(Console.ReadLine());
                    if (userSelection <= max && userSelection >= min)
                    {
                        isValid = true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine($"{errorMessage}.\nPress Enter to try again.");
                    Console.ReadLine();
                }
            }
            return userSelection;
        }

        //Method to read questions and display all inputs. VERY important. 
        public static int GetUserChoice(string inputMessage, string errorMessage, List<string> choices)
        {
            if (choices.Count == 0)
            {
                throw new ArgumentNullException(nameof(choices));
            }

            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}: {choices[i]}");
            }
            return GetNumberBetweenMinAndMax(inputMessage, errorMessage, 1, choices.Count);
        }
    }
}