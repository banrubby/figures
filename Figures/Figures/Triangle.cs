namespace Figures
{
    public class Triangle : AbstrackFigure
    {
        private readonly decimal a;
        private readonly decimal b;
        private readonly decimal c;

        public override string Name => nameof(Triangle);
        public Triangle(decimal a, decimal b, decimal c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool IsRightTriangle => a * a == b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a;

        public override decimal CalulateSquare()
        {
            var p = (a + b + c) / 2;
            var temp = p * (p - a) * (p - b) * (p - c);
            return (decimal) Math.Sqrt((double)temp);
        }
    }
}
