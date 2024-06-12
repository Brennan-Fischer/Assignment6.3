using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._3
{      public  class CallQueue
    {
       public Queue<CallNode> Calls {  get; set; }
       public int QueueCount { get; set; }
        public int NextCallID { get; set; }

        public CallQueue()
        {
            Calls= new Queue<CallNode>();
            NextCallID = 1000;
            Add();

            return;
        }
        public void Add()
        {
            CallNode node = new CallNode();
            node.CallID = NextCallID++;
            Calls.Enqueue(node);
            QueueCount++;
            Console.WriteLine($"Call Queue is now {QueueCount} long");
            return;
        }
        public void Answer()
        {
            Calls.Dequeue();
            QueueCount--;
            Console.WriteLine($"Call Queue is now {QueueCount} long");
        }
    }
}
