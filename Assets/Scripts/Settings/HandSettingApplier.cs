using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandSettingApplier : MonoBehaviour
{
    void Start() {
        if (SettingsData.leftHanded == true) {
            RectTransform rect = GetComponent<RectTransform>();
            rect.anchorMin = new Vector2((rect.anchorMin.x + 1) % 2, rect.anchorMin.y);
            rect.anchorMax = new Vector2((rect.anchorMax.x + 1) % 2, rect.anchorMax.y);
            rect.anchoredPosition = new Vector2(-rect.anchoredPosition.x, rect.anchoredPosition.y);
        }
    }
}
