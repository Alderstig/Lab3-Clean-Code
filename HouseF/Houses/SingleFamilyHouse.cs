using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF.Houses
{
    public class SingleFamilyHouse : House
    {
        public SingleFamilyHouse()
        {
            NoOfRooms = 4;
            NoOfWindows = 8;
            HasSwimmingPool = false;
            ParkingSpotsInGarage = 2;
        }
    }
}
