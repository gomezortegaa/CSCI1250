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

const string PLAYERS_FILE = "players.txt";
const string POINTS_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;

//Look for the data files next to Progran.cs, howeever the program is started.
string projectFolder = Path.GetFullPath(
        Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
Directory.SetCurrentDirectory(projectFolder);

string[] players = File.ReadAllLines("players.txt");
string [] points = File.ReadAllLines("points.txt");

//Part 1: The Standings
Console.Write("PLAYERS".PadRight(11));
Console.WriteLine("POINTS".PadRight(11));

for(int i = 0; i < players.Length; i++)
{
    Console.WriteLine(players[i].PadRight(11) + points[i].PadRight(11));
}

int leader = LeaderIndex(points);
int seasontotal = TotalPoints(points);

Console.WriteLine("Leader: " + players[leader] + " with " + points[leader]);
Console.WriteLine("Season total: " + seasontotal);

//Part 2: Game Night



//Methods
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

static int TotalPoints(string[] points)
{
    int score = 0;
    foreach (string point in points)
    {
        score = score + Convert.ToInt32(point);
    }
    return score;
}