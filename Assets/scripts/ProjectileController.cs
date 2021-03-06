﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public GameObject player;

    public SpriteRenderer mySpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            Destroy(this.gameObject);
        }
        //^^förstör projektilen om den rör någonting annat än spelaren
    }

    public void Flip()
    {
        mySpriteRenderer.flipX = !mySpriteRenderer.flipX;
    }//^^gör att projektilen är vänd åt samma håll som spelaren

}
