/*
 * Что бы код был понятен и хорошо выглядел, будем придерживаться реализации от интерфейса.
 * У нас будут классы фигур, которые будут наследоваться от этого интерфейса. Это нужно опять же для удобства кода 
 * и его расширяемости
 */
namespace AreaCalculator
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius) => this.radius = radius; // инициализируем конструктор таким образом


        public double CalculateArea() => Math.PI* radius * radius; // это наш метод по расчету

    }

    public class Triangle : IShape
    {
        private double sideA;
        private double sideB;
        private double sideC;


        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            Func<double> calculateAreaFunc = () =>
            {
                double semiPerimeter = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            };

            return calculateAreaFunc();
            /*
             * Тут я просто хотел показать что знаю о такой вещи, как делегат. Через лямбду мы просто заворачиваем 
             * тело метода в делегат Func. 
             * Разницы с реализацией без делегата толком нет, просто хотел показать технологию.
             */
        }

        public bool IsRightTriangle()
        {
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);

            double aSquare = sides[0] * sides[0];
            double bSquare = sides[1] * sides[1];
            double cSquare = sides[2] * sides[2];

            return Math.Abs(aSquare + bSquare - cSquare) <= double.Epsilon;
        }
    }
}
