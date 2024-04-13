using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDTI.Classes
{
    public class PetShop
    {
        public string nomePetShop;
        public int distanciaEduardo;
        public double precoBanhoRacaPequena;
        public double precoBanhoRacaGrande;
        public double taxaFimDeSemana;
        public bool taxaFixa;
        public double totalSoma;


        public PetShop(string nomePetShop, int distanciaEduardo, double precoBanhoRacaPequena, double precoBanhoRacaGrande, double taxaFimDeSemana, bool taxaFixa)
        {
            this.nomePetShop = nomePetShop;
            this.distanciaEduardo = distanciaEduardo;
            this.precoBanhoRacaPequena = precoBanhoRacaPequena;
            this.precoBanhoRacaGrande = precoBanhoRacaGrande;
            this.taxaFimDeSemana = taxaFimDeSemana;
            this.taxaFixa = taxaFixa;
        }
        public double somarBanhos(int qtdRacasPequenas, int qtdRacasGrandes, DateTime diaDosBanhos)
        {
            double precoBanhoRacaGrandeComTaxa = precoBanhoRacaGrande, precoBanhoRacaPequenaComTaxa = precoBanhoRacaPequena;
            if (diaDosBanhos.DayOfWeek == DayOfWeek.Saturday || diaDosBanhos.DayOfWeek == DayOfWeek.Sunday)
            {
                if (taxaFixa)
                {
                    precoBanhoRacaGrandeComTaxa += taxaFimDeSemana;
                    precoBanhoRacaPequenaComTaxa += taxaFimDeSemana;
                }
                else
                {
                    precoBanhoRacaGrandeComTaxa *= taxaFimDeSemana;
                    precoBanhoRacaPequenaComTaxa *= taxaFimDeSemana;
                }
            }

            totalSoma = (qtdRacasGrandes * precoBanhoRacaGrandeComTaxa) + (qtdRacasPequenas * precoBanhoRacaPequenaComTaxa);
            Console.WriteLine(nomePetShop + ": " + totalSoma.ToString());
            return totalSoma;
        }
      
    }
}
