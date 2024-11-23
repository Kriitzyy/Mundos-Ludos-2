using System;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Net.Quic;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using warmonsterclass; 

namespace displaymenu {

namespace warmonsterclass {
public class WarMonster {
    static public List<Enemy> Enemies = new List<Enemy>(); // List for the enemies
    public static void Main(string[] args) {

          int playerlevel = 0; // Start variables, user level
          int menuchoice;   // Switch choice
          bool userisplaying = true; // Boolean for user is playing
          bool hasweapon = false; // IF the user has a weapon
          bool firstTimeTheme = true;  // Display first theme

          Console.WriteLine("Please enter you're name:");
          string UserName = Console.ReadLine()!.ToLower(); // REading user input and convert to lower case 

            Player Player = new Player(UserName, 200, 100);  // The user name and health with damage 

             while (userisplaying) {// Boolean for while loop
                  Console.Clear(); // Clearing terminal

                  if (firstTimeTheme) { // Displaing the theme 1 time
                  Console.WriteLine($"Welcome to the WarMonster!!, {Player.Name} hopefully you'll have fun!");

                  Enemy.DisplayTheme(Player); // THe theme

                  firstTimeTheme = false; // False after displayed
                  }

                  Enemy.DisplayMenu(ref playerlevel, Player, ref hasweapon); // Displaying the manu
                  string PlayerChoice = Console.ReadLine()!.ToLower();// REading user input and convert to lower case 

                  if (int.TryParse(PlayerChoice, out menuchoice)) { // USed as error handling and converts string to int
                        switch (menuchoice) { // switch choice
                               case 1: 
                               Console.Clear();
                               if (playerlevel <= 3) { // if the user is under level 3
                                    Enemy.FightRatsAndMiniMonsters(ref playerlevel, Player, ref hasweapon); // method for fight
                               }
                               else {
                                    Console.WriteLine($"{Player.Name} are too strong to fight rats and mini monsters! 💪"); // if the user is too strong
                               }
                              break;

                               case 2:
                               Console.Clear();
                               if (playerlevel >= 3) { // If the user is over level 3
                                    Enemy.FightMonster(ref playerlevel, Player, ref hasweapon);
                              }
                              else {
                                    Console.WriteLine($"{Player.Name} need to be level 3 to fight Monsters! ⚠️"); // IF the user is too strong
                              }
                              break;

                              case 3:
                              Console.Clear();
                              Enemy.UserExperience(ref playerlevel); // displaying users level
                              break;
                              
                              case 4:
                              Console.Clear();
                              if (playerlevel >= 5) {
                                    Console.WriteLine($"{Player.Name} can now fight the final boss!🤼");  
                                    Enemy.FightFinalBoss(ref playerlevel, Player, ref hasweapon); // fucntion for the finalboss fight
                              }
                              else if (playerlevel <= 5) {
                                    Console.WriteLine($"{Player.Name} need to be level 5 to fight the final boss!🛠️"); // IF the user is not level 5
                              }
                              else {
                                    Console.WriteLine("Choose in the menu 1-6!"); // error handling
                              }
                              break;

                              case 5: 
                              Console.Clear();
                              Console.WriteLine("Here are the instructions:❗❓"); 
                              GameMenu.DisplayUserNeedHelp(Player); // Displaying instrunctions
                              break;

                              case 6:
                              userisplaying = false; // exit and ending the loop
                              Console.Clear(); 
                              Console.WriteLine("Exiting Warmonster...  ☹");
                              break;
                              
                              default: // Erro handling
                              Console.WriteLine("Start by choosing number 1 ❗❗"); 
                              break;
                        }
                  } 
                  else {
                        Console.WriteLine("Start by choosing numer 1! ❗❗"); // Erro handling
                  }   
                  Console.WriteLine($"\nPress any key to get to the menu {Player.Name}...."); // Until the user presses anything
                  Console.ReadKey(); // Until the user presses anything         
            }
         }   
      }
    }
 }