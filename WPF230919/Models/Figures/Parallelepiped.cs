using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF230319.Models.Figures
{
    public class Parallelepiped : IVolumetric
    {
        public Parallelepiped(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public Parallelepiped() : this(2, 3, 4) { }


        // сторона A
        double _a;
        public double A
        {
            get => _a;
            set
            {
                if (value <= 0)
                    throw new Exception("Получено недопустимое значение");
                _a = value;
            }
        }

        // сторона B
        double _b;
        public double B
        {
            get => _b;
            set
            {
                if (value <= 0)
                    throw new Exception("Получено недопустимое значение");
                _b = value;
            }
        }

        // сторона C
        double _c;
        public double C
        {
            get => _c;
            set
            {
                if (value <= 0)
                    throw new Exception("Получено недопустимое значение");
                _c = value;
            }
        }


        public double CalcSurfaceArea() => (_a * _b + _a * _c + _b * _c) * 2;
        public double CalcVolume() => _a * _b * _c;


        // строковое представление
        public override string ToString()
        {
            return
                $"Прямоуг-й параллелепипед: \nСторона A: {A:n2}; \nСторона B: {B:n2}; \nСторона C: {C:n2}; \n" +
                $"Площадь поверхности: {CalcSurfaceArea():n2}; \nОбъем: {CalcVolume():n2}";
        }

    }
}
