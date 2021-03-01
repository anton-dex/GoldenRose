namespace csharpcore
{
	public class Updater
	{
		public int SellIn { get; protected set; }
		public int Quality { get; protected set; }

		public Updater(int sellIn, int quality)
		{
			SellIn = sellIn;
			Quality = quality;
		}

		public virtual void UpdateMetrics()
		{
			if (Quality > 0)
				Quality--;

			SellIn--;

			if (SellIn < 0 && Quality > 0)
				Quality--;

		}
	}
}
