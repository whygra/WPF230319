using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF230319.Models.Figures
{
    public class Cylinder : IVolumetric
    {
        public Cylinder(double r, double height)
        {
            Radius = r;
            Height = height;
        }

        public Cylinder() : this(2, 3) { }


        // радиус основания
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

        // высота
        double _height;
        public double Height
        {
            get => _height;
            set
            {
                if (value <= 0)
                    throw new Exception("Получено недопустимое значение");
                _height = value;
            }
        }


        public double CalcSurfaceArea() => Math.PI * _radius * 2 * (_height + _radius);
        public double CalcVolume() => Math.PI * _radius * _radius * _height;

        // строковое представление
        public override string ToString()
        {
            return
                $"Цилиндр: \nРадиус основания: {Radius:n2}; \nВысота: {Height:n2t}; \n" +
                $"Площадь поверхности: {CalcSurfaceArea():n2}; \nОбъем: {CalcVolume():n2}";
        }
    }
}
