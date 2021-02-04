using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Figure.Models
{
    public class Triangle : Figure
    {
        /// <summary>
        /// Сторона A
        /// </summary>
        public double SideA { get; }
        /// <summary>
        /// Сторона B
        /// </summary>
        public double SideB { get; }
        /// <summary>
        /// Сторона C
        /// </summary>
        public double SideC { get; }
        /// <summary>
        /// Объявляем поле при необходимости
        /// </summary>
        private readonly Lazy<bool> isRectangular;
        /// <summary>
        /// true\false наличия прямого угла
        /// </summary>
        public bool IsRectangular => isRectangular.Value;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <exception cref="ArgumentOutOfRangeException">Если у стороны знак '-'</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0) throw new ArgumentOutOfRangeException("Сторона не может иметь знак '-'");
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            isRectangular = new Lazy<bool>(CheckRectangular);
        }
        /// <summary>
        /// Проверка на прямой угол
        /// </summary>
        /// <returns>true\false наличия прямого угла</returns>
        protected bool CheckRectangular()
        {
            if ((SideA * SideA + SideB * SideB == SideC * SideC) ||
                (SideA * SideA + SideC * SideC == SideB * SideB) ||
                (SideC * SideC + SideB * SideB == SideA * SideA)) return true;
            return false;
        }
        /// <summary>
        /// Расчет площади
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        protected override double CalculateArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            double areaOfTriangle = Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
            return areaOfTriangle;
        }
    }
}
