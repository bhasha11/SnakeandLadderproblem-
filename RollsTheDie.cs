using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackLadderP
{
    public class RollsTheDie
    {

            public int StartPoint = 0; 
            public int RanDice;
            public void StartPlaying()
            {
                Console.WriteLine("Game Started! Good Luck "); 
                Random Random = new Random(); 
                RanDice = Random.Next(1, 7); 
                Console.WriteLine("player Role Dice number is:" + " " + RanDice); 
            }
        }
    }


