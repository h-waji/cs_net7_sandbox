namespace cs_net7_sandbox
{
    class User: ISharable
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

        public void Share()
        {
            Console.WriteLine("now sharing...");
        }
    }
}
