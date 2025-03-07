using System;
using System.Text;

namespace HeroPerk
{
    /// <summary>
    /// This is an example of summary
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Perks perks = Perks.None;

            string leitura = Console.ReadLine();
            foreach (var item in leitura)
            {
                switch (item)
                {
                    case 'a':
                        if ((perks & Perks.AutoHeal) == Perks.AutoHeal)
                        {
                            perks &= ~Perks.AutoHeal;
                        }
                        else
                        {
                            perks ^= Perks.AutoHeal;
                        }
                        break;

                    case 's':
                        if ((perks & Perks.Stealth) == Perks.Stealth)
                        {
                            perks &= ~Perks.Stealth;
                        }
                        else
                        {
                            perks ^= Perks.Stealth;
                        }
                        break;

                    case 'w':
                        if ((perks & Perks.WarpShift) == Perks.WarpShift)
                        {
                            perks &= ~Perks.WarpShift;
                        }
                        else
                        {
                            perks ^= Perks.WarpShift;
                        }
                        break;

                    case 'd':
                        if ((perks & Perks.DoubleJump) == Perks.DoubleJump)
                        {
                            perks &= ~Perks.DoubleJump;
                        }
                        else
                        {
                            perks ^= Perks.DoubleJump;
                        }
                        break;

                    default:
                        Console.WriteLine("!Unknown perk!");
                        return;
                }

            }

            if(perks != Perks.None)
            {
                Console.WriteLine(perks);
            }
            else
            {
                Console.WriteLine("!No perks at all!");
            }

            if (((perks & Perks.WarpShift) == Perks.WarpShift) && ((perks & Perks.DoubleJump) == Perks.DoubleJump))
            {
                Console.WriteLine("!Silent jumper!");
            }

            if ((perks & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("!Not gonna make it!");
            }
            

        }
    }

    [Flags]
    enum Perks
    {
        None = 0,          // No perks
        WarpShift = 1,     // 0001
        Stealth = 2,       // 0010
        AutoHeal = 4,      // 0100
        DoubleJump = 8     // 1000
    }
}