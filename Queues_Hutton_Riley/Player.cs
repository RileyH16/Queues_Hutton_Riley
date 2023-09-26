using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Hutton_Riley
{
    class Player
    {
        //a property called Health with automatic getters and setters
        public int Health { get; set; }

        //a property called GamerTag, with an automatic getter
        public string GamerTag { get; }

        //a constructor that takes one int parameter and one string parameter.
        public Player(int healthParam, string nameParam)
        {
            //Assigns the parameters to the corresponding properties
            Health = healthParam;
            GamerTag = nameParam;
        }

        //a public method called JoinGame, that takes two parameters. One of type Game and one of type Queue<Player>.
        public void JoinGame(Game game, Queue<Player> queue)
        {
            //If the game's current players is equal to the max players, then it will add 'this' player to the queue.
            if (game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this);
            }
            //Else, prints "Joining Game" and increase current players by 1.
            else
            {
                Console.WriteLine("Joining Game!");
                game.CurrentPlayers++;
            }
        }

        //Override the ToString method and return GamerTag.
        public override string ToString()
        {
            return GamerTag;
        }
    }
}
