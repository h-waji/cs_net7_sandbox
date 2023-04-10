using cs_net7_sandbox;

User tom = new User("Tom");
tom.SayHi();

AdminUser bob = new AdminUser("Bob");
bob.SayHello();
bob.SayHi();
bob.Share();

Point point = new Point(4, 3);
point.GetInfo();

Nokonoko noko = new Nokonoko();
noko.GetInfo();

Patapata pata = new Patapata();
pata.GetInfo();

Team hamsters = new Team();
hamsters[0] = "Hamham1";
hamsters[1] = "Hamham2";
hamsters[2] = "Hamham3";
Console.WriteLine(hamsters[1]);

// ----- LINQ -----
List<double> prices = new List<double>() { 66.6, 55.5, 44.4, 33.3 };
var results = prices
            .Select(n => n * 1.10)
            .Where(n => n > 50);

foreach(var result in results)
{
    Console.WriteLine(result);
}

// ----- Generic -----
MyData<string> s = new MyData<string>();
s.WriteThreeTimes("Hello");

MyData<double> d = new MyData<double>();
d.WriteThreeTimes(77.77);
