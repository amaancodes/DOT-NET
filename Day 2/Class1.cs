//Mycode class library contains class1.cs
namespace MyCode{
    public class maths{
        public void callbyValue(ref int i, ref int j){
            int k;
            k = i;
            i = j;
            j = k;
            Console.WriteLine($"In my code value pof");
        }
    }
}

