using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftMods.Entries
{
	public record ModItem(
		string Slug,
		string Author,
		string Title,
		string Description,
		string Icon,
		List<string> Gallery
	);
}
