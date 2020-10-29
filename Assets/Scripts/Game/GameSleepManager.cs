using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSleepManager : MonoBehaviour
{
    void Update()
    {
        if (GameData.sleep < 10.0f) {
            GetComponent<Image>().color = (int)Time.time % 2 == 1 ? new Color(1.0f, 1.0f, 1.0f, 1.0f) : new Color(0.0f, 0.0f, 1.0f, 1.0f);
        }
    }

    public void RestoreSleep() {
        GameData.sleep = 100.0f;
    }
}
