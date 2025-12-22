//public class Person
//{
//    public string Name { get; set; }

//    public static int PopulationCounter { get; set; } = 0;
//    //creating a constructor for the clss

//    public Person(string name) { 

//        Name = name;
//        PopulationCounter ++;

//    }

//}

//public class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Hello World");
//        Person p1 = new Person("Alf");
//        Person p2 = new Person("Elp");
//        Person p3 = new Person("Jay");
//        Console.WriteLine(p1.Name);
//        Console.WriteLine(p2.Name);
//        Console.WriteLine(p3.Name);
//        Console.WriteLine(Person.PopulationCounter);
//    }
//}



//****************************************static & nonstatic methods ***************************************

//public class Calculator
//{
//    public int Sum(int a, int b)
//    {
//        return a+b;
//    }

//    public static int Product(int a, int b)
//    {
//        return a*b;
//    }
//}


//public class Program
//{
//    public static void Main(string[] args) { 
//    Calculator calc = new Calculator();
//        int add= calc.Sum(1, 2);
//    int pd = Calculator.Product(1, 2);
//        Console.WriteLine(add);
//        Console.WriteLine(pd);

//    }
//}



//****************************************static methods in action ***************************************


//public class Meeting
//{
//    public static void SayHello(string name)
//    {
//        Console.WriteLine("Hello " + name);
//    }
//}


//public class Program
//{

//    private static void Main(string[] args)
//    {
//        Meeting.SayHello("Alf");
//        Meeting.SayHello("Joe");
//    }

//}


//****************************************INTERFACES ***************************************


//public interface IEnemy { 

//void Attack();
//void Defend();

//}

//public interface IWild
//{
//    void habitat();
//}

//// using interfaces to create abstractions
//public interface ITamedEnemy : IEnemy {
//    void Feed();
//    void Calm();


//}


//// implementing the interface

//class Dragon : IEnemy 
//{
//    public void Attack() { Console.WriteLine(" Dragon Breathes fire"); }
//    public void Defend() { Console.WriteLine("Dragon Spreads wings"); }
//}

//class Vampire : IEnemy
//{
//    public void Attack()
//    {
//        Console.WriteLine("Vampire realeases its fangs");
//    }

//    public void Defend()
//    {
//        Console.WriteLine("Vampire dissapears in the air");
//    }
//}

//public class Dog : ITamedEnemy
//{
//    public void Attack()
//    {
//        throw new NotImplementedException();
//    }

//    public void Calm()
//    {
//        throw new NotImplementedException();
//    }

//    public void Defend()
//    {
//        throw new NotImplementedException();
//    }

//    public void Feed()
//    {
//        throw new NotImplementedException();
//    }
//}

//// using interface for multiple inheritance

//public class Lion : IEnemy, IWild
//{
//    public void Attack()
//    {
//        throw new NotImplementedException();
//    }

//    public void Defend()
//    {
//        throw new NotImplementedException();
//    }

//    public void habitat()
//    {
//        throw new NotImplementedException();
//    }
//}
//public class Program
//{
//    private static void Main (string[] args)
//    {
//        IEnemy e1 = new Dragon();
//        IEnemy e2 = new Vampire();
//        //e1.Attack();
//        //e2.Attack();
//        //e1.Defend();
//        //e2.Defend();

//        List<IEnemy> list = new List<IEnemy>();
//        list.Add(e1);
//        list.Add(e2);

//        foreach (IEnemy e in list) { 
//        e.Attack();
//            e.Defend();
//        }
//    }
//}


//****************************************PARTIAL CLASSES***************************************
// can be used to divide a class into different components

//public partial class Book// defining attributes
//{
//    public string title { get; set; }
//    public string description { get; set; }
//    public string author { get; set; }
//}

//public partial class Book // defining methods
//{
//    public void ShowInfo()
//    {
//        Console.WriteLine($"Title: {title}");
//        Console.WriteLine($"Description: {description}");
//        Console.WriteLine($"Author: {author}");
//    }

//}


//public class Program
//{
//    public static void Main( string[] args)
//    {
//        Book book1 = new Book();
//        book1.title = "Art of Programing";
//        book1.description = "A Beginners Programing Guide";
//        book1.author = "Linus Tovads";

//        book1.ShowInfo();

//    }
//}


//**************************************** IF STATEMENTS ***************************************



//if (1 == 2)
//{
//    Console.WriteLine("1 is equal to 1");
//}
//else
//{
//    Console.WriteLine("Condition is false");
//}   

//bool hasCat = false;

//if (hasCat)
//{
//    Console.WriteLine("Feed your cat");
//}
//else
//{
//    Console.WriteLine("Get a cat, cats are awesome");
//}
//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine("Enter your cat's weight in kgs:");
//int catWeight = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter your cat's age in years:");
//int catAge = int.Parse(Console.ReadLine());

//Console.ForegroundColor = ConsoleColor.Red;
//Console.BackgroundColor = ConsoleColor.White;

//if (catWeight <= 4)
//{

//    Console.WriteLine("Your cat is a small cat");
//    //nested if statement
//    if (catAge > 2) Console.WriteLine("Your cat is underweight, please feed it more");

//    else Console.WriteLine("Your cat is of normal weight");

//}
//else if(catWeight>4 && catWeight<6)
//{
//   Console.WriteLine("Your cat is a medium sized cat");
//}
//else
//{
//    Console.WriteLine("Your cat is a big cat");
//}

//Console.ResetColor();

//**************************************** SWITCH STATEMENTS ***************************************

//List<string> languages= [ "English", "Kiswahili", "Luo", "Hindu" ];
//List<string> greeting = ["Hello", "Habari", "Ber", "Namaste"];

//Console.WriteLine("Please Select a language:");
//Console.ForegroundColor = ConsoleColor.Red;
//languages.ForEach(lang => Console.WriteLine($"{languages.IndexOf(lang)}: {lang}"));

//Console.WriteLine("Enter your choice:");

//Console.ForegroundColor = ConsoleColor.Green;
//int choice = int.Parse(Console.ReadLine());

////try { Console.WriteLine($"{greeting[choice]}"); }
////catch (ArgumentOutOfRangeException)
////{
////    Console.ForegroundColor = ConsoleColor.Red;
////    Console.WriteLine("Invalid choice, please select a valid option");
////    Console.ResetColor();
////}

//// using switch statement
//string greet;

//switch (choice)
//{
//    case 0: greet = "Hello"; break;
//    case 1: greet = "Habari"; break;
//    case 2: greet = "Ber";break;
//    case 3: greet = "Namaste"; break;
//    default: greet = "Invalid Choice";  break;
//}

//Console.WriteLine(greet);

List<string> month = new List<string> { "Jan", "Feb", "Mar", "Apr", "May","Jun","Jul","Aug","Sep","Oct","Nov","Dec" };

Console.WriteLine("Select a Month:");
Console.ForegroundColor = ConsoleColor.Yellow;
month.ForEach(m => Console.WriteLine($"{month.IndexOf(m)+1}: {m}"));
Console.ResetColor();
Console.WriteLine("Enter your choice:");
Console.ForegroundColor = ConsoleColor.Green;
int choice = int.Parse(Console.ReadLine());
dynamic daysInMonth = "Not Valid";

switch (choice)
{
    case 2: daysInMonth = "28 OR 29 in a Leap Year"; break;
    case 1:
    case 3:
    case 5:
    case 7: 
    case 8: 
    case 10: 
    case 12: daysInMonth = 31; break;
    case 4: 
    case 6:
    case 9:
    case 11: daysInMonth = 30; break;
  
}
Console.WriteLine($"Number of days: {daysInMonth}");
Console.ResetColor();