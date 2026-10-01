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
