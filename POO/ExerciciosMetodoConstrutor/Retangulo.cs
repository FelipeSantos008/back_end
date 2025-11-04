

namespace ExerciciosMetodoConstrutor
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public Retangulo(double l, double a)
        {
            Largura = l;
            Altura = a;

            double AreaRetangulo = l * a;

            System.Console.WriteLine(@$"  Largura do Retangulo: {Largura}
            Altura do Retangulo: {Altura}
            
            Area final: {AreaRetangulo}");
        }
    }
}