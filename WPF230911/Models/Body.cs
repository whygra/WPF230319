using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF230319.Models.Figures;

namespace WPF230319.Models
{
    // тело
    public class Body
    {
        // конструктор
        public Body(IVolumetric figure, Material material)
        {
            Figure = figure;
            Material = material;
        }
        public Body() : this(new Sphere(), MaterialFactory.Steel) { }

        // материал тела
        public Material Material { get; set; }

        // форма тела
        // тип интерфейса - свойства фигуры конкретного типа будут недоступны
        public IVolumetric Figure { get; set; }

        // методы вычисления площади и объема вызывают методы фигуры (для удобства)
        public double CalcSurfaceArea() => Figure.CalcSurfaceArea();

        public double CalcVolume() => Figure.CalcVolume();

        // метод вычисления массы тела
        //                                        см3 * г/см3
        public double CalcMass() => Figure.CalcVolume() * Material.Density;

        public override string ToString()
        {
            return $"{Figure}; \nМатериал:{Material.Name}; \nПлотность:{Material.Density:n}; \nМасса:{CalcMass():n2}";
        }
    }
}
