using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
	class ParkingOverFloException : Exception
	{
		public ParkingOverFloException() :
			base("На парковке свободных мест нет")
		{ }
	}
}
