/*User Input
Console.WriteLine("What's your name?");
String name = Console.ReadLine();
Console.WriteLine("What's your age?");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Hello {name}");
Console.WriteLine($"Your current age is {age}");
Console.WriteLine($"Thank you {name} you can GTFO now! :)");
*/

/*Arithmetics
Console.WriteLine("What's your number of friends?");
int friends = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Hi stranger you currently have {friends} friends");
friends += 5;
friends -= 3;
friends *= 2;
friends /= 4;
Console.WriteLine($"Hi stranger after a while you currently have {friends} friends");
*/

/*Math Class
double x = 5;
double y = 3;
double a = Math.Pow(x, 2);
Console.WriteLine(a);
double b = Math.Sqrt(x);
Console.WriteLine(b);
double c = Math.Abs(x);
Console.WriteLine(c);
double d = Math.Max(x, y);
Console.WriteLine(d);
double e = Math.Min(x, y);
Console.WriteLine(e);
*/

/*Random Numbers
Random random = new Random();

int num1 = random.Next(1, 7);
int num2 = random.Next(1, 7);
int num3 = random.Next(1, 7);
Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);
*/

/*Hypotenuse Calculator
Console.WriteLine("Please enter A side");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter B side");
double B = Convert.ToDouble(Console.ReadLine());
double C = Math.Sqrt((A * A) + (B * B));
Console.WriteLine($"The Hypotenuse is {C}");
*/

/*Strings Methods
string fullName = "Dionis Senja";
Console.WriteLine(fullName.ToUpper());
Console.WriteLine(fullName.ToLower());
fullName = fullName.Insert(0, "Mr.");
Console.WriteLine(fullName);

string phoneNumber = "123-465-7890";
phoneNumber = phoneNumber.Replace("-", "");
Console.WriteLine(phoneNumber);
*/

/* If Statements
Console.WriteLine("Please enter your name: ");
String name = Console.ReadLine();

if (name == "")
{
    Console.WriteLine("You did not enter your name!");
}
else
{
    Console.WriteLine("Hello " + name);
}
*/

/*Switches 
  Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday!");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday!");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday!");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday!");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday!");
                    break;
                default:
                    Console.WriteLine(day + " is not a day!");
                    break;
            }

 */

/*While Loops
      String name = "";

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

Console.WriteLine("Hello " + name);
 */

/*For Loops
for (int i=0; i<10; i++)
{
    Console.WriteLine("Happy New Year Motherfuckers!");
}
*/

/*Neseted Loops*/
for (int i=0; i<=4; i++)
{
    for(int j=0; j<=i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}






