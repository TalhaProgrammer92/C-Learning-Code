namespace Float
{
    internal class FloatDatatypes
    {
        static void Main(string[] args)
        {
            /*
            Datatype ----- Size ----- .NET type ----- Precision (number of total digits)

            float ----- 32 bit ----- System.Single ----- 7

            double ----- 64 bit ----- System.Double ----- 15, 16

            decimal ----- 128 bit ----- System.Decimal ----- 28, 29
            */
            
            // Varaibles
            float variable_float = 123.31113f;                  // 'f' is compulsory
            double variable_double = 123.321654987d;             // 'd' is optional
            decimal variable_decimal = 45567.4235532534436m;    // 'm' is compulsory
            
            // Output
            Console.WriteLine("Float:\t\t{0}", variable_float);
            Console.WriteLine("Double:\t\t{0}", variable_double);
            Console.WriteLine("Decimal:\t{0}", variable_decimal);
        }
    }
}
