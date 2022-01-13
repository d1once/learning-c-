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

/* While Loops
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

/*Neseted Loops
for (int i=0; i<=4; i++)
{
    for(int j=0; j<=i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
*/

/* Number Guessing Game

Random random = new Random();
bool playAgain = true;
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
string response;

while (playAgain)
{
    guess = 0;
    guesses = 0;
    response = "";
    number = random.Next(min, max + 1);

    while (guess != number)
    {
        Console.WriteLine($"Guess a number between {min} - {max} :");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Guess : {guess}");

        if (guess > number)
        {
            Console.WriteLine($"{guess} is to high");
        } else if (guess < number)
        {
            Console.WriteLine($"{guess} is to low");
        }

        guesses++;
    }

    Console.WriteLine($"Number {number}");
    Console.WriteLine("You Win!");
    Console.WriteLine($"Guesses {guesses}");

    Console.WriteLine("Do you like to play again? (Y/N): ");
    response = Console.ReadLine();
    response = response.ToUpper();
    if (response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }

    Console.WriteLine("Thanks for playing! ... I guess");
}
*/

/* ROCK PAPER SCISSORS

Random random = new Random();
bool playAgain = true;
String player;
String computer;
String answer;

while (playAgain)
{
    player = "";
    computer = "";
    answer = "";
    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {
        Console.WriteLine("Enter ROCK, PAPER or SCISSORS:");
        player = Console.ReadLine().ToUpper();
    }

    switch (random.Next(1, 4))
    {
        case 1:
            computer = "ROCK";
            break;
        case 2:
            computer = "PAPER";
            break;
        case 3:
            computer = "SCISSORS";
            break;
    }

    Console.WriteLine($"Player: {player}");
    Console.WriteLine($"Computer: {computer}");

    switch (player)
    {
        case "ROCK":
            if (computer == "ROCK")
            {
                Console.WriteLine("Draw");
            }
            else if(computer == "PAPER")
            {
                Console.WriteLine("You Lose");
            }
            else
            {
                Console.WriteLine("You Win");
            }
            break;
        case "PAPER":
            if (computer == "ROCK")
            {
                Console.WriteLine("You Win");
            }
            else if(computer == "PAPER")
            {
                Console.WriteLine("Draw");
            }
            else
            {
                Console.WriteLine("You Lose");
            }

            break;
        case  "SCISSORS":
            if (computer == "ROCK")
            {
                Console.WriteLine("You Lose");
            }
            else if(computer == "PAPER")
            {
                Console.WriteLine("You Win");
            }
            else
            {
                Console.WriteLine("Draw");
            }

            break;

    }

    Console.WriteLine("Do you like to play again (Y/N):");
    answer = Console.ReadLine().ToUpper();
    if (answer == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }

    Console.WriteLine("Arigatou!");
    
}
*/

/*Calculator APP
 do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.Write("Would you like to continue? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
            */

/*Arrays
// String[] cars = {"BMW", "Mustang", "Corvette"};
String[] cars = new string[3];
cars[0] = "Tesla";
cars[1] = "Mustang";
cars[2] = "Corvette";

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}
*/

/*Foreach loop
   // foreach loop = a simpler way to iterate over an array, but it's less flexible

            String[] cars = {"BMW", "Mustang", "Corvette"};

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
*/

/*Methods
// method  = performs a section of code, whenever it's called "invoked".
//           benefit = Let's us reuse code w/o writing it multiple times

String name = "Bro";
int age = 21;

SingHappyBirthday(name, age);

Console.ReadKey();
static void SingHappyBirthday(String birthdayBoy, int yearsOld)
{
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine("Happy birthday dear " + birthdayBoy);
    Console.WriteLine("You are " + yearsOld + " years old!");
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine();
}

*/

/*Return keyword

Console.WriteLine("Enter first number");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Multiply(x,y));

static int Multiply(int a, int b)
{
    return a * b;
}
*/




