using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta04.Calculator
{
    internal static class Change
    {
        public static float change;

        public static Money GetChange(float valueProduct, float payment)
        {
            change = payment - valueProduct;

            return CalcChange();
        }

        private static Money CalcChange()
        {
            Money money = new Money();

            change = float.Parse(change.ToString("F2"));

            money.Change_Value = change;

            do
            {
                if (change >= 200)
                {
                    change -= 200;
                    money.Value_200++;
                } else
                {
                    if (change >= 100)
                    {
                        change -= 100;
                        money.Value_100++;
                    } else
                    {
                        if (change >= 50)
                        {
                            change -= 50;
                            money.Value_50++;
                        } else
                        {
                            if (change >= 20)
                            {
                                change -= 20;
                                money.Value_20++;
                            } else
                            {
                                if (change >= 10)
                                {
                                    change -= 10;
                                    money.Value_10++;
                                } else
                                {
                                    if (change >= 5)
                                    {
                                        change -= 5;
                                        money.Value_5++;
                                    } else
                                    {
                                        if (change >= 2)
                                        {
                                            change -= 2;
                                            money.Value_2++;
                                        } else
                                        {
                                            if (change >= 1)
                                            {
                                                change -= 1;
                                                money.Value_1++;
                                            } else
                                            {
                                                if (change >= 0.50)
                                                {
                                                    change -= 0.50f;
                                                    money.Value_0_50++;
                                                } else
                                                {
                                                    if (change >= 0.25)
                                                    {
                                                        change -= 0.25f;
                                                        money.Value_0_25++;
                                                    } else
                                                    {
                                                        if (change >= 0.10)
                                                        {
                                                            change -= 0.10f;
                                                            money.Value_0_10++;
                                                        } else
                                                        {
                                                            if (change >= 0.05)
                                                            {
                                                                change -= 0.05f;
                                                                money.Value_0_05++;
                                                            } else
                                                            {
                                                                change -= 0.01f;
                                                                money.Value_0_01++;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } while (float.Parse(change.ToString("F2")) != 0.00f);

            return money;
        }
    }

    public class Money
    {
        public int Value_200 { get; set; } = 0;
        public int Value_100 { get; set; } = 0;
        public int Value_50 { get; set; } = 0;
        public int Value_20 { get; set; } = 0;
        public int Value_10 { get; set; } = 0;
        public int Value_5 { get; set; } = 0;
        public int Value_2 { get; set; } = 0;
        public int Value_1 { get; set; } = 0;
        public int Value_0_50 { get; set; } = 0;
        public int Value_0_25 { get; set; } = 0;
        public int Value_0_10 { get; set; } = 0;
        public int Value_0_05 { get; set; } = 0;
        public int Value_0_01 { get; set; } = 0;
        public float Change_Value { get; set; }

        public Money()
        {
            // CONSTRUCTOR \\
        }
    }
}
