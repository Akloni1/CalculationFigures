using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationFigures
{
    public interface ITriangle: IFigure
    {
        /// <summary>
        /// Метод определяет прямоугольный треугольник или нет
        /// </summary>
        /// <returns></returns>
        bool IsRightTriangle();
    }
}
