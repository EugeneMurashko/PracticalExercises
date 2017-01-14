using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassCounter Counter = new ClassCounter();
            ClassEvent_1 Event_1 = new ClassEvent_1();
            ClassEvent_2 Event_2 = new ClassEvent_2();

            Counter.onCount += Event_1.Message;
            Counter.onCount += Event_2.Message;

            Counter.Count();
            Console.ReadLine();
        }
    }

    class ClassCounter
    {
        public delegate void MethodContainer();

        public event MethodContainer onCount;

        public void Count()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    onCount();
                }
            }
        }
    }

    class ClassEvent_1
    {
        public void Message()
        {
            Console.WriteLine("Event 1");
        }
    }

    class ClassEvent_2
    {
        public void Message()
        {
            Console.WriteLine("Event 2");
        }
    }
}
