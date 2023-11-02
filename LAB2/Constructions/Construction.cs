using LAB2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Constructions
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
            Height = 23;
            Width = 12;
            Entrances = 6;
            HumanCapacity = 5;
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
        public BuildMaterialType BuildMaterial { 
            get
            {
                return _buildMaterial;
            }
            set
            {
                //if(value == string.Empty)
                //{
                  //  throw new ArgumentNullException();
                //}
                //_buildMaterial = value;
            }
        }
        private BuildMaterialType _buildMaterial { get; set; }
    }
}
