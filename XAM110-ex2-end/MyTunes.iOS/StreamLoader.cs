using System.IO;
using MyTunes.Shared;

namespace MyTunes
{
	public class StreamLoader : IStreamLoader
	{
		public Stream GetStreamForFilename(string filename)
		{
			return File.OpenRead(filename);
		}
	}
}
