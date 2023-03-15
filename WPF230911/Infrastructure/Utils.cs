using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF230319.Infrastructure
{
    public static class Utils
    {
        // парсит вещественное число из текстбокса
        public static double ParseDouble(TextBox txb) =>
            Double.Parse(txb.Text);

        private static Random Random = new Random();

        // случайное число
        public static int GetRandom(int lo, int hi) =>
            Random.Next(lo, hi);

        // случайный элемент коллекции
        public static T GetRandom<T>(IEnumerable<T> collection) =>
            collection.ElementAt(GetRandom(0, collection.Count()));

    }
}
