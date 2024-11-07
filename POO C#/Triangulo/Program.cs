using System.Globalization;

namespace triangulo
{
    class program
    {
        public static void Main()
        {
            double x1,x2,x3,px,xa;
            double y1,y2,y3,py,ya;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            y2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            y3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            px = (x1+x2+x3) / 2;
            py = (y1+y2+y3) / 2;

            xa = Math.Sqrt(px*(px-x1)*(px-x2)*(px-x3));
            ya = Math.Sqrt(py*(py-y1)*(py-y2)*(py-y3));

            Console.WriteLine("Área de X: " + xa.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + ya.ToString("F4", CultureInfo.InvariantCulture));

            if(xa > ya)
            {
                Console.WriteLine("Maior Área: X");
            } else{
                Console.WriteLine("Maior Área: Y");
            }
        }
    }
}