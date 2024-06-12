using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._3
{
    public class CallNode
    {
        public int? CallID {  get; set; }
        DateTime CallDate { get; set; }

       public CallNode()
        {
            CallDate = DateTime.Now;
            return;
        }
    }


}
