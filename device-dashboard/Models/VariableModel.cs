using CommunityToolkit.Mvvm.ComponentModel;
using System;
namespace device_dashboard.Models
{
	public class VariableModel: ObservableObject
	{
		public string Name { get; set; }

		private object _value;
		
		public object Value
		{
			get { return _value; }
			set { SetProperty<object>(ref _value, value); }
		}

		public string Unit {  get; set; }
	}
}

