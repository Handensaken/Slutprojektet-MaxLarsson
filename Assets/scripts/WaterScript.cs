﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    // Start is called before the first frame update
    int strawCountRemaining;
    void Start()
    {
        strawCountRemaining = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(strawCountRemaining >= 3)
        {
            SceneManagement.KillWin();  
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Straw"))
        {
            strawCountRemaining++;
        }
    }
}
