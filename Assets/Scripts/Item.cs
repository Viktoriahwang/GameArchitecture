using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class ItemEvent : UnityEvent<Item> { }

public class Item : MonoBehaviour {

    public bool consumable = true;

    //returns true if item is kept, false if destroyed
    public bool Use()
    {
        return !consumable;
    }
}
