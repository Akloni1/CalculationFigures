using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationFigures
{
    public class Triangle : ITriangle
    {
        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        /// <summary>
        /// Метод вычисляет площадь тренугольника
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public double Area()
        {
            if (IsTriangleExists())
            {
                double perimeter = _side1 + _side2 + _side3;
                double s = perimeter / 2;
                double area = Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
                return area;
            }
            else
            {
                throw new ArgumentException("Треугольник с заданными сторонами не может существовать");
            }

        }

        /// <summary>
        /// Метод определяет существует ли треугольник с заданными сторонами
        /// </summary>
        /// <returns></returns>
        private bool IsTriangleExists()
        {
            if (_side1 + _side2 > _side3 && _side1 + _side3 > _side2 && _side2 + _side3 > _side1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Метод определяет прямоугольный треугольник или нет
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public bool IsRightTriangle()
        {
            if (IsTriangleExists())
            {
                if (_side1 * _side1 + _side2 * _side2 == _side3 * _side3
                  || _side1 * _side1 + _side3 * _side3 == _side2 * _side2
                  || _side2 * _side2 + _side3 * _side3 == _side1 * _side1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new ArgumentException("Треугольник с заданными сторонами не может существовать");
            }
        }


    }
}
