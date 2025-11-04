using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class MediaAluno
    {
        public string Nome;
        public double N1, N2, N3;

        //Construtor com paramêtros
        public MediaAluno(double param1, double param2, double param3)
        {
            //define os valolres iniciais para as minhas propriedades
            // N1 = 0; valor fixo
            N1 = param1;
            N2 = param3;
            N3 = param3;
        }

        public MediaAluno()
        {
            N1 = N2 = N3 = 0; //atritbuindo valor fixo para as 3 propriedades de uma vez
        }

        public void Media()
        {
            double Media = (N1 + N2 + N3) / 3;

            System.Console.WriteLine(@$"A média do(a) {Nome} foi: {Media}");
        }
    }
}