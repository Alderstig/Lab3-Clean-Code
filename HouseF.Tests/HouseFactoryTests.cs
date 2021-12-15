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
        public void CreateHouse_GivenHouse_ReturnsTrueIfIsInstanceOfSingleFamilyHouse()
        {
            House singleFamilyHouse = _factory.CreateHouse("singleFamilyHouse");

            Assert.IsInstanceOf<SingleFamilyHouse>(singleFamilyHouse);
        }

        [Test]
        public void CreateHouse_GivenHouse_ReturnsTrueIfIsInstanceOfTinyHouse()
        {
            House tinyHouse = _factory.CreateHouse("tinyHouse");

            Assert.IsInstanceOf<TinyHouse>(tinyHouse);
        }

        [Test]
        public void CreateHouse_GivenHouse_ReturnsTrueIfIsInstanceOfMansion()
        {
            House mansion = _factory.CreateHouse("mansion");

            Assert.IsInstanceOf<Mansion>(mansion);
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
    }
}
