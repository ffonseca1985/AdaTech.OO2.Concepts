namespace GenericsConcepts
{
    public abstract class Shape
    {
        public virtual double Area { get { return 0; } }
    }

    public class Circle : Shape
    {
        private double r;
        public Circle(double radius) { r = radius; }
        public double Radius { get { return r; } }
        public override double Area { get { return Math.PI * r * r; } }
    }

    //IComparer Tem a assinatura: IComparer<in T>, ou seja é contravariante
    public class ShapeAreaComparer<T> : IComparer<T> where T : Shape 
    {
        //int IComparer<Shape>.Compare(Shape a, Shape b)
        //{
        //    if (a == null) return b == null ? 0 : -1;
        //    return b == null ? 1 : a.Area.CompareTo(b.Area);
        //}

        public int Compare(T? a, T? b)
        {
            if (a == null) return b == null ? 0 : -1;
            return b == null ? 1 : a.Area.CompareTo(b.Area);
        }
    }
}
