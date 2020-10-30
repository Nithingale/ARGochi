using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBar : MonoBehaviour
{
    public string dataType;

    private RectTransform bar;
    private float refBarPosY;
    private float refBarHeight; 

    void Start() {
        bar = GetComponent<RectTransform>();
        refBarPosY = bar.anchoredPosition.y;
        refBarHeight = bar.sizeDelta.y;
    }

    void Update() {
        float progress = dataType == "food" ? GameData.food / GameData.foodRef : dataType == "sleep" ? GameData.sleep / GameData.sleepRef : 0.0f;
        bar.anchoredPosition = new Vector2(bar.anchoredPosition.x, refBarPosY - (1.0f - progress) * (refBarHeight / 2.0f));
        bar.sizeDelta = new Vector2(bar.sizeDelta.x, refBarHeight * progress);
    }
}
