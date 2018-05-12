using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    public List<BaseStat> stats = new List<BaseStat>();

    void Start()
    {
        stats.Add(new BaseStat(4, "Power", "Your power level."));
        stats.Add(new BaseStat(2, "Vitality", "Your vitality level."));

    }

    public void AddStatBonus(List<BaseStat> statBonses)
    {
        foreach(BaseStat statBonus in statBonuses)
        {
            stats.Find(x => x.StatName == statBonses.StatName).AddStatBonus(new StatBonus(statBonus.BaseValue));
        }
    }

    public void RemoveStatBonus(List<BaseStat> statBonses)
    {
        foreach (BaseStat statBonus in statBonuses)
        {
            stats.Find(x => x.StatName == statBonses.StatName).RemoveStatBonus(new StatBonus(statBonus.BaseValue));
        }
    }


}
