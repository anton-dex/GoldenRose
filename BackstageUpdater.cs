using System;
namespace csharpcore
{
	public class BackstageUpdater: Updater
	{
		public BackstageUpdater(int sellIn, int quality) : base(sellIn, quality)
		{ }

		public override void UpdateMetrics()
		{
			if (Quality < 50)
				Quality++;

			if (Quality < 50)
			{
				if (SellIn < 11)
					Quality++;

				if (SellIn < 6)
					Quality++;
			}

			SellIn--;

			if (SellIn < 0)
				Quality = 0;
		}
	}
}
