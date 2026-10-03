Console.Write("What is your full name?");

string? fullName = Console.ReadLine();
fullName = fullName.Trim();

Random rng = new Random();

//Part 1: The Name


int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

string upperfirst = firstName.ToUpper();
string lowerlast = lastName.ToUpper();

string firstuser = firstName.Substring(0,1);
string username = firstuser + lastName;

string firstinitial = firstName.Substring(0,1);
string secondinitial = lastName.Substring(0,1);
string initials = firstinitial + "." + secondinitial + ".";

string lastlength = Convert.ToString(lastName.Length);

Console.WriteLine("Name on badge: " + upperfirst + " " + lowerlast);
Console.WriteLine ("Username: " + username.ToLower());
Console.WriteLine ("Initials: " + initials.ToUpper());
Console.WriteLine ("Letters in last name: " + lastlength);

//Part 2: The Numbers

int studentID = rng.Next(100000, 999999);
int lockerNumber = rng.Next(1, 500);

Console.WriteLine("StudentID: " + studentID);
Console.WriteLine("Locker: " + lockerNumber);

//Part 3: The Walk

double dormx, dormy, classx, classy, fps;

Console.WriteLine ("What's the X distance from your dorm?");
dormx = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("What's the Y distance from your dorm?");
dormy = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("What's the X distance to your classroom?");
classx = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("What's the Y distance to your classroom?");
classy = Convert.ToDouble(Console.ReadLine());



double distance = Math.Sqrt(Math.Pow(dormx - classx,2) + Math.Pow (dormy - classy,2));

Console.WriteLine ("Distance: " + distance.ToString("F1"));

//The Time

int fulltime, mins, secs;

Console.WriteLine ("What's your walking speed in feet per second?");
fps = Convert.ToDouble(Console.ReadLine());

fulltime = Convert.ToInt32(distance / fps);

mins = fulltime / 60;

secs = fulltime % 60; 

Console.WriteLine("Walk Time: " + mins + (" Min " + secs + " Sec"));

