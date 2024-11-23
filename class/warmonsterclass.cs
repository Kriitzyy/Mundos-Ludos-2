using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using warmonsterclass; 

    namespace warmonsterclass {
    public class Player { //Player class 
    public string Name { get; set; } // Player name 
    public int Health { get; set; } // HP
    public int Damage { get; set; } // Player damage

    public Player(string name, int health, int damage)
    {   // Properites
        Name = name;
        Health = health;
        Damage = damage;
    }
}

public class Enemy // Enemy class 
{
    public string Name { get; set; } // Enemy name 
    public int Health { get; set; } // HP
    public int Damage { get; set; } //Damage
    public static List<Enemy> Enemies = new List<Enemy>();  

    public Enemy(string name, int health, int damage)
    {   // properites 
        Name = name;
        Health = health;
        Damage = damage;
    }
      // fucntion for the menu
    static public void DisplayMenu(ref int playerlevel, Player Player, ref bool hasweapon) {// Playerlevel, Player, And weapon is used in fucntion

            GameMenu.DisplayMainMenu(ref playerlevel, Player, ref hasweapon); // DIsplaying the main men
    }

    static public void DisplayTheme(Player player) { // DIsplaying the theme
            
            GameMenu.DisplayTheme(player); // Theme
    }
      // Function for the fight rats and mini monsters
      static public void FightRatsAndMiniMonsters(ref int playerlevel, Player Player, ref bool hasweapon) { // Playerlevel, Player, And weapon is used in fucntion

            Console.Clear();

            Enemy MiniMonster = new Enemy("Mini Monster", 50, 10 ); // ENemies used as objects (required)
            Enemy Rat = new Enemy("Rat", 30, 5); // ENemies used as objects (required)

            Enemies.Add(MiniMonster); // Adding enemies to list
            Enemies.Add(Rat); // Adding enemies to list

            Enemies.Clear();  

            Console.WriteLine("Which room do you want to enter? 'right' door or 'left' door?🚪");
            string LeftRightRoom = Console.ReadLine()!.ToLower(); // Reads user input and converts t0 lower cased 

            if (LeftRightRoom.ToLower() == "right") { // IF the user enters right room
                   Console.Clear();

                   Console.WriteLine("You have entered a treasure room! 💰"); 
                   playerlevel += 1; // Levels up one level for treasure find
                   Console.WriteLine($"\nYou found 50 gold coins, and gained {playerlevel} levels! 💰⬆️!"); // showing the experience gained
                   Console.WriteLine($"Current level is: {playerlevel}"); // Showing current level
            }
            else if (LeftRightRoom.ToLower() == "left") { // IF the user chooses left
                  Console.Clear();

                  Console.WriteLine("You have found a healing potion! 🧪"); 
                  Console.WriteLine("You have gained 2 experience aswell! ⬆️");

                  playerlevel += 2; // REcevies level
                  Player.Health += 10; // Receives HP

                  Console.WriteLine($"You're current health is: {Player.Health} ⛑️"); // Showing current health
            }
            else {
                  Console.WriteLine("Wrong input. Choose right or left door!"); // Eroor handling 
            }

            Console.WriteLine($"\nA {MiniMonster.Name} approaches with {MiniMonster.Health} HP and {MiniMonster.Damage} damage! 🐀🧟");
            Console.WriteLine($"A {Rat.Name} approaches with {Rat.Health} HP and {Rat.Damage} Damage 🐀🧟"); // Enemies approaching
            
            Console.WriteLine("\nType 'fight' if you want to fight ⚔️, or 'run' 🏃 if you want to run away: "); 
            string FightorRun = Console.ReadLine()!.ToLower(); // IF the user wants to fight or run. reads as lower cased

            if (FightorRun.ToLower() == "fight") { // IF the user fights
                    
                    Console.Clear();

                    Console.WriteLine($"You have been attacked by a {Rat.Name} 🐀 and a {MiniMonster.Name} 🧟‍♂️"); 
                    int AttackDamage = MiniMonster.Damage + Rat.Damage; // USer losing HP for attack
                    Player.Health -= AttackDamage;  // USer losing HP for attack

                    Console.WriteLine($"\nYou're current health is: {Player.Health} ⛑️"); // Current HP
            }
            else if (FightorRun.ToLower() == "run") { // IF the user flees

                  Console.Clear();

                  Console.WriteLine("You attempted to flee!🏃");

                  Player.Health -= 5;  // LOsses HP
                  Console.WriteLine($"\nYou took 5 damage while escaping! Your health is now: {Player.Health} 𓀒𓀒");
                  return; // sending the user back
            }
            else {
                  Console.WriteLine("Invalid input. choose between fighting or running!"); // ERror ha dling
            }

            Console.WriteLine("\nStill want to 'fight' ⚔️ or 'run'?  🏃");
            string UserInput = Console.ReadLine()!.ToLower(); // REads input and converts to lower cased

            if (UserInput.ToLower() == "fight") { // IF the user fights

                  Console.Clear();
                  // DEFeating the enemy 
                  Console.WriteLine($"You have defeated the {Rat.Name} and the {MiniMonster.Name} 😵 💀");

                  Console.WriteLine($"\nYou're current level is: {playerlevel}");  // Current Level

                  Console.WriteLine($"You're current health is: {Player.Health} HP ⛑️"); // Current HP
            }
            else if (UserInput.ToLower() == "run") { // IF the user flee

                  Console.Clear();

                  Console.WriteLine("You have found a healing potion, while running!🧪");

                  Player.Health += 50; // For finding healing potion 50 + HP

                  Console.WriteLine($"You have gained {Player.Health} HP ⛑️"); // Current health
                  return;
            }
            else {
                  Console.WriteLine("Invalid input. choose between fighting or running!"); // Error handling 
            }

            Console.WriteLine("\nYou have gained 3 levels! ⬆️"); 
            playerlevel += 3; // USer gains 3 levels
            Console.WriteLine($"You're current level is: {playerlevel} 📈"); // Current level
      }
      // Fucntion for Fight the monsters
      static public void FightMonster(ref int playerlevel, Player Player, ref bool hasweapon) { // Playerlevel, Player, And weapon is used in fucntion

            Console.Clear();

            Console.WriteLine("There are another door 'open' the door 🚪");
            string UserInput = Console.ReadLine()!.ToLower(); // Reads as lower cased 

            if (UserInput.ToLower() == "open") { // IF the user opens the door

                  Console.Clear();

                  Console.WriteLine("There's a weapon🔫 do you want to 'pick' it up or 'not'? ❌ ");
                  string PickWeapon = Console.ReadLine()!.ToLower(); // Reads as lower cased 

                  if (PickWeapon.ToLower() == "pick") { // If the user takes the weapon

                        Console.Clear();

                        Console.WriteLine("\nYou have a weapon 🔫"); 
                                                                        hasweapon = true;  // Boolean true for the weapn
                        Player.Damage += 5;  // Damage increased 5 +

                        Console.WriteLine($"\nYou're current damage is: {Player.Damage}🔫"); // Current damage 
                  }
                  else if (PickWeapon.ToLower() == "not") { // if the user doesnt take the weapon

                        Console.Clear();

                        Console.WriteLine($"{Player.Name} chose not to pick it up, you have lost damage! ⬇️"); 

                        Player.Damage -= 5;  // Looses damage

                        Console.WriteLine($"\n{Player.Name}'s current damage is: {Player.Damage}⬇️");// current damage
                  }
                  else {
                        Console.WriteLine("Wrong input. Do you want a weapon or not? "); // Error handling
                  }                  
            }

            Console.WriteLine(""); 
         
            Enemy Rat = new Enemy("Rat", 50, 5); // Enemies used as objetcs with Damage name and HP
            Enemy Monster = new Enemy("Monster", 100, 10); // Enemies used as objetcs damage name and HP

            Enemies.Add(Rat); // Adding enemies to list
            Enemies.Add(Monster); // Adding enemies to list

            Console.WriteLine($"\n A {Monster.Name} approaches with {Monster.Health} HP and {Monster.Damage} damage! 🧟");// enemies attacks
            Console.WriteLine($" A {Rat.Name} approaches with {Rat.Health} HP and {Rat.Damage} Damage 🐀"); // enemies attacks
            
            Console.WriteLine("\nDo you want to 'fight' ⚔️ or 'run'? 🏃");
            string UserFight = Console.ReadLine()!.ToLower(); // Reads user input as lowercased
                  // IF the user fights
                  if (UserFight.ToLower() == "fight") {

                  Console.Clear();

                  Console.WriteLine($"The {Monster.Name} and the {Rat.Name} Attacked you 💥");

                  int TotalDamage = Monster.Damage + Rat.Damage; // The user looses HP
                  Player.Health -= TotalDamage; // The user looses HP

                  Console.WriteLine($"You're current health is: {Player.Health} ⛑️"); // Current health 

                  Console.WriteLine("\n Do you want to 'confront'⚔️ the enemies or 'evande'? 🏃");
                  string FightOrRun = Console.ReadLine()!.ToLower();// Reads user input as lowercased

                  if (Player.Health == 0 ) { // If the users HP is 0

                        Console.Clear(); 

                        Console.WriteLine($" You have been defeated.. {Player.Name} better luck next time! ⛔");
                        // Users looses, Displaying Gameover theme
                        GameMenu.DisplayGameOver(ref playerlevel, Player, ref hasweapon); // Displaying game over menu
                        return; // sending the enemy back
                  } 
                  else if (FightOrRun.ToLower() == "confront") { // If the user confronts the enemy

                        Console.Clear();

                        Console.WriteLine($"You have defeated the {Monster.Name} and the {Rat.Name} ☠️ ⚔️");

                        playerlevel += 3; // USer receives 3 levels for defeating enemies

                        Console.WriteLine($"You're current health is {Player.Health} ⛑️"); // CUrrent HP
                  }
                  else if (FightOrRun.ToLower() == "evade") { // IF the users chooses to run

                        Console.Clear();
                        
                        Console.WriteLine("You have tripped and lost you're weapon 🔫❌");   
                        hasweapon = false; // looses weapon while tripping
                        return;
                  }
                  else {
                        Console.WriteLine("Fight or run? Choose. ❗❗"); // Error handling
                  }
            }
            else if (UserFight.ToLower() == "run") { // If the user runs
                  Console.Clear();
                  Console.WriteLine("You have tripped𓀒 and lost 10 damage, and 1 level... ⛔ ");

                  Player.Health -= 10; // Looses HP 
                  playerlevel -= 1; // Looses Level

                  Console.WriteLine($"\n Level is {playerlevel}📈 and {Player.Health} HP⛑️ "); // Current level and HP
                  return;
            }
            else {
                  Console.WriteLine("Fight or run? Choose.❗❗"); // Error handling
            }

            Console.WriteLine("\nYou have gained 2 points ⬆️⬆️");
            playerlevel += 2; // IF the user wins gains 2 levels
            Console.WriteLine($"You're current level is: {playerlevel}"); // current level
      }

      // Fucntion for current user level
      static public void UserExperience(ref int playerlevel) { // Playerlevel used 
            
            Console.WriteLine($"You're level is: {playerlevel} 📈"); // Users level
      }     

      static public void FightFinalBoss(ref int playerlevel, Player Player, ref bool hasweapon) { // Playerlevel, Player, And weapon is used in fucntion

            Console.Clear();

            Enemy FinalBoss = new Enemy("Final boss", 150, 30); // Finalboss as a object with HP and damage (required)

            Enemies.Add(FinalBoss); // Enemie in the list
 
            if (!hasweapon) { // IF the user doesnt have a weapon he cant fight the final boss
                  Console.WriteLine($"You can't fight {FinalBoss.Name} because you have lost you're weapon");
            }

            while (Player.Health > 0 && FinalBoss.Health > 0) { // While for if the user is 0 or the final boss is 0.

                  Console.WriteLine($"The {FinalBoss.Name} is attacking you with {FinalBoss.Damage} Damage ☢️💥"); // Damage attacked

                  Player.Health -= FinalBoss.Damage; // User looses HP for attack

                  Console.WriteLine($"You're current health: {Player.Health} ⛑️"); // Current HP

                  if (Player.Health < 0 ) {

                        Console.WriteLine($"You have been defeated by the {FinalBoss.Name}. Game over. ❌"); // IF the user looses

                        GameMenu.DisplayGameOver(ref playerlevel, Player, ref hasweapon); // Game over menu
                        return;
                  }

                  Console.WriteLine("\nYou're turn do you want to 'attack' or 'heal'?⛑️🔫");
                  string AttackorHeal = Console.ReadLine()!.ToLower(); // Reads as lower cased 

                  if (AttackorHeal.ToLower() == "attack") { // If the user attacks
                        Console.Clear();
                        FinalBoss.Health -= Player.Damage; // Finalboss loosing HP

                        Console.WriteLine($"You have attacked the {FinalBoss.Name}, dealing {Player.Damage} damage to the boss!💥🔫");
                  }
                  else if (AttackorHeal.ToLower() == "heal") {  // IF the user heals
                       
                        Console.Clear();

                        Player.Health += 20; // receives HP

                        Console.WriteLine("You have gained 20 health! ⛑️");

                        Console.WriteLine($"\nYou're current health is: {Player.Health} ⛑️"); // Current HP
                  }
                

                  if (FinalBoss.Health <= 0) { // IF the user has 0 HP

                        Console.Clear();

                        Console.WriteLine($"You have defeated the {FinalBoss.Name}. Victory is yours 🏆");

                        playerlevel += 20;  // USer receives 20 levels for winnig the fight

                        Console.WriteLine($"\n 📈⬆️ You have gained {playerlevel} levels! ⬆️📈");

                        GameMenu.DisplayVictory();
                        return;
                  }
                 
                  Console.WriteLine($"The {FinalBoss.Name} attacks you for {FinalBoss.Damage} damage!💥");
                  Player.Health -= FinalBoss.Damage; // User attacked losing HP

                  Console.WriteLine($"\nYou're current health is: {Player.Health} ⛑️⛑️ "); // Current HP

                  if (Player.Health < 0) { // IF the user is 0 HP
                  
                        Console.WriteLine($"You have been defeated by the {FinalBoss.Name}. Game over. ⛔❌");

                        GameMenu.DisplayGameOver(ref playerlevel, Player, ref hasweapon); // display Gameover theme
                        return;
                  }
            }
      }

      static public void UserNeedHelp(Player Player) { // IF the user needs help

            GameMenu.DisplayUserNeedHelp(Player); // Displaying the help menu.
            
      }
   }
}
