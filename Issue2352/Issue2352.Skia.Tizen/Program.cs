using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Issue2352.Skia.Tizen
{
	class Program
	{
		static void Main(string[] args)
		{
			var host = new TizenHost(() => new Issue2352.App(), args);
			host.Run();
		}
	}
}
