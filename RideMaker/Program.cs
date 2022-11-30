Vehicle Testarossa = new Vehicle("Ferrari Testarossa", 2, "Yellow", true, 180);

Vehicle Civic = new Vehicle("Honda Civic", "Gray");

Vehicle M3 = new Vehicle("BMW M3", 4, "Electric Red", true, 205);

Vehicle DiabloSV = new Vehicle("Lamborghini Diablo SV", 2, "Black", true, 190);

List<Vehicle> CarList = new List<Vehicle>(){Testarossa, Civic, M3, DiabloSV};

foreach (Vehicle entry in CarList)
{
    // System.Console.WriteLine(entry.name);
    entry.ShowInfo();
}

Testarossa.Travel(100);
Testarossa.ShowInfo();
DiabloSV.Travel(134.7);
DiabloSV.ShowInfo();
Civic.Travel(1389.4);
Civic.ShowInfo();
M3.Travel(852.1);
M3.ShowInfo();
Testarossa.Travel(269.8);
Testarossa.ShowInfo();

