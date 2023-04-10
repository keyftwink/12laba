namespace _12laba
{
    class EventClass
    {
        public delegate void Event(string name);
        public event Event MyEvent;
        public string name;
        public EventClass(string name)
        {
            this.name = name;
        }
        public void GenerateEvent()
        {
            if (MyEvent != null)
            {
                MyEvent.Invoke(name);
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            EventClass eventObject1 = new EventClass("event object 1");
            EventClass eventObject2 = new EventClass("event object 2");

            eventObject1.MyEvent += HandleEvent;
            eventObject2.MyEvent += HandleEvent;

            eventObject1.GenerateEvent();
            eventObject2.GenerateEvent();
        }


        public static void HandleEvent(string eventName)
        {
            Console.WriteLine("событие: " + eventName);
        }
    }
}