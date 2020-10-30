using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultySettingSlider : MonoBehaviour
{
    void Start() {
        Slider slider = GetComponent<Slider>();
        slider.value = SettingsData.difficulty;
        slider.onValueChanged.AddListener((float value) => {
            SettingsData.difficulty = (int)value;
            GameData.foodRef = SettingsData.difficulty * 10.0f;
            GameData.sleepRef = SettingsData.difficulty * 30.0f;
            GameData.food = Mathf.Min(GameData.food, GameData.foodRef);
            GameData.sleep = Mathf.Min(GameData.sleep, GameData.sleepRef);
        });
    }
}