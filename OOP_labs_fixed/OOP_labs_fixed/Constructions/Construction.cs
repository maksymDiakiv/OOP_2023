using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_labs_fixed.Constructions.Models;

namespace OOP_labs_fixed.Constructions
{
    class Construction
    {
        public Construction(double height, double width, int entrances, int humanCapacity, BuildMaterialType buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }
        public Construction()
        {
            Height = 10;
            Width = 5;
            Entrances = 1;
            HumanCapacity = 140;
            BuildMaterial = BuildMaterialType.Wood;
        }
        public Construction(CreateConstructionDto input)
        {
            Height = input.Height;
            Width = input.Width;
            Entrances = input.Entrances;
            HumanCapacity = input.HumanCapacity;
            BuildMaterial = input.BuildMaterial;
        }
        public double Height { get; set; }
        public double Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public BuildMaterialType BuildMaterial
        {
            get
            {
                return _buildMaterial;
            }
            set
            {
                _buildMaterial = value;
                if (_buildMaterial == null)
                {
                    throw new ArgumentNullException("_buildMaterial cannot be an empty string");
                }
            }
        }
        private BuildMaterialType _buildMaterial;

        public double GetSquareCost()
        {
            if (BuildMaterial == BuildMaterialType.Brick)
            {
                return Width * Height * 0.9 * 0.8;
            }
            if (BuildMaterial == BuildMaterialType.Concrete)
            {
                return Width * Height * 0.9 * 0.87;
            }
            if (BuildMaterial == BuildMaterialType.Wood)
            {
                return Width * Height * 0.9 * 0.78;
            }
            return 0;
        }
    }
}