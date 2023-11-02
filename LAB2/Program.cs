using System;
using LAB2.Constructions;
using LAB2.models;

namespace LAB2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var construction = new Construction(23, 45, 4, 6, BuildMaterialType.Concrete);
            var construction2 = new Construction();
            var input = new CreateConstructionDto() { 
                BuildMaterial = BuildMaterialType.Wood,
                Width = 23,
                Height = 10,
                HumanCapacity = 39,
                Entrances = 22
            
            
            };

            var construction3 = new CreateConstructionDto();
            Console.WriteLine(construction.Entrances);
            Console.WriteLine(construction2.Entrances);
            Console.WriteLine(construction.BuildMaterial);
            Console.WriteLine(construction2.BuildMaterial);
            Console.WriteLine(construction3.BuildMaterial);
        }
    }
}
