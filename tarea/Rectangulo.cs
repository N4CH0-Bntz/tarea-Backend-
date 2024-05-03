public class Rectangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    


    public Rectangulo(double base_, double altura)
    {
        Base = base_;
        Altura = altura;
    }



    public override double CalcularArea()
    {
        return Base * Altura;
    }
}
