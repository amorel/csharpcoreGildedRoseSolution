namespace csharpcore
{
    public class Item
    {
        private const int MAX_QUALITY = 50;
        private const int MIN_SELLIN = 0;

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public virtual void upgrade() { }
        public void downgradeQuality()
        {
            if (Quality > MIN_SELLIN)
                Quality--;
        }

        public void improveQuality()
        {
            if (Quality < MAX_QUALITY)
                Quality = Quality++;
        }
    }
}
