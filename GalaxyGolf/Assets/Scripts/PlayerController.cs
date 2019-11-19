using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Transform ball1Prefab;
    public Transform ball2Prefab;
    public Transform ball3Prefab;
    public Transform ball4Prefab;
    public Transform ball5Prefab;
    public Transform ball6Prefab;
    public Camera cam;
    public Rigidbody rb;
    public Transform blackHole;
    public Text strokeNumberText;
    public Text totalStrokeNumberText;
    public Text powerOfShotText;
    public Slider powerSlider;

    public float mouseSensitivity = 10;
    public float powerOFShot;
    public int strokeNum = 1;
    public int ballNumber;
    public int totalNumberOfStrokes;
    public int currentHole;
    public int powerMeterSpeed = 10000;


    bool mouse1Down;
    bool mouse2Down;
    bool mouse3Down;
    public bool strokeInProgress = false;
    public bool strokeStarted = false;



    // Start is called before the first frame update
    void Start()
    {
        ballNumber = GlobalControl.Instance.ballNumber;
        totalNumberOfStrokes = GlobalControl.Instance.totalNumberOfStrokes;
        currentHole = GlobalControl.Instance.currentHole;

        totalStrokeNumberText.text = totalNumberOfStrokes.ToString();


        if (ballNumber == 1)
        {
            Transform ball = Instantiate(ball1Prefab);
            Vector3 startPos = new Vector3(0f, 10f, 0f);
            ball.position = startPos;
            ball.transform.parent = transform;
        }

        else if (ballNumber == 2)
        {
            Transform ball = Instantiate(ball2Prefab);
            Vector3 startPos = new Vector3(0f, 10f, 0f);
            ball.position = startPos;
            ball.transform.parent = transform;
        }

        else if (ballNumber == 3)
        {
            Transform ball = Instantiate(ball3Prefab);
            Vector3 startPos = new Vector3(0f, 10f, 0f);
            ball.position = startPos;
            ball.transform.parent = transform;
        }

        else if (ballNumber == 4)
        {
            Transform ball = Instantiate(ball4Prefab);
            Vector3 startPos = new Vector3(0f, 10f, 0f);
            ball.position = startPos;
            ball.transform.parent = transform;
        }

        else if (ballNumber == 5)
        {
            Transform ball = Instantiate(ball5Prefab);
            Vector3 startPos = new Vector3(0f, 10f, 0f);
            ball.position = startPos;
            ball.transform.parent = transform;
        }

        else if (ballNumber == 6)
        {
            Transform ball = Instantiate(ball6Prefab);
            Vector3 startPos = new Vector3(0f, 10f, 0f);
            ball.position = startPos;
            ball.transform.parent = transform;
        }

    }

    // Update is called once per frame
    void Update()
    {
        // Get user inputs and set booleans.
        GetUserInput();

        // Rotates camera around ball using player's mouse inputs.
        RotateCamera();

        // Deals with the shooting sequence.
        Shoot();


    }

    public void GetUserInput()
    {
        // Get user inputs and set booleans.
        if (Input.GetButtonDown("Fire1"))
        {
            mouse1Down = true;
        }

        if (Input.GetButtonUp("Fire1"))
        {
            mouse1Down = false;
        }

        if (Input.GetButtonDown("Fire2"))
        {
            mouse2Down = true;
        }

        if (Input.GetButtonUp("Fire2"))
        {
            mouse2Down = false;
        }

        if (Input.GetButtonDown("Fire3"))
        {
            mouse3Down = true;
        }

        if (Input.GetButtonUp("Fire3"))
        {
            mouse3Down = false;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            powerOFShot += 1;
            powerOfShotText.text = powerOFShot.ToString();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            powerOFShot -= 1;
            powerOfShotText.text = powerOFShot.ToString();
        }
    }

    public void RotateCamera()
    {
        // Rotates camera around ball using player's mouse inputs.
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");
        if (mouse3Down && strokeInProgress == false) cam.transform.RotateAround(transform.position, Vector3.up, rotateHorizontal * mouseSensitivity);
        if (mouse2Down && strokeInProgress == false) cam.transform.RotateAround(transform.position, -cam.transform.right, rotateVertical * mouseSensitivity);
    }

    public void Shoot()
    {
        // Starts power meter when player starts shot.
        if (mouse1Down && strokeInProgress == false)
        {
            if (powerOFShot < 10) powerOFShot += Time.deltaTime * powerMeterSpeed;
            else powerOFShot = 0;
            strokeStarted = true;
            powerSlider.value = powerOFShot;
        }

        // Launches ball when player shoots.
        if (mouse1Down == false && strokeInProgress == false && strokeStarted)
        {
            strokeStarted = false;
            strokeInProgress = true;
            rb.AddForce(cam.transform.forward * powerOFShot * 300, ForceMode.Impulse);
        }

        // Check to see if stroke has been complete and update bool so that the next stroke can be made.
        // Also we will update the camera position so the it is once again behind the planet.
        if (strokeInProgress == true && rb.IsSleeping())
        {
            strokeInProgress = false;
            Vector3 pos = new Vector3(transform.position.x - (cam.transform.forward.x * 5), transform.position.y - (cam.transform.forward.y * 5), transform.position.z - (cam.transform.forward.z * 5));
            cam.transform.position = pos;

            // Update power meter for new shot.
            powerOFShot = 0;
            powerSlider.value = powerOFShot;

            // Update the text object on screen.
            strokeNum += 1;
            strokeNumberText.text = strokeNum.ToString();
            totalNumberOfStrokes += 1;
            totalStrokeNumberText.text = totalNumberOfStrokes.ToString();

            // Check to see if ball is in hole. If it is, we will end the hole.
            if (blackHole.GetComponent<BlackHole>().ballInHole)
            {
                Debug.Log("Hole is Over");
                currentHole += 1;
                SaveData();
                if (currentHole == 10) SceneManager.LoadScene(11, LoadSceneMode.Single);
                else SceneManager.LoadScene(10, LoadSceneMode.Single);
            }
        }

    }

    // Save data to global control   
    public void SaveData()
    {
        GlobalControl.Instance.ballNumber = ballNumber;
        GlobalControl.Instance.totalNumberOfStrokes = totalNumberOfStrokes;
        GlobalControl.Instance.currentHole = currentHole;
    }
}



