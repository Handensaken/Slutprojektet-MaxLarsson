using System;
using UnityEngine.SceneManagement;


public class SceneManagement
{
    public static void Death()
    {
        SceneManager.LoadScene(1);
    }
    public static void SaveWin()
    {
        SceneManager.LoadScene(2);
    }
    public static void KillWin()
    {
        SceneManager.LoadScene(3);
    }
}
