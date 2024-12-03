using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

using FluentIcons.Common;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

using Richasy.WinUI.Share.ViewModels;

using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MinecraftMods
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class TestWindow
	{
		private IReadOnlyList<AppNavigationItemViewModel> GetMenuItems()
		{ 
			var list = new List<AppNavigationItemViewModel>
			{
			new AppNavigationItemViewModel(null, typeof(MainWindow), "你好", FluentIcons.Common.Symbol.Rocket, false)
		};
			return list;
		}
		public TestWindow()
		{
			this.InitializeComponent();
		}
	}
}
