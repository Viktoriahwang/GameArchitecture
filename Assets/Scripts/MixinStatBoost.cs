using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixinStatBoost : ItemMixin {

    public string stat = "Strength";
    public int amount = 5;
	public override void Use()
	{
        Debug.Log("Boosting " + stat + " " + amount);
    }


}
