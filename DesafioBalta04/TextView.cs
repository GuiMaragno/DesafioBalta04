using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta04
{
    internal static class TextView
    {
        public static float GetProductValue()
        {
            Console.Write("Informe o valor total do produto (em R$): ");
            float value = float.Parse(Console.ReadLine().Replace(',', '.'));

            if (value >= 100)
            {
                return value / 100;
            } else
            {
                return value;
            }
        }

        public static float GetPaymentValue()
        {
            Console.Write("Informe o valor pago (em R$): ");
            float value = float.Parse(Console.ReadLine().Replace(',', '.'));

            if (value >= 100)
            {
                return value / 100;
            }
            else
            {
                return value;
            }
        }

        public static void ShowResults(Calculator.Money money)
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("\nResultados:\n");

            Console.WriteLine($"Total do Troco: R${money.Change_Value}\n");

            Console.WriteLine($"Notas de R$200 de troco: \t{money.Value_200}");
            Console.WriteLine($"Notas de R$100 de troco: \t{money.Value_100}");
            Console.WriteLine($"Notas de R$50 de troco: \t{money.Value_50}");
            Console.WriteLine($"Notas de R$20 de troco: \t{money.Value_20}");
            Console.WriteLine($"Notas de R$10 de troco: \t{money.Value_10}");
            Console.WriteLine($"Notas de R$5 de troco: \t\t{money.Value_5}");
            Console.WriteLine($"Notas de R$2 de troco: \t\t{money.Value_2}");
            Console.WriteLine($"Moedas de R$1 de troco: \t{money.Value_1}");
            Console.WriteLine($"Moedas de R$0,50 de troco: \t{money.Value_0_50}");
            Console.WriteLine($"Moedas de R$0,25 de troco: \t{money.Value_0_25}");
            Console.WriteLine($"Moedas de R$0,10 de troco: \t{money.Value_0_10}");
            Console.WriteLine($"Moedas de R$0,05 de troco: \t{money.Value_0_05}");
            Console.WriteLine($"Moedas de R$0,01 de troco: \t{money.Value_0_01}");

            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }

        public static string GetOption()
        {
            Console.Write("Deseja refazer (1 para Sim / 0 para Não): ");
            return Console.ReadLine();
        }
    }
}
