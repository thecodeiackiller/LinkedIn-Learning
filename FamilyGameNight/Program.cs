using FamilyGameNight;
using System.ComponentModel;

Console.WriteLine("Hello, World!");

List<Player> playerList = new List<Player>();

playerList.Add(new Player("Kimbo", "Slice", 233, 211));
playerList.Add(new Player("Siddhartha", "Guatama", 200, 250));
playerList.Add(new Player("George", "Washington", 144, 132));
playerList.Add(new Player("Derek", "Jeter", 200, 178));
playerList.Add(new Player("Dua", "Lipa", 200, 300));

Player.filterPlayers(playerList, 10);




