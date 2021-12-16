using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseFB
{
    public class HouseBuilder
    {
        private House _house;

        public HouseBuilder()
        {
            _house = new House();
        }

        public HouseBuilder SetNoOfRooms(int noOfRooms)
        {
            _house.NoOfRooms = noOfRooms;
            return this;
        }

        public HouseBuilder SetNoOfWindows(int noOfWindows)
        {
            _house.NoOfWindows = noOfWindows;
            return this;
        }

        public HouseBuilder SetStreetAdress(string adress)
        {
            _house.StreetAdress = adress;
            return this;
        }

        public HouseBuilder HasSwimmingPool(bool hasSwimmingPool)
        {
            _house.HasSwimmingPool = hasSwimmingPool;
            return this;
        }

        public HouseBuilder SetNoOfParkingSpots(int parkingSpots)
        {
            _house.ParkingSpotsInGarage = parkingSpots;
            return this;
        }
        public House Build()
        {
            if(_house.NoOfRooms < 1 || _house.NoOfWindows < 0 || _house.ParkingSpotsInGarage < 0) throw new Exception("The house does not meet the requirements");
            return _house;
        }
    }
}
