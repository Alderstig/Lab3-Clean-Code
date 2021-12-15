using HouseFB;

HouseBuilder builder = new();

House house = builder
    .SetNoOfRooms(0)
    .SetNoOfWindows(1)
    .SetStreetAdress("MyAdress 1")
    .HasSwimmingPool(false)
    .SetNoOfParkingSpots(1)
    .Build();

Console.WriteLine(house.ToString());
