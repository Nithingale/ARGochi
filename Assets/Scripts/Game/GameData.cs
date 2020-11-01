using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{
    public static float foodRef = SettingsData.difficulty * 10.0f;
    public static float sleepRef = SettingsData.difficulty * 30.0f;

    public static float food = foodRef;
    public static float sleep = sleepRef;
    public static bool isAlive = true;

    public static bool playFeed = false;
    public static bool playSleep = false;
    public static bool playDie = false;
}