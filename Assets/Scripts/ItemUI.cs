using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.Events;

[System.Serializable]
public class ItemUIEvent : UnityEvent<ItemUI>{}

public class ItemUI : MonoBehaviour {

    public Item item;
    public Text itemName;

    public ItemUIEvent onClicked;

	// Use this for initialization
	void Start () {
        if (item)
            Display(item);
	}
	
    public virtual void Display(Item item)
    {
        this.item = item;

        itemName.text = item.name;
    }
    public virtual void Click()
    {
        onClicked.Invoke(this);
    }
}
