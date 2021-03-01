using System;
namespace csharpcore
{
	public class AgedBrieUpdater : Updater
	{
		public AgedBrieUpdater(int sellIn, int quality) : base(sellIn, quality)
		{ }

		public override void UpdateMetrics()
		{
			if (Quality < 50)
				Quality++;

			SellIn--;

			if (SellIn < 0 && Quality < 50)
				Quality++;
		}
	}
}
