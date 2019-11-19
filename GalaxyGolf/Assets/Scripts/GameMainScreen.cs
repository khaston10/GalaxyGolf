using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMainScreen : MonoBehaviour
{
    public int ballNumber;
    public int totalNumberOfStrokes;
    public int currentHole;
    public Text PlanetDescription;

    // Start is called before the first frame update
    void Start()
    {
        ballNumber = GlobalControl.Instance.ballNumber;
        totalNumberOfStrokes = GlobalControl.Instance.totalNumberOfStrokes;
        currentHole = GlobalControl.Instance.currentHole;
    }


    // Save data to global control   
    public void SaveData()
    {
        GlobalControl.Instance.ballNumber = ballNumber;
        GlobalControl.Instance.totalNumberOfStrokes = totalNumberOfStrokes;
        GlobalControl.Instance.currentHole = currentHole;
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

    public void HoverPlanet1()
    {
        PlanetDescription.text = "Rosopia: Completely covered in flowers, the planet’s surface hasn’t been visible for eons.Some say the planet is actually a giant ball of space whale manure.";
    }

    public void HoverPlanet2()
    {
        PlanetDescription.text = "Rustopur: Originally two planets, millenia ago a massive water planet collided with an iron giant planet. In only a year, the combined planet became the universes largest ball of rust.";
    }

    public void HoverPlanet3()
    {
        PlanetDescription.text = "Arhturo: Very similar to earth, and once housed intelligent life. However, shortly after the dominant intelligent species discovered nuclear opium, all living things on the planet mysterious died.";
    }

    public void HoverPlanet4()
    {
        PlanetDescription.text = "Glomp: Entirely composed of a large gelatinous substance.Satellites from many intelligent species have attempted to land on this planet only to sink to it’s core.";
    }

    public void HoverPlanet5()
    {
        PlanetDescription.text = "Shariff: A former outpost of the galactic federation.It is said to be a secret prison for the universes most dangerous outlaws.";
    }

    public void HoverPlanet6()
    {
        PlanetDescription.text = "Vhalamar: Thought to be only in legend.Comprised of oceans of frankincense and continents of pure gold.";
    }
}
