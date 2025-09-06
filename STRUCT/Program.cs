using STRUCT;

internal class Program
{
    private static void Main(string[] args)
    {
        // Struct s = new Struct(10, 20);
        Struct s = new Struct(14, 20);

        s.Display();

        Rectangle r = new Rectangle();
        r.Width = 10;
        r.Height = 20;
        r.GetArea();

        //Struct and Class example
        BookStruct bs1 = new BookStruct("C# Programming", "John Doe");
        BookStruct bs2 = bs1; // Copying struct
        bs2.Title = "Java Programming"; // Modifying copy
        Console.WriteLine("Structs:");
        bs1.Display(); // Original remains unchanged
        bs2.Display(); // Copy reflects change


        BookClass bc1 = new BookClass("C# Programming", "John Doe");
        BookClass bc2 = bc1; // Copying class reference
        bc2.Title = "Java Programming"; // Modifying copy
        Console.WriteLine("Classes:");
        bc1.Display(); // Original reflects change
        bc2.Display(); // Copy reflects change
        Console.WriteLine(
            "Structs are value types and are copied on assignment, while classes are reference types and share the same reference on assignment."
        );

        //Enums
        TrafficLightSignal signal = new TrafficLightSignal();
        signal.ChangeColor();
        //signal.Display();
        

    }
}