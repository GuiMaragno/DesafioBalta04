using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option = "1";

            do
            {
                Console.Clear();

                Console.WriteLine("\tDesafio do Balta 04\n");

                float valueProduct = TextView.GetProductValue();

                float payment = TextView.GetPaymentValue();

                Calculator.Money money = Calculator.Change.GetChange(valueProduct, payment);

                TextView.ShowResults(money);

                option = TextView.GetOption();
            } while (!option.Equals("0"));
        }
    }
}
