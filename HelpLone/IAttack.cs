using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
    internal interface IAttack
    {
        public string Bash();
        public string Slash();
        public string Cleave();
    }
}
