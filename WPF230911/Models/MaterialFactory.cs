using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WPF230319.Infrastructure;

namespace WPF230319.Models
{
    public static class MaterialFactory
    {
        public static readonly Material Steel = new Material("Сталь", 7.8);
        public static readonly Material Ice = new Material("Лёд", 0.9);
        public static readonly Material Granite = new Material("Гранит", 2.7);
        public static readonly Material Copper = new Material("Медь", 8.9);

        // коллекция материалов
        public static Material[] Materials = { Steel, Ice, Granite, Copper };

        // случайный материал
        public static Material GetRandom() =>
            Utils.GetRandom(Materials);
    }
}
