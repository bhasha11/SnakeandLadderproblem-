﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackLadderP
{
    public class CheckForOption
    {

            public int StartPoint = 0; 
            public int RanDice = 0;
            public int ComputerChoice;
            int Option = 0;
            
            public void StartPlaying()
            {
                Console.WriteLine("Game Started! Good Luck "); 
                Random Random = new Random(); 
                RanDice = Random.Next(1, 7); 
                Console.WriteLine("player Role Dice number is:" + " " + RanDice);
                ComputerChoice = Random.Next(0, 3);  
                Console.WriteLine("Dice value:" + ComputerChoice); 
                switch (ComputerChoice) 
                {
                    
                    case 0:                            
                        Console.WriteLine("No Play");
                        break;
                    case 1:                             
                        StartPoint += RanDice;          
                        Console.WriteLine("Got Ladder:" + StartPoint);
                        break;
                    case 2:                                 
                        StartPoint -= RanDice;           
                        Console.WriteLine("Snake Attack:" + StartPoint);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");  
                        break;
                }

            }
        }
    }


