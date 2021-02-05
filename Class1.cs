using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Class1 : TaskList
    {
        public string TaskName { get; set; }
        public string Priority { get; set; }
        public string Complexity { get; set; }
        public int Days { get; set; }


        public override int GeneralTime()
        {
            int result = Days;
            return result;
        }
        public void ToStringPriority() { }
        public void ToStringNDays() { }

        public void AddToLists() { 
        }

    }
}
