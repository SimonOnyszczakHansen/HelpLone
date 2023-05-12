using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
    internal class Wizard : IWizard, ITeleport, IHp, IFight
    {
        public string Die()
        {
            return "I'm Dying";
        }
        public string Fight()
        {
            return "I'm fighting";
        }
        public string Heal()
        {
            return "I'm healing";
        }
        public string Teleport(int x, int y)
        {
            return $"I'm teleporting to {x} {y}";
        }

        public string ThrowFrostNova()
        {
            return "I'm throwing my frost nova";
        }

        public string ThrowMagicMisile()
        {
            return "I'm throwing a magic misile" ;
        }
    }
}
