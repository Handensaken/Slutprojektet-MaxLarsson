using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScript : MonoBehaviour
{ 
    public void PlayAgain()
    {
        SceneManagement.Play();
    }
    public void Quit()
    {
        Application.Quit();
    }
}
