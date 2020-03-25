namespace csharpcore
{
    static class ItemFactory
    {
        public static Item GetItemByType(string name, int sellIn, int quality)
        {
            switch (name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    return new Item() { Name = name, SellIn = sellIn, Quality = quality };
                case "Aged Brie":
                    return new AgeBrie() { Name = name, SellIn = sellIn, Quality = quality };
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new Backstage() { Name = name, SellIn = sellIn, Quality = quality };
                case "Conjured Mana Cake":
                    return new Conjured() { Name = name, SellIn = sellIn, Quality = quality };
                default:
                    return new Normal() { Name = name, SellIn = sellIn, Quality = quality };
            }
        }
    }
}
