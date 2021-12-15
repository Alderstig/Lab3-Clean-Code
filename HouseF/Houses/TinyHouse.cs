using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF.Houses
{
    public class TinyHouse : House
    {
        public TinyHouse()
        {
            NoOfRooms = 2;
            NoOfWindows = 4;
            HasSwimmingPool = false;
            ParkingSpotsInGarage = 0;
        }
    }
}
