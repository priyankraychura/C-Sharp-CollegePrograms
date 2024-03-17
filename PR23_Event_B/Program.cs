using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR23_Event_B
{
    public class MyEventPublisher
    {
        public event EventHandler MyEvent;

        public void RaiseEvent()
        {
            Console.WriteLine("Event is about to be raised.");
            OnMyEvent();
        }

        protected virtual void OnMyEvent()
        {
            MyEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyEventPublisher publisher = new MyEventPublisher();

            publisher.MyEvent += (sender, e) =>
            {
                Console.WriteLine("Event handled by outer reference.");
            };

            publisher.RaiseEvent();

            Console.ReadLine();
        }
    }
}
