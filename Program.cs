using TesteDTI.Classes;

namespace TesteDTI
{
    public class Program
    {
        static PetShop MeuCaninoFeliz = new PetShop("Meu Canino Feliz", 2000, 20.00, 40.00, 1.20, false);
        static PetShop VaiRex = new PetShop("Vai Rex", 1700, 15.00, 50.00, 5.00, true);
        static PetShop ChowChawgas = new PetShop("ChowChawgas", 800, 30.00, 45.00, 0.0, true);
        static PetShop[] petshops = [MeuCaninoFeliz, VaiRex, ChowChawgas];
        // Faço um array de PetShops para facilitar o acesso a todos, pois farei muitas comparações posteriormente e trabalhar com loop é melhor.

        static void Main(string[] args)
        {

            DateTime data = DateTime.Now;
            Console.WriteLine("Bem vindo ao software que ajudará o Senhor Eduardo a escolher o certo!");
            Console.WriteLine("Qual dia o senhor pretende levar seus cachorros para tomar banho?");
            //Verificação de data válida e se ainda não passou
            do
            {
                try
                {
                    Console.Write("Insira no formato dd/mm/aaaa:");
                    string inputData = Console.ReadLine();
                    data = DateTime.ParseExact(inputData, "dd/MM/yyyy", null);

                    if (data < DateTime.Now)
                    {
                        Console.WriteLine("O dia escolhido já passou, tente outro dia.");
                    }
                }
                catch (FormatException)
                {
                    throw new FormatException("O formato insirido da data foi incorreto.");
                }

            } while (data <= DateTime.Now);

            Console.Write("Senhor Eduardo, por favor me diga a quantidade de cães grandes o senhor vai levar para tomar banho hoje: ");
            int qtdCaesGrandes = int.Parse(Console.ReadLine());
            Console.Write("Agora, por favor me diga a quantidade de cães pequenos o senhor vai levar para tomar banho hoje: ");
            int qtdCaesPequenos = int.Parse(Console.ReadLine());

            var melhorPetShop = verificarQualMelhorPetShop(data, qtdCaesPequenos, qtdCaesGrandes);

            Console.WriteLine($"O melhor PetShop para o Senhor Eduardo é: {melhorPetShop.nomePetShop} \nValor: {melhorPetShop.totalSoma}");

        }

        public static PetShop verificarQualMelhorPetShop(DateTime date, int qtdRacasPequenas, int qtdRacasGrandes)
        {
            PetShop melhorPetshop = null;

            for (int i = 0; i < petshops.Length; i++)
            {
                petshops[i].somarBanhos(qtdRacasPequenas, qtdRacasGrandes, date);

                if (melhorPetshop == null)
                {
                    // É o primeiro petshop calculado
                    melhorPetshop = petshops[i];
                }
                else
                {
                    // Não é mais o primeiro, precisa testar com o melhor possível anterior

                    // Testes separados em variáveis para melhor legibilidade do código
                    bool temValorMenor = petshops[i].totalSoma < melhorPetshop.totalSoma;
                    bool temValorIgualEDistanciaMenor = petshops[i].totalSoma == melhorPetshop.totalSoma && petshops[i].distanciaEduardo < melhorPetshop.distanciaEduardo;

                    if (temValorMenor || temValorIgualEDistanciaMenor)
                    {
                        melhorPetshop = petshops[i];
                    }
                }

            }

            return melhorPetshop;
        }
    }
}

