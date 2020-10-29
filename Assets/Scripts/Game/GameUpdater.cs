using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUpdater : MonoBehaviour
{
    void Update()
    {
        GameData.food -= Time.deltaTime;
        GameData.sleep -= Time.deltaTime;
    }
}
