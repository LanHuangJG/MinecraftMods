using CommunityToolkit.Mvvm.Input;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MinecraftMods.Controls
{
	public sealed partial class IconButton : UserControl
	{
		public IconButton()
		{
			this.InitializeComponent();
		}
		public string Text
		{
			get => (string)GetValue(TextProperty);
			set => SetValue(TextProperty, value);
		}
		public FluentIcons.Common.Symbol Icon
		{
			get => (FluentIcons.Common.Symbol)GetValue(IconProperty);
			set => SetValue(IconProperty, value);
		}
		public IRelayCommand Command
		{
			get => (IRelayCommand)GetValue(CommandProperty);
			set => SetValue(CommandProperty, value);
		}
		public static readonly DependencyProperty TextProperty =
		 DependencyProperty.Register(
			 nameof(Text),
			typeof(string),
		 typeof(IconButton),
		 new PropertyMetadata(default));
		public static readonly DependencyProperty IconProperty =
		 DependencyProperty.Register(
			 nameof(Icon),
			 typeof(FluentIcons.Common.Symbol),
		 typeof(IconButton),
		 new PropertyMetadata(default));

		public static readonly DependencyProperty CommandProperty =
		 DependencyProperty.Register(
			 nameof(Command),
			 typeof(IRelayCommand),
		 typeof(IconButton),
		 new PropertyMetadata(default));
	}
}
