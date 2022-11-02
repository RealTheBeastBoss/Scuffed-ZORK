using System;
using System.Collections.Generic;
using System.IO;

namespace Scuffed_ZORK
{
    class Program
    {
        public static Square[,] caveRoomA = new Square[3, 3];
        public static Square caveRoomA0_0 = new Square(caveRoomA, 1, "There doesn't seem to be anything here.", 0, 0);
        public static Square caveRoomA0_1 = new Square(caveRoomA, 1, "On the wall in front of you, there appears to be a marking depicting a game of Tic Tac Toe:\n" +
            " |O|X\nX|X|O\nO|X|O", 0, 1);
        public static Square caveRoomA0_2 = new Square(caveRoomA, 1, "You run a finger along the outline, confirming that it is in fact a door.", 0, 2);
        public static Square caveRoomA1_0 = new Square(caveRoomA, 1, "The markings on this wall seem to show a non-descript treasure map with writing that says 'X marks the spot'.", 1, 0);
        public static Square caveRoomA1_1 = new Square(caveRoomA, 1, "You can barely see the walls of the small cave you're in.", 1, 1);
        public static Square caveRoomA1_2 = new Square(caveRoomA, 1, "There is nothing to see here.", 1, 2);
        public static Square caveRoomA2_0 = new Square(caveRoomA, 1, "You look at the wall here and notice writing on the surface that says 'Pray your problems away'. Just some graffiti.", 2, 0);
        public static Square caveRoomA2_1 = new Square(caveRoomA, 1, "You cannot see anything around here.", 2, 1);
        public static Square caveRoomA2_2 = new Square(caveRoomA, 1, "You see an arrow on the wall pointing downwards.", 2, 2); // 4 Leaves start here
        public static Square[,] caveRoomB = new Square[4, 6];
        public static Square caveRoomB0_0 = new Square(caveRoomB, 2, "Writing on the wall says, 'Red - Third in Time' What's that, a Doctor Who reference?", 0, 0);
        public static Square caveRoomB0_1 = new Square(caveRoomB, 2, "Nothing here catches your eye.", 0, 1);
        public static Square caveRoomB0_2 = new Square(caveRoomB, 2, "Some writing says, 'Blue - If window was a number'.", 0, 2);
        public static Square caveRoomB0_3 = new Square(caveRoomB, 2, "You cannot see very much here.", 0, 3); // Starting Square + Note 1
        public static Square caveRoomB0_4 = new Square(caveRoomB, 2, "You see a picture of a box on the wall.", 0, 4); // Blue Box
        public static Square caveRoomB0_5 = new Square(caveRoomB, 2, "Empty.", 0, 5);
        public static Square caveRoomB1_0 = new Square(caveRoomB, 2, "There is an arrow on the wall that is pointing upwards.", 1, 0); // Green Key Above Square
        public static Square caveRoomB1_1 = new Square(caveRoomB, 2, "Nothing.", 1, 1);
        public static Square caveRoomB1_2 = new Square(caveRoomB, 2, "This place seems quite chill.", 1, 2); // Yellow Box
        public static Square caveRoomB1_3 = new Square(caveRoomB, 2, "This area is vacant.", 1, 3);
        public static Square caveRoomB1_4 = new Square(caveRoomB, 2, "It is completely baron here.", 1, 4);
        public static Square caveRoomB1_5 = new Square(caveRoomB, 2, "This looks normal.", 1, 5); // Purple Box
        public static Square caveRoomB2_0 = new Square(caveRoomB, 2, "There appears to be a door in this wall.", 2, 0);
        public static Square caveRoomB2_1 = new Square(caveRoomB, 2, "A lot of these areas appear to have nothing important about them.", 2, 1);
        public static Square caveRoomB2_2 = new Square(caveRoomB, 2, "Worthless.", 2, 2);
        public static Square caveRoomB2_3 = new Square(caveRoomB, 2, "You notice nothing out of the ordinary.", 2, 3); // Green Box
        public static Square caveRoomB2_4 = new Square(caveRoomB, 2, "Unoccupied.", 2, 4);
        public static Square caveRoomB2_5 = new Square(caveRoomB, 2, "Devoid of all known usefulness.", 2, 5);
        public static Square caveRoomB3_0 = new Square(caveRoomB, 2, "Writing on the wall says, 'Pray your problems away'. More Graffiti?!", 3, 0); // Red Box
        public static Square caveRoomB3_1 = new Square(caveRoomB, 2, "This area seems rather deserted.", 3, 1);
        public static Square caveRoomB3_2 = new Square(caveRoomB, 2, "It is really clean in this one place.", 3, 2);
        public static Square caveRoomB3_3 = new Square(caveRoomB, 2, "You find an arrow on the wall pointing upwards.", 3, 3); // Note 8 Above Square
        public static Square caveRoomB3_4 = new Square(caveRoomB, 2, "Scribblings on the wall says, 'It goes in location order, like reading a book'. Confusing, isn't it?", 3, 4);
        public static Square caveRoomB3_5 = new Square(caveRoomB, 2, "This must be the crying corner.", 3, 5);
        public static Square[,] caveRoomC = new Square[5, 3];
        public static Square caveRoomC0_0 = new Square(caveRoomC, 3, "There is nothing here.", 0, 0);
        public static Square caveRoomC0_1 = new Square(caveRoomC, 3, "You see a door in the wall.", 0, 1);
        public static Square caveRoomC0_2 = new Square(caveRoomC, 3, "This corner is empty.", 0, 2);
        public static Square caveRoomC1_0 = new Square(caveRoomC, 3, "Art on the wall says, 'Help is just one command away'. Very meta, I like it.", 1, 0);
        public static Square caveRoomC1_1 = new Square(caveRoomC, 3, "Empty.", 1, 1);
        public static Square caveRoomC1_2 = new Square(caveRoomC, 3, "This area has nothing in it.", 1, 2);
        public static Square caveRoomC2_0 = new Square(caveRoomC, 3, "Nothing.", 2, 0);
        public static Square caveRoomC2_1 = new Square(caveRoomC, 3, "There's a sign nailed to the ground saying, 'Remember!'", 2, 1);
        public static Square caveRoomC2_2 = new Square(caveRoomC, 3, "You are quite tired of areas that don't have much in them.", 2, 2); // Cardboard Box
        public static Square caveRoomC3_0 = new Square(caveRoomC, 3, "Completely empty here.", 3, 0);
        public static Square caveRoomC3_1 = new Square(caveRoomC, 3, "Nothing seems to be here.", 3, 1);
        public static Square caveRoomC3_2 = new Square(caveRoomC, 3, "Nothing for miles around by the looks of things.", 3, 2);
        public static Square caveRoomC4_0 = new Square(caveRoomC, 3, "Looking down, you notice some writing, 'Pray your problems away'. I'm going to call the council soon.", 4, 0);
        public static Square caveRoomC4_1 = new Square(caveRoomC, 3, "The room fades into darkness ahead of you, and you hear some low rumbling ahead.", 4, 1);
        public static Square caveRoomC4_2 = new Square(caveRoomC, 3, "All clear over here.", 4, 2);
        public static Item leaf = new Item("Leaf", "It smells like old toothpaste.", "You hear rustling as you hold it in your hand.", "That was funny to watch, but it tasted disgusting.", "It is a red leaf with an X embedded in it.");
        public static Item greenKey = new Item("Green Key", "This key unlocks the Green Box.");
        public static Item yellowKey = new Item("Yellow Key", "This key unlocks the Yellow Box.");
        public static Note note1 = new Note("Note 1", "This’ll be a bit more difficult, allow me to help: 'Purple = 9:30AM + 8 hours and 8 minutes. Convert that to 24hr Time'.", null);
        public static Note note2 = new Note("Note 2", "Red - According to Nintendo, what letter stands for Winner?", caveRoomB2_3);
        public static Note note3 = new Note("Note 3", "Blue - The Meaning of Life, divided by (9 + 10!!) / 2. Now take 1 from that.", caveRoomB1_5);
        public static Note note4 = new Note("Note 4", "This note exists for literally no reason, enjoy!", null);
        public static Note note5 = new Note("Note 5", "Blue - Nope.", caveRoomB1_2);
        public static Note note6 = new Note("Note 6", "Red - Lord Marquaad's Letter.", caveRoomB1_2);
        public static Note note7 = new Note("Note 7", "Red - 6.", caveRoomB0_4);
        public static Note note8 = new Note("Note 8", "Blue - Ready for a game of Golf?", caveRoomB3_3);
        public static Note note9 = new Note("Note 9", "This enemy may have been easy to beat, but it was really difficult to code.", null);
        public static Note goldNote = new Note("Gold Note", "Congratulations, you've beaten this room. Having this note will allow you to open the door.", null);
        public static Food apple = new Food("Apple", "Yuck, it's one of those green ones.", 3, 0);
        public static Food magicCarrot = new Food("Magic Carrot", "It tastes like a carrot, but slightly magical.", 2);
        public static Weapon knife = new Weapon("Knife", 3, 2);
        public static Weapon sword = new Weapon("Sword", 4, 3);
        public static List<Item> items = new List<Item>() { leaf, greenKey, yellowKey, note1, note2, note3, note4, note5, note6, note7, note8, note9, 
            goldNote, apple, magicCarrot, knife, sword }; // Every Item in the Game
        public static Box greenBox = new Box("Green Box", caveRoomB2_3, greenKey, /*Box Contents:*/ note2, knife, note4);
        public static Box purpleBox = new Box("Purple Box", caveRoomB1_5, "1738", "This box requires the Purple Unlock Code.", yellowKey, note3, apple);
        public static Box blueBox = new Box("Blue Box", caveRoomB0_4, "2904", "This box requires the Blue Unlock Code.", note7);
        public static Box yellowBox = new Box("Yellow Box", caveRoomB1_2, yellowKey, /*Box Contents:*/ note5, note6);
        public static Box redBox = new Box("Red Box", caveRoomB3_0, "mfel", "This box requires the Red Unlock Code.", goldNote);
        public static Box cardboardBox = new Box("Cardboard Box", caveRoomC2_2, (Item)null, /*Box Contents:*/ sword);
        public static List<Box> boxes = new List<Box>() { greenBox, purpleBox, blueBox, yellowBox, redBox, cardboardBox }; // Every Box in the Game
        public static Enemy roomC = new Enemy(caveRoomC0_1, RandomName(), RNG(8, 11), 0, RNG(2, 4), note9, magicCarrot, goldNote);
        public static List<Enemy> enemies = new List<Enemy>() { roomC }; // Every Enemy in the Game
        public static bool gameOver = false;
        public static string playerName = "null";
        public static Square playerSquare = caveRoomA1_1;
        public static int row = 1;
        public static int column = 1;
        public static bool endCommand = false;
        public static bool isUp = false;
        public static int commandCount = 0; // This is how many commands have been entered since last Console Clear
        public static int commandLimit = RNG(12, 16); // This is the randomised limit to how many commands can be entered before a Console Clear
        public static bool hasMoved = false;
        public static bool inCombat = false;
        public static bool permaDeath = false;
        public static bool endTurn = true;
        public static int playerEnergy = 5;
        public static bool isWaiting = false;
        public static int playerHealth = 10;
        public static int maxPlayerHealth = 10;
        public enum Difficulty {EASY, NORMAL, HARD};
        public static Difficulty gameDifficulty;
        public static string actionWord;
        public static string savedCommand;
        public static bool gameLoaded = false;
        public static List<Item> inventory = new List<Item>();
        public static List<string> reminders = new List<string>();
        static void Main(string[] args) // Program runs
        {
            EstablishSquares();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Scuffed ZORK! A pseudo-game by Jack Cumbers.\nBased on the game by Tim Anderson, Marc Blank, Bruce Daniels, and Dave Lebling.");
            Console.WriteLine("");
            Console.Write("Would you like to load your saved game?: ");
            string input = Console.ReadLine().ToLower();
            if (input == "n" || input == "no" || input == "nope") // Determines if game should be loaded
            {
                Console.WriteLine("Thanks for your input!\n");
                bool hasDifficulty = false;
                Console.WriteLine("Which Difficulty Do You Want To Play?:\n");
                Console.WriteLine("EASY - Resets game to last save upon death.");
                Console.WriteLine("NORMAL - Resets you to the start of the room upon death.");
                Console.WriteLine("HARD - Permanently deletes you upon death.\n");
                while (!hasDifficulty)
                {
                    Console.Write("> ");
                    switch(Console.ReadLine().ToLower())
                    {
                        default:
                            continue;
                        case "easy":
                            gameDifficulty = Difficulty.EASY;
                            Console.WriteLine("You have chosen EASY difficulty.");
                            hasDifficulty = true;
                            break;
                        case "normal":
                            gameDifficulty = Difficulty.NORMAL;
                            Console.WriteLine("You have chosen NORMAL difficulty.");
                            hasDifficulty = true;
                            break;
                        case "hard":
                            gameDifficulty = Difficulty.HARD;
                            Console.WriteLine("You have chosen HARD difficulty.");
                            hasDifficulty = true;
                            break;
                    }
                    Console.WriteLine("");
                    Console.Write("Enter your name: ");
                    playerName = Console.ReadLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(playerSquare.roomName + ", Mount. Beluga");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{playerName}, you see before you a cave with seemingly no exit. You quickly scan the walls of the cave and notice two things:\n" +
                        "\t1. A rectangular outline in the stone wall to your northeast.\n\t2. A bunch of marks in the stone occuring in multiple spots along the wall.\n" +
                        "You can't see much other than that the room seems to be strangely square and is about 3m\xB2 with you in the center.\n");
                }
            } else
            {
                LoadGame("Saved Game"); // Calls method to load game from save file
                Console.WriteLine("Loading Saved Game...");
            }
            while (!gameOver) // This is each action until the game is over
            {
                if (commandCount >= commandLimit) // This clears the console after a random number of commands entered
                {
                    commandCount = 0;
                    commandLimit = RNG(12, 16);
                    Console.WriteLine("");
                    Console.Write("Console Clearing in Progress, Press Enter to Continue: ");
                    Console.ReadLine();
                    Console.Clear();
                    if (!inCombat)
                    {
                        Console.WriteLine($"{playerSquare.roomName} (Column: {column + 1}, Row: {row + 1})");
                    }
                }
                if (inCombat) // This is the Turn-Based Combat System
                {
                    if (endTurn)
                    {
                        if (!gameLoaded)
                        {
                            Console.WriteLine("");
                            EnemyTurn(playerSquare.enemy);
                        }
                        if (playerHealth <= 0) // This is if the player died
                        {
                            inCombat = false;
                            switch (gameDifficulty)
                            {
                                case Difficulty.EASY:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You Died! Starting from last save...");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    LoadGame("Saved Game");
                                    break;
                                case Difficulty.NORMAL:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You Died! Resetting the Room...");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    LoadGame("Saved Room");
                                    break;
                                case Difficulty.HARD:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You Died! Game Ending...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    permaDeath = true;
                                    SaveGame("Saved Game");
                                    ParseAction("quit", "");
                                    break;
                            }
                            continue;
                        }
                        ShowStats();
                    } else
                    {
                        endTurn = true;
                    }
                    if (isWaiting)
                    {
                        Console.Write("\nYou are waiting... ");
                        Console.ReadLine();
                        playerEnergy += 5;
                        isWaiting = false;
                    } else
                    {
                        GetCommand();
                        commandCount++;
                    }
                    if (playerSquare.enemy.health <= 0 && playerHealth > 0) // This is if the enemy has died
                    {
                        inCombat = false;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\n{playerSquare.enemy.name} has been defeated!");
                        Console.WriteLine($"{playerSquare.enemy.name} dropped {playerSquare.enemy.loot.Count} items.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (Item item in playerSquare.enemy.loot)
                        {
                            playerSquare.inventory.Add(item);
                        }
                        playerSquare.enemy = null;
                        playerEnergy = 5;
                    }
                    continue;
                }
                gameLoaded = false;
                CheckRoomCompleted();
                GetCommand();
                if (hasMoved) // This happens if the player has moved since last action
                {
                    if (actionWord != "look" && actionWord != "open" && playerEnergy > 0 && RNG(1, 100) <= 5)
                    {
                        playerEnergy--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That movement was exhausting! You used up an energy point.\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    isUp = false;
                    playerSquare = playerSquare.room[row, column];
                    playerSquare.beenVisited = true;
                    Console.WriteLine($"{playerSquare.roomName} (Column: {column + 1}, Row: {row + 1})");
                    Console.WriteLine("");
                    Console.WriteLine(playerSquare.locationText);
                    if (playerSquare.box != null)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"There is the {playerSquare.box.boxName} in this area.");
                        playerSquare.box.square = playerSquare;
                    }
                    if (playerSquare.inventory.Count > 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("This area contains:");
                        foreach (Item item in playerSquare.inventory)
                        {
                            Console.WriteLine($"  - {item.itemName}.");
                        }
                    }
                    if (playerSquare.enemy != null)
                    {
                        inCombat = true;
                        endTurn = true;
                        Console.WriteLine("\nAn enemy approaches!");
                    }
                    hasMoved = false;
                }
                commandCount++;
            }
            Console.ReadLine();
        }
        public static void ParseCommand(string command) // Attempts to parse the player's command
        {
            int wordCount = 1;
            actionWord = "";
            endCommand = false;
            string nextWord;
            do // Only runs when there is still somthing left in the command, and when the command isn't ended
            {
                nextWord = "";
                int charPos = 0;
                try
                {
                    foreach (Char c in command)
                    {
                        charPos++;
                        if (c == ' ')
                        {
                            break;
                        }
                        else
                        {
                            if (wordCount == 1)
                            {
                                actionWord += c;
                            }
                            else
                            {
                                nextWord += c;
                            }
                        }
                    }
                } catch 
                {
                    Console.WriteLine("There is no action to repeat.");
                    return;
                }
                command = command.Substring(charPos); // Removes the Action Word from the Command
                if (wordCount == 1)
                {
                    if (actionWord != "take" && actionWord != "get" && actionWord != "pick" && playerSquare.box != null)
                    {
                        playerSquare.box.isOpen = false;
                    }
                    ParseAction(actionWord, command);
                }
                else
                {
                    ParseNext(nextWord, command);
                }
                wordCount++;
            } while (command != "" && !endCommand);
        }
        public static void GetCommand() // Allows the player to enter a command
        {
            Console.WriteLine("");
            Console.Write("> ");
            string command = Console.ReadLine(); // This is the variable that will be parsed into an action
            Console.WriteLine("");
            command = command.ToLower();
            string commandCopy = command;
            ParseCommand(command);
            if (commandCopy != "g")
            {
                savedCommand = commandCopy;
            }

        }
        public static void ParseAction(string actionWord, string command) // Tries to parse the action word
        {
            switch(actionWord)
            {
                default:
                    endCommand = true;
                    endTurn = false;
                    Console.WriteLine("That's not a verb I recognise.");
                    break;
                case "":
                    endCommand = true;
                    endTurn = false;
                    Console.WriteLine("You can't just stay silent!");
                    break;
                case "quit":
                    Console.WriteLine("Press Any Key to Continue: ");
                    Console.ReadKey();
                    Environment.Exit(420);
                    break;
                case "q":
                    ParseAction("quit", command);
                    break;
                case "save":
                    endCommand = true;
                    endTurn = false;
                    if (command == "" || command == "game") // Determines if there is anything in the Command after the Action Word
                    {
                        SaveGame("Saved Game"); // This will call the method to save to a file
                        Console.WriteLine("The Game has been Saved to 'Saved Game.txt'.");
                    } else
                    {
                        Console.WriteLine("I understood you as far as wanting to save.");
                    }
                    break;
                case "help":
                    endCommand = true;
                    endTurn = false;
                    if (command == "" || command == "me")
                    {
                         DisplayHelp(); // This will display the help text
                    } else
                    {
                        Console.WriteLine("I understood you as far as wanting to help");
                    }
                    break;
                case "north":
                    endCommand = true;
                    if (inCombat)
                    {
                        Console.WriteLine("You cannot do that while in Combat Mode.");
                        endTurn = false;
                        return;
                    }
                    if (row > 0) // Checks if there's space to the north to move to
                    {
                        row--;
                        hasMoved = true;
                    } else
                    {
                        Console.WriteLine("There is a wall in that direction, it is impossible to move there.");
                    }
                    break;
                case "n":
                    ParseAction("north", command);
                    break;
                case "south":
                    endCommand = true;
                    if (inCombat)
                    {
                        Console.WriteLine("You cannot do that while in Combat Mode.");
                        endTurn = false;
                        return;
                    }
                    if (row < playerSquare.maxRow - 1) // Checks if there is space to the south
                    {
                        row++;
                        hasMoved = true;
                    } else
                    {
                        Console.WriteLine("There is a wall in that direction, it is impossible to move there.");
                    }
                    break;
                case "s":
                    ParseAction("south", command);
                    break;
                case "east":
                    endCommand = true;
                    if (inCombat)
                    {
                        Console.WriteLine("You cannot do that while in Combat Mode.");
                        endTurn = false;
                        return;
                    }
                    if (column < playerSquare.maxColumn - 1)
                    {
                        column++;
                        hasMoved = true;
                    } else
                    {
                        Console.WriteLine("There is a wall in that direction, it is impossible to move there.");
                    }
                    break;
                case "e":
                    ParseAction("east", command);
                    break;
                case "west":
                    endCommand = true;
                    if (inCombat)
                    {
                        Console.WriteLine("You cannot do that while in Combat Mode.");
                        endTurn = false;
                        return;
                    }
                    if (column > 0)
                    {
                        column--;
                        hasMoved = true;
                    } else
                    {
                        Console.WriteLine("There is a wall in that direction, it is impossible to move there.");
                    }
                    break;
                case "w":
                    ParseAction("west", command);
                    break;
                case "northwest":
                    endCommand = true;
                    if (inCombat)
                    {
                        Console.WriteLine("You cannot do that while in Combat Mode.");
                        endTurn = false;
                        return;
                    }
                    if (row <= 0)
                    {
                        Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                        return;
                    }
                    if (column <= 0)
                    {
                        Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                        return;
                    }
                    column--;
                    row--;
                    hasMoved = true;
                    break;
                case "north-west":
                    ParseAction("northwest", command);
                    break;
                case "nw":
                    ParseAction("northwest", command);
                    break;
                case "northeast":
                    endCommand = true;
                    if (inCombat)
                    {
                        Console.WriteLine("You cannot do that while in Combat Mode.");
                        endTurn = false;
                        return;
                    }
                    if (row <= 0)
                    {
                        Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                        return;
                    }
                    if (column >= playerSquare.maxColumn - 1)
                    {
                        Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                        return;
                    }
                    row--;
                    column++;
                    hasMoved = true;
                    break;
                case "north-east":
                    ParseAction("northeast", command);
                    break;
                case "ne":
                    ParseAction("northeast", command);
                    break;
                case "southwest":
                    endCommand = true;
                    if (inCombat)
                    {
                        Console.WriteLine("You cannot do that while in Combat Mode.");
                        endTurn = false;
                        return;
                    }
                    if (row >= playerSquare.maxRow - 1)
                    {
                        Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                        return;
                    }
                    if (column <= 0)
                    {
                        Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                        return;
                    }
                    row++;
                    column--;
                    hasMoved = true;
                    break;
                case "south-west":
                    ParseAction("southwest", command);
                    break;
                case "sw":
                    ParseAction("southwest", command);
                    break;
                case "southeast":
                    endCommand = true;
                    if (inCombat)
                    {
                        Console.WriteLine("You cannot do that while in Combat Mode.");
                        endTurn = false;
                        return;
                    }
                    if (row >= playerSquare.maxRow - 1)
                    {
                        Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                        return;
                    }
                    if (column >= playerSquare.maxColumn - 1)
                    {
                        Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                        return;
                    }
                    row++;
                    column++;
                    hasMoved = true;
                    break;
                case "south-east":
                    ParseAction("southeast", command);
                    break;
                case "se":
                    ParseAction("southeast", command);
                    break;
                case "up":
                    endCommand = true;
                    if (playerSquare.box == null)
                    {
                        Console.WriteLine("There is no box in this area to climb up onto.");
                        return;
                    }
                    if (isUp)
                    {
                        Console.WriteLine("You are already on top of a box.");
                        return;
                    }
                    isUp = true;
                    if (playerSquare == caveRoomB1_0) // Update per climbable square
                    {
                        Console.WriteLine("You climb onto the box and grab the item you find there, a Key!");
                        inventory.Add(greenKey);
                        return;
                    }
                    if (playerSquare == caveRoomB3_3)
                    {
                        Console.WriteLine("You climb onto the box and grab the item you find there, a Note!");
                        inventory.Add(note8);
                        return;
                    }
                    Console.WriteLine("You are on top of the box, but don't see anything.");
                    break;
                case "down":
                    endCommand = true;
                    if (!isUp)
                    {
                        Console.WriteLine("You are already on the ground.");
                        return;
                    }
                    isUp = false;
                    Console.WriteLine("You have climbed down from the box.");
                    break;
                case "climb":
                    if (command != "")
                    {
                        return;
                    }
                    Console.WriteLine("I understood you as far as wanting to climb.");
                    break;
                case "look":
                    endCommand = true;
                    if (inCombat)
                    {
                        Console.WriteLine("You cannot do that in Combat Mode");
                        endTurn = false;
                        return;
                    }
                    if (command == "" || command == "around")
                    {
                        hasMoved = true;
                    } else
                    {
                        Console.WriteLine("I understood you as far as wanting to look.");
                    }
                    break;
                case "shout":
                    endCommand = true;
                    Console.WriteLine("Sure, why not? AAAAAAAAAAAAAAAAAAAAAAAARRRRRRRRRRRRRRRRRRGGGGGGGGGGGHHHH!!!!!!! *ahem* Was that good?");
                    break;
                case "zork":
                    endCommand = true;
                    Console.WriteLine("What did you just call me?!");
                    break;
                case "bar":
                    if (command == "" || command[0] == ' ')
                    {
                        Console.WriteLine("You're lucky I'm not Welsh.");
                    } else
                    {
                        Console.WriteLine("I understood you as far as wanting to bar.");
                    }
                    break;
                case "g":
                    if (savedCommand == "")
                    {
                        endCommand = true;
                        Console.WriteLine("There is no command to repeat");
                        return;
                    }
                    ParseCommand(savedCommand);
                    break;
                case "inventory":
                    endCommand = true;
                    endTurn = false;
                    if (inventory.Count == 0)
                    {
                        Console.WriteLine("You are empty handed.");
                        return;
                    }
                    Console.WriteLine("You are currently holding:");
                    foreach (Item item in inventory)
                    {
                        Console.WriteLine($" - {item.itemName}");
                    }
                    break;
                case "i":
                    if (command != "")
                    {
                        return;
                    }
                    ParseAction("inventory", command);
                    break;
                case "go":
                    if (inCombat)
                    {
                        endCommand = true;
                        Console.WriteLine("You cannot do that while in Combat Mode.");
                        endTurn = false;
                        return;
                    }
                    if (command != "")
                    {
                        return;
                    }
                    Console.WriteLine("I understood you as far as wanting to go.");
                    break;
                case "walk":
                    if (inCombat)
                    {
                        endCommand = true;
                        Console.WriteLine("You cannot do that while in Combat Mode.");
                        endTurn = false;
                        return;
                    }
                    if (command != "")
                    {
                        return;
                    }
                    Console.WriteLine("I understood you as far as wanting to walk.");
                    break;
                case "smell":
                    if (command == "")
                    {
                        Console.WriteLine("You need to elaborate.");
                        return;
                    }
                    SmellItem(command);
                    endCommand = true;
                    break;
                case "taste":
                    if (command == "")
                    {
                        Console.WriteLine("You need to elaborate.");
                        return;
                    }
                    TasteItem(command);
                    endCommand = true;
                    break;
                case "listen":
                    if (command == "")
                    {
                        Console.WriteLine("You need to elaborate.");
                        return;
                    }
                    ListenItem(command);
                    endCommand = true;
                    break;
                case "take":
                    if (command == "")
                    {
                        Console.WriteLine("You need to elaborate.");
                        return;
                    }
                    TakeAction(command);
                    endCommand = true;
                    break;
                case "get":
                    ParseAction("take", command);
                    break;
                case "pick":
                    ParseAction("take", command);
                    break;
                case "place":
                    if (command == "")
                    {
                        Console.WriteLine("You need to elaborate.");
                        return;
                    }
                    PlaceAction(command);
                    endCommand = true;
                    break;
                case "drop":
                    ParseAction("place", command);
                    break;
                case "open":
                    if (inCombat)
                    {
                        Console.WriteLine("You cannot do that while in Combat Mode.");
                        endTurn = false;
                        return;
                    }
                    if (command == "")
                    {
                        Console.WriteLine("You need to elaborate.");
                        return;
                    }
                    OpenAction(command);
                    endCommand = true;
                    break;
                case "map":
                    endCommand = true;
                    endTurn = false;
                    if (command != "")
                    {
                        Console.WriteLine("I understood as far as you wanting to map.");
                        return;
                    }
                    DisplayMap(); // This displays the map to the console
                    break;
                case "move":
                    endCommand = true;
                    if (inCombat)
                    {
                        Console.WriteLine("You cannot do that while in Combat Mode.");
                        endTurn = false;
                        return;
                    }
                    if (command == "")
                    {
                        Console.WriteLine("You need to elaborate.");
                        return;
                    }
                    MoveAction(command);
                    break;
                case "read":
                    endCommand = true;
                    if (command == "")
                    {
                        Console.WriteLine("You need to elaborate.");
                        return;
                    }
                    ReadAction(command);
                    break;
                case "remember":
                    endCommand = true;
                    endTurn = false;
                    if (command == "")
                    {
                        Console.WriteLine("There's no point remembering nothing.");
                        return;
                    }
                    reminders.Add(command);
                    Console.WriteLine($"Remembered '{command}'");
                    break;
                case "remind":
                    endCommand = true;
                    if (reminders.Count == 0)
                    {
                        Console.WriteLine("You have nothing for me to remind you about.");
                        return;
                    }
                    Console.WriteLine("Here are your reminders:\n");
                    foreach(string reminder in reminders)
                    {
                        Console.WriteLine("  - " + reminder);
                    }
                    break;
                case "hello":
                    endCommand = true;
                    Console.WriteLine("Hello to you too.");
                    break;
                case "hi":
                    endCommand = true;
                    Console.WriteLine("Hi, my name's ZORK.");
                    break;
                case "find":
                    endCommand = true;
                    if (command == "")
                    {
                        Console.WriteLine("You need to elaborate.");
                        return;
                    }
                    FindAction(command);
                    break;
                case "tp":
                    endCommand = true;
                    if (inCombat)
                    {
                        Console.WriteLine("You cannot do that while in Combat Mode.");
                        endTurn = false;
                        return;
                    }
                    if (playerName != "Dev")
                    {
                        Console.WriteLine("Only a developer can use a Dev Tool.");
                        return;
                    }
                    TeleportAction(command);
                    break;
                case "give":
                    endCommand = true;
                    endTurn = false;
                    if (playerName != "Dev")
                    {
                        Console.WriteLine("Only a developer can use a Dev Tool.");
                        return;
                    }
                    GiveAction(command);
                    break;
                case "jump":
                    endCommand = true;
                    if (command != "")
                    {
                        Console.WriteLine("You cannot do that.");
                        return;
                    }
                    Console.WriteLine(RandomJumpText());
                    break;
                case "kill":
                    endCommand = true;
                    if (playerName != "Dev")
                    {
                        Console.WriteLine("Only a developer can use a Dev Tool.");
                        return;
                    }
                    if (!inCombat)
                    {
                        Console.WriteLine("You can only kill if you are in combat.");
                        return;
                    }
                    playerSquare.enemy.health = 0;
                    break;
                case "wait":
                    endCommand = true;
                    if (!inCombat)
                    {
                        Console.WriteLine("You can only do this while in combat.");
                        return;
                    }
                    isWaiting = true;
                    Console.WriteLine("You have decided to wait next turn, so you'll get +5 energy.");
                    break;
                case "heal":
                    endCommand = true;
                    if (!inCombat)
                    {
                        Console.WriteLine("You can only do this while in combat.");
                        return;
                    }
                    if (command != "")
                    {
                        int num;
                        try
                        {
                            num = Convert.ToInt32(command);
                        } catch
                        {
                            Console.WriteLine("You cannot do that.");
                            endTurn = false;
                            return;
                        }
                        if (num <= 0)
                        {
                            Console.WriteLine("The number needs to be higher than 0.");
                            endTurn = false;
                            return;
                        }
                        if (playerEnergy < num)
                        {
                            Console.WriteLine("You don't have enough energy to do this.");
                            return;
                        }
                        playerEnergy -= num;
                        if (playerHealth >= maxPlayerHealth - num)
                        {
                            playerHealth = maxPlayerHealth;
                        } else
                        {
                            playerHealth += num;
                        }
                        Console.WriteLine($"You have decided to heal, using {num} energy to heal {num} health points.");
                        return;
                    }
                    if (playerEnergy < 3)
                    {
                        Console.WriteLine("You don't have enough energy to do this.");
                        endTurn = false;
                        return;
                    }
                    playerEnergy -= 3;
                    if (playerHealth >= maxPlayerHealth - 3)
                    {
                        playerHealth = maxPlayerHealth;
                    } else
                    {
                        playerHealth += 3;
                    }
                    Console.WriteLine("You have decided to heal, using 3 energy to heal 3 health points.");
                    break;
                case "eat":
                    endCommand = true;
                    if (command == "")
                    {
                        Console.WriteLine("You need to elaborate.");
                        endTurn = false;
                        return;
                    }
                    EatCommand(command);
                    break;
                case "attack":
                    endCommand = true;
                    if (!inCombat)
                    {
                        Console.WriteLine("You must be in Combat to do this.");
                        return;
                    }
                    if (command == "")
                    {
                        Console.WriteLine("You need to elaborate.");
                        endTurn = false;
                        return;
                    }
                    AttackCommand(command, playerSquare.enemy);
                    break;
                case "examine":
                    endCommand = true;
                    endTurn = false;
                    if (command == "")
                    {
                        Console.WriteLine("You need to elaborate.");
                        return;
                    }
                    ExamineCommand(command);
                    break;
                case "run":
                    if (inCombat)
                    {
                        endCommand = true;
                        Console.WriteLine("You cannot do that while in Combat Mode.");
                        endTurn = false;
                        return;
                    }
                    if (command != "")
                    {
                        return;
                    }
                    Console.WriteLine("I understood you as far as wanting to run.");
                    break;
                case "reset":
                    endCommand = true;
                    bool hasDecided = false;
                    Console.WriteLine("You would be about to reset to the start of the room you are in. Are you sure about this?");
                    while (!hasDecided)
                    {
                        Console.Write("\n> ");
                        string choice = Console.ReadLine().ToLower();
                        if (choice == "yes" || choice == "y")
                        {
                            LoadGame("Saved Room");
                            return;
                        } 
                        if (choice == "no" || choice == "nope" || choice == "n")
                        {
                            hasDecided = true;
                        }
                    }
                    break;
            }
        }
        public static void ParseNext(string nextWord, string command)
        {
            switch(nextWord)
            {
                default:
                    if (command != "")
                    {
                        return;
                    }
                    Console.WriteLine($"I understood you as far as wanting to {actionWord}");
                    break;
                case "north":
                    if (actionWord == "run")
                    {
                        if (row <= 1)
                        {
                            Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                            break;
                        }
                        row -= 2;
                        hasMoved = true;
                        break;
                    }
                    if (actionWord != "go" && actionWord != "walk")
                    {
                        Console.WriteLine($"One cannot simply {actionWord} {nextWord}.");
                        return;
                    }
                    ParseAction("north", command);
                    break;
                case "east":
                    if (actionWord == "run")
                    {
                        if (column >= playerSquare.maxColumn - 2)
                        {
                            Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                            break;
                        }
                        column += 2;
                        hasMoved = true;
                        break;
                    }
                    if (actionWord != "go" && actionWord != "walk")
                    {
                        Console.WriteLine($"One cannot simply {actionWord} {nextWord}.");
                        return;
                    }
                    ParseAction("east", command);
                    break;
                case "south":
                    if (actionWord == "run")
                    {
                        if (row >= playerSquare.maxRow - 2)
                        {
                            Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                            break;
                        }
                        row += 2;
                        hasMoved = true;
                        break;
                    }
                    if (actionWord != "go" && actionWord != "walk")
                    {
                        Console.WriteLine($"One cannot simply {actionWord} {nextWord}.");
                        return;
                    }
                    ParseAction("south", command);
                    break;
                case "west":
                    if (actionWord == "run")
                    {
                        if (column <= 1)
                        {
                            Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                            break;
                        }
                        column -= 2;
                        hasMoved = true;
                        break;
                    }
                    if (actionWord != "go" && actionWord != "walk")
                    {
                        Console.WriteLine($"One cannot simply {actionWord} {nextWord}.");
                        return;
                    }
                    ParseAction("west", command);
                    break;
                case "northeast":
                    if (actionWord == "run")
                    {
                        if (row <= 1 || column >= playerSquare.maxColumn - 2)
                        {
                            Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                            break;
                        }
                        row -= 2;
                        column += 2;
                        hasMoved = true;
                        break;
                    }
                    if (actionWord != "go" && actionWord != "walk")
                    {
                        Console.WriteLine($"One cannot simply {actionWord} {nextWord}.");
                        return;
                    }
                    ParseAction("northeast", command);
                    break;
                case "northwest":
                    if (actionWord == "run")
                    {
                        if (row <= 1 || column <= 1)
                        {
                            Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                            break;
                        }
                        row -= 2;
                        column -= 2;
                        hasMoved = true;
                        break;
                    }
                    if (actionWord != "go" && actionWord != "walk")
                    {
                        Console.WriteLine($"One cannot simply {actionWord} {nextWord}.");
                        return;
                    }
                    ParseAction("northwest", command);
                    break;
                case "southwest":
                    if (actionWord == "run")
                    {
                        if (row >= playerSquare.maxRow - 2 || column <= 1)
                        {
                            Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                            break;
                        }
                        row += 2;
                        column -= 2;
                        hasMoved = true;
                        break;
                    }
                    if (actionWord != "go" && actionWord != "walk")
                    {
                        Console.WriteLine($"One cannot simply {actionWord} {nextWord}.");
                        return;
                    }
                    ParseAction("southwest", command);
                    break;
                case "southeast":
                    if (actionWord == "run")
                    {
                        if (row >= playerSquare.maxRow - 2 || column >= playerSquare.maxColumn - 2)
                        {
                            Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                            break;
                        }
                        row += 2;
                        column += 2;
                        hasMoved = true;
                        break;
                    }
                    if (actionWord != "go" && actionWord != "walk")
                    {
                        Console.WriteLine($"One cannot simply {actionWord} {nextWord}.");
                        return;
                    }
                    ParseAction("southeast", command);
                    break;
                case "north-east":
                    if (actionWord == "run")
                    {
                        if (row <= 1 || column >= playerSquare.maxColumn - 2)
                        {
                            Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                            break;
                        }
                        row -= 2;
                        column += 2;
                        hasMoved = true;
                        break;
                    }
                    if (actionWord != "go" && actionWord != "walk")
                    {
                        Console.WriteLine($"One cannot simply {actionWord} {nextWord}.");
                        return;
                    }
                    ParseAction("northeast", command);
                    break;
                case "north-west":
                    if (actionWord == "run")
                    {
                        if (row <= 1 || column <= 1)
                        {
                            Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                            break;
                        }
                        row -= 2;
                        column -= 2;
                        hasMoved = true;
                        break;
                    }
                    if (actionWord != "go" && actionWord != "walk")
                    {
                        Console.WriteLine($"One cannot simply {actionWord} {nextWord}.");
                        return;
                    }
                    ParseAction("northwest", command);
                    break;
                case "south-west":
                    if (actionWord == "run")
                    {
                        if (row >= playerSquare.maxRow - 2 || column <= 1)
                        {
                            Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                            break;
                        }
                        row += 2;
                        column -= 2;
                        hasMoved = true;
                        break;
                    }
                    if (actionWord != "go" && actionWord != "walk")
                    {
                        Console.WriteLine($"One cannot simply {actionWord} {nextWord}.");
                        return;
                    }
                    ParseAction("southwest", command);
                    break;
                case "south-east":
                    if (actionWord == "run")
                    {
                        if (row >= playerSquare.maxRow - 2 || column >= playerSquare.maxColumn - 2)
                        {
                            Console.WriteLine("There is a wall in the way, it is impossible to move there.");
                            break;
                        }
                        row += 2;
                        column += 2;
                        hasMoved = true;
                        break;
                    }
                    if (actionWord != "go" && actionWord != "walk")
                    {
                        Console.WriteLine($"One cannot simply {actionWord} {nextWord}.");
                        return;
                    }
                    ParseAction("southeast", command);
                    break;
                case "up":
                    if (actionWord != "climb")
                    {
                        Console.WriteLine($"One cannot simpy {actionWord} {nextWord}.");
                        return;
                    }
                    ParseAction("up", command);
                    break;
                case "down":
                    if (actionWord != "climb")
                    {
                        Console.WriteLine($"One cannot simpy {actionWord} {nextWord}.");
                        return;
                    }
                    ParseAction("down", command);
                    break;
            }
        }
        public static void EstablishSquares() // This places all of the squares in their grids and adds data to them
        {
            caveRoomA0_2.exitSquare = true; // Makes this the Exit Square for Room A
            caveRoomA1_1.beenVisited = true; // Makes this Square appear as a - on the map
            caveRoomA2_2.AddInventory(leaf, leaf, leaf, leaf);
            caveRoomB0_3.AddInventory(note1);
            caveRoomB0_4.box = blueBox; // Adds a box to this square
            caveRoomB1_2.box = yellowBox; // Adds a box to this square
            caveRoomB1_5.box = purpleBox; // Adds a box to this square
            caveRoomB2_0.exitSquare = true; // Makes this the Exit Square for Room B
            caveRoomB2_3.box = greenBox; // Adds a box to this square
            caveRoomB3_0.box = redBox; // Adds a box to this square
            caveRoomC0_1.exitSquare = true; // Makes this the Exit Square for Room C
            caveRoomC0_1.enemy = roomC; // Adds an enemy to this square
            caveRoomC2_2.box = cardboardBox; // Adds a box to this square
            caveRoomA[0, 0] = caveRoomA0_0; // Room A
            caveRoomA[0, 1] = caveRoomA0_1;
            caveRoomA[0, 2] = caveRoomA0_2;
            caveRoomA[1, 0] = caveRoomA1_0;
            caveRoomA[1, 1] = caveRoomA1_1;
            caveRoomA[1, 2] = caveRoomA1_2;
            caveRoomA[2, 0] = caveRoomA2_0;
            caveRoomA[2, 1] = caveRoomA2_1;
            caveRoomA[2, 2] = caveRoomA2_2;
            caveRoomB[0, 0] = caveRoomB0_0; // Room B
            caveRoomB[0, 1] = caveRoomB0_1;
            caveRoomB[0, 2] = caveRoomB0_2;
            caveRoomB[0, 3] = caveRoomB0_3;
            caveRoomB[0, 4] = caveRoomB0_4;
            caveRoomB[0, 5] = caveRoomB0_5;
            caveRoomB[1, 0] = caveRoomB1_0;
            caveRoomB[1, 1] = caveRoomB1_1;
            caveRoomB[1, 2] = caveRoomB1_2;
            caveRoomB[1, 3] = caveRoomB1_3;
            caveRoomB[1, 4] = caveRoomB1_4;
            caveRoomB[1, 5] = caveRoomB1_5;
            caveRoomB[2, 0] = caveRoomB2_0;
            caveRoomB[2, 1] = caveRoomB2_1;
            caveRoomB[2, 2] = caveRoomB2_2;
            caveRoomB[2, 3] = caveRoomB2_3;
            caveRoomB[2, 4] = caveRoomB2_4;
            caveRoomB[2, 5] = caveRoomB2_5;
            caveRoomB[3, 0] = caveRoomB3_0;
            caveRoomB[3, 1] = caveRoomB3_1;
            caveRoomB[3, 2] = caveRoomB3_2;
            caveRoomB[3, 3] = caveRoomB3_3;
            caveRoomB[3, 4] = caveRoomB3_4;
            caveRoomB[3, 5] = caveRoomB3_5;
            caveRoomC[0, 0] = caveRoomC0_0; // Room C
            caveRoomC[0, 1] = caveRoomC0_1;
            caveRoomC[0, 2] = caveRoomC0_2;
            caveRoomC[1, 0] = caveRoomC1_0;
            caveRoomC[1, 1] = caveRoomC1_1;
            caveRoomC[1, 2] = caveRoomC1_2;
            caveRoomC[2, 0] = caveRoomC2_0;
            caveRoomC[2, 1] = caveRoomC2_1;
            caveRoomC[2, 2] = caveRoomC2_2;
            caveRoomC[3, 0] = caveRoomC3_0;
            caveRoomC[3, 1] = caveRoomC3_1;
            caveRoomC[3, 2] = caveRoomC3_2;
            caveRoomC[4, 0] = caveRoomC4_0;
            caveRoomC[4, 1] = caveRoomC4_1;
            caveRoomC[4, 2] = caveRoomC4_2;
        }
        public static void CheckRoomCompleted() // Checks the requirements that complete the room the player is in
        {
            if (playerSquare.room == caveRoomA) // Update per room
            {
                if (playerSquare.roomComplete)
                {
                    return;
                }
                if (caveRoomA0_2.inventory.Contains(leaf) && caveRoomA1_0.inventory.Contains(leaf) && caveRoomA1_1.inventory.Contains(leaf) && caveRoomA2_1.inventory.Contains(leaf))
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Congratulations, {playerName}! You have completed Cave Room A, please make your way to the door and open it.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    caveRoomA0_2.roomComplete = true;
                    return;
                }
            } else if (playerSquare.room == caveRoomB || playerSquare.room == caveRoomC) // Every room that needs a Gold Note
            {
                if (playerSquare.roomComplete)
                {
                    return;
                }
                if (inventory.Contains(goldNote))
                {
                    foreach(Square square in playerSquare.room)
                    {
                        square.roomComplete = true;
                    }
                    return;
                }
            }
        }
        public static void GiveAction(string command)
        {
            foreach (Item item in items)
            {
                if (command == item.itemName.ToLower())
                {
                    inventory.Add(item);
                    Console.WriteLine($"{item.itemName} has been given.");
                    return;
                }
            }
            Console.WriteLine("That is not an item.");
        }
        public static void DisplayHelp()
        {
            Console.WriteLine("Help Text:\n");
            Console.WriteLine("Scuffed ZORK is a game that I made using C#, which is very far removed from the language ZORK was originally made using. Therefore, the game works slightly\ndifferent to how you may expect.");
            Console.WriteLine("It uses a command parser system that works similarly to the one in Minecraft, but mine is a bit more lenient with its structure. " +
                "The first word you input is\nknown as the Action Word, this is then used to determine what it is that you are trying to do within the game. There are many actions you can perform, some\nof which may do the same things as another. Below, I will provide a basic list of the main actions you can take each turn.\n");
            if (!inCombat)
            {
                Console.WriteLine("Movement:\n");
                Console.WriteLine("In order to move within the game, there are several commands you can enter. You are able to move in the 8 cardinal directions, like the King in a game of\nChess. " +
                    "You can do this by using the first letter(s) of the direction you wish to go (n - north, se - southeast, for example). In addition to this, you can\nuse the full word, or you can use 'go' or 'walk' " +
                    "to walk in a direction, but you must use the full word if you opt to use this method. If you use the 'move'\naction, you will move just like using the 'go' or 'walk' commands, but you can only use it if " +
                    "there is a moveable object in your area, then it will be moved\nwith you. As well as this, you can use the 'up' action to climb up a box. You can also use the 'run' command to go a little further than usual.\n");
                Console.WriteLine("Utility Commands:\n");
                Console.WriteLine("There are a few actions you can take that will perform a task that will help with the meta game. The first one you'd need to know about is saving the game,\nusing the " +
                    "'save' action will put all of the save data into a separate text file that can be loaded when you start the game. You can also leave the game\nusing the 'quit' action. The 'look' " +
                    "action will tell you everything you can see in the area you are currently in. As the player, you have an inventory which\nyou can access using 'I' or 'inventory'. If you ever find " +
                    "yourself lost, you can use the 'map' action to generate a map of the room you are in. You don't\nneed to pull up a notepad while you are playing this game because you can " +
                    "use the reminders system so you don't forget any clues. It works by using the\n'remember' action to save whatever you put after the word and you just need to ask the game to " +
                    "remind you of everything that you have remembered. There\nis even a command you can use to locate something that you may have lost, like the door or a box. This is done by " +
                    "using the 'find' action, then entering the\nname of what you are looking for as long as you have seen it before.\n");
                Console.WriteLine("Dealing with Items:\n");
                Console.WriteLine("Sometimes when you enter an area it contains items, you can pick up these items using either the 'get', 'take', or 'pick' action. You can also 'drop' or\n'place' " +
                    "items too. This will also let you take items from an open box, but it has to be open. There are different types of items: Items, Notes, Keys, Food,\nand Weapons. You can read " +
                    "any notes that you have, and eat any food that you have. Examining an item, area, or enemy will give you more information about them.\n");
                Console.WriteLine("Boxes:\n");
                Console.WriteLine("Boxes contain a certain number of items. There are 3 types of Box: Key, Code, and Open. Key Boxes are ones that require a specific key item to open. " +
                    "Code Boxes\nare ones that need an Unlock Code to open, Unlock Codes are either 4 letters, or 4 numbers. Clues for these can be found in the room that the box is " +
                    "found in,\nwith the order they go in being linked to the location. Open Boxes can be opened without a Code/Key.\n");
            }
            Console.WriteLine("Combat:\n");
            Console.WriteLine("This game's combat system is Turn-Based. The enemy you are fighting always goes first, then you are able to have your turn. The enemy can do 5 actions:\nBlindly Attack, " +
                "Wait, Eat, Heal, and Attack. When they blindly attack you, it hits you for half of their attack damage. There are several combat actions that\nyou can perform. You can eat any food " +
                "that you have in your inventory. If you don't have enough energy or food, you can wait a turn to earn some extra energy.\nIf you ever find yourself low on health, you can make a " +
                "one-to-one trade of energy to healing power. You can use the 'attack' action to deal damage to the\nenemy, you need to choose which weapon you want to use.");
        }
        public static void TeleportAction(string command)
        {
            int wordCount = 1;
            string teleportWord;
            Square[,] targetRoom = null;
            int targetRow = 404;
            int targetColumn = 404;
            while (wordCount <= 3)
            {
                teleportWord = "";
                while (teleportWord == "")
                {
                    if (command == "")
                    {
                        Console.WriteLine("Proper Syntax: tp roomID row column");
                        return;
                    }
                    int charPos = 0;
                    foreach (char c in command)
                    {
                        charPos++;
                        if (c == ' ')
                        {
                            break;
                        }
                        else
                        {
                            teleportWord += c;
                        }
                    }
                    command = command.Substring(charPos);
                }
                if (wordCount == 1)
                {
                    switch(teleportWord) // Update per room
                    {
                        default:
                            command = "";
                            break;
                        case "caverooma":
                            targetRoom = caveRoomA;
                            break;
                        case "caveroomb":
                            targetRoom = caveRoomB;
                            break;
                        case "caveroomc":
                            targetRoom = caveRoomC;
                            break;
                    }
                } else if (wordCount == 2)
                {
                    try
                    {
                        targetRow = Convert.ToInt32(teleportWord);
                    } catch
                    {
                        command = "";
                    }
                } else
                {
                    try
                    {
                        targetColumn = Convert.ToInt32(teleportWord);
                    }
                    catch
                    {
                        command = "";
                    }
                }
                wordCount++;
            }
            try
            {
                playerSquare = targetRoom[targetRow, targetColumn];
                hasMoved = true;
                row = targetRow;
                column = targetColumn;
                Console.WriteLine("Teleported!...");
                Console.WriteLine("");
            } catch
            {
                Console.WriteLine("Proper Syntax: tp roomID row column");
            }
        }
        public static void DisplayMap()
        {
            Console.WriteLine("^ -> You are here.");
            Console.WriteLine("- -> You have been here before.");
            Console.WriteLine("  -> You have not been here yet.");
            Console.WriteLine("");
            for (int n = 0; n < playerSquare.room.GetLength(1); n++)
            {
                if (n == 0)
                {
                    Console.Write($"  {n + 1}");
                } else
                {
                    Console.Write($" {n + 1}");
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < playerSquare.room.GetLength(0); i++)
            {
                Console.Write($"{i + 1}|");
                for (int j = 0; j < playerSquare.room.GetLength(1); j++)
                {
                    if (playerSquare == playerSquare.room[i, j])
                    {
                        Console.Write("^|");
                        continue;
                    }
                    if (playerSquare.room[i, j].beenVisited)
                    {
                        Console.Write("-|");
                        continue;
                    }
                    Console.Write(" |");
                }
                Console.WriteLine();
            }
        }
        public static void ReadAction(string command)
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("You have nothing in your inventory.");
                return;
            }
            string itemName = "a";
            while (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "my")
            {
                if (command == "")
                {
                    Console.WriteLine($"I understood you as far as wanting to {actionWord}.");
                    return;
                }
                itemName = "";
                int charPos = 0;
                foreach (char c in command)
                {
                    charPos++;
                    if (c != ' ')
                    {
                        itemName += c;
                    }
                    else if (itemName != "a" && itemName != "the" && itemName != "an" && itemName != "my" && itemName != "")
                    {
                        itemName += c;
                    }
                    if (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "my")
                    {
                        try
                        {
                            if (command[charPos] != 'n')
                            {

                                command = command.Substring(charPos);
                                break;
                            }
                        }
                        catch
                        {
                            command = "";
                        }
                    }
                }
            }
            foreach (Item item in inventory)
            {
                if (itemName == item.itemName.ToLower())
                {
                    if (item.GetType().Name != "Note")
                    {
                        Console.WriteLine("The item you want to read is not a note.");
                        return;
                    }
                    Note note = (Note)item;
                    note.ReadNote();
                    return;
                }
            }
            Console.WriteLine($"You don't have an item called '{itemName}'.");
            return;
        }
        public static void MoveAction(string command)
        {
            if (playerSquare.box == null)
            {
                Console.WriteLine("There is no box here to move.");
                return;
            }
            string moveWord = "";
            while (moveWord == "a" || moveWord == "box" || moveWord == "the" || moveWord == "")
            {
                if (command == "")
                {
                    Console.WriteLine("I understood you as far as wanting to move something.");
                    return;
                }
                moveWord = "";
                int charPos = 0;
                foreach (char c in command)
                {
                    charPos++;
                    if (c == ' ')
                    {
                        break;
                    }
                    else
                    {
                        moveWord += c;
                    }
                }
                command = command.Substring(charPos);
            }
            switch(moveWord)
            {
                default:
                    Console.WriteLine($"You cannot move the box {moveWord}.");
                    return;
                case "north":
                    if (row == 0)
                    {
                        Console.WriteLine("There is a wall in that direction, it is impossible to move a box there.");
                        return;
                    }
                    if (playerSquare.room[row - 1, column].box != null)
                    {
                        Console.WriteLine("The area you plan on moving the box to already contains one, therefore you cannot do that.");
                        return;
                    }
                    playerSquare.room[row - 1, column].box = playerSquare.box;
                    playerSquare.box = null;
                    row--;
                    break;
                case "south":
                    if (row >= playerSquare.maxRow - 1)
                    {
                        Console.WriteLine("There is a wall in that direction, it is impossible to move a box there.");
                        return;
                    }
                    if (playerSquare.room[row + 1, column].box != null)
                    {
                        Console.WriteLine("The area you plan on moving the box to already contains one, therefore you cannot do that.");
                        return;
                    }
                    playerSquare.room[row + 1, column].box = playerSquare.box;
                    playerSquare.box = null;
                    row++;
                    break;
                case "west":
                    if (column == 0)
                    {
                        Console.WriteLine("There is a wall in that direction, it is impossible to move a box there.");
                        return;
                    }
                    if (playerSquare.room[row, column - 1].box != null)
                    {
                        Console.WriteLine("The area you plan on moving the box to already contains one, therefore you cannot do that.");
                        return;
                    }
                    playerSquare.room[row, column - 1].box = playerSquare.box;
                    playerSquare.box = null;
                    column--;
                    break;
                case "east":
                    if (column >= playerSquare.maxColumn - 1)
                    {
                        Console.WriteLine("There is a wall in that direction, it is impossible to move a box there.");
                        return;
                    }
                    if (playerSquare.room[row, column + 1].box != null)
                    {
                        Console.WriteLine("The area you plan on moving the box to already contains one, therefore you cannot do that.");
                        return;
                    }
                    playerSquare.room[row, column + 1].box = playerSquare.box;
                    playerSquare.box = null;
                    column++;
                    break;
                case "northwest":
                    if (row == 0 || column == 0)
                    {
                        Console.WriteLine("There is a wall in that direction, it is impossible to move a box there.");
                        return;
                    }
                    if (playerSquare.room[row - 1, column - 1].box != null)
                    {
                        Console.WriteLine("The area you plan on moving the box to already contains one, therefore you cannot do that.");
                        return;
                    }
                    playerSquare.room[row - 1, column - 1].box = playerSquare.box;
                    playerSquare.box = null;
                    row--;
                    column--;
                    break;
                case "northeast":
                    if (row == 0 || column >= playerSquare.maxColumn - 1)
                    {
                        Console.WriteLine("There is a wall in that direction, it is impossible to move a box there.");
                        return;
                    }
                    if (playerSquare.room[row - 1, column + 1].box != null)
                    {
                        Console.WriteLine("The area you plan on moving the box to already contains one, therefore you cannot do that.");
                        return;
                    }
                    playerSquare.room[row - 1, column + 1].box = playerSquare.box;
                    playerSquare.box = null;
                    row--;
                    column++;
                    break;
                case "southwest":
                    if (row >= playerSquare.maxRow - 1 || column == 0)
                    {
                        Console.WriteLine("There is a wall in that direction, it is impossible to move a box there.");
                        return;
                    }
                    if (playerSquare.room[row + 1, column - 1].box != null)
                    {
                        Console.WriteLine("The area you plan on moving the box to already contains one, therefore you cannot do that.");
                        return;
                    }
                    playerSquare.room[row + 1, column - 1].box = playerSquare.box;
                    playerSquare.box = null;
                    row++;
                    column--;
                    break;
                case "southeast":
                    if (row >= playerSquare.maxRow - 1 || column >= playerSquare.maxColumn - 1)
                    {
                        Console.WriteLine("There is a wall in that direction, it is impossible to move a box there.");
                        return;
                    }
                    if (playerSquare.room[row + 1, column + 1].box != null)
                    {
                        Console.WriteLine("The area you plan on moving the box to already contains one, therefore you cannot do that.");
                        return;
                    }
                    playerSquare.room[row + 1, column + 1].box = playerSquare.box;
                    playerSquare.box = null;
                    row++;
                    column++;
                    break;
                case "north-west":
                    MoveAction("northwest");
                    break;
                case "north-east":
                    MoveAction("northeast");
                    break;
                case "south-west":
                    MoveAction("southwest");
                    break;
                case "south-east":
                    MoveAction("southeast");
                    break;
            }
            hasMoved = true;
        }
        public static void OpenAction(string command)
        {
            string openWord = "a";
            while (openWord == "a" || openWord == "the" || openWord == "an" || openWord == "up")
            {
                if (command == "")
                {
                    Console.WriteLine($"I understood you as far as wanting to {actionWord}.");
                    return;
                }
                openWord = "";
                int charPos = 0;
                foreach (char c in command)
                {
                    charPos++;
                    if (c != ' ')
                    {
                        openWord += c;
                    }
                    else if (openWord != "a" && openWord != "the" && openWord != "an" && openWord != "up" && openWord != "")
                    {
                        openWord += c;
                    }
                    if (openWord == "a" || openWord == "the" || openWord == "an" || openWord == "up")
                    {
                        try
                        {
                            if (command[charPos] == ' ')
                            {

                                command = command.Substring(charPos);
                                break;
                            }
                        }
                        catch
                        {
                            command = "";
                        }
                    }
                }
            }
            if (openWord.Length >= 4 && openWord.Substring(0, 4) == "door") // Checks if the user wants to open a door
            {
                if (!playerSquare.exitSquare)
                {
                    Console.WriteLine("There is no door here.");
                    return;
                }
                if (!playerSquare.roomComplete)
                {
                    Console.WriteLine("This room is not complete yet.");
                    return;
                }
                Console.WriteLine("You open the door and step through into the next room. The door closes behind you and disappears.");
                Console.Write("Press Enter to Continue: ");
                Console.ReadLine();
                Console.Clear();
                commandCount = 0;
                reminders.Clear();
                if (inventory.Count > 0) // This will remove any notes from the player's inventory
                {
                    List<Item> toRemove = new List<Item>();
                    foreach (Item item in inventory)
                    {
                        if (item.GetType() == goldNote.GetType())
                        {
                            toRemove.Add(item);
                        }
                    }
                    if (toRemove.Count > 0)
                    {
                        foreach (Item item in toRemove)
                        {
                            inventory.Remove(item);
                        }
                    }
                }
                if (playerSquare.room == caveRoomA) // Update per room
                {
                    playerSquare = caveRoomB0_3;
                    row = 0;
                    column = 3;
                    hasMoved = true;
                    SaveGame("Saved Room");
                    return;
                } else if (playerSquare.room == caveRoomB)
                {
                    playerSquare = caveRoomC4_1;
                    row = 4;
                    column = 1;
                    hasMoved = true;
                    SaveGame("Saved Room");
                    return;
                } else if (playerSquare.room == caveRoomC)
                {
                    playerHealth = maxPlayerHealth;
                    hasMoved = true;
                    SaveGame("Saved Room");
                    Console.WriteLine("You win... for now."); // Temporary
                    ParseAction("quit", ""); // Temporary
                }
            }
            foreach (Box box in boxes)
            {
                if (openWord.Length >= box.boxName.Length && openWord.Substring(0, box.boxName.Length) == box.boxName.ToLower())
                {
                    openWord = "box";
                }
            }
            if (openWord.Length >= 3 && openWord.Substring(0, 3) == "box") // Checks if the user wants to open a box
            {
                if (playerSquare.box == null)
                {
                    Console.WriteLine("There is no box here.");
                    return;
                }
                if (!playerSquare.box.isUnlocked)
                {
                    playerSquare.box.hasVisited = true;
                    if (playerSquare.box.unlockType == "keypad")
                    {
                        Console.WriteLine(playerSquare.box.lockedMessage);
                        Console.WriteLine("");
                        Console.Write("Keypad Entry Panel: ");
                        string input = Console.ReadLine();
                        if (input.ToLower() != playerSquare.box.unlockCode)
                        {
                            Console.WriteLine("Access Denied!");
                            return;
                        }
                        playerSquare.box.isUnlocked = true;
                        Console.WriteLine("You have unlocked the box.");
                        Console.WriteLine("");
                        OpenAction("box");
                        return;
                    }
                    if (playerSquare.box.unlockKey == null) {

                        playerSquare.box.isUnlocked = true;
                        Console.WriteLine("You have unlocked the box.");
                        Console.WriteLine("");
                        OpenAction("box");
                        return;
                    }
                    foreach (Item item in inventory)
                    {
                        if (item == playerSquare.box.unlockKey)
                        {
                            playerSquare.box.isUnlocked = true;
                            Console.WriteLine("You have unlocked the box.");
                            Console.WriteLine("");
                            inventory.Remove(item);
                            OpenAction("box");
                            return;
                        }
                        if (item.itemName == "Key")
                        {
                            Console.WriteLine("The key you have doesn't fit the lock on this box.");
                            return;
                        }
                    }
                    Console.WriteLine($"This box requires the {playerSquare.box.unlockKey.itemName} to unlock.");
                    return;
                }
                playerSquare.box.isOpen = true;
                Console.Write("This box contains");
                if (playerSquare.box.inventory.Count == 0)
                {
                    Console.WriteLine(" nothing.");
                    return;
                }
                Console.WriteLine(":");
                foreach (Item item in playerSquare.box.inventory)
                {
                    Console.WriteLine($"  - {item.itemName}.");
                }
                return;
            }
            Console.WriteLine($"There is nothing called '{openWord}' that you can open.");
        }
        public static void FindAction(string command)
        {
            string itemName = "a";
            while (itemName == "a" || itemName == "the" || itemName == "an")
            {
                if (command == "")
                {
                    Console.WriteLine($"I understood you as far as wanting to {actionWord}.");
                    return;
                }
                itemName = "";
                int charPos = 0;
                foreach (char c in command)
                {
                    charPos++;
                    if (c != ' ')
                    {
                        itemName += c;
                    }
                    else if (itemName != "a" && itemName != "the" && itemName != "an" && itemName != "")
                    {
                        itemName += c;
                    }
                    if (itemName == "a" || itemName == "the" || itemName == "an")
                    {
                        try
                        {
                            if (command[charPos] != ' ')
                            {

                                command = command.Substring(charPos);
                                break;
                            }
                        }
                        catch
                        {
                            command = "";
                        }
                    }
                }
            }
            switch(itemName)
            {
                default:
                    Console.WriteLine($"You cannot find {itemName}");
                    break;
                case "door":
                    foreach(Square square in playerSquare.room)
                    {
                        if (square.exitSquare && square.beenVisited)
                        {
                            Console.WriteLine($"You remember the door's location as Column {square.column + 1}, Row {square.row + 1}.");
                            return;
                        }
                    }
                    Console.WriteLine("There doesn't seem to be a door, curious.");
                    break;
                case "green box": // Update per box
                    if (greenBox.hasVisited && playerSquare.room == caveRoomB)
                    {
                        Console.WriteLine($"You remember the box's location as Column {greenBox.square.column + 1}, Row {greenBox.square.row + 1}.");
                        return;
                    }
                    Console.WriteLine("What do you mean by Green Box?!");
                    break;
                case "purple box":
                    if (purpleBox.hasVisited && playerSquare.room == caveRoomB)
                    {
                        Console.WriteLine($"You remember the box's location as Column {purpleBox.square.column + 1}, Row {purpleBox.square.row + 1}.");
                        return;
                    }
                    Console.WriteLine("What do you mean by Purple Box?!");
                    break;
                case "blue box":
                    if (blueBox.hasVisited && playerSquare.room == caveRoomB)
                    {
                        Console.WriteLine($"You remember the box's location as Column {blueBox.square.column + 1}, Row {blueBox.square.row + 1}.");
                        return;
                    }
                    Console.WriteLine("What do you mean by Blue Box?!");
                    break;
                case "yellow box":
                    if (yellowBox.hasVisited && playerSquare.room == caveRoomB)
                    {
                        Console.WriteLine($"You remember the box's location as Column {yellowBox.square.column + 1}, Row {yellowBox.square.row + 1}.");
                        return;
                    }
                    Console.WriteLine("What do you mean by Yellow Box?!");
                    break;
                case "red box":
                    if (redBox.hasVisited && playerSquare.room == caveRoomB)
                    {
                        Console.WriteLine($"You remember the box's location as Column {redBox.square.column + 1}, Row {redBox.square.row + 1}.");
                        return;
                    }
                    Console.WriteLine("What do you mean by Red Box?!");
                    break;
            }
        }
        public static void PlaceAction(string command)
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine($"You have nothing to {actionWord}.");
                return;
            }
            string itemName = "a";
            while (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "down" || itemName == "my")
            {
                if (command == "")
                {
                    Console.WriteLine($"I understood you as far as wanting to {actionWord}.");
                    return;
                }
                itemName = "";
                int charPos = 0;
                foreach (char c in command)
                {
                    charPos++;
                    if (c != ' ')
                    {
                        itemName += c;
                    } else if (itemName != "a" && itemName != "the" && itemName != "an" && itemName != "down" && itemName != "my" && itemName != "")
                    {
                        itemName += c;
                    }
                    if (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "down" || itemName == "my")
                    {
                        try
                        {
                            if (command[charPos] == ' ')
                            {

                                command = command.Substring(charPos);
                                break;
                            }
                        }
                        catch
                        {
                            command = "";
                        }
                    }
                }
            }
            if ((itemName.Length >= 3 && itemName.Substring(0, 3) == "all") || (itemName.Length >= 10 && itemName.Substring(0, 10) == "everything"))
            {
                foreach (Item item in inventory)
                {
                    playerSquare.inventory.Add(item);
                }
                inventory.Clear();
                Console.WriteLine("Placed All.");
                return;
            }
            foreach (Item item in inventory)
            {
                if (itemName == item.itemName.ToLower())
                {
                    playerSquare.inventory.Add(item);
                    inventory.Remove(item);
                    Console.WriteLine("Placed.");
                    return;
                }
            }
            Console.WriteLine($"You do not have an item called '{itemName}' in your inventory.");
        }
        public static void TakeAction(string command)
        {
            if (playerSquare.box != null)
            {
                if (!playerSquare.box.isUnlocked)
                {
                    Console.WriteLine("The box in this room is locked.");
                    Console.WriteLine("");
                } else if (!playerSquare.box.isOpen)
                {
                    Console.WriteLine("The box in this room is not open.");
                    Console.WriteLine("");
                }
            }
            if (playerSquare.inventory.Count == 0)
            {
                Console.WriteLine("This area contains no items.");
                if (playerSquare.box == null || (playerSquare.box != null && !playerSquare.box.isOpen))
                {
                    return;
                }
                Console.WriteLine("");
            }
            string itemName = "a";
            while (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "up")
            {
                if (command == "")
                {
                    Console.WriteLine($"I understood you as far as wanting to {actionWord}.");
                    return;
                }
                itemName = "";
                int charPos = 0;
                foreach (char c in command)
                {
                    charPos++;
                    if (c != ' ')
                    {
                        itemName += c;
                    }
                    else if (itemName != "a" && itemName != "the" && itemName != "an" && itemName != "up" && itemName != "")
                    {
                        itemName += c;
                    }
                    if (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "up")
                    {
                        try
                        {
                            if (command[charPos] == ' ')
                            {

                                command = command.Substring(charPos);
                                break;
                            }
                        } catch
                        {
                            command = "";
                        }
                    }
                }
            }
            if ((itemName.Length >= 3 && itemName.Substring(0, 3) == "all") || (itemName.Length >= 10 && itemName.Substring(0, 10) == "everything"))
            {
                if (playerSquare.box != null && playerSquare.box.isOpen)
                {
                    foreach (Item item in playerSquare.box.inventory)
                    {
                        inventory.Add(item);
                    }
                    playerSquare.box.inventory.Clear();
                    Console.WriteLine("Taken Everything in the Box.");
                    return;
                }
                foreach (Item item in playerSquare.inventory)
                {
                    inventory.Add(item);
                }
                playerSquare.inventory.Clear();
                Console.WriteLine("Taken All.");
                return;
            }
            if (playerSquare.box != null && playerSquare.box.isOpen)
            {
                if (playerSquare.box.inventory.Count == 0)
                {
                    Console.WriteLine("This box is empty.");
                    Console.WriteLine("");
                    return;
                }
                foreach (Item item in playerSquare.box.inventory)
                {
                    if (itemName == item.itemName.ToLower())
                    {
                        inventory.Add(item);
                        playerSquare.box.inventory.Remove(item);
                        Console.WriteLine($"Taken {item.itemName} from the box.");
                        return;
                    }
                }
                Console.WriteLine($"There is not an item called '{itemName}' in the box.");
                return;
            }
            foreach (Item item in playerSquare.inventory)
            {
                if (itemName == item.itemName.ToLower())
                {
                    inventory.Add(item);
                    playerSquare.inventory.Remove(item);
                    Console.WriteLine("Taken.");
                    return;
                }
            }
            Console.WriteLine($"There is not an item called '{itemName}' in this area.");
        }
        public static void SmellItem(string command)
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("You have no items in your inventory to smell.");
                return;
            }
            string itemName = "a";
            while (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "my")
            {
                if (command == "")
                {
                    Console.WriteLine($"I understood you as far as wanting to {actionWord}.");
                    return;
                }
                itemName = "";
                int charPos = 0;
                foreach (char c in command)
                {
                    charPos++;
                    if (c != ' ')
                    {
                        itemName += c;
                    }
                    else if (itemName != "a" && itemName != "the" && itemName != "an" && itemName != "my" && itemName != "")
                    {
                        itemName += c;
                    }
                    if (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "my")
                    {
                        try
                        {
                            if (command[charPos] == ' ')
                            {

                                command = command.Substring(charPos);
                                break;
                            }
                        }
                        catch
                        {
                            command = "";
                        }
                    }
                }
            }
            foreach (Item item in inventory)
            {
                if (itemName == item.itemName.ToLower())
                {
                    Console.WriteLine(item.smellText);
                    return;
                }
            }
            Console.WriteLine($"You do not have an item called '{itemName}' in your inventory.");
        }
        public static void TasteItem(string command)
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("You have no items in your inventory to taste.");
                return;
            }
            string itemName = "a";
            while (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "my")
            {
                if (command == "")
                {
                    Console.WriteLine($"I understood you as far as wanting to {actionWord}.");
                    return;
                }
                itemName = "";
                int charPos = 0;
                foreach (char c in command)
                {
                    charPos++;
                    if (c != ' ')
                    {
                        itemName += c;
                    }
                    else if (itemName != "a" && itemName != "the" && itemName != "an" && itemName != "my" && itemName != "")
                    {
                        itemName += c;
                    }
                    if (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "my")
                    {
                        try
                        {
                            if (command[charPos] == ' ')
                            {

                                command = command.Substring(charPos);
                                break;
                            }
                        }
                        catch
                        {
                            command = "";
                        }
                    }
                }
            }
            foreach (Item item in inventory)
            {
                if (itemName == item.itemName.ToLower())
                {
                    Console.WriteLine(item.tasteText);
                    return;
                }
            }
            Console.WriteLine($"You do not have an item called '{itemName}' in your inventory.");
        }
        public static void ListenItem(string command)
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("You have no items in your inventory to listen to.");
                return;
            }
            string itemName = "a";
            while (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "my")
            {
                if (command == "")
                {
                    Console.WriteLine($"I understood you as far as wanting to {actionWord}.");
                    return;
                }
                itemName = "";
                int charPos = 0;
                foreach (char c in command)
                {
                    charPos++;
                    if (c != ' ')
                    {
                        itemName += c;
                    }
                    else if (itemName != "a" && itemName != "the" && itemName != "an" && itemName != "my" && itemName != "")
                    {
                        itemName += c;
                    }
                    if (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "my")
                    {
                        try
                        {
                            if (command[charPos] != ' ')
                            {

                                command = command.Substring(charPos);
                                break;
                            }
                        }
                        catch
                        {
                            command = "";
                        }
                    }
                }
            }
            foreach (Item item in inventory)
            {
                if (itemName == item.itemName.ToLower())
                {
                    Console.WriteLine(item.listenText);
                    return;
                }
            }
            Console.WriteLine($"You do not have an item called '{itemName}' in your inventory.");
        }
        public static void ExamineCommand(string command) // Things you can examine are: Items, Enemies, and Squares
        {
            string itemName = "a";
            while (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "my" || itemName == "this")
            {
                if (command == "")
                {
                    Console.WriteLine($"I understood you as far as wanting to {actionWord}.");
                    return;
                }
                itemName = "";
                int charPos = 0;
                foreach (char c in command)
                {
                    charPos++;
                    if (c != ' ')
                    {
                        itemName += c;
                    }
                    else if (itemName != "a" && itemName != "the" && itemName != "an" && itemName != "my" && itemName != "this" && itemName != "")
                    {
                        itemName += c;
                    }
                    if (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "my" || itemName == "this")
                    {
                        try
                        {
                            if (command[charPos] == ' ')
                            {

                                command = command.Substring(charPos);
                                break;
                            }
                        }
                        catch
                        {
                            command = "";
                        }
                    }
                }
            }
            if (playerSquare.enemy != null && (itemName == playerSquare.enemy.name.ToLower() || itemName == "enemy"))
            {
                Console.WriteLine(playerSquare.enemy.examineText);
                return;
            }
            if (itemName == "area" || itemName == "here")
            {
                Console.WriteLine(playerSquare.locationText);
                if (playerSquare.box != null)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"There is the {playerSquare.box.boxName} in this area.");
                    playerSquare.box.square = playerSquare;
                }
                if (playerSquare.inventory.Count > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("This area contains:");
                    foreach (Item item in playerSquare.inventory)
                    {
                        Console.WriteLine($"  - {item.itemName}.");
                    }
                }
                return;
            }
            foreach (Item item in inventory)
            {
                if (item.itemName.ToLower() == itemName)
                {
                    Console.WriteLine(item.examineText);
                    return;
                }
            }
            Console.WriteLine($"{itemName} is not something that you can examine.");
        }
        public static void AttackCommand(string command, Enemy enemy)
        {
            if (inventory.Count == 0) // If the player's inventory is empty
            {
                if (playerEnergy >= 2) // If the player has enough energy to punch the enemy
                {
                    playerEnergy -= 2;
                    enemy.health--;
                    Console.WriteLine($"You don't have any items on you, so you punched {enemy.name} instead.");
                    return;
                }
                Console.WriteLine($"You don't have any items, or enough energy to punch {enemy.name}.");
                endTurn = false;
                return;
            }
            bool hasWeapon = false;
            foreach (Item item in inventory)
            {
                if (item.GetType() == knife.GetType())
                {
                    hasWeapon = true;
                }
            }
            if (!hasWeapon) // If the player doesn't have a weapon
            {
                if (playerEnergy >= 2) // If the player has enough energy to punch the enemy
                {
                    playerEnergy -= 2;
                    enemy.health--;
                    Console.WriteLine($"You don't have any weapons on you, so you punched {enemy.name} instead.");
                    return;
                }
                Console.WriteLine($"You don't have any weapons, or enough energy to punch {enemy.name}.");
                endTurn = false;
                return;
            } // The player has a weapon in their inventory at this point
            string itemName = "a";
            while (itemName == "a" || itemName == "with" || itemName == enemy.name.ToLower() || itemName == "an" || itemName == "my" || itemName == "the" || itemName == "using" || itemName == "her" || itemName == "him" || itemName == "them")
            {
                if (command == "")
                {
                    Console.WriteLine("You need to specify which weapon you want to use.");
                    endTurn = false;
                    return;
                }
                itemName = "";
                int charPos = 0;
                foreach (char c in command)
                {
                    charPos++;
                    if (c != ' ')
                    {
                        itemName += c;
                    }
                    else if (itemName != "a" && itemName != "with" && itemName != enemy.name.ToLower() && itemName != "an" && itemName != "my" && itemName != "the" && itemName != "using" && itemName != "her" && itemName != "him" && itemName != "them" && itemName != "")
                    {
                        itemName += c;
                    }
                    if (itemName == "a" || itemName == "with" || itemName == enemy.name.ToLower() || itemName == "an" || itemName == "my" || itemName == "the" || itemName == "using" || itemName == "her" || itemName == "him" || itemName == "them")
                    {
                        try
                        {
                            if (command[charPos] == ' ')
                            {
                                command = command.Substring(charPos);
                                break;
                            }
                        }
                        catch
                        {
                            command = "";
                        }
                    }
                }
            } // At this point, the player has inputted a word that isn't a filler word
            foreach (Item item in inventory)
            {
                if (item.GetType() == knife.GetType() && item.itemName.ToLower() == itemName) // If the item is a weapon and it is the item the player specified
                { // We have the weapon that the player wants to attack the enemy with at this point
                    Weapon weapon = (Weapon)item;
                    if (playerEnergy < weapon.nrgCost) // If the player doesn't have enough energy to use the weapon
                    {
                        Console.WriteLine($"You don't have enough energy to use your {weapon.itemName}");
                        return;
                    } // At this point, the player can use their weapon
                    playerEnergy -= weapon.nrgCost;
                    enemy.health -= weapon.damage;
                    Console.WriteLine($"You attacked {enemy.name} with the {weapon.itemName}, using {weapon.nrgCost} energy to damage for {weapon.damage} hp.");
                    return;
                }
            } // At this point, the word the player entered was not a weapon
            Console.WriteLine($"{itemName} is not something you can use to attack.");
            endTurn = false;
        }
        public static void EatCommand(string command)
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("You have no items in your inventory to eat.");
                endTurn = false;
                return;
            }
            bool hasFood = false;
            foreach (Item item in inventory)
            {
                if (item.GetType() == apple.GetType())
                {
                    hasFood = true;
                }
            }
            if (!hasFood)
            {
                Console.WriteLine("You have no food to eat.");
                endTurn = false;
                return;
            }
            string itemName = "a";
            while (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "my")
            {
                if (command == "")
                {
                    Console.WriteLine($"I understood you as far as wanting to {actionWord}.");
                    endTurn = false;
                    return;
                }
                itemName = "";
                int charPos = 0;
                foreach (char c in command)
                {
                    charPos++;
                    if (c != ' ')
                    {
                        itemName += c;
                    }
                    else if (itemName != "a" && itemName != "the" && itemName != "an" && itemName != "my" && itemName != "")
                    {
                        itemName += c;
                    }
                    if (itemName == "a" || itemName == "the" || itemName == "an" || itemName == "my")
                    {
                        try
                        {
                            if (command[charPos] == ' ')
                            {

                                command = command.Substring(charPos);
                                break;
                            }
                        }
                        catch
                        {
                            command = "";
                        }
                    }
                }
            }
            foreach (Item item in inventory)
            {
                if (item.GetType() == apple.GetType() && item.itemName.ToLower() == itemName)
                {
                    Food food = (Food)item;
                    food.Eat(null);
                    return;
                }
            }
            Console.WriteLine($"{itemName} is not an eatable item that you have.");
            endTurn = false;
        }
        public static int RNG(int min, int max)
        {
            int rnd;
            Random num = new Random();
            rnd = num.Next(min, max + 1);
            return rnd;
        }
        public static string RandomJumpText()
        {
            return RNG(1, 10) switch
            {
                1 => "You jumped, it looked great, nothing happened.",
                2 => "What was the point of that?",
                3 => "...",
                4 => "?",
                5 => "Your mind works in mysterious ways.",
                6 => "How High?",
                7 => "Great song, but what has that got to do with this?",
                8 => "That was pointless.",
                9 => "In the words of David Tennant, 'WHAT?!'",
                10 => "You need help.",
                _ => "null",
            };
        }
        public static string RandomName()
        {
            return RNG(1, 30) switch // Needs to be one word
            {
                1 => "Bob",
                2 => "Steve",
                3 => "Jeff",
                4 => "Jeremiah",
                5 => "Karen",
                6 => "Sarah",
                7 => "Finnguala",
                8 => "Polydeukes",
                9 => "Rita",
                10 => "Georgina",
                11 => "Rehav'am",
                12 => "Allon",
                13 => "Asta",
                14 => "Skyler",
                15 => "Monika",
                16 => "Raman",
                17 => "Singh",
                18 => "Trahan",
                19 => "Jose",
                20 => "Alfred",
                21 => "Lygma",
                22 => "Wilfred", 
                23 => "Doris",
                24 => "Ncuti",
                25 => "Jessica",
                26 => "Chloe",
                27 => "Ashad",
                28 => "Ace",
                29 => "David",
                30 => "Sacha",
                _ => "null"
            };
        }
        public static void ShowStats()
        {
            Console.WriteLine("");
            Console.WriteLine($"Your Health: {playerHealth}hp / {maxPlayerHealth}hp");
            Console.WriteLine($"Your Energy: {playerEnergy}");
            Console.WriteLine($"{playerSquare.enemy.name}'s Health: {playerSquare.enemy.health}hp / {playerSquare.enemy.maxHealth}hp");
            Console.WriteLine($"{playerSquare.enemy.name}'s Energy: {playerSquare.enemy.energy}");
            Console.WriteLine($"{playerSquare.enemy.name}'s Attack Damage: {playerSquare.enemy.damage}");
        }
        public static void EnemyTurn(Enemy enemy) // Enemies can wait, heal, blindly attack, eat, attack.
        {
            if (enemy.isWaiting)
            {
                Console.WriteLine($"{enemy.name} is waiting...");
                enemy.energy += 5;
                enemy.isWaiting = false;
                return;
            }
            if (RNG(1, 5) == 2) // 20% Chance to Blindly Attack
            {
                Console.WriteLine($"{enemy.name} blindly attacked you!");
                playerHealth -= enemy.damage / 2;
                return;
            }
            if (enemy.energy < 3) // Wait or Eat when on low energy
            {
                if (RNG(0, 1) == 1) // 50% Chance to Attempt to Eat
                {
                    foreach (Item item in enemy.loot)
                    {
                        if (item.GetType() == apple.GetType())
                        {
                            Food food = (Food)item;
                            if (food.maxHealthIncrease != 0) // If the food is a Max Health Food
                            {
                                continue;
                            }
                            food.Eat(enemy);
                            return;
                        }
                    }
                }
                enemy.isWaiting = true;
                Console.WriteLine($"{enemy.name} has decided to wait next turn.");
                return;
            }
            if (enemy.health <= enemy.maxHealth / 2) // When enemy health is below or equal to half
            {
                if (RNG(0, 1) == 1) // 50% Chance to Heal
                {
                    enemy.energy -= 3;
                    enemy.health += 3;
                    Console.WriteLine($"{enemy.name} is using 3 energy to heal 3 health points.");
                    return;
                }
                enemy.energy -= 2;
                playerHealth -= enemy.damage;
                Console.WriteLine($"{enemy.name} attacked you for {enemy.damage} hp.");
                return;
            }
            if (RNG(1, 4) == 3 && enemy.health != enemy.maxHealth) // 25% Chance to Heal
            {
                enemy.energy -= 3;
                if (enemy.health >= enemy.maxHealth - 3)
                {
                    enemy.health = enemy.maxHealth;
                }
                else
                {
                    enemy.health += 3;
                }
                Console.WriteLine($"{enemy.name} is using 3 energy to heal 3 health points.");
                return;
            }
            enemy.energy -= 2;
            playerHealth -= enemy.damage;
            Console.WriteLine($"{enemy.name} attacked you for {enemy.damage} hp.");
        }
        public static void AddInventory(params Item[] items) // Adds an undisclosed number of items to the player's inventory
        {
            foreach (Item item in items)
            {
                inventory.Add(item);
            }
        }
        public static void SaveGame(string fileName)
        {
            TextWriter tw = File.CreateText($"{fileName}.txt");
            tw.WriteLine("DO NOT MESS WITH THIS FILE OR YOUR SAVE WILL BE RUINED!!!!");
            tw.WriteLine(permaDeath);
            tw.WriteLine(playerName); // Player's Name
            tw.WriteLine(inventory.Count); // Inventory Count
            foreach (Item item in inventory) // Inventory Content
            {
                tw.WriteLine(item.itemName);
            }
            tw.WriteLine(row); // Player's Row
            tw.WriteLine(column); // Player's Column
            tw.WriteLine(playerSquare.roomNum); // Current Location
            tw.WriteLine(inCombat); // If in Combat
            foreach (Enemy enemy in enemies) // Enemy Variables
            {
                tw.WriteLine(enemy.name); // Enemy Name
                tw.WriteLine(enemy.health); // Enemy Health
                tw.WriteLine(enemy.maxHealth); // Enemy Max Health
                tw.WriteLine(enemy.damage); // Enemy Damage
                tw.WriteLine(enemy.energy); // Enemy Energy
                tw.WriteLine(enemy.isWaiting); // Is Enemy Waiting
                tw.WriteLine(enemy.loot.Count); // Enemy's Loot Count
                foreach (Item item in enemy.loot) // Enemy's Loot
                {
                    tw.WriteLine(item.itemName);
                }
            }
            tw.WriteLine(playerHealth); // Player's Health
            tw.WriteLine(maxPlayerHealth); // Player's Max Health
            tw.WriteLine(playerEnergy); // Player's Energy
            foreach (Box box in boxes) // Box Variables
            {
                tw.WriteLine(box.boxName); // Temporary
                tw.WriteLine(box.square.row); // Box's Row
                tw.WriteLine(box.square.column); // Box's Column
                tw.WriteLine(box.square.roomNum); // Box's Location
                tw.WriteLine(box.isUnlocked); // Is Box Unlocked
                tw.WriteLine(box.hasVisited); // Has the Player Visited
                tw.WriteLine(box.inventory.Count); // Box's Inventory Count
                foreach (Item item in box.inventory) // Box's Inventory
                {
                    tw.WriteLine(item.itemName);
                }
            }
            tw.WriteLine(isUp); // Is the Player on a Box
            tw.WriteLine(gameDifficulty.ToString()); // Game Difficulty
            tw.WriteLine(reminders.Count); // Reminders Count
            foreach (string reminder in reminders) // Reminders
            {
                tw.WriteLine(reminder);
            }
            foreach (Square square in caveRoomA) // Update per room
            {
                tw.WriteLine(square.roomComplete); // Is Room Complete
                tw.WriteLine(square.beenVisited); // Has Player Visited
                tw.WriteLine(square.inventory.Count); // Inventory Count
                foreach (Item item in square.inventory) // Inventory
                {
                    tw.WriteLine(item.itemName);
                }
            }
            foreach (Square square in caveRoomB)
            {
                tw.WriteLine(square.roomComplete); // Is Room Complete
                tw.WriteLine(square.beenVisited); // Has Player Visited
                tw.WriteLine(square.inventory.Count); // Inventory Count
                foreach (Item item in square.inventory) // Inventory
                {
                    tw.WriteLine(item.itemName);
                }
            }
            foreach (Square square in caveRoomC)
            {
                tw.WriteLine(square.roomComplete); // Is Room Complete
                tw.WriteLine(square.beenVisited); // Has Player Visited
                tw.WriteLine(square.inventory.Count); // Inventory Count
                foreach (Item item in square.inventory) // Inventory
                {
                    tw.WriteLine(item.itemName);
                }
            }
            tw.Close();
        }
        public static void LoadGame(string fileName)
        {
            TextReader tr = new StreamReader($"{fileName}.txt");
            tr.ReadLine();
            if (bool.Parse(tr.ReadLine()))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThis Save File is unplayable.");
                Console.ForegroundColor = ConsoleColor.White;
                ParseAction("quit", "");
            }
            gameLoaded = true;
            playerName = tr.ReadLine(); // Player's Name
            inventory.Clear();
            int invCount = Convert.ToInt32(tr.ReadLine()); // Inventory Count
            for (int i = 0; i < invCount; i++) // Inventory Content
            {
                string name = tr.ReadLine();
                foreach (Item item in items)
                {
                    if (name == item.itemName)
                    {
                        inventory.Add(item);
                    }
                }
            }
            row = Convert.ToInt32(tr.ReadLine()); // Player's Row
            column = Convert.ToInt32(tr.ReadLine()); // Player's Column
            switch (tr.ReadLine()) // Current Location
            {
                case "1": // Update per room
                    playerSquare = caveRoomA[row, column];
                    break;
                case "2":
                    playerSquare = caveRoomB[row, column];
                    break;
                case "3":
                    playerSquare = caveRoomC[row, column];
                    break;
            }
            inCombat = bool.Parse(tr.ReadLine()); // If in Combat
            foreach (Enemy enemy in enemies) // Enemy Variables
            {
                enemy.name = tr.ReadLine(); // Enemy Name
                enemy.health = Convert.ToInt32(tr.ReadLine()); // Enemy Health
                if (enemy.health <= 0)
                {
                    enemy.square.enemy = null;
                }
                enemy.maxHealth = Convert.ToInt32(tr.ReadLine()); // Enemy Max Health
                enemy.damage = Convert.ToInt32(tr.ReadLine()); // Enemy Damage
                enemy.energy = Convert.ToInt32(tr.ReadLine()); // Enemy Energy
                enemy.isWaiting = bool.Parse(tr.ReadLine()); // Is Enemy Waiting
                enemy.loot.Clear();
                int lootCount = Convert.ToInt32(tr.ReadLine()); // Enemy's Loot Count
                for (int i = 0; i < lootCount; i++) // Enemy's Loot
                {
                    string word = tr.ReadLine();
                    foreach (Item item in items)
                    {
                        if (word == item.itemName)
                        {
                            enemy.loot.Add(item);
                        }
                    }
                }
            }
            playerHealth = Convert.ToInt32(tr.ReadLine()); // Player's Health
            maxPlayerHealth = Convert.ToInt32(tr.ReadLine()); // Player's Max Health
            playerEnergy = Convert.ToInt32(tr.ReadLine()); // Player's Energy
            foreach (Box box in boxes)
            {
                tr.ReadLine(); // Temporary
                int otherRow = Convert.ToInt32(tr.ReadLine()); // Box's Row
                int otherColumn = Convert.ToInt32(tr.ReadLine()); // Box's Column
                switch(tr.ReadLine()) // Box's Location
                {
                    case "1": // Update per room
                        box.square = caveRoomA[otherRow, otherColumn];
                        break;
                    case "2":
                        box.square = caveRoomB[otherRow, otherColumn];
                        break;
                    case "3":
                        box.square = caveRoomC[otherRow, otherColumn];
                        break;
                }
                box.isUnlocked = bool.Parse(tr.ReadLine()); // Is Box Unlocked
                box.hasVisited = bool.Parse(tr.ReadLine()); // Has Player Visited
                box.inventory.Clear();
                int boxCount = Convert.ToInt32(tr.ReadLine()); // Box's Inventory Count
                for (int i = 0; i < boxCount; i++) // Box's Inventory
                {
                    string name = tr.ReadLine();
                    foreach (Item item in items)
                    {
                        if (name == item.itemName)
                        {
                            box.inventory.Add(item);
                        }
                    }
                }
            }
            isUp = bool.Parse(tr.ReadLine()); // Is the Player on a Box
            switch(tr.ReadLine()) // Game Difficulty
            {
                case "EASY":
                    gameDifficulty = Difficulty.EASY;
                    break;
                case "NORMAL":
                    gameDifficulty = Difficulty.NORMAL;
                    break;
                case "HARD":
                    gameDifficulty = Difficulty.HARD;
                    break;
            }
            int reminderCount = Convert.ToInt32(tr.ReadLine()); // Reminder Count
            for (int i = 0; i < reminderCount; i++) // Reminders
            {
                reminders.Add(tr.ReadLine());
            }
            foreach (Square square in caveRoomA) // Update per room
            {
                square.inventory.Clear();
                square.roomComplete = bool.Parse(tr.ReadLine()); // Is Room Complete
                square.beenVisited = bool.Parse(tr.ReadLine()); // Has Player Visited
                int count = Convert.ToInt32(tr.ReadLine()); // Inventory Count
                for (int i = 0; i < count; i++) // Inventory
                {
                    string name = tr.ReadLine();
                    foreach (Item item in items)
                    {
                        if (name == item.itemName)
                        {
                            square.inventory.Add(item);
                        }
                    }
                }
            }
            foreach (Square square in caveRoomB)
            {
                square.inventory.Clear();
                square.roomComplete = bool.Parse(tr.ReadLine()); // Is Room Complete
                square.beenVisited = bool.Parse(tr.ReadLine()); // Has Player Visited
                int count = Convert.ToInt32(tr.ReadLine()); // Inventory Count
                for (int i = 0; i < count; i++) // Inventory
                {
                    string name = tr.ReadLine();
                    foreach (Item item in items)
                    {
                        if (name == item.itemName)
                        {
                            square.inventory.Add(item);
                        }
                    }
                }
            }
            foreach (Square square in caveRoomC)
            {
                square.inventory.Clear();
                square.roomComplete = bool.Parse(tr.ReadLine()); // Is Room Complete
                square.beenVisited = bool.Parse(tr.ReadLine()); // Has Player Visited
                int count = Convert.ToInt32(tr.ReadLine()); // Inventory Count
                for (int i = 0; i < count; i++) // Inventory
                {
                    string name = tr.ReadLine();
                    foreach (Item item in items)
                    {
                        if (name == item.itemName)
                        {
                            square.inventory.Add(item);
                        }
                    }
                }
            }
            tr.Close();
        }
    }
}
