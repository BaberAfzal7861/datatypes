namespace data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // how to define a variable
            // datatype identifier (optional assignment)
            // eg:
            // int = integer
            int myInteger;
            myInteger = 2147483647;
            Console.WriteLine(myInteger);
            // lowest 2^-31 and max is 2^31
            //real/float:
            //you have to put a captial F at the end of the number
            float myFloat = 0.579F;
            //higher precision of float is decimal but we have to put an m at the end
            decimal myDecimal = 1.342946m;
            // the best one to use is double we dont need a letter at the end
            double myDouble = 1.23456;
            //the next one on the list in boolean
            // we shoud always write boolean with a capital B so Boolean
            // in c sharp boolean is bool
            bool myBool = true;
            myBool = false;
            // the next one is character which is singular character and its
            // called in c sharp char and we reference them with a single speech mark
            char myChar = 'p';
            // next one is string and this is a collection of characters
            // we identify a string with string and this is with double quotation marks
            string myString = "this is a string";

        }
    }
}