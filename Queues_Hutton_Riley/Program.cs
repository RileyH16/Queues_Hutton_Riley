// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using Queues_Hutton_Riley;

//New game object with max players at 50 and current players at 49.
Game myGame = new Game(50, 49);

//Queue for Player objects.
Queue<Player> waitingToJoinQ = new Queue<Player>();

//4 Player objects, giving them 100 health and unique gamer tags.
Player p1 = new Player(100, "Juice");
Player p2 = new Player(100, "Butter");
Player p3 = new Player(100, "Flare");
Player p4 = new Player(100, "Numbchugga");

//all 4 player objects passing through the game and queue as arguments.
p1.JoinGame(myGame, waitingToJoinQ);
p2.JoinGame(myGame, waitingToJoinQ);
p3.JoinGame(myGame, waitingToJoinQ);
p4.JoinGame(myGame, waitingToJoinQ);

//Prints "Players in Queue" to console.
Console.WriteLine("Players in da Q:");
//Loops through the queue and print all the players on a new line.
foreach (Player player in waitingToJoinQ)
{
    Console.WriteLine(player);
}
//calls KickPlayer
myGame.KickPlayer();
//Calls CheckQueue
myGame.CheckQueue(waitingToJoinQ);

//prints "\nPlayers in Queue" to console.
Console.WriteLine("\nPlayers in da Q:");
//Loop through the queue and print all the players on a new line.
foreach (Player player in waitingToJoinQ)
{
    Console.WriteLine(player);
}