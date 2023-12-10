using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_labs_fixed.Constructions
{
    class Construction
    {
        public Construction(double height, double width, int entrances, int humanCapacity, string buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }
        public double Height { get; set; }
        public double Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial
        {
            get
            {
                return _buildMaterial;
            }
            set
            {
                _buildMaterial = value;
                if (_buildMaterial == "")
                {
                    throw new ArgumentNullException("_buildMaterial cannot be an empty string");
                }
            }
        }
        private string _buildMaterial;
    }
}