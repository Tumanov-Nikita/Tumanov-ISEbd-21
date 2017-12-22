using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab
{
    class Mixer
    {
        public void Mix (Egg e)
        {
            if (e.Have_salt==false && e.Have_shell==false)
            {
                e.Mixed = true;
            }
            else
            if (e.Have_salt)
            {
                e.Mixed_with_salt = true;
            }

        }
    }
}
