using System;
using System.Text;

namespace DemoApp
{
	public class LinkDetailsViewModel
	{
		public Dictionary<string, object> ReferringParams { get; set; }

		public string BranchLinkData
		{
			get
			{
				var values = new StringBuilder();
				foreach (var item in ReferringParams)
					values.Append($"{item.Key}: {item.Value} {Environment.NewLine}");

				return values.ToString();
			}
		}
    }
}

