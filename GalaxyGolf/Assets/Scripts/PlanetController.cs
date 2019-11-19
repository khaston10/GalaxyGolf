using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour
{
    public Vector3 pointToOrbit;
    public float orbitSpeed;
    public bool orbitClockWise;
    public bool orbitAroundY;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (orbitAroundY)
        {
            if (orbitClockWise) transform.RotateAround(pointToOrbit, Vector3.up, Time.deltaTime * orbitSpeed);
            else transform.RotateAround(pointToOrbit, -Vector3.up, Time.deltaTime * orbitSpeed);
        }
        else
        {
            if (orbitClockWise) transform.RotateAround(pointToOrbit, Vector3.right, Time.deltaTime * orbitSpeed);
            else transform.RotateAround(pointToOrbit, -Vector3.right, Time.deltaTime * orbitSpeed);
        }
        
    }
}
