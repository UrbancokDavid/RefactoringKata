﻿using System;
using System.Collections.Generic;
using static RefactoringKata.SaleItems;

namespace RefactoringKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IList<Item> items = new List<Item> {
                new Item { Name = DEXTERITY_VEST, SellIn = 10, Quality = 20 },
                new Item { Name = AGED_BRIE,      SellIn = 2,  Quality = 0  },
                new Item { Name = ELIXIR,         SellIn = 5,  Quality = 7  },
                new Item { Name = SULFURAS,       SellIn = 0,  Quality = 80 },
                new Item { Name = SULFURAS,       SellIn = -1, Quality = 80 },
                new Item { Name = BACKSTAGE_PASS, SellIn = 15, Quality = 20 },
                new Item { Name = BACKSTAGE_PASS, SellIn = 10, Quality = 49 },
                new Item { Name = BACKSTAGE_PASS, SellIn = 5,  Quality = 49 },
				new Item { Name = CONJURED_MANA,  SellIn = 3,  Quality = 6  }
            };

            var app = new GildedRose(items);
            
            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine($"-------- day {i} --------");
                Console.WriteLine("Name, SellIn, Quality");

                foreach (var item in items)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine();

                app.UpdateQuality();
            }
        }
    }
}
