using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationFigures
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            _radius = radius;
        }
        private readonly double _radius;
        private const double _pi = 3.14159;

        /// <summary>
        /// Метод вычисляет площадь круга
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public double Area()
        {
           var s = (_radius>0)? _pi * _radius *_radius : throw new ArgumentException("Круг с заданным радиусом не может существовать");
           return s;
        }
    }
}
