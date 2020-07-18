using System;

namespace BauMestreCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do baú a ser calculado:");
            Console.WriteLine(/*Pratos de 18 Un.*/"1.Refeição Especial de Arehaza 2.Espetinho de Queijo de Lhama 3.Salada de Caçador\n" +
            "4.Carne Frita 5.Salada de Carne Magra 6.Croquete de Carne\n7.Samambaia Frita 8.Biscoito de Colmeia " +
            "9.Chá com Leite\n10.Chá Sute 11.Queijo Gratin " /*15 Un.*/+ "12.Bife Saboroso\n13.Holmick 14.Hamburguer do Rei da Selva " +
            "15.Pudim Escuro\n16.Sanduíche de Carne 17.Sanduíche de Presunto " /*9 Un.*/+ "18.Pratos Abundantes de Acompanhamentos\n" +
            /*6 Un.*/"19.Espetinho de Queijo de Lhama Apimentado 20.Salada de Caçador Fresca 21.Carne de Croquete Crocante\n" +
            "22.Salada de Carne de Qualidade Superior 23.Carne Frita Especial 24.Samambaia Frita Bem Gostosa\n25.Chá Sute Saudável " +
            "26.Biscoito de Colmeia Crocante 27.Queijo Gratin Gostoso\n28.Chá com Leite Suave " /*5 Un.*/+ "29.Holmich de Caldo Grosso " +
            "30.Hamburguer Grande do Rei da Selva\n31.Pudim Escuro Sangrento 32.Sanduiche de Carne de Alta Qualidade 33.Sanduíche de Presunto " +
            "Alta Qualidade");

            int chosenDish = int.Parse(Console.ReadLine());
            int unsPerCrate = 0;

            if (chosenDish <= 11)
            {
                unsPerCrate += 18;
                Console.WriteLine($"{unsPerCrate} por Baú");
            }

            else if (chosenDish > 11 && chosenDish <= 17)
            {
                unsPerCrate += 15;
                Console.WriteLine($"{unsPerCrate} por Baú");
            }

            else if (chosenDish == 18)
            {
                unsPerCrate += 9;
                Console.WriteLine($"{unsPerCrate} por Baú");
            }

            else if (chosenDish > 18 && chosenDish <= 28)
            {
                unsPerCrate += 6;
                Console.WriteLine($"{unsPerCrate} por Baú");
            }

            else if (chosenDish > 28 && chosenDish <= 33)
            {
                unsPerCrate += 5;
                Console.WriteLine($"{unsPerCrate} por Baú");
            }

            else
            {
                Console.WriteLine("Prato inexiste, reinicie a aplicação!");
            }

            Console.WriteLine("Qual o preço de mercado do item escolhido?");

            int mktPrice = int.Parse(Console.ReadLine());

            int cratePrice = mktPrice * unsPerCrate;

            Console.WriteLine($"Preço por baú: {cratePrice}");
            Console.WriteLine("Qual seu bônus de lucro de maestria?");
            
            int masteryBonus = int.Parse(Console.ReadLine());
            double bonusProfit = (220000 * masteryBonus) / 100;

            double sellPrice = 550000 + bonusProfit;

            double finalProfit = sellPrice - cratePrice;

            Console.WriteLine($"Seu lucro é de {finalProfit} por caixa");

            Console.WriteLine("Digite seus pontos de Contribuição");
            int contrib = int.Parse(Console.ReadLine());
            int dailyDelivery = contrib / 2;
            double profit = dailyDelivery * finalProfit;
            Console.Write($"Lucro diário com base no CP: {profit}\n\n\n");
            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadLine();
        }
    }
}
