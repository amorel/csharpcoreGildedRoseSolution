using System.Collections.Generic;

namespace csharpcore
{
    public class Normal : Item
    {
        public override void upgrade()
        {
            SellIn--;
            downgradeQuality();
            if (SellIn < 0) downgradeQuality();
        }
    }
    public class Backstage : Item
    {
        public override void upgrade()
        {
            SellIn--;
            improveQuality();
            if (SellIn < 10) improveQuality();
            if (SellIn < 5) improveQuality();
            if (SellIn < 0) Quality = 0;
        }
    }
    public class AgeBrie : Item
    {
        public override void upgrade()
        {
            SellIn--;
            improveQuality();
            if (SellIn < 0) improveQuality();
        }
    }
    public class Conjured : Item
    {
        public override void upgrade()
        {
            SellIn--;
            var i = 2;
            while (i-- > 0)
            {
                downgradeQuality();
                if (SellIn < 0) downgradeQuality();
            }
        }
    }

    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items) item.upgrade();
        }
    }
}
