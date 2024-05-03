class Program
{
    static void Main(string[] args)
    {
        Circulo circulo = new Circulo(5);
        Rectangulo rectangulo = new Rectangulo(4, 6);

        Console.WriteLine("El área del círculo es: " + circulo.CalcularArea());
        Console.WriteLine("El área del rectángulo es: " + rectangulo.CalcularArea());
    }
}
//ignacio Benitez