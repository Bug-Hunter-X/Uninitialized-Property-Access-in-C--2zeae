public class MyClass
{
    public int MyProperty { get; set; } = 0; // Explicit Initialization

    public void MyMethod()
    {
        // Accessing MyProperty after initializing
        Console.WriteLine(MyProperty); //Prints 0
        MyProperty = 10;
        Console.WriteLine(MyProperty); //Prints 10
    }
}