using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace device_dashboard.Models
{
    public class DeviceItemModel
    {
        public int Index { get; set; }
        private bool _isWarning {  get; set; }

        public List<VariableModel> VariableList { get; set; }
    }
}
