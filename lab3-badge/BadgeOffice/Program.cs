Console.Write("What is your full name?");
string fullName = Console.ReadLine();
fullName = fullName.Trim();


int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);


string upperfirst = firstName.ToUpper();
string lowerlast = lastName.ToUpper();

string firstuser = upperfirst.Substring(3);


Console.WriteLine("Name on badge: " + upperfirst + " " + lowerlast);
Console.WriteLine ("Username: " + firstuser);





/*
Console.WriteLine("Name on badge:" + );
Console.WriteLine("Username" + username);
Console.WriteLine("Initials:" + initials)
Console.WriteLine("Letter in Last Name: " lastnameTotal)
*/