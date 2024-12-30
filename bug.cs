public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized can lead to unexpected behavior.
        Console.WriteLine(MyProperty); //Prints 0, but might be unexpected if no default is expected.
        MyProperty = 10; //Now assigned a value.
        Console.WriteLine(MyProperty); //Prints 10
    }
}