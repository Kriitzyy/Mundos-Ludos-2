using System;
namespace warmonsterclass {
    // With a own class 
    public static class GameMenu {
         // DIsplaying the menu in a own file
        public static void DisplayMainMenu(ref int playerlevel, Player Player, ref bool hasweapon) { // Fucntions used inside 

            Console.WriteLine("     ❗Choose an option:❗  ");

            Console.WriteLine("\n[1] - Fight rats and mini monsters! ⚔️ ");
            Console.WriteLine("[2] - Fight bigger monsters! ⚔️ ");
            Console.WriteLine("[3] - View Player Experience ⚔️ ");
            Console.WriteLine("[4] - Fight The Final Boss! ⚔️ ");
            Console.WriteLine("[5] - Need help? Get instructions. ❓");
            Console.WriteLine("[6] - Exit Warmonster... ⛔ ");

            Console.WriteLine($"\n        📉 {Player.Name} stats: 📈            "); // showing players stats
            Console.WriteLine($"Health: {Player.Health} ❤️  || Damage: {Player.Damage}  💥"); 
            Console.WriteLine($"Experience: {playerlevel} 📊  ||   Weapon: {(hasweapon ? "Yes" : "No")} 🔫❓");
        }
        // DIsplaying if the user needs help with instructions
        public static void DisplayUserNeedHelp(Player Player) {// Fucntions used inside 
            Console.WriteLine("#          📝 Instructions: How to Play 📝         ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("[1] Fight rats and mini monsters to gain levels.");
            Console.WriteLine("[2] Reach level 3 to fight bigger monsters.");
            Console.WriteLine("[4] At level 5, you can challenge the Final Boss!");
            Console.WriteLine("[5] - If you lose you're weapon you can't fight the finalboss!");
            Console.WriteLine("[6] View experience points to track progress.");

            Console.WriteLine($"\n      Good luck, {Player.Name}! 🏆  ");
        }
        // displaying the start theme
        public static void DisplayTheme(Player Player) {// Fucntions used inside 

            Console.WriteLine("\n┏┓┏┓┏┓╋╋╋╋╋╋╋╋╋╋╋╋╋╋╋┏┓");
            Console.WriteLine("┃┃┃┃┃┃╋╋╋╋╋╋╋╋╋╋╋╋╋┏┛┗┓");
            Console.WriteLine("┃┃┃┃┃┣━━┳━┳┓┏┳━━┳━┓┏━┻┓┏╋━━┳━┓");
            Console.WriteLine("┃┗┛┗┛┃┏┓┃┏┫┗┛┃┏┓┃┏┓┫━━┫┃┃┃━┫┏┛");
            Console.WriteLine("┗┓┏┓┏┫┏┓┃┃┃┃┃┃┗┛┃┃┃┣━━┃┗┫┃━┫┃");
            Console.WriteLine(" ┗┛┗┛┗┛┗┻┛┗┻┻┻━━┻┛┗┻━━┻━┻━━┻┛ ");
            Console.WriteLine(" ⚔️   Adventure Awaits!  ⚔️ ");
        }
        // Function for the victory
        public static void DisplayVictory() {

            Console.WriteLine("\n\n  _    _ _    _                   ");
            Console.WriteLine(" | |  | (_)    | |                    ");
            Console.WriteLine(" | |  | |_  ___| |_ ___  _ __ _   _   ");
            Console.WriteLine(" | |/\\| | |/ __| __/ _ \\| '__| | | ");
            Console.WriteLine(" \\  /\\  / | (__| || (_) | |  | |_| ");
            Console.WriteLine("  \\/  \\/|_|\\___|\\__\\___/|_|   |");
            Console.WriteLine("                               __/ |  ");
            Console.WriteLine("                              |___/   ");
        }
        // Fucntion for game over
        public static void DisplayGameOver(ref int playerlevel, Player Player, ref bool hasweapon) {// Fucntions used inside 

            Console.WriteLine("\n⛔❌ GAME OVER ❌⛔");
            Console.WriteLine("      ▄███████████▄         ");
            Console.WriteLine("    ▄██▀▀▀▀▀▀▀▀▀▀▀▀██▄      ");
            Console.WriteLine("  ▄█▀                   ▀█▄  ");
            Console.WriteLine(" ▀                       ▀   ");
            Console.WriteLine(" ⛔  Better luck next time! ⛔");

               
            Console.WriteLine("\nFinal Stats:");
            Console.WriteLine($"- Level: {playerlevel}");
            Console.WriteLine($"- Health: {Player.Health} HP");
            Console.WriteLine($"- Damage: {Player.Damage}");

            int UserChoice; // User choice
            bool EndGame = true; // 
            Console.WriteLine("Do you want to 'play' again or 'not'? ⚔️ "); 
            string UserInput = Console.ReadLine()!.ToLower(); // Reading user input, and convert to lower case

            if (UserInput == "play") { // If the user wants to play
                Console.Clear();
                // Here we can display the theme and main menu again
                GameMenu.DisplayTheme(Player);
                GameMenu.DisplayMainMenu(ref playerlevel, Player, ref hasweapon);
            }
            else if (UserInput == "not") {
                Console.WriteLine("Exiting Warmonster have a great time.... ☹️");
                EndGame = false; // Ending the game
                return; // ends the game
            }
    else {
        Console.WriteLine("Invalid input, ensure typing the right input!");
        
      }
    }

  }

 }
  
