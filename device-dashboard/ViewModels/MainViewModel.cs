using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using device_dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace device_dashboard.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        // 基本信息池
        public List<DeviceGroupModel> DeviceGroup { get; set; } =
            new List<DeviceGroupModel>();

        // 结合ObservableObject, 图片变化后通知 View
        private string _currentImage;

        public string CurrentImage
        {
            get { return _currentImage; }
            set { SetProperty<string>(ref _currentImage, value); }
        }

        // 绑定数据源 MVVM
        public List<DeviceItemModel> DeviceList { get; set; } =
            new List<DeviceItemModel>();

        public List<AlarmItemModel> AlarmList { get; set; } =
            new List<AlarmItemModel>();

        // UI 点击选择设备
        public RelayCommand<object> NavCommand { get; set; }

        public MainViewModel()
        {
            // 有多少个设备组
            DeviceGroup.Add(new DeviceGroupModel()
            {
                Image = "/device-dashboard;component/Assets/Images/Devices/d_1.png",
                // 里面对应多少台设备
                DeviceList = new List<DeviceItemModel>()
                {
                    new DeviceItemModel()
                    {
                        Index=11,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="进给倍率",
                                Value="0",
                            },
                            new VariableModel{
                                Name="主轴转速",
                                Value="0",
                                Unit="r/min"
                            },
                            new VariableModel{
                                Name="机床坐标-X",
                                Value="-500.000",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="机床坐标-Y",
                                Value="-122.002",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="机床坐标-Z",
                                Value="-1525.321",
                                Unit="mm"
                            },
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=12,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="进给倍率",
                                Value="0",
                            },
                            new VariableModel{
                                Name="主轴转速",
                                Value="0",
                                Unit="r/min"
                            },
                            new VariableModel{
                                Name="机床坐标-X",
                                Value="-500.000",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="机床坐标-Y",
                                Value="-122.002",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="机床坐标-Z",
                                Value="-1525.321",
                                Unit="mm"
                            },
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=13,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="进给倍率",
                                Value="0",
                            },
                            new VariableModel{
                                Name="主轴转速",
                                Value="0",
                                Unit="r/min"
                            },
                            new VariableModel{
                                Name="机床坐标-X",
                                Value="-500.000",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="机床坐标-Y",
                                Value="-122.002",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="机床坐标-Z",
                                Value="-1525.321",
                                Unit="mm"
                            },
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=14,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="进给倍率",
                                Value="0",
                            },
                            new VariableModel{
                                Name="主轴转速",
                                Value="0",
                                Unit="r/min"
                            },
                            new VariableModel{
                                Name="机床坐标-X",
                                Value="-500.000",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="机床坐标-Y",
                                Value="-122.002",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="机床坐标-Z",
                                Value="-1525.321",
                                Unit="mm"
                            },
                        }
                    }
                }
            });
            DeviceGroup.Add(new DeviceGroupModel()
            {
                Image = "/device-dashboard;component/Assets/Images/Devices/d_2.png",
                // 里面对应多少台设备
                DeviceList = new List<DeviceItemModel>()
                {
                    new DeviceItemModel()
                    {
                        Index=21,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="L编号",
                                Value="31",
                            },
                            new VariableModel{
                                Name="N编号",
                                Value="0",
                            },
                            new VariableModel{
                                Name="B编号",
                                Value="0"
                            },
                            new VariableModel{
                                Name="启动ON时间",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="加工ON时间",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="E条件编号",
                                Value="909002"
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=22,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="L编号",
                                Value="31",
                            },
                            new VariableModel{
                                Name="N编号",
                                Value="0",
                            },
                            new VariableModel{
                                Name="B编号",
                                Value="0"
                            },
                            new VariableModel{
                                Name="启动ON时间",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="加工ON时间",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="E条件编号",
                                Value="909002"
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=23,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="L编号",
                                Value="31",
                            },
                            new VariableModel{
                                Name="N编号",
                                Value="0",
                            },
                            new VariableModel{
                                Name="B编号",
                                Value="0"
                            },
                            new VariableModel{
                                Name="启动ON时间",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="加工ON时间",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="E条件编号",
                                Value="909002"
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=24,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="L编号",
                                Value="31",
                            },
                            new VariableModel{
                                Name="N编号",
                                Value="0",
                            },
                            new VariableModel{
                                Name="B编号",
                                Value="0"
                            },
                            new VariableModel{
                                Name="启动ON时间",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="加工ON时间",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="E条件编号",
                                Value="909002"
                            }
                        }
                    }
                }
            });
            DeviceGroup.Add(new DeviceGroupModel()
            {
                Image = "/device-dashboard;component/Assets/Images/Devices/d_3.png",
                // 里面对应多少台设备
                DeviceList = new List<DeviceItemModel>()
                {
                    new DeviceItemModel()
                    {
                        Index=31,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="MANUAL",
                            },
                            new VariableModel{
                                Name="关节轴-J1",
                                Value="-97.979",
                            },
                            new VariableModel{
                                Name="关节轴-J2",
                                Value="-31.493",
                            },
                            new VariableModel{
                                Name="关节轴-J3",
                                Value="-34.517",
                            },
                            new VariableModel{
                                Name="关节轴-J4",
                                Value="-0.032",
                            },
                            new VariableModel{
                                Name="关节轴-J5",
                                Value="-8.535",
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=32,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="手动",
                            },
                            new VariableModel{
                                Name="关节轴-J1",
                                Value="-97.979",
                            },
                            new VariableModel{
                                Name="关节轴-J2",
                                Value="-31.493",
                            },
                            new VariableModel{
                                Name="关节轴-J3",
                                Value="-34.517",
                            },
                            new VariableModel{
                                Name="关节轴-J4",
                                Value="-0.032",
                            },
                            new VariableModel{
                                Name="关节轴-J5",
                                Value="-8.535",
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=33,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="手动",
                            },
                            new VariableModel{
                                Name="关节轴-J1",
                                Value="-97.979",
                            },
                            new VariableModel{
                                Name="关节轴-J2",
                                Value="-31.493",
                            },
                            new VariableModel{
                                Name="关节轴-J3",
                                Value="-34.517",
                            },
                            new VariableModel{
                                Name="关节轴-J4",
                                Value="-0.032",
                            },
                            new VariableModel{
                                Name="关节轴-J5",
                                Value="-8.535",
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=34,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="手动",
                            },
                            new VariableModel{
                                Name="关节轴-J1",
                                Value="-97.979",
                            },
                            new VariableModel{
                                Name="关节轴-J2",
                                Value="-31.493",
                            },
                            new VariableModel{
                                Name="关节轴-J3",
                                Value="-34.517",
                            },
                            new VariableModel{
                                Name="关节轴-J4",
                                Value="-0.032",
                            },
                            new VariableModel{
                                Name="关节轴-J5",
                                Value="-8.535",
                            }
                        }
                    }
                }
            });
            DeviceGroup.Add(new DeviceGroupModel()
            {
                Image = "/device-dashboard;component/Assets/Images/Devices/d_4.png",
                // 里面对应多少台设备
                DeviceList = new List<DeviceItemModel>()
                {
                    new DeviceItemModel()
                    {
                        Index=41,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="MANUAL",
                            },
                            new VariableModel{
                                Name="位置坐标-X",
                                Value="50.23",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="位置坐标-Y",
                                Value="26.67",
                            },
                            new VariableModel{
                                Name="位置坐标-Z",
                                Value="10.45",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="表面粗糙度",
                                Value="0.32",
                                Unit="μm"
                            },
                            new VariableModel{
                                Name="峰谷高度",
                                Value="2.10",
                                Unit="μm"
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=42,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="MANUAL",
                            },
                            new VariableModel{
                                Name="位置坐标-X",
                                Value="50.23",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="位置坐标-Y",
                                Value="26.67",
                            },
                            new VariableModel{
                                Name="位置坐标-Z",
                                Value="10.45",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="表面粗糙度",
                                Value="0.32",
                                Unit="μm"
                            },
                            new VariableModel{
                                Name="峰谷高度",
                                Value="2.10",
                                Unit="μm"
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=43,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="MANUAL",
                            },
                            new VariableModel{
                                Name="位置坐标-X",
                                Value="50.23",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="位置坐标-Y",
                                Value="26.67",
                            },
                            new VariableModel{
                                Name="位置坐标-Z",
                                Value="10.45",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="表面粗糙度",
                                Value="0.32",
                                Unit="μm"
                            },
                            new VariableModel{
                                Name="峰谷高度",
                                Value="2.10",
                                Unit="μm"
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=44,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="MANUAL",
                            },
                            new VariableModel{
                                Name="位置坐标-X",
                                Value="50.23",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="位置坐标-Y",
                                Value="26.67",
                            },
                            new VariableModel{
                                Name="位置坐标-Z",
                                Value="10.45",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="表面粗糙度",
                                Value="0.32",
                                Unit="μm"
                            },
                            new VariableModel{
                                Name="峰谷高度",
                                Value="2.10",
                                Unit="μm"
                            }
                        }
                    }
                }
            });
            DeviceGroup.Add(new DeviceGroupModel()
            {
                Image = "/device-dashboard;component/Assets/Images/Devices/d_5.png",
                // 里面对应多少台设备
                DeviceList = new List<DeviceItemModel>()
                {
                    new DeviceItemModel()
                    {
                        Index=51,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="停止编号",
                                Value="0",
                            },
                            new VariableModel{
                                Name="开机ON时间",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="作业ON时间",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="E条件编号",
                                Value="909002",
                            },
                            new VariableModel{
                                Name="机械坐标",
                                Value="暂无",
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=52,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="停止编号",
                                Value="0",
                            },
                            new VariableModel{
                                Name="开机ON时间",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="作业ON时间",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="E条件编号",
                                Value="909002",
                            },
                            new VariableModel{
                                Name="机械坐标",
                                Value="暂无",
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=53,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="停止编号",
                                Value="0",
                            },
                            new VariableModel{
                                Name="开机ON时间",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="作业ON时间",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="E条件编号",
                                Value="909002",
                            },
                            new VariableModel{
                                Name="机械坐标",
                                Value="暂无",
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=54,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="工作模式",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="停止编号",
                                Value="0",
                            },
                            new VariableModel{
                                Name="开机ON时间",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="作业ON时间",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="E条件编号",
                                Value="909002",
                            },
                            new VariableModel{
                                Name="机械坐标",
                                Value="暂无",
                            }
                        }
                    }
                }
            });

            for (int i = 0; i < 15; i++)
            {
                AlarmList.Add(new AlarmItemModel() { Index = i + 1 });
            }

            NavCommand = new RelayCommand<object>(OnNavigation);
        }

        // 委托
        private void OnNavigation(object arg)
        {
            var group = DeviceGroup[int.Parse(arg.ToString())];
            // 显示当前级的设备图片
            CurrentImage = group.Image;

            DeviceList = group.DeviceList;
            // 与Image采用了不同的通知方法，单独通知这个属性。都可以
            this.OnPropertyChanged(nameof(DeviceList));
        }

    }
}
