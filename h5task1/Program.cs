namespace h5task1
{
    interface IDeveloper : IComparable<IDeveloper>
    {
        string Tool { get; set; }
        void Info();
    }

    class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        private string language;
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }
        public Programmer(string language) 
        {
            this.language = language;
        }
        public void Info() { Console.WriteLine($"Hi, I'm a programmer and my programming language is {Tool}"); }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }

    class Builder : IDeveloper, IComparable<IDeveloper>
    {
        private string tool;
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }
        public Builder(string tool)
        {
            this.tool = tool;
        }
        public void Info() { Console.WriteLine($"Hi, I'm a builder and my tool is {Tool}"); }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer("C#"));
            developers.Add(new Programmer("Javascript"));
            developers.Add(new Programmer("C++"));
            developers.Add(new Builder("Hammer"));
            developers.Add(new Builder("Screwdriver"));
            developers.Add(new Builder("Drill"));

            for (int i = 0; i < developers.Count; i++)
            {
                developers[i].Info();
            }
            developers.Sort();

            for (int i = 0; i < developers.Count; i++)
            {
                developers[i].Info();
            }
        }
    }
}