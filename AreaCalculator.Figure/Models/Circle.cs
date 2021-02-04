using System;

namespace AreaCalculator.Figure.Models
{
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius { get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentOutOfRangeException">Если у радиуса знак '-'</exception>
        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException("Радиус не может иметь знак '-'");
            Radius = radius;
        }
        /// <summary>
        /// Расчет площади
        /// </summary>
        /// <returns>площадь окружности</returns>
        protected override double CalculateArea()
        {
            double areaOfCircle = Math.PI * Radius * Radius;
            return areaOfCircle;
        }
    }
}
