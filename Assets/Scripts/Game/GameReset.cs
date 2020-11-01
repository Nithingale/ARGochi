using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameReset : MonoBehaviour
{
    public void Reset() {
        if (GameData.isAlive == false) {
            GameData.isAlive = true;
            GameData.foodRef = SettingsData.difficulty * 10.0f;
            GameData.sleepRef = SettingsData.difficulty * 30.0f;
            GameData.food = GameData.foodRef;
            GameData.sleep = GameData.sleepRef;
        }
    }
}
