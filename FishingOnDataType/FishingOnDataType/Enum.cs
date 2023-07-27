using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingOnDataType
{
    public class Enum
    {
        public enum weekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        };

        public enum systemStatus
        {
            Active,
            Inactive,
            Hold,
            Pending,
            Approved
        }

        public void Print()
        {
            Console.WriteLine($"Weekend of hSenid is : {weekDays.Friday} & {weekDays.Saturday}");
            Console.WriteLine($"My Employement Status is : {systemStatus.Active}");
        }
    }
}
