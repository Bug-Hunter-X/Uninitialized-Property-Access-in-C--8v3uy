public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that is not initialized can lead to unexpected behavior.
        int value = MyProperty; // This might throw an exception or return a default value, which may not be intended.
    }
}