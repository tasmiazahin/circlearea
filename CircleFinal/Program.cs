namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius:");

            Circle circle1 = new Circle(5);
            Console.WriteLine("Area of circle is :" + circle1.getArea());
            Console.WriteLine("Enter Radius:");
            // circle1.getArea();
            Circle circle2 = new Circle(6);
            Console.WriteLine("Area of circle is :" + circle2.getArea());
            //circle2.getArea();
            Console.WriteLine("Enter Radius for boll:");
            Console.WriteLine("Area of boll is :" + circle2.getBoll());

            //circle1.getBoll();
            Console.WriteLine("what is the area if triangle");
            TriAngle tri = new TriAngle(5, 6);
            Console.WriteLine("Area of triangle is " + tri.getTri());

            Console.ReadLine();
        }
        
    }

    class Circle
    {
        double PI = 3.141f;
        int _Radius;

        public Circle(int radius)
        {
            this._Radius = radius;

        }
        public double getArea()
        {
            //Console.WriteLine("Enter Radius:");
            //double radius = Convert.ToDouble(Console.ReadLine());
            double area = PI * _Radius * _Radius;
            // Console.WriteLine("Area of circle is :"+ area);
            return area;
        }
        public double getBoll()
        {
            // Console.WriteLine("Enter Radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            return 1.333 * (PI * radius * radius * radius);
            //Console.WriteLine("Area of boll is :" + area);
            //return area;

        }
    }
    class TriAngle
    {
        private double _height;
        private double _base;
        public TriAngle(double height, double bas)
        {
            this._height = height;
            this._base = bas;

        }
        public double getTri()
        {
            return 0.5 * _height * _base;
        }
    }

}







