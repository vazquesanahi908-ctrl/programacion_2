namespace operaciones
{
    public class Suma
    {
        public static double sumar(double a, double b)
            {
                return a + b;
        }
    }
    public class Resta
    {
        public static double restar(double a, double b)
        {
            return a - b;
        }
    }
    public class Multiplicacion
    {
        public static double multiplicar(double a, double b)
        {
            return a * b;
        }
    }
    public class Division
    {
        public static double dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return a / b;
        }
    }
}
