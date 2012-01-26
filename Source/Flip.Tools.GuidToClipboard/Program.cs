using System;
using System.Windows.Forms;



namespace Flip.Tools.GuidToClipboard
{

	internal class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Clipboard.SetText(Guid.NewGuid().ToString().ToLower());
		}

	}

}
