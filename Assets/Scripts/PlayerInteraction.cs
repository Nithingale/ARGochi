using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float force = 1000.0f;
    private Rigidbody rb;
    public float initialPos = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject chaos = GameObject.Find("Chaos");
        if (chaos) {
            chaos.transform.eulerAngles = new Vector3(
                chaos.transform.eulerAngles.x,
                chaos.transform.eulerAngles.y + initialPos,
                chaos.transform.eulerAngles.z
            );
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Jump()
    {
        GameObject chaos = GameObject.Find("Chaos");
        if (chaos) 
            chaos.GetComponent<Rigidbody>().AddForce(Random.Range(-10.0f, 10.0f), force, Random.Range(-10.0f, 10.0f));
    }

    public void Stand()
    {
        GameObject chaos = GameObject.Find("Chaos");
        if (chaos) {
            chaos.transform.eulerAngles = new Vector3(
                chaos.transform.eulerAngles.x,
                chaos.transform.eulerAngles.y,
                0
            );
        }
    }
}
