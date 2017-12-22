using SecondLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
    class ClassArray<T> where T: IAnimals
    {
        private Dictionary<int, T> places;
		private int maxCount;
        private T defaultValue;

        public ClassArray(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
			maxCount = size;
        }



        public static int operator +(ClassArray<T> p, T animal)
        {
			if (p.places.Count == p.maxCount)
			{
				throw new ParkingOverFloException();
			}

            for (int i=0; i<p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places.Add(i, animal);
                    return i;
                }
            }
			p.places.Add(p.places.Count, animal);
            return p.places.Count - 1;
        }

        public static T operator -(ClassArray<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T animal = p.places[index];
                p.places.Remove(index);
                return animal;
            }
			throw new ParkingIndexOfRangeException();

		}

        private bool CheckFreePlace (int index)
        {

			return !places.ContainsKey(index);
          
        }


		public T this[int ind]
		{
			get
			{
				if (places.ContainsKey(ind))
				{
					return places[ind];
				}
				return defaultValue;
			}
		}

        public T getObject(int ind)
        {
            if (ind>-1 && ind < places.Count)
            {
                return places[ind];
            }
            return defaultValue;
        }


    }
}
