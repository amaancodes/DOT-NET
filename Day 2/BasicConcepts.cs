/*Basic Concepts is the name of the console app which contains this Program cs file. 
This will contain the reference of the MyCode library as it depends on that class library.*/

namespace BasicConcepts{
    internal class Program{
        static void Main(string[] args){
            maths m = new maths();
            int i = 100;
            int j = 20;
            m.callbyValue(ref i,ref j);
            Console.WriteLine($"Value of i,{i}");
            Console.WriteLine($"Value of j,{j}");
            Console.WriteLine("-------------");
            
            int sq=m.CalculateSqSqRootCube(i, out double sqrt,out int cube);
            Console.WriteLine($"Square={sq}");
            Console.WriteLine($"Cube={cube}");
            Console.WriteLine($"Square Root={sqrt}");
            Console.WriteLine("-----------");

            Tuple<double,int,float,string> Empdata = Tuple.Create<double, int, float, string>(1234.5d,123,789.67f,"Falguni");
            Console.WriteLine(Empdata.Item1);
            Console.WriteLine(Empdata.Item2);
            Console.WriteLine(Empdata.Item3);
            Console.WriteLine(Empdata.Item4);


            object o;
            int val = 1089;
            o = val; //Boxing
            Console.WriteLine
            int b = int(o); //explicit casting to take the data from object and store it as integer.
        }
    }
}