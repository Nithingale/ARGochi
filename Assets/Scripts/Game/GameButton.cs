﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameButton : MonoBehaviour
{
    public string dataType;
    public GameObject chaos;

    private Image image;
    private Animator animator;

    void Start() {
        image = GetComponent<Image>();
        animator = chaos.GetComponent<Animator>();
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
            animator.SetBool("Eat", true);
        } else if (dataType == "sleep") {
            GameData.sleep = GameData.sleepRef;
            animator.SetBool("Sleep", true);
        }
    }
}
