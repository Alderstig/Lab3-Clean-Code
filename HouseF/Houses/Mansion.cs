using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF.Houses
{
    public class Mansion : House
    {
        public Mansion()
        {
            NoOfRooms = 10;
            NoOfWindows = 20;
            HasSwimmingPool = true;
            ParkingSpotsInGarage = 8;
        }
    }
}
