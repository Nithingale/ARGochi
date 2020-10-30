using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandSettingToggler : MonoBehaviour
{
    void Start() {
        Toggle toggle = GetComponent<Toggle>();
        toggle.isOn = SettingsData.leftHanded;
        toggle.onValueChanged.AddListener((bool isOn) => {
            SettingsData.leftHanded = isOn;
        });
    }
}
