namespace Datatypes
{
    internal class Datatypes
    {
        static void Main(string[] args)
        {
            /*
            Datatype ----- Range ----- Size ----- Type
            
            sbyte -----  -128 to 127 ----- 8 bit ----- Signed integer
            
            byte ----- 0 to 255 ----- 8 bit ----- Unsigned integer
            
            char ----- U+0000 to U+ffff ----- 16 bit ----- Unicode character
            
            short ----- -32,768 to 32,767 ----- 16 bit ----- Signed integer

            ushort ----- 0 to 65,535 ----- 16 bit ----- Unsigned integer

            int ----- -2,147,483,648 to 2,147,483,647 ----- 32 bit ----- Signed integer

            uint ----- 0 to 4,294,967,295 ----- 32 bit ----- Unsigned integer

            long ----- -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 ----- 64 bit ----- Signed integer

            ulong ----- 0 to 18,446,744,073,709,551,615 ----- 64 bit ----- Unsigned integer
             
            Boolean ----- false or true ----- 

             */

            // DataType Variable = Value;
            byte variable_byte = 250;
            sbyte variable_sbyte = -12;
            Boolean variable_bool = variable_sbyte < variable_byte;

            // "int.MinValue" returns minimum possible value of the integer datatype.
            // "int.MaxValue" returns maximum possible value of the integer datatype.
            /*Console.WriteLine("Rangs of int: {0} to {1}", int.MinValue, int.MaxValue);*/
            Console.WriteLine(variable_bool);
        }
    }
}
