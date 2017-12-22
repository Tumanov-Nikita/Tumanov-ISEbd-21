using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab
{
    class Pan
    {      
        private Milk[] milk;
        private Water[] water;
        private Egg[] eggs;
        private Salt salt;
        public bool ReadyToGo { get { return Check(); } }

        public void Init(int countEggs, int CountMilk)
        {
            water = new Water[3];
            eggs = new Egg[countEggs];
            milk = new Milk[CountMilk];
        }


        public void AddEggs(Egg e)
        {
            for (int i = 0; i < eggs.Length; i++)
            {
                if (eggs[i] == null)
                {
                    eggs[i] = e;
                    return;
                }
            }
        }

        public bool Check()
        {
         
            if (eggs.Length == 0)
            {
                return false;
            }         
            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i] == null)
                {
                    return false;
                }
            }
            return true;
        }

        public void AddSalt(Salt s)
        {

                    salt = s;

        }

        public void AddMilk(Milk m)
        {
            for (int i = 0; i < milk.Length; i++)
            {
                if (milk == null)
                {
                    milk[i] = m;
                    return;
                }
            }         
        }

        public void GetHeat()
        {
            if (!Check())
            {
                return;
            }
            if (eggs.Length > 0)
            {
                for (int i=0; i < eggs.Length; i++)
                {
                    eggs[i].GetHeat();
                }
            }
        }


        public bool IsReady()
        {
            for (int i=0; i < eggs.Length; i++)
            {
                if (eggs[i].Has_ready < 10)
                {
                    return false;
                }
            }
            return true;
        }

        public Egg[] GetEggs()
        {
            return eggs;
        }
    }
}
