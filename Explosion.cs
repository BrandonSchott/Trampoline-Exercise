using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    float velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        velocity = other.transform.GetComponent<Rigidbody>().velocity.y;
        Debug.Log(velocity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(velocity <= -1.5)
        {
            collision.rigidbody.AddForce(new Vector3(0, -velocity * 0.9f, 0), ForceMode.Impulse);
        }
    }
}
