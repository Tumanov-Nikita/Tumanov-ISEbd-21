using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab
{
    class Knife
    {
        public void Smash(Egg p)
        {
            if (p.Have_shell)
            {
                p.Have_shell = false;
            }
        }
    }
}
