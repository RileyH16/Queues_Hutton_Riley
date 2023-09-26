using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Hutton_Riley
{
    class Game
    {
        //a property called, MaxPlayers with an automatic getter.
        public int MaxPlayers { get; }

        //a property called, CurrentPlayers with an automatic getter and setter.
        public int CurrentPlayers { get; set; }

        //a constructor that takes two int parameters, maxPlayers and currentPlayers.
        public Game(int maxP,int currentP)
        {
            //assigns parameters to the corresponding properties
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        //a method called, KickPlayer. In the body it decrements CurrentPlayers by 1.
        public void KickPlayer()
        {
            CurrentPlayers--;
        }

        //a method called, CheckQueue, that takes a Queue<Player> parameter.
        public void CheckQueue(Queue<Player> playerQueue)
        {
            //checks if CurrentPlayers is less than MaxPlayers
            if (CurrentPlayers < MaxPlayers)
            {
                //checks if the queue has elements in it.
                if (playerQueue.Count > 0)
                {
                    //Dequeues on the queue and increment current players by 1
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                //Else, prints "No Players in the Queue!".
                else
                {
                    Console.WriteLine("No players in the queue!");
                }
            }
        }
    }
}
