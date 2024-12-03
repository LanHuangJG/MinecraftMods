using MinecraftMods.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MinecraftMods
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainWindow
	{
		public MainViewModel ViewModel = new();
		public MainWindow()
		{
			this.InitializeComponent();
			ExtendsContentIntoTitleBar = true;
			AppWindow.TitleBar.IconShowOptions = Microsoft.UI.Windowing.IconShowOptions.HideIconAndSystemMenu;
			AppWindow.TitleBar.PreferredHeightOption = Microsoft.UI.Windowing.TitleBarHeightOption.Tall;
			this.SetTitleBar(MyTitleBar);
			MyTitleBar.Window = this;
		}
	}
}
