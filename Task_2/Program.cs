using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo User1 = new UserInfo();
            UserInfo User2 = new UserInfo(Name: "Alex");
            UserInfo User3 = new UserInfo(Name: "Alex", Age: 26);

            Console.WriteLine("User1");
            Console.WriteLine("Name: " + User1.Name);
            Console.WriteLine("Age: " + User1.Age);
            Console.WriteLine("");

            Console.WriteLine("User2");
            Console.WriteLine("Name: " + User2.Name);
            Console.WriteLine("Age: " + User2.Age);
            Console.WriteLine("");

            Console.WriteLine("User3");
            Console.WriteLine("Name: " + User3.Name);
            Console.WriteLine("Age: " + User3.Age);

            Console.ReadLine();
        }
    }

    class UserInfo
    {
        public string Name { get; set; }
        public byte Age { get; set; }

        public UserInfo() { }
        public UserInfo(string Name)
        {
            this.Name = Name;
        }
        public UserInfo(string Name, byte Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
