using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceleratorController : MonoBehaviour
{
    public float acceleratorStrength = 10;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<Rigidbody>().AddForce(transform.right * acceleratorStrength, ForceMode.Impulse);
        }
    }
}
