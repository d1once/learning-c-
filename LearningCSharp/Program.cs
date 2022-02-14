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

/*Method overloading
// method overloading  = methods share same name, but different parameters
//                       name + parameters = signature
//                       methods must have a unique signature

double total;
            
total = Multiply(2, 3, 4);

Console.WriteLine(total);

static double Multiply(double a, double b)
{      
    return a * b;
}
static double Multiply(double a, double b, double c)
{
    return a * b * c;
}
*/

/*Params keyword
//params keyword = a method parameter that takes a variable number of arguments.
//                 The parameter type must be a single - dimensional array

double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

Console.WriteLine(total);

static double CheckOut(params double[] prices)
{
    double total = 0;

    foreach (double price in prices)
    {
        total += price;
    }
    return total;
}
*/


/*Exception keyword
//        try     = try some code that is considered "dangerous"
//        catch   = catches and handles exceptions when they occur
//        finally = always executes regardless if exception is caught or not

int x;
int y;
double result;

try
{
    Console.Write("Enter number 1: ");
    x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter number 2: ");
    y = Convert.ToInt32(Console.ReadLine());

    result = x / y;

    Console.WriteLine("result: " + result);
}
catch (FormatException e)
{
    Console.WriteLine("Enter ONLY numbers PLEASE!");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("You can't divide by zero! IDIOT!");
}
catch (Exception e)
{
    Console.WriteLine("Something went wrong!");
}
finally
{
    Console.WriteLine("Thanks for visiting!");
}
*/

/*Ternary operator

bool isRaining = false;
String sentence = String.Empty;

isRaining ? sentence = "Take an umbrella and FUCK OFF!" : sentence = "Go on freely buddy! :D";

Console.WriteLine(sentence);
*/

/*String Interpolation
String firstName = "Dionis";
String lastName = "Senja";
Console.WriteLine($"Hi my name is {firstName} {lastName}");
*/


/*Multidimensional  Arrays 
String[,] parkingLot = { {"Mustang", "F-150", "Explorer"},
                         {"Corvette", "Camaro", "Silverado"},
                        {"Corolla", "Camry", "Rav4"}
                        };
foreach(String car in parkingLot) {
    Console.WriteLine(car);
}
*/

/* Classes 

 static class Messages
    {
        public static void Hello()
        {
            Console.WriteLine("Hello! Welcome to the program");
        }
        public static void Waiting()
        {
            Console.WriteLine("I am waiting for something");
        }
        public static void Bye()
        {
            Console.WriteLine("Bye! Thanks for visiting");
        }
    }
*/

/*Objects
            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Rick";
            human1.age = 65;

            human2.name = "Morty";
            human2.age = 16;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
*/

/*Constructor 
Car car1 = new Car("Ford", "Mustang", 2022, "red");
Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

car1.Drive();
car2.Drive();

Console.ReadKey();

class Car
{
  String make;
  String model;
  int year;
  String color;

  public Car(String make, String model, int year, String color)
  {
    this.make = make;
    this.model = model;
    this.year = year;
    this.color = color;
  }

  public void Drive()
  {
    Console.WriteLine("You drive the " + make + " " + model);
  }
}
*/

/*Static
// static = modifier to declare a static member, which belongs to the class itself
//          rather than to any specific object

Car car1 = new Car("Mustang");
Car car2 = new Car("Corvette");
Car car3 = new Car("Lambo");

Console.WriteLine(Car.numberOfCars);
Car.StartRace();

Console.ReadKey();

class Car
{
    String model;
    public static int numberOfCars;

    public Car(String model)
    {
        this.model = model;
        numberOfCars++;
    }

    public static void StartRace()
    {
        Console.WriteLine("The race has begun!");
    }
}
*/

/*Overloaded Constructors
// overloaded constructors = technique to create multiple constructors,
//                           with a different set of parameters.
//                           name + parameters = signature

Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");

Console.ReadKey();


class Pizza
{
  String bread;
  String sauce;
  String cheese;
  String topping;

  public Pizza(String bread)
  {
    this.bread = bread;
  }
  public Pizza(String bread, String sauce)
  {
    this.bread = bread;
    this.sauce = sauce;
  }
  public Pizza(String bread, String sauce, String cheese)
  {
    this.bread = bread;
    this.sauce = sauce;
    this.cheese = cheese;
  }
  public Pizza(String bread, String sauce, String cheese, String topping)
  {
    this.bread = bread;
    this.sauce = sauce;
    this.cheese = cheese;
    this.topping = topping;
  }
}
*/

/*Inheritance
// inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent

Car car = new Car();
Bicycle bicycle = new Bicycle();
Boat boat = new Boat();

Console.WriteLine(car.speed);
Console.WriteLine(car.wheels);
car.go();

Console.WriteLine(bicycle.speed);
Console.WriteLine(bicycle.wheels);
bicycle.go();

Console.WriteLine(boat.speed);
Console.WriteLine(boat.wheels);
boat.go();

Console.ReadKey();

class Vehicle
{
  public int speed = 0;

  public void go()
  {
    Console.WriteLine("This vehicle is moving!");
  }
}
class Car : Vehicle
{
  public int wheels = 4;
}
class Bicycle : Vehicle
{
  public int wheels = 2;
}
class Boat : Vehicle
{
  public int wheels = 0;
}
*/

/*Abstract Classes
 // abstract classes =  modifier that indicates missing components or incomplete implementation

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            //Vehicle vehicle = new Vehicle(); //can't create a vehicle object

            Console.ReadKey();
    
    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
*/

/*Array of objects
Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

foreach (Car car in garage)
{
  Console.WriteLine(car.model);
}

Console.ReadKey();

class Car
{
  public String model;

  public Car(String model)
  {
    this.model = model;
  }
}
*/

/*Objects as arguments
  Car car1 = new Car("Mustang","red");

            Car car2 = Copy(car1);

            Console.WriteLine(car2.color + " " + car2.model);

            Console.ReadKey();
        

        public static void ChangeColor(Car car, String color)
        {
            car.color = color;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    
    class Car 
    {
        public String model;
        public String color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
*/

/*Method overriding
    //method overriding = provides a new version of a method inherited from a parent class
            //                    inherited method must be: abstract, virtual, or already overriden
            //                    Used with ToString(), polymorphism 

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadKey();
    class Animal 
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }
    class Cat : Animal
    {

    }
*/

/*To string method
Car car = new Car("Chevy", "Corvette", 2022, "blue");

Console.WriteLine(car.ToString());

Console.ReadKey();

class Car
{
  String make;
  String model;
  int year;
  String color;

  public Car(String make, String model, int year, String color)
  {
    this.make = make;
    this.model = model;
    this.year = year;
    this.color = color;
  }
  public override string ToString()
  {
    return "This is a " + make + " " + model;
  }
}
*/

/*Polymorphism
// polymorphism = Greek word that means to "have many forms"
//                Objects can be identified by more than one type
//                Ex. A Dog is also: Canine, Animal, Organism

Car car = new Car();
Bicycle bicycle = new Bicycle();
Boat boat = new Boat();

Vehicle[] vehicles = { car, bicycle, boat };

foreach (Vehicle vehicle in vehicles)
{
  vehicle.Go();
}

Console.ReadKey();

class Vehicle
{
  public virtual void Go()
  {

  }
}
class Car : Vehicle
{
  public override void Go()
  {
    Console.WriteLine("The car is moving!");
  }
}
class Bicycle : Vehicle
{
  public override void Go()
  {
    Console.WriteLine("The bicycle is moving!");
  }
}
class Boat : Vehicle
{
  public override void Go()
  {
    Console.WriteLine("The boat is moving!");
  }
}
*/

/*Interfaces
 // interface = defines a "contract" that all the classes inheriting from should follow

            //             An interface declares "what a class should have"
            //             An inheriting class defines "how it should do it"

            //             benefits = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();

            Console.ReadKey();
        interface IPrey
        {
            void Flee();
        }
        interface IPredator
        {
            void Hunt();
        }
        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!");
            }
        }
        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching for food!");
            }
        }
        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("The fish swims away!");
            }
            public void Hunt()
            {
                Console.WriteLine("The fish is searching for smaller fish!");
            }
        } 
*/
/*Lists

List<String> food = new List<String>();

food.Add("Pizza");
food.Add("Burger");

foreach (String item in food) {
   Console.WriteLine(item);
}
*/

/*Lists of object

List<Player> players = new List<Player>();

Player player1 = new Player("Ultra");
Player player2 = new Player("Giga");
Player player3 = new Player("Chad");

players.Add(player1);
players.Add(player2);
players.Add(player3);

foreach (Player player in players) {
    Console.WriteLine(player);
}


class Player {
    public String username;

    public Player(string username) {
        this.username = username;
    }
}
*/

/*Getter and setters

     //getters & setters = add security to fields by encapsulation
            //                    They're accessors found within properties

            // properties = combine aspects of both fields and methods (share name with a field)
            // get accessor = used to return the property value
            // set accessor = used to assign a new value
            // value keyword = defines the value being assigned by the set (parameter)
*/

/*Auto implemented properties
// Auto-Implemented properties =  shortcut when no additional logic is required in the property
//                                you do not have to define a field for a property,
//                                you only have to write get; and/or set; inside the property                             

Car car = new Car("Porsche");

Console.WriteLine(car.Model);

Console.ReadKey();

class Car
{
  public String Model { get; set; }

  public Car(String model)
  {
    this.Model = model;
  }
}
*/

/*Enums
 // enums = special "class" that contains a set of named integer constants.
            //         Use enums when you have values that you know will not change,
            //         To get the integer value from an item, you must explicitly convert to an int

            //         name = integer

            //Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
            //Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);

            String name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);

            Console.WriteLine("planet: " + name);
            Console.WriteLine("radius: " + radius +"km");
            Console.WriteLine("volume: " + volume +"km^3");

            Console.ReadKey();
        
        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    
    enum Planets
    {
        Mercury = 1, 
        Venus = 2, 
        Earth = 3, 
        Mars = 4, 
        Jupiter = 5, 
        Saturn = 6, 
        Uranus = 7, 
        Neptune = 8, 
        Pluto = 9
    }

    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
*/