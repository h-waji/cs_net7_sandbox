namespace cs_net7_sandbox
{
    class Team
    {
        private string[] members = new string[3];
        public string this[int i]
        {
            get { return members[i]; }
            set { members[i] = value; }
        }
    }
}
