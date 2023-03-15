using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF230319.Models
{
    // материал
    public class Material
    {
        // название материала
        public string Name { get; private set; }

        // плотность
        public double Density { get; private set; }

        public Material(string name, double density)
        {
            Name = name;
            Density = density;
        }
    }
}
