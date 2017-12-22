using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
	class ParkingIndexOfRangeException : Exception
	{
		public ParkingIndexOfRangeException() :
			base("На парковке нет животного по такому месту")
		{ }
	}
}
