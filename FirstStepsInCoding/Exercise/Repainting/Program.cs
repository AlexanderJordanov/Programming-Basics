using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine()); 
            int paint = int.Parse(Console.ReadLine());  
            int diluent = int.Parse(Console.ReadLine());    
            int hours = int.Parse(Console.ReadLine());

            double sumMaterials = (nylon + 2) * 1.5 + (paint + paint * 0.1) * 14.5 + diluent * 5 + 0.4;

            Console.WriteLine(sumMaterials + ((sumMaterials * 0.3) * hours));
        }
    }
}
