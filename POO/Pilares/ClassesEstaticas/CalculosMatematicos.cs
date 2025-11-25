using System.Reflection.Metadata;

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        //Operações Matemáticas simples

        //visibilidade tipoDeRetorno Parametros
        public static float Somar(float a, float b)
        {
            return a + b;
        }
        public static float Subtrair(float a, float b)
        {
            return a - b;

        }
        public static float Multiplicar(float a, float b)
        {
            return a * b;
        }
        public static float Dividir(float a, float b)
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Não é possível dividir por zero");       
                return 0;
            } else
            {
                return a / b;
            }
            
            
        }
    }
}