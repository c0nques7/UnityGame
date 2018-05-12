using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {
    public Item sword;

    private void Start()
    {
        List<BaseStat> swordStats = new List<BaseStat>();
        swordStats.Add(new BaseStat(6, "Power", "Your power level."));
        sword = new Item(swordStats, "sword");

    }

}
