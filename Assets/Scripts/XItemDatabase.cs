using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {
    public List<Item> items = new List<Item>();

    void Awake()
    {
        items.Add(new Item("Glove", 0, "Rocky gloves.", 20, 0, Item.ItemType.Weapon));
        items.Add(new Item("Bazuka", 1, "Un poco abusador.", 200, 0, Item.ItemType.Weapon));
    }
	
}
