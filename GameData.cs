using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{
    private const string KEY_MAGE = "Mage";
    private const string KEY_ARCHER = "Archer";
    private const string KEY_KILLER = "Killer";
    private const string KEY_TOOTH = "Tooth";

    public static int Mage
    {
        get { return PlayerPrefs.GetInt(KEY_MAGE, 2); }
        set { PlayerPrefs.SetInt(KEY_MAGE, value); }
    }

    public static int Archer
    {
        get { return PlayerPrefs.GetInt(KEY_ARCHER, 2); }
        set { PlayerPrefs.SetInt(KEY_ARCHER, value); }
    }

    public static int Killer
    {
        get { return PlayerPrefs.GetInt(KEY_KILLER, 2); }
        set { PlayerPrefs.SetInt(KEY_KILLER, value); }
    }

    public static int Tooth
    {
        get { return PlayerPrefs.GetInt(KEY_TOOTH, 15); }
        set { PlayerPrefs.SetInt(KEY_TOOTH, value); }
    }
}
