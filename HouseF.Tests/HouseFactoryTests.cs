using HouseF.Houses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HouseF.Tests
{
    [TestFixture]
    public class HouseFactoryTests
    {
        private HouseFactory _factory;

        [SetUp]
        public void Setup()
        {
            _factory = new HouseFactory();
        }

        [Test]
        public void CreateHouse_GivenSingleFamilyHouse_ReturnsTrueIfActualValuesAreEqualToExpectedValues()
        {
            List<object> expectedValues = CreateListOfValues(4, 8, false, 2);

            List<object> actualValues = CreateHouseAndExtractValuesIntoList("singleFamilyHouse");

            CollectionAssert.AreEqual(expectedValues, actualValues);
        }

        [Test]
        public void CreateHouse_GivenTinyHouse_ReturnsTrueIfActualValuesAreEqualToExpectedValues() 
        {
            List<object> expectedValues = CreateListOfValues(2, 4, false, 0);

            List<object> actualValues = CreateHouseAndExtractValuesIntoList("tinyHouse");

            CollectionAssert.AreEqual(expectedValues, actualValues);
        }

        [Test]
        public void CreateHouse_GivenMansion_ReturnsTrueIfActualValuesAreEqualToExpectedValues()
        {
            List<object> expectedValues = CreateListOfValues(10, 20, true, 8);

            List<object> actualValues = CreateHouseAndExtractValuesIntoList("mansion");

            CollectionAssert.AreEqual(expectedValues, actualValues);
        }

        [Test]
        public void CreateHouse_GivenListOfHouses_ReturnsTrueIfNotNull()
        {
            List<House> housesToTest = new List<House>() 
            {
                _factory.CreateHouse("mansion"),
                _factory.CreateHouse("tinyHouse"),
                _factory.CreateHouse("singleFamilyHouse")
            };

            CollectionAssert.AllItemsAreNotNull(housesToTest);
        }

        private List<object> CreateListOfValues(int noOfRooms, int noOfWindows, bool hasSwimmingPool, int parkingSpotsInGarage)
        {
            return new List<object> { noOfRooms, noOfWindows, hasSwimmingPool, parkingSpotsInGarage };
        }

        private List<object> CreateHouseAndExtractValuesIntoList(string houseType)
        {
            House house = _factory.CreateHouse(houseType);
            List<object> values = CreateListOfValues(
                house.NoOfRooms,
                house.NoOfWindows,
                house.HasSwimmingPool,
                house.ParkingSpotsInGarage);

            return values;
        }
    }
}
