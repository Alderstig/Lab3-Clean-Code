using HouseF;
using HouseF.Houses;

HouseFactory factory = new();

House mansion = factory.CreateHouse("mansion");
mansion.StreetAdress = "MansionAdress 1";

Console.WriteLine(mansion);

House tinyHouse = factory.CreateHouse("tinyhouse");
tinyHouse.StreetAdress = "TinyHouseAdress 1";

Console.WriteLine(tinyHouse);

House singleFamilyHouse = factory.CreateHouse("singleFamilyHouse");
singleFamilyHouse.StreetAdress = "SingleFamilyHouseAdress 1";

Console.WriteLine(singleFamilyHouse);
