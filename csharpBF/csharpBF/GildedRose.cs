using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                    switch (Items[i].Name)
                    {
                        case "Sulfuras, Hand of Ragnaros":
                            break;

                        case "Aged Brie":
                            Items[i].SellIn--;
                            if (Items[i].Quality < 50)
                            {
                                if (Items[i].SellIn < 0)
                                    Items[i].Quality += 2;
                                else
                                    Items[i].Quality++;
                            }
                            break;

                        case "Backstage passes to a TAFKAL80ETC concert":
                            Items[i].SellIn--;
                            if (Items[i].SellIn < 10 && Items[i].Quality < 50)
                                Items[i].Quality ++;
                            if (Items[i].SellIn < 5 && Items[i].Quality < 50)
                                Items[i].Quality ++;

                            if (Items[i].Quality < 50)
                                Items[i].Quality++;
                            if (Items[i].SellIn < 0)
                                Items[i].Quality = 0;
                            break;

                        case "Conjured Mana Cake":
                            if (Items[i].Quality > 0)
                                Items[i].Quality -= 2;
                                Items[i].SellIn--;
                            break;

                        default:
                            Items[i].SellIn--;
                            if (Items[i].Quality > 0 && Items[i].Quality < 50)
                            {
                                if (Items[i].SellIn < 0)
                                        Items[i].Quality -= 2;
                                else  
                                        Items[i].Quality--;
                            }
                            break;
                    }
                
            }
        }
    }
    
}
