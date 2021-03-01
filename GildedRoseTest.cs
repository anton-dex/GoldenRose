using Xunit;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRoseTest
    {
        [Fact]
        public void Foo()
        {
            var Items = new List<Item> { new Item("foo", 0, 0) };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }

		[Fact]
		public void AgedBrieItemTest()
		{
			var Items = new List<Item> { new Item("Aged Brie", 1, 0) };
			var app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.Equal(0, Items[0].SellIn);
			Assert.Equal(1, Items[0].Quality);

			app.UpdateQuality();
			Assert.Equal(-1, Items[0].SellIn);
			Assert.Equal(3, Items[0].Quality);
		}

		[Fact]
		public void SulfurasItemTest()
		{
			var Items = new List<Item> { new Item("Sulfuras, Hand of Ragnaros", 0, 80) };
			var app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.Equal(0, Items[0].SellIn);
			Assert.Equal(80, Items[0].Quality);

			app.UpdateQuality();
			Assert.Equal(0, Items[0].SellIn);
			Assert.Equal(80, Items[0].Quality);
		}

		[Fact]
		public void BackstageItemTest()
		{
			var Items = new List<Item> { new Item("Backstage passes to a TAFKAL80ETC concert", 6, 20) };
			var app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.Equal(5, Items[0].SellIn);
			Assert.Equal(22, Items[0].Quality);

			app.UpdateQuality();
			Assert.Equal(4, Items[0].SellIn);
			Assert.Equal(25, Items[0].Quality);
		}

		[Fact]
		public void ElixirItemTest()
		{
			var Items = new List<Item> { new Item("Elixir of the Mongoose", 5, 7) };
			var app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.Equal(4, Items[0].SellIn);
			Assert.Equal(6, Items[0].Quality);

			app.UpdateQuality();
			Assert.Equal(3, Items[0].SellIn);
			Assert.Equal(5, Items[0].Quality);
		}
	}
}