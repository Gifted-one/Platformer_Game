using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_controller : MonoBehaviour
{
    public GameObject Main_Screen;
    public GameObject Controls_Screen;


    void Start()
    {
        Main_Screen.SetActive(true);
        Controls_Screen.SetActive(false);
    }

    public void ControlsButton()
    {
        Main_Screen.SetActive(false);
        Controls_Screen.SetActive(true);
    }

    public void Back()
    {
        Main_Screen.SetActive(true);
        Controls_Screen.SetActive(false);
    }
}
