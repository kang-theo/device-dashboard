using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace device_dashboard.Models
{
    public class AlarmItemModel
    {
        public int Index { get; set; }
        public string Time { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
    }
}
