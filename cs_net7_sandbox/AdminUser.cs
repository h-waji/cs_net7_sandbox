namespace cs_net7_sandbox
{
    class AdminUser : User
    {
        public AdminUser(string name) : base(name) { }

        public void SayHello()
        {
            Console.WriteLine($"Hello. I'm {name}");
        }

        public override void SayHi()
        {
            Console.WriteLine($"[ADMIN] Hi. I'm {name}");
        }
    }
}
