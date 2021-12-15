using HouseF.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class HouseFactory
    {
        private Dictionary<string, Type> _houses;

        public HouseFactory()
        {
            _houses = LoadHouseByReflection();
        }

        public House CreateHouse(string houseType)
        {
            return GetHouseFromDictionary(houseType.ToLower());
        }

        private Dictionary<string, Type> LoadHouseByReflection()
        {
            var availableTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && t.IsSubclassOf(typeof(House)));

            var availableHouses = new Dictionary<string, Type>();

            foreach (Type t in availableTypes)
            {
                availableHouses.Add(t.Name.ToLower(), t);
            }

            return availableHouses;
        }

        private House GetHouseFromDictionary(string houseType)
        {
            Type type = _houses[houseType];

            if (type == null)
            {
                throw new ArgumentException("Could not find House of type " + houseType);
            }

            return (House)Activator.CreateInstance(type);
        }
    }
}
