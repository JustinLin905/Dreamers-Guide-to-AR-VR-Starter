using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMetadata {
    public int id;
    public string name;
    public string description;
    public float price;
}

public static class ItemDictionary
{
    private static Dictionary<int, ItemMetadata> items = new Dictionary<int, ItemMetadata>();

    static ItemDictionary()
    {
        items.Add(0, new ItemMetadata { id = 0, name = "Watermelon Sword", description = "A delicious and refreshing melee weapon. High in nutrients.", price = 10.0f });
        items.Add(1, new ItemMetadata { id = 1, name = "Popsicle Sword", description = "A cool tool for summer battles.", price = 20.0f });
        items.Add(2, new ItemMetadata { id = 2, name = "Chibi Cat", description = "An adorable pet cat. Bring them home today!", price = 30.0f });
    }

    public static ItemMetadata GetItem(int id)
    {
        return items[id];
    }
}