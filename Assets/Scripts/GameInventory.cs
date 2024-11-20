using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<string> items = new List<string>();

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void ShowItems()
    {
        foreach (var item in items)
        {
            Debug.Log(item);
        }
    }

    public static Inventory operator +(Inventory a, Inventory b)
    {
        Inventory combined = new Inventory();

        
        combined.items.AddRange(a.items);
        combined.items.AddRange(b.items);

        return combined;
    }
}

public class GameInventory : MonoBehaviour
{
    void Start()
    {
     
        Inventory potionInventory = new Inventory();
        potionInventory.AddItem("Potion of Healing");
        potionInventory.AddItem("Potion of Strength");

        Inventory elixirInventory = new Inventory();
        elixirInventory.AddItem("Elixir");
        elixirInventory.AddItem("Elixir of Darkness");

      
        Inventory combinedInventory = potionInventory + elixirInventory;

        
        combinedInventory.ShowItems();
    }
}

