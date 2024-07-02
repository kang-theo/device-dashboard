using device_dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace device_dashboard.ViewModels
{
    public class MainViewModel
    {
        // 绑定数据源 MVVM
        public List<DeviceItemModel> DeviceList { get; set; } =
            new List<DeviceItemModel>();

        public MainViewModel()
        {
            DeviceList.Add(new DeviceItemModel() { Index = 1 });
            DeviceList.Add(new DeviceItemModel() { Index = 2 });
            DeviceList.Add(new DeviceItemModel() { Index = 3 });
            DeviceList.Add(new DeviceItemModel() { Index = 4 });
        }
    }
}
