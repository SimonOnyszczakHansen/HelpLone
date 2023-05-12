using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
    internal class Barbarian : IAttack, IFight, IHp
    {
        public string Bash()
        {
            return "I'm bashing someone";
        }
        public string Cleave()
        {
            return "I'm cleaving someone";
        }
        public string Die()
        {
            return "I'm dying";
        }
        public string Fight()
        {
            return "I'm fighting";
        }
        public string Heal()
        {
            return "I'm healing";
        }
        public string Slash()
        {
            return "I'm slashing someone";
        }
    }
}
