using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUpdater : MonoBehaviour
{
    void Update()
    {
        GameData.food -= Time.deltaTime;
        GameData.sleep -= Time.deltaTime;

        if (GameData.food < 0.0f || GameData.sleep < 0.0f) GameData.isAlive = false;
    }
}
