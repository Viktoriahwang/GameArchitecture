using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour {

    public static Inventory playerInventory;

    public List<Item> items;
    public bool isPlayerInventory = false;

    public UnityEvent onChanged;

	// Use this for initialization
	void Awake () {
        if (isPlayerInventory)
            playerInventory = this;
	}
	
	// Update is called once per frame
    public void Add(Item item)
    {
        items.Add(item);
        onChanged.Invoke();
    }

    public void Remove(Item item)
	{
        if (items.Contains(item))
           return;

        items.Remove(item);
        onChanged.Invoke();
	}
}
