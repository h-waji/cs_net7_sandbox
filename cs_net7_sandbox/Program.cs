User tom = new User("Tom");
tom.SayHi();

AdminUser bob = new AdminUser("Bob");
bob.SayHello();
bob.SayHi();

class User
{
    public string name;

    public User() : this("nobody") { }

    public User(string name) 
    {
        this.name = name;
    }

    public virtual void SayHi()
    {
        Console.WriteLine($"Hi. I'm {name}");
    }
}

class AdminUser: User
{
    public AdminUser(string name): base(name) { }

    public void SayHello()
    {
        Console.WriteLine($"Hello. I'm {name}");
    }

    public override void SayHi()
    {
        Console.WriteLine($"[ADMIN] Hi. I'm {name}");
    }
}
