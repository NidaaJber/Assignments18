using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContainer<T>
{
    private T item;

    public void SetItem(T item)
    {
        this.item = item;
    }

    public T GetItem()
    {
        return item;
    }
}

public static class GameUtils
{
    public static string DescribeItem<T>(T something)
    {
        return $"This item is {something}.";
    }
}

public class GenericsTest : MonoBehaviour
{
    void Start()
    {
       
        GameContainer<string> gameContainer = new GameContainer<string>();
        gameContainer.SetItem("Healing Potion");

        
        string storedItem = gameContainer.GetItem();
        Debug.Log("Stored item: " + storedItem);

        
        string description = GameUtils.DescribeItem(storedItem);
        Debug.Log(description);
    }
}



