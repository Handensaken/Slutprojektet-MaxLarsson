using System;
using UnityEngine.SceneManagement;


public class SceneManagement
{
    public static void Death()
    {
        SceneManager.LoadScene(1);      //laddar en dödsscen
    }
    public static void SaveWin()
    {
        SceneManager.LoadScene(2);      //laddar en vinstskärm
    }
    public static void KillWin()
    {
        SceneManager.LoadScene(3);      //laddar en vinstskärm
    }
    public static void Play()
    {
        SceneManager.LoadScene(0);      //laddar spelet
    }
}
