using ExercicioResolvido_MetodoAbstrato.Entities.Enums;

namespace ExercicioResolvido_MetodoAbstrato.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
