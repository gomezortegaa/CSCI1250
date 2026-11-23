/*
* Name: Andy Gomez
* Course: CSCI 1250, Section 001
* Assignment: Lab 08, Game Night
* Date: November 21, 2026
* Description: Keeps a game night leaderboard in three text files. Shows the
* season so far, records tonight's points, saves the new totals,
* and adds tonight's result to a history that grows every week.
*/

using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Net;

const string PLAYERS_FILE = "players.txt";
const string POINTS_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;

//Look for the data files next to Progran.cs, however the program is started.
string projectFolder = Path.GetFullPath(
        Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
Directory.SetCurrentDirectory(projectFolder);

string[] players = File.ReadAllLines("players.txt");
string [] points = File.ReadAllLines("points.txt");
string[] history = File.ReadAllLines("history.txt");

int leader = LeaderIndex(points);
int seasontotal = TotalPoints(points);



int tonightNumber = history.Length + 1;


Console.WriteLine("=== GAME NIGHT LEADERBOARD ===");
if(history.Length == 0)
{
    
    Console.WriteLine("No Nights Played Yet");
}
else
{
    Console.WriteLine("Nights Played: " + history.Length);
    foreach (string night in history)
    {
        Console.WriteLine(" " + night);
    }
    
}
Console.WriteLine("Tonight Is Night " + tonightNumber + ".");

//Part 1: The Standings
Console.Write("PLAYERS".PadRight(11));
Console.WriteLine("POINTS".PadRight(11));

for(int i = 0; i < players.Length; i++)
{
    Console.WriteLine(players[i].PadRight(11) + points[i].PadRight(11));
}


Console.WriteLine("Leader: " + players[leader] + " with " + points[leader]);
Console.WriteLine("Season total: " + seasontotal);

//Part 2: Game Night

int bestScore = 0;
string winner = "";

//The For Loop, it uses the length for players to ask that many inputs, 
// The While loop, if its less than 0 or greater than 20 it asks for values between 0-20, so While those both conditions are true.
//the If statement just asks if the input score is greater than the bestScore than it makes that the new bestScore
for(int i = 0; i < players.Length; i++)
{
    Console.Write("Points tonight for " + players[i] + ": ");
    int tonight = Convert.ToInt32(Console.ReadLine());

    while(tonight < 0 || tonight > 20)
    {
        Console.WriteLine("Points must be from 0 to 20.");
        tonight = Convert.ToInt32(Console.ReadLine());
    }

    if(tonight > bestScore)
    {
        bestScore = tonight;
        winner = players[i];
    }

    int season = Convert.ToInt32(points[i]) + tonight;
    points[i] = season.ToString();
}

Console.WriteLine("Tonight's winner: " + winner + " with " + bestScore);

File.WriteAllLines(POINTS_FILE, points);
Console.WriteLine("Saved point.txt.");




//Methods

//The foor Loop finds the highest of scores, identifies it, then stores it.  It then stores its value under LeaderIndex
static int LeaderIndex(string[] points)
{
    int leader = 0;

    for (int i = 1; i < points.Length; i++)
    {
        if (Convert.ToInt32(points[i]) > Convert.ToInt32(points[leader]))
        {
            leader = i;
        }
        
    }
    return leader;
}

//ForEach Loop, for each value in the array, it adds to the score and equals to it, storing the value until called upon
static int TotalPoints(string[] points)
{
    int score = 0;
    foreach (string point in points)
    {
        score = score + Convert.ToInt32(point);
    }
    return score;
}

//The return just makes a string, it INTs night, winner, and points, when called it just takes the inputted values and puts it into the string.
static string HistoryEntry(int night, string winner, int points)
{
    return "Night " + night + ": " + winner + " won with " + points + " points" ;
}

string[] entry = { HistoryEntry(tonightNumber, winner, bestScore)};
File.AppendAllLines(HISTORY_FILE, entry);

Console.WriteLine("Added to history.txt: " + "Night " + history.Length + ": " + winner + " won with " + bestScore + " points");