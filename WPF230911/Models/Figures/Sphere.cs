using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF230319.Models.Figures;

namespace WPF230319.Models.Figures
{
    public class Sphere : IVolumetric
    {

        public Sphere(double r)
        {
            Radius = r;
        }

        public Sphere() : this(5) { }


        // радиус
        double _radius;
        public double Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                    throw new Exception("Получено недопустимое значение");
                _radius = value;
            }
        }
        public double CalcSurfaceArea() => 4 * Math.PI * _radius * _radius;
        public double CalcVolume() => Math.PI * _radius * _radius * _radius / 3;

        // строковое представление
        public override string ToString()
        {
            return
                $"Сфера: \nРадиус: {Radius:n2}; \n" +
                $"Площадь поверхности: {CalcSurfaceArea():n2}; \nОбъем: {CalcVolume():n2}";
        }
    }
}
