using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HoleSplashScreenGame : MonoBehaviour
{
    public int ballNumber;
    public int totalNumberOfStrokes;
    public int currentHole;
    public Text holeNumber;

    // Start is called before the first frame update
    void Start()
    {
        ballNumber = GlobalControl.Instance.ballNumber;
        totalNumberOfStrokes = GlobalControl.Instance.totalNumberOfStrokes;
        currentHole = GlobalControl.Instance.currentHole;
    }

    // Update is called once per frame
    void Update()
    {
        holeNumber.text = currentHole.ToString();
    }

    public void ClickNextLevel()
    {
        SceneManager.LoadScene(currentHole, LoadSceneMode.Single);
    }
}
