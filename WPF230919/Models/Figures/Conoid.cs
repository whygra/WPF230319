using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF230319.Models.Figures
{
    public class Conoid : IVolumetric
    {

        public Conoid(double r1, double r2, double height)
        {
            R1 = r1;
            R2 = r2;
            Height = height;
        }

        public Conoid() : this(1, 2, 3) { }


        // радиус основания 1
        double _r1;
        public double R1
        {
            get => _r1;
            set
            {
                if (value <= 0)
                    throw new Exception("Получено недопустимое значение");
                _r1 = value;
            }
        }

        // радиус основания 2
        double _r2;
        public double R2
        {
            get => _r2;
            set
            {
                if (value <= 0)
                    throw new Exception("Получено недопустимое значение");
                _r2 = value;
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

        double DeltaR => Math.Abs(_r2 - _r1);

        // образующая
        public double L => Math.Sqrt(_height * _height + DeltaR * DeltaR);

        public double CalcSurfaceArea() => Math.PI * L * (_r1 + _r1);
        public double CalcVolume() => Math.PI * _height * (_r1 + _r2) * (_r1 + _r2) / 3;

        // строковое представление
        public override string ToString()
        {
            return 
                $"Конус: \nРадиус нижнего основания: {R1:n2}; \nРадиус верхнего основания: {R2:n2}; \nВысота: {Height:n2}; \n" +
                $"Площадь поверхности: {CalcSurfaceArea():n2}; \nОбъем: {CalcVolume():n2}";
        }
    }
}
