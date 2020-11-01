using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayer : MonoBehaviour
{
    void Update() {
        if (GameData.playFeed == true) {
            GetComponent<Animator>().SetTrigger("Eat");
            GameData.playFeed = false;
        } else if (GameData.playSleep == true) {
            GetComponent<Animator>().SetTrigger("Sleep");
            GameData.playSleep = false;
        } else if (GameData.playDie == true) {
            GetComponent<Animator>().SetTrigger("Die");
            GameData.playDie = false;
        }
    }
}
