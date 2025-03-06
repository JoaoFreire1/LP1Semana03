using System;
using System.Security.Permissions;
using HeroPerks;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            for (string s in args)
            {
                switch (char r in string s)
                {
                    case w:
                        myRoles ^=Perks.WarpShift;
                        break;
                
                    case a:
                        myRoles ^=Perks.AutoHeal;
                        break;
                
                    case s:
                        myRoles ^=Perks.Stealth;
                        break;
                
                    case d:
                        myRoles ^=Perks.DoubleJump;
                        break;

                }
            }
        }
    }
}
