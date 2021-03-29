namespace csharpcore
{
    internal abstract class UpdateStrategy
    {
        protected UpdateStrategy(Item item)
        {
            this.item = item;
        }

        internal abstract void Update();

        #region Internals (for inheriting classes)

        private const int MinQuality = 0;
        private const int MaxQuality = 50;
        private readonly Item item;

        protected bool IsExpired()
        {
            return item.SellIn < 0;
        }

        protected int GetDaysBeforeExpiring()
        {
            return item.SellIn;
        }

        protected void DecreaseSellInByOne()
        {
            item.SellIn -= 1;
        }

        protected void IncreaseQualityBy(int increase)
        {
            item.Quality += increase;

            if (item.Quality > MaxQuality)
                item.Quality = MaxQuality;
        }

        protected void DecreaseQualityBy(int decrease)
        {
            item.Quality -= decrease;

            if (item.Quality < MinQuality)
                ResetQuality();
        }

        protected void ResetQuality()
        {
            item.Quality = MinQuality;
        }

        #endregion
    }
}