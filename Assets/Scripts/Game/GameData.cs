using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{
    public static float foodRef = SettingsData.difficulty * 10.0f;
    public static float sleepRef = SettingsData.difficulty * 25.0f;

    public static float food = foodRef;
    public static float sleep = sleepRef;
    public static bool isAlive = true;
}