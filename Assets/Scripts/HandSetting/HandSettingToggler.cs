using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandSettingToggler : MonoBehaviour
{
    private Toggle toggle;

    void Start() {
        toggle = GetComponent<Toggle>();
        toggle.isOn = HandSettingData.leftHanded;
        toggle.onValueChanged.AddListener((bool isOn) => {
            HandSettingData.leftHanded = isOn;
        });
    }
}
