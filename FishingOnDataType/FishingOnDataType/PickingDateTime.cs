using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingOnDataType 
{
    public class PickingDateTime
    {
        public DateTime currentDateTimeNow = DateTime.Now;
        public DateTime onlyCurrentDate = DateTime.Now;
        public void Print()
        {
            Console.WriteLine($"Current Date Time Now : {currentDateTimeNow}");
            Console.WriteLine($"Only Current Date : {onlyCurrentDate}");

        }
    }
}
