using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour {

    public Inventory inventory;
    public Transform content;
    public ItemUI itemUIPrefab;

	// Use this for initialization
	void Start () {
        if (inventory)
            Display(inventory);
	}
	
    public virtual void Display(Inventory i)
    {
        if (this.inventory) 
        {
            this.inventory.onChanged.RemoveListener(Refresh);
        }
        this.inventory = i;
        this.inventory.onChanged.AddListener(Refresh);
        Refresh();
    }

    //visual refresh. Changes itemUI stuff
    public virtual void Refresh()
    {
        foreach(Transform t in content)
        {
            Destroy(t.gameObject);
        }

        foreach (Item i in inventory.items)
        {
            ItemUI ui = ItemUI.Instantiate(itemUIPrefab, content);
            ui.onClicked.AddListener(UIClicked);
            ui.Display(i);
        }
    }

    public virtual void UIClicked(ItemUI iui)
    {
        Inventory.playerInventory.Add(iui.item);
        inventory.Remove(iui.item);

        Destroy(iui.gameObject);
    }
}
