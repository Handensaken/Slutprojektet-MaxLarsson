﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y +3.65f, -10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}