using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public bool ballInHole = false;
    public int multiplicationFactor = 100;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ballInHole = true;
            other.GetComponent<Rigidbody>().drag = 5;
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }     
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ballInHole = false;
            other.GetComponent<Rigidbody>().drag = 1;
            gameObject.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
