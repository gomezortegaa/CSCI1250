/*
* Name: Andy Gomez Ortega
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

Console.Write("What is your full name?");

string? fullName = Console.ReadLine();
fullName = fullName.Trim();

Random rng = new Random();

//Part 1: The Name

string firstName, lastName, upperfirst, upperlast, firstuser, username, firstinitial, secondinitial, initials, lastlength, name;
int spacePosition;

spacePosition = fullName.IndexOf(" ");
firstName = fullName.Substring(0, spacePosition);
lastName = fullName.Substring(spacePosition + 1);

upperfirst = firstName.ToUpper();
upperlast = lastName.ToUpper();

name = upperfirst + " " + upperlast;

firstuser = firstName.Substring(0,1);
username = firstuser.ToLower() + lastName.ToLower();

firstinitial = firstName.Substring(0,1);
secondinitial = lastName.Substring(0,1);
initials = firstinitial + "." + secondinitial + ".";

lastlength = Convert.ToString(lastName.Length);

Console.WriteLine("Name on badge: " + name);
Console.WriteLine ("Username: " + username);
Console.WriteLine ("Initials: " + initials.ToUpper());
Console.WriteLine ("Letters in last name: " + lastlength);

//Part 2: The Numbers

int studentID;
string lockerNumber;

studentID = rng.Next(100000, 999999);
lockerNumber = Convert.ToString(rng.Next(1, 500));

Console.WriteLine("StudentID: " + studentID);
Console.WriteLine("Locker: " + lockerNumber);

//Part 3: The Walk

double dormx, dormy, classx, classy, fps, distance;

Console.WriteLine ("What's the X distance from your dorm?");
dormx = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("What's the Y distance from your dorm?");
dormy = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("What's the X distance to your classroom?");
classx = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("What's the Y distance to your classroom?");
classy = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(dormx - classx,2) + Math.Pow (dormy - classy,2));
Console.WriteLine ("Distance: " + distance.ToString("F1"));

//The Time

int fulltime, mins, secs;
string walktime;

Console.WriteLine ("What's your walking speed in feet per second?");
fps = Convert.ToDouble(Console.ReadLine());

fulltime = Convert.ToInt32(distance / fps);

mins = fulltime / 60;

secs = fulltime % 60; 

walktime = mins + " Min " + secs + " Sec";

Console.WriteLine("Walk Time: " + walktime);

//Part 4: The Badge

int checkdigit;
string fullID;

checkdigit = studentID % 9;
fullID = studentID + "-" + checkdigit;

Console.WriteLine("==================================");
Console.WriteLine("ETSU STUDENT BADGE".PadLeft("ETSU STUDENT BADGE".Length + 8));
Console.WriteLine("==================================");

Console.WriteLine("NAME" + name.PadLeft(name.Length + 6));
Console.WriteLine("USERNAME" + username.PadLeft(username.Length + 2));
Console.WriteLine("ID" +  fullID.PadLeft(fullID.Length + 8));
Console.WriteLine("Locker" + lockerNumber.PadLeft(lockerNumber.Length + 4));
Console.WriteLine("Walk" + walktime.PadLeft(walktime.Length + 6));
Console.WriteLine("==================================");