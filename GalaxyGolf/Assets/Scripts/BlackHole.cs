using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public bool ballInHole = false;
    void OnTriggerEnter(Collider other)
    {
        ballInHole = true;
    }
}
