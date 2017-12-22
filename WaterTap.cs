using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab
{
    class WaterTap
    {
        public bool State { set ; get; }
        public void Wash(Egg p)
        {
            if (State)
            {
                p.Dirty = 0;
            }
        }

        public Water GetWater()
        {
            if (State)
            {
                return new Water();
            }
            else
            {
                return null;
            }
        }

    }
}
