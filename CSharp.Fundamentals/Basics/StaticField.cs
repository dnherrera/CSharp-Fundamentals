namespace CSharp.Fundamentals.Basics
{
    public class StaticField
    {
        static void Main(string[] args)
        {
            Area A = new Area(); // A - is an instance of a class. 
           // Console.WriteLine(A.PI); //This is because the PI is a static field. Static fields can only be accessed using the name of the class and not the instance of the class.
        }
    }

    class Area
    {
        public static double PI = 3.14;
    }
}
