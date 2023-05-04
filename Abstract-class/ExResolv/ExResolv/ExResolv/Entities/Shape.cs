using ExResolv.Entities.Enums;

namespace ExResolv.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }

        protected Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area();
    }
}
