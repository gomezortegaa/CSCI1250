/*
 * Name:    Andy Gomez
 * Course:  CSCI 1250, Section 001
 * Assignment:  Lab 02, Trip Calculator
 * Date:    September 22, 2026
 * Description: Calculates the fuel, food, and work behind one road trip.
*/

/*
Part 1
*/

using System.Numerics;

Console.WriteLine ("=== Part 1: Road Trip ===");

Console.Write("How many miles did you travel? ");
int roundTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the mile per gallon for the car you travel on? ");
double milePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("What was the average price per gallon you paid? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = roundTrip / milePerGallon;

double fuelcost = gallonsNeeded * pricePerGallon;


Console.WriteLine ("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine ("Fuel cost: " + fuelcost.ToString("C"));



/*
Part 2
*/

Console.WriteLine ("=== Part 2: Pizza Party ===");

Console.Write ("How many people are going? ");
int attandance = Convert.ToInt32(Console.ReadLine());

Console.Write ("How many pizzas? ");
int pizzaboxes = Convert.ToInt32(Console.ReadLine());

Console.Write ("Price per pizza? ");
double pizzacost = Convert.ToDouble(Console.ReadLine());

const int pizzaslices = 8;

int totalslices = pizzaboxes * pizzaslices;

double slicesPer = totalslices / attandance;

double pizzatotal = pizzaboxes * pizzacost;


Console.WriteLine ("Total slices: " + totalslices);
Console.WriteLine ("Slices Per Person: " + slicesPer.ToString("F1"));
Console.WriteLine ("Pizza Cost:" + pizzatotal.ToString("C"));



/*
Part 3
*/

Console.WriteLine ("=== Part 3: Paycheck ===");

Console.Write ("How many hours have you worked? ");
int hoursWorked = Convert.ToInt32(Console.ReadLine()); 

Console.Write("How much do you get paid?");
decimal payrate = Convert.ToDecimal(Console.ReadLine());

const decimal taxrate = .18m;

decimal grosspay = hoursWorked * payrate;

decimal withheld = grosspay * taxrate;

decimal takehome = grosspay - withheld;


Console.WriteLine ("Gross Pay: " + grosspay.ToString("C"));
Console.WriteLine ("Tax withheld: " + withheld.ToString("C"));
Console.WriteLine ("Take Home Pay: " + takehome.ToString("C"));

/*
Part 4
*/

double tripTotal = fuelcost + pizzatotal;
decimal costper = Convert.ToDecimal(tripTotal / attandance);
decimal takehomeper = takehome / hoursWorked;
decimal hoursNeeded = costper / takehomeper;

Console.WriteLine ("=== Part 4: The Whole Trip ===");

Console.WriteLine ("Trip Total: " + tripTotal.ToString("C"));
Console.WriteLine ("Cost Per Person: " + costper.ToString("C"));
Console.WriteLine ("Take home pay per hour: " + takehomeper.ToString("C"));
Console.WriteLine ("Hours you must work to cover your share: " + hoursNeeded.ToString("C"));