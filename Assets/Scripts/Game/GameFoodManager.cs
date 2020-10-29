using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFoodManager : MonoBehaviour
{
    void Update()
    {
        if (GameData.food < 10.0f) {
            GetComponent<Image>().color = (int)Time.time % 2 == 0 ? new Color(1.0f, 1.0f, 1.0f, 1.0f) : new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
    }

    public void RestoreFood() {
        GameData.food = 100.0f;
    }
}
