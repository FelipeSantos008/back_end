using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 0;
        public int VolumeMaximo = 100;

        public void AumentarVolume()
        {
            if (NivelVolume < VolumeMaximo)
            {
            NivelVolume++;
            System.Console.WriteLine($"Aumentando volume: {NivelVolume}");    
            } else
            {
                System.Console.WriteLine("O volume já atingiu o nivel máximo");
            }
            
        }


        public void DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
                System.Console.WriteLine($"O volume já está no minímo: {NivelVolume}");
            }
            NivelVolume--;
            System.Console.WriteLine($"Diminuindo volume: {NivelVolume}");
        }

        public void Ligar()
        {
            System.Console.WriteLine("Ligando ...");
        }
        public void Desligar()
        {
            System.Console.WriteLine("Desligando");
        }
    }
}