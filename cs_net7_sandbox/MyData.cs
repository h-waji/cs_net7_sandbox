namespace cs_net7_sandbox
{
    class MyData<T>
    {
        public void WriteThreeTimes(T data) 
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(data);
            }
        }
    }
}
