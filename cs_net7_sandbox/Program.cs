Console.WriteLine("使いづらいけど優秀なVisual Studio");

User tom = new User("Tom");
tom.SayHi();

class User
{
    public string name;

    public User() : this("nobody") { }

    public User(string name) 
    {
        this.name = name;
    }

    public void SayHi()
    {
        Console.WriteLine($"Hi. I'm {name}");
    }
}
