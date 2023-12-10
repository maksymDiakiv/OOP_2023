using OOP_labs_fixed.Constructions;
using OOP_labs_fixed.Constructions.Models;
namespace OOP_labs
{
    class Program
    {
        static void Main(string[] args)
        {
            var construction = new Construction(50, 25, 4, 200, BuildMaterialType.Wood);
            var construction1 = new Construction();
            var input = new CreateConstructionDto()
            {
                BuildMaterial = BuildMaterialType.Wood,
                Width = 23,
                Height = 12,
                Entrances = 2,
                HumanCapacity = 2
            };

            //Console.WriteLine(construction.HumanCapacity);
            //new line for git
            //Console.WriteLine(construction.Entrances);
            //Console.WriteLine(construction.Entrances);
            Console.WriteLine(construction1.Entrances);
            Console.WriteLine(construction.BuildMaterial);
            Console.WriteLine(input.HumanCapacity);
            Console.WriteLine(construction.GetSquareCost());
        }
    }
}
