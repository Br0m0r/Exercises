using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character
{
    public class CalcGen
    {
        private static Random random = new Random();

        internal static int GenerateAbilityScore()
        {
            int[] rolls = new int[4];
            for (int i = 0; i < 4; i++)
            {
                rolls[i] = random.Next(1, 7);
            }

            Array.Sort(rolls);

            return rolls[1] + rolls[2] + rolls[3];
        }

        internal static int CalculateHitpoints(int constitution)
        {
            int modifier = (constitution - 10) / 2;
            return 10 + modifier;
        }
    }
}
