using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScript : MonoBehaviour
{ 
    public void PlayAgain()
    {
        SceneManagement.Play();     //startar om spelet
    }
    public void Quit()
    {
        Application.Quit();     //ska stänga programmet
    }
}
