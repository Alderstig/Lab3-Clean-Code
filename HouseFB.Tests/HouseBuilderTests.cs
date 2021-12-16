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
        [SetUp]
        public void Setup()
        {
            _builder = new HouseBuilder();
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
    }
}
