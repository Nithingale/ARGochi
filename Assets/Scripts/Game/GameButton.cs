using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameButton : MonoBehaviour
{
    public string dataType;
    public GameObject chaos;

    private Image image;

    void Start() {
        image = GetComponent<Image>();
    }

    void Update() {
        if (dataType == "food") {
            if (GameData.food < Mathf.Max(GameData.foodRef / 10.0f, 10.0f)) image.color = (int)Time.time % 2 == 0 ? new Color(1.0f, 1.0f, 1.0f, 1.0f) : new Color(1.0f, 0.0f, 0.0f, 1.0f);
            else image.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        } else if (dataType == "sleep") {
            if (GameData.sleep < Mathf.Max(GameData.sleepRef / 10.0f, 10.0f)) image.color = (int)Time.time % 2 == 0 ? new Color(1.0f, 1.0f, 1.0f, 1.0f) : new Color(0.0f, 0.0f, 1.0f, 1.0f);
            else image.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
    }

    public void Restore() {
        if (dataType == "food") {
            GameData.food = GameData.foodRef;
            Animation anim = chaos.GetComponent<Animation>();
            int i = 0;
            foreach (AnimationState state in anim) {
                if (i == 1) {
                    anim.Play(state.name);
                    break;
                }
                i++;
            }
        } else if (dataType == "sleep") {
            GameData.sleep = GameData.sleepRef;
            Animation anim = chaos.GetComponent<Animation>();
            int i = 0;
            foreach (AnimationState state in anim) {
                if (i == 3) {
                    anim.Play(state.name);
                    break;
                }
                i++;
            }
        }
    }
}
