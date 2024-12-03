using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using MinecraftMods.Entries;
namespace MinecraftMods.ViewModels
{
	public partial class MainViewModel : ObservableObject
	{
		[ObservableProperty]
		public string keyWord;

		[ObservableProperty]
		public List<ModItem> modItems;

		[RelayCommand]
		public void Search()
		{
			Task.Run(async () =>
			{
				using var client = new HttpClient();
				var json = await client.GetStringAsync("https://api.modrinth.com/v2/search");
				List<ModItem> modItems = [];
				JsonNode node = JsonNode.Parse(json)!;
				foreach (var hit in node["hits"]!.AsArray())
				{
					List<string> gallery = [];
					foreach (var item in hit["gallery"]!.AsArray())
					{
						gallery.Add(item!.GetValue<string>());
					}
					modItems.Add(
						new ModItem(
								hit["slug"]!.GetValue<string>(),
								hit["author"]!.GetValue<string>(),
								hit["title"]!.GetValue<string>(),
								hit["description"]!.GetValue<string>(),
								hit["icon_url"]!.GetValue<string>(),
								gallery
							)
					);
				}
				Debug.WriteLine(modItems[0].Icon);
				App.DispatcherQueue.TryEnqueue(() =>
				{
					ModItems = modItems;
				});
			});
		}
	}
}
