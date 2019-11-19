using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameScreen : MonoBehaviour
{
    public int totalNumberOfStrokes;
    public Text totalNumberOfStrokesText;

    private void Start()
    {
       totalNumberOfStrokes = GlobalControl.Instance.totalNumberOfStrokes;
       totalNumberOfStrokesText.text = totalNumberOfStrokes.ToString();
    }
    public void ClickReturn()
    {
        Application.Quit();
    }
}
