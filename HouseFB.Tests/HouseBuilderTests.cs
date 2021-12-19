using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseFB.Tests
{
    [TestFixture]
    public class HouseBuilderTests
    {
        private HouseBuilder _builder;
        private House _house;

        [SetUp]
        public void Setup()
        {
             _builder = new HouseBuilder();

            _house = _builder
                .SetNoOfRooms(1)
                .SetNoOfWindows(1)
                .SetStreetAdress("MyAdress 1")
                .HasSwimmingPool(false)
                .SetNoOfParkingSpots(1)
                .Build();
        }

        [Test]
        public void Build_GivenHouseBuilder_ReturnsTrueIfExceptionNotThrown()
        {
            HouseBuilder builder = _builder
                    .SetNoOfRooms(1)
                    .SetNoOfWindows(1)
                    .SetStreetAdress("MyAdress 1")
                    .HasSwimmingPool(false)
                    .SetNoOfParkingSpots(1);

            Assert.DoesNotThrow(() => builder.Build());
        }

        [Test]
        public void SetNoOfRooms_GivenHouseBuilder_ReturnsTrueIfMatchingExpectedNoOfRooms()
        {
            int expectedNoOfRooms = 1;

            Assert.AreEqual(expectedNoOfRooms, _house.NoOfRooms);
        }

        [Test]
        public void SetNoOfWindows_GivenHouseBuilder_ReturnsTrueIfMatchingExpectedNoOfWindows()
        {
            int expectedNoOfWindows = 1;

            Assert.AreEqual(expectedNoOfWindows, _house.NoOfWindows);
        }

        [Test]
        public void SetStreetAdress_GivenHouseBuilder_ReturnsTrueIfMatchingExpectedStreetAdress()
        {
            string expectedStreetAdress = "MyAdress 1";

            Assert.AreEqual(expectedStreetAdress, _house.StreetAdress);
        }

        [Test]
        public void HasSwimmingPool_GivenHouseBuilder_ReturnsTrueIfMatchingExpectedBool()
        {
            bool expectedHasSwimmingPool = false;

            Assert.AreEqual(expectedHasSwimmingPool, _house.HasSwimmingPool);
        }

        [Test]
        public void SetNoOfParkingSpots_GivenHouseBuilder_ReturnsTrueIfMatchingExpectedNoOfParkingSpots()
        {
            int expectedNoOfParkingSpots = 1;

            Assert.AreEqual(expectedNoOfParkingSpots, _house.ParkingSpotsInGarage);
        }
    }
}
