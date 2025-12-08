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


public class Meeting
{
    public static void SayHello(string name)
    {
        Console.WriteLine("Hello " + name);
    }
}


public class Program
{

    private static void Main(string[] args)
    {
        Meeting.SayHello("Alf");
        Meeting.SayHello("Joe");
    }
    
}