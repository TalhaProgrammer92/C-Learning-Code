namespace ReadingAndWriting
{
    internal class read_write
    {
        static void Main(string[] args)
        {
            // String variable
            /*string variable;*/
            
            // Print a message
            /*Console.WriteLine("Enter the value:");*/

            // Get value for the variable
            /*variable = Console.ReadLine();*/

            // Prints the value of the varaible - Method 1
            // Concatinate two strings
            /*Console.WriteLine("Value is " + variable);*/

            // Prints the value of the varaible - Method 2
            // Prints a formatted message to the console, displaying the value of a variable at the `{0}` placeholder.
            /*Console.WriteLine("Value is {0}", variable);*/
            
            /*
             In `Console.WriteLine("Value is {0}", variable);`, `{0}` isn't actually accepted as a value itself. It acts as a placeholder for the value you provide. Here's a breakdown:

* `"Value is {0}"`: This is a string literal containing text and a placeholder.
* `{0}`: This is a format specifier indicating where the value of the following argument will be inserted. The `0` refers to the **index (position)** of the argument in the function call.

**Why not another value?**

* It needs to be a placeholder for something to be inserted. Numbers like `1` or `2` wouldn't make sense in the string itself.
* The `0` specifically refers to the first argument (`variable`) passed to `Console.WriteLine` after the string literal. If there were more arguments, you'd use `{1}`, `{2}`, and so on, to reference them in order.

This approach allows for flexible formatting and easy insertion of different values without modifying the core message itself.
             */

            // Number
            int num1, num2, sum;

            // Get number
            Console.WriteLine("Enter 1st number:");
            // `int.Parse(string)` converts a string representation of an integer to an actual integer value.
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            num2 = int.Parse(Console.ReadLine());

            // Calculate the sum
            sum = num1 + num2;

            // Show the sum
            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
        }
    }
}
