using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR23_Event_A
{
    public class MyTest
    {
        private EventHandler myEventHandlers;

        public event EventHandler MyEvent
        {
            add
            {
                //myEventHandlers += value;
                Console.WriteLine("add operation.");
            }
            remove
            {
                //myEventHandlers -= value;
                Console.WriteLine("remove operation.");
            }
        }
    }

    public class Test
    {
        public void TestEvent()
        {
            MyTest myTest = new MyTest();
            myTest.MyEvent += myTest_MyEvent;
            myTest.MyEvent -= myTest_MyEvent;
        }

        public void myTest_MyEvent(object sender, EventArgs e)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.TestEvent();
            Console.ReadLine();
        }
    }
}
