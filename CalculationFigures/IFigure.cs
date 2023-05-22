using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationFigures
{
    public interface IFigure
    {
        /// <summary>
        /// Расчитывает площать фигуры
        /// </summary>
        /// <returns></returns>
        double Area();
    }
}
