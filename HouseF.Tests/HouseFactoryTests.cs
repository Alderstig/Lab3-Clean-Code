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
        public void CreateHouse_GivenStringHouseType_ReturnsTrueIfIsInstanceOfSingleFamilyHouse()
        {
            House singleFamilyHouse = _factory.CreateHouse("singleFamilyHouse");

            Assert.IsInstanceOf<SingleFamilyHouse>(singleFamilyHouse);
        }

        [Test]
        public void CreateHouse_GivenStringHouseType_ReturnsTrueIfIsInstanceOfTinyHouse()
        {
            House tinyHouse = _factory.CreateHouse("tinyHouse");

            Assert.IsInstanceOf<TinyHouse>(tinyHouse);
        }

        [Test]
        public void CreateHouse_GivenStringHouseType_ReturnsTrueIfIsInstanceOfMansion()
        {
            House mansion = _factory.CreateHouse("mansion");

            Assert.IsInstanceOf<Mansion>(mansion);
        }
    }
}
