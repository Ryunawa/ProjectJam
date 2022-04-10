using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BonusPath
{
    public enum BonusPathValue
    {
        Snowflake,
        Sword,
        Boots,
        Chococoin
    }

    public static string BPToString(BonusPathValue bp)
    {
        return bp switch
        {
            BonusPathValue.Snowflake => "Snowflake",
            BonusPathValue.Sword => "Sword",
            BonusPathValue.Boots => "Boots",
            _ => "Chococoin"
        };
    }
};

