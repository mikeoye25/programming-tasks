using System;
using System.Collections.Generic;

namespace TestDataPreparation.Challenges
{
    public static class UniqueArrayItems
    {
        public static int[] Execute(int[] items)
        {
            var itemsLength = items.Length;
            if (itemsLength <= 0)
            {
                Console.WriteLine($"No items!");
                return new int[0];
            }
            var uniqueItemsDict = new Dictionary<int, int>();
            for (var i = 0; i < itemsLength; i++)
            {
                var item = items[i];
                if(!uniqueItemsDict.ContainsKey(item))
                {
                    Console.WriteLine($"{i + 1}: {item}");
                    uniqueItemsDict.Add(item, 1);
                }
            }
            int[] uniqueItems = new int[uniqueItemsDict.Count];
            var index = 0;
            foreach(var uniqueItem in uniqueItemsDict)
            {
                uniqueItems[index] = uniqueItem.Key;
                index++;
            }
            return uniqueItems;
        }
    }
}
