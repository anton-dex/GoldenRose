using System;
namespace csharpcore
{
	public class SulfurasUpdater : Updater
	{
		public SulfurasUpdater(int sellIn, int quality) : base(sellIn, quality)
		{ }

		/// <summary>
		/// Quality and SellIn don't change
		/// </summary>
		public override void UpdateMetrics()
		{ }
	}
}
