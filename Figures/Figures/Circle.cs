namespace Figures
{
    public class Circle : AbstrackFigure
    {
        private readonly decimal radius;

        public override string Name => nameof(Circle);

        public Circle(decimal radious)
        {
            this.radius = radious;
        }

        public override decimal CalulateSquare()
        {
            return radius * radius * (decimal) Math.PI;
        }
    }
}
