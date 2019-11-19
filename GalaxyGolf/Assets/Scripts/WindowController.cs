using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour
{
    public bool rotateAroundY;
    public bool moveAlongX;

    public float rotateSpeed;
    public float movementSpeed;
    public int negativeXEndPoint;
    public int positiveXEndPoint;

    bool movingPositive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateAroundY) transform.RotateAround(transform.position, Vector3.up, rotateSpeed);
        if (moveAlongX)
        {
            if (movingPositive)
            {
                if (transform.position.x <= positiveXEndPoint) transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
                else movingPositive = false;
            }


            else
            {
                if (transform.position.x >= negativeXEndPoint) transform.Translate(-Vector3.right * Time.deltaTime * movementSpeed);
                else movingPositive = true;
            }
           
        }
    }
}
