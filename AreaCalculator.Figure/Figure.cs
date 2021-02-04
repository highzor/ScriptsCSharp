using System;

namespace AreaCalculator.Figure
{
    public abstract class Figure
    {
        /// <summary>
        /// Объявляем поле при необходимости
        /// </summary>
        private readonly Lazy<double> area;
        /// <summary>
        /// true\false наличия прямого угла
        /// </summary>
        public double Area => area.Value;
        /// <summary>
        /// Конструктор с площадью при необходимости
        /// </summary>
        protected Figure()
        {
            area = new Lazy<double>(CalculateArea);
        }
        /// <summary>
        /// Расчет площади
        /// </summary>
        /// <returns></returns>
        protected abstract double CalculateArea();
    }
}
