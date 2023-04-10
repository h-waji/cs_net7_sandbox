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
