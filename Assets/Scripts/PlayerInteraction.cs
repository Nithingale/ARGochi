using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private float force = 100.0f;
    private Rigidbody rb;
    private float initialPos = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject chaos = GameObject.FindWithTag("chaos");
        if (chaos) {
            chaos.transform.position = new Vector3(
                chaos.transform.position.x,
                chaos.transform.position.y + initialPos,
                chaos.transform.position.z
            );
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Jump()
    {
        GameObject chaos = GameObject.FindWithTag("chaos");
        if (chaos) 
            chaos.GetComponent<Rigidbody>().AddForce(Random.Range(-10.0f, 10.0f), force, Random.Range(-10.0f, 10.0f));
    }

    public void Stand()
    {
        GameObject chaos = GameObject.FindWithTag("chaos");
        if (chaos) {
            chaos.transform.eulerAngles = new Vector3(
                chaos.transform.eulerAngles.x,
                chaos.transform.eulerAngles.y,
                0
            );
        }
    }
}
