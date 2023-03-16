using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF230319.Models.Figures
{
    public interface IVolumetric
    {
        double CalcSurfaceArea();
        double CalcVolume();
    }
}
