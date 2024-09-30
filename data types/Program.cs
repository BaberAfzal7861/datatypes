namespace data_types
{
    internal class Program
    {
        //record/structure is a collection of data of different data types
        //to do this we have to set up a structure
        struct Town
        {
            // in here we haev to identify data that would be stored about a "town"
            //to do this we have to use public meanng its accesible from anywhere
            public string TownName;
            public int Population;
            public double Area;
            public string County;

            //in the brackets we need to identify the different things to make a town
            public Town(string tName, int tPop, double tArea, string tCounty)
            {
                TownName = tName;
                Population = tPop;
                Area = tArea;
                County = tCounty;

            }

        }
        
        static void Main(string[] args)
        {
            // how to define a variable
            // datatype identifier (optional assignment)
            // eg:
            // int = integer
            int myInteger;
            myInteger = 2147483647;
            Console.WriteLine(myInteger);
            Console.WriteLine(myInteger+myInteger);


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
            // adding two characters outputs the ASCII values of the characters
            char myChar = 'P';
            char myChar1 = 'U';
            Console.WriteLine(myChar + myChar1);


            // next one is string and this is a collection of characters
            // we identify a string with string and this is with double quotation marks
            string myString = "this is a string";
            string anotherstring = "So is this!";
            Console.WriteLine(myString+", "+anotherstring);
            Console.Write(myChar1+" , "+ anotherstring);
            //joining a string with a char outputs the string and the the letter instead of the string and then the ASCII value of the har
            // this is because we are just adding to a string
            // joing two strings is called concatenation


            // date/time 
            // allows you to use the date and the time 
            DateTime myDateTime = DateTime.Now;
            // datetime.now is called a method
            Console.WriteLine ("\x0A"+myDateTime);
            DateTime myDateTime1 = DateTime.Today;
            Console.WriteLine(myDateTime1);
            // you can also do this for year,month,day,hour,minute,second,millisecond 

            //records/structure
            // to implement we now have a new data type
            //we made this earlier and we named it Town
            // we have to allocate memory to this
            Town myTown = new Town();
            //now we can start adding data
            myTown.TownName = "Heckmondwike";
            myTown.Population = 40;
            myTown.Area = 300.5;
            myTown.County = "W Yorks";
            Console.WriteLine(myTown.TownName);
            Console.WriteLine(myTown.Population);

            // you can do this all in one line of code making it easier for larger programs
            Town newTown = new Town("dewsbury",100,2500,"Yorkshire");
            Console.WriteLine(newTown.TownName);

            // final data type is arrays
            // an array is a collection of data of the same type
            // we opne an array by stating the data type and opening square brackets and then the identifer
            int[] someNums = { 5, 9, 4, 3, 9, 4, 9, 5, 4, 52 };
            // to access one of those values we need to use its index(position) which start at 0 so 5 is at index 0
            Console.WriteLine(someNums[0]);
            //that outputs 5




        }
    }
}