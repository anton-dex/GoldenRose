namespace csharpcore
{
    public class Item
    {
		public readonly string Name;

        public int SellIn { get; private set; }

        public int Quality { get; private set; }

		private Updater updater;

		public Item(string name, int sellIn, int quality)
		{
			Name = name;
			SellIn = sellIn;
			Quality = quality;

			updater = ChooseUpdater();
		}

		public Updater ChooseUpdater()
		{
			if (Name == "Aged Brie")
				return new AgedBrieUpdater(SellIn, Quality);

			if (Name == "Backstage passes to a TAFKAL80ETC concert")
				return new BackstageUpdater(SellIn, Quality);

			if (Name == "Sulfuras, Hand of Ragnaros")
				return new SulfurasUpdater(SellIn, Quality);

			return new Updater(SellIn, Quality);
		}

		/// <summary>
		/// Update quality and sellIn metrics
		/// </summary>
		public void UpdateMetrcs()
		{
			updater.UpdateMetrics();

			SellIn = updater.SellIn;
			Quality = updater.Quality;
		}
    }
}
