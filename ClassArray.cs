using SecondLab;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
    class ClassArray<T> : IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>>
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

        private int currentIndex;
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }





        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public int CompareTo(ClassArray<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }
            else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i=0; i< this.places.Count; i++)
                {
                    if (this.places[thisKeys[i]] is Rabbit &&
                        other.places[thisKeys[i]] is SportRabbit)
                    {
                        return 1;
                    }
                    if (this.places[thisKeys[i]] is SportRabbit &&
                       other.places[thisKeys[i]] is Rabbit)
                    {
                        return -1;
                    }
                    if (this.places[thisKeys[i]] is Rabbit &&
                       other.places[thisKeys[i]] is Rabbit)
                    {
                        return (this.places[thisKeys[i]] is Rabbit)
                            .CompareTo(other.places[thisKeys[i]] is Rabbit);
                    }
                    if (this.places[thisKeys[i]] is SportRabbit &&
                       other.places[thisKeys[i]] is SportRabbit)
                    {
                        return (this.places[thisKeys[i]] is SportRabbit)
                            .CompareTo(other.places[thisKeys[i]] is SportRabbit);
                    }
                }
            }
            return 0;
        }



        public static int operator +(ClassArray<T> p, T animal)
        {
            var isSportRabbit = animal is SportRabbit;
			if (p.places.Count == p.maxCount)
			{
				throw new ParkingOverFloException();
			}
            int index = p.places.Count;
            for (int i=0; i<p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if (animal.GetType() == p.places[i].GetType())
                {
                    if (isSportRabbit)
                    {
                        if ((animal as SportRabbit).Equals(p.places[i]))
                        {
                            throw new ParkingAlreadyHaveException();
                        }
                    }
                    else if ((animal as Rabbit).Equals(p.places[i]))
                    {
                        throw new ParkingAlreadyHaveException();                    
                    }
                }
            }
            if (index != p.places.Count)
            {
                p.places.Add(index, animal);
                return index;
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
