using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BleydSample.Models
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Component> Components { get; set; }
        public bool IsRpeated { get; set; }
        public List<String> DaysRepeated { get; set; }
        public DateTime RepeatStartDate { get; set; }
        public DateTime RepeatEndDate { get; set; }
        public DateTime RepeatStartTime { get; set; }
        public DateTime RepeatEndTime { get; set; }
    }
}
