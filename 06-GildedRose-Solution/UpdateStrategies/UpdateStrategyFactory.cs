// ReSharper disable StringLiteralTypo

namespace csharpcore
{
    internal static class UpdateStrategyFactory
    {
        internal static UpdateStrategy Create(Item item)
        {
            if (item.Name == "Sulfuras, Hand of Ragnaros")
                return new LegendaryUpdateStrategy(item);

            if (item.Name == "Aged Brie")
                return new AgedBrieUpdateStrategy(item);

            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                return new ConcertTicketUpdateStrategy(item);

            if (item.Name.StartsWith("Conjured"))
                return new ConjuredUpdateStrategy(item);

            return new NormalUpdateStrategy(item);
        }
    }
}