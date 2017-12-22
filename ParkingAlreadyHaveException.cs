using System;
using System.Runtime.Serialization;

namespace ThirdLab
{
    
 class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException():
            base("На парковке уже есть такое животное")
        { }      
    }
}