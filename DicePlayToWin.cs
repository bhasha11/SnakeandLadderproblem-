using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackLadderP
{
    public class DicePlayToWin
    {

            public int StartPoint = 0;
            public int RanDice = 0;
            public int count;
            public int randomeNumber;
            public string play = "";

            public int No_Play = 0;
            public int Ladder = 1;
            public int Snake = 2;
            public void StartPlaying()
            {
                Console.WriteLine("Game Started! Good Luck ");
                while (StartPoint != 100)  
                {

                    Random Random = new Random(); 
                    RanDice = Random.Next(1, 7); 
                    Console.WriteLine("player Role Dice number is:" + " " + RanDice);
                    randomeNumber = Random.Next(0, 3);  

                    if (randomeNumber == 0)
                    {
                        play = "No_Play";
                    }
                    else if (randomeNumber == 1)
                    {
                        play = "Ladder";
                    }
                    else if (randomeNumber == 2)
                    {
                        play = "Snake";
                    }
                    Console.WriteLine("Dice value:" + play); 
                    switch (play) 
                    {
                        case "No_Play":                            
                            Console.WriteLine("No Moves");
                            count++;
                            break;
                        case "Ladder":                            
                            StartPoint += RanDice;       
                            count++;
                            if (StartPoint > 100)           
                            {

                                StartPoint -= RanDice;    
                            }
                            Console.WriteLine("Position of the Player:" + StartPoint);
                            break;
                        case "Snake":                               
                            StartPoint -= RanDice;              
                            if (StartPoint < 0)                
                            {
                                StartPoint = 0;
                            }
                            Console.WriteLine("Snake Attack:" + StartPoint);
                            Console.WriteLine(StartPoint); 
                            break;
                        default:
                            Console.WriteLine("Invalid Option");  
                            break;
                    }
                   

                }
            Console.WriteLine("Dice Role to Win the Game is " + count);
        }
        }
    }

