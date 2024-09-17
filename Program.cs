namespace AreaOfRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Length = 0.0f;
            float Breadth = 0.0f;
            float Area = 0.0f;

            
            Console.WriteLine("---Rectangle Area Calculator---");
            Console.WriteLine("");

            //READ Length
            Console.Write("Enter the length of the rectangle: ");
            Length = float.Parse(Console.ReadLine());

            //READ Breadth
            Console.Write("Enter the breadth of the rectangle: ");
            Breadth = float.Parse(Console.ReadLine());

            //COMPUTE Area as Length * Breadth
            Area = (Length * Breadth);

            //PRINT Area
            Console.WriteLine("The area of the rectangle is: " + Area);
            Console.WriteLine("End of the Program");

        }
    }
}
