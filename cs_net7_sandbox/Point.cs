namespace cs_net7_sandbox
{
    struct Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y) 
        { 
            X = x; 
            Y = y; 
        }

        public void GetInfo()
        {
            Console.WriteLine($"Point: ({X}:{Y})");
        }
    }
}
