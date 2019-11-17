using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMainScreen : MonoBehaviour
{
    public int ballNumber;
    public int totalNumberOfStrokes;

    // Start is called before the first frame update
    void Start()
    {
        ballNumber = GlobalControl.Instance.ballNumber;
        totalNumberOfStrokes = GlobalControl.Instance.totalNumberOfStrokes;
    }


    // Save data to global control   
    public void SaveData()
    {
        GlobalControl.Instance.ballNumber = ballNumber;
        GlobalControl.Instance.totalNumberOfStrokes = totalNumberOfStrokes;
    }

    // Handles user clicking UI.
    public void ClickStart()
    {
        SaveData();
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void ClickPlanet1()
    {
        ballNumber = 1;
    }

    public void ClickPlanet2()
    {
        ballNumber = 2;
    }

    public void ClickPlanet3()
    {
        ballNumber = 3;
    }

    public void ClickPlanet4()
    {
        ballNumber = 4;
    }

    public void ClickPlanet5()
    {
        ballNumber = 5;
    }

    public void ClickPlanet6()
    {
        ballNumber = 6;
    }
}
