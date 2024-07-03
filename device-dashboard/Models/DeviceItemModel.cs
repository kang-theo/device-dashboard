using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace device_dashboard.Models
{
    public class DeviceItemModel: ObservableObject // 可通知类型
    {
        public int Index { get; set; }
        private bool _isWarning;

        public bool IsWarning
        {
            get { return _isWarning; }
            set { SetProperty<bool>(ref _isWarning, value); }
        }

        public List<VariableModel> VariableList { get; set; }
    }
}
