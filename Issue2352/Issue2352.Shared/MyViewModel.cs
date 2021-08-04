using System;
using System.Collections.Generic;
using System.Text;

namespace Issue2352
{
	public class MyViewModel
	{
		public string Message => $"1st line of 5-line message {Environment.NewLine} 2nd line {Environment.NewLine} 3rd line {Environment.NewLine} 4th line {Environment.NewLine} 5th line.";
	}
}
