using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleTankScript : MonoBehaviour
{
    public int HP;
    // Start is called before the first frame update
    void Start()
    {
        HP = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            Destroy(this.gameObject);       //dödar sköldpaddan om dess HP når 0
        }
    }
    bool called = false;
    private void LateUpdate()       //uppdaterar i slutet av varje frame, det sista som händer varje frame.
    {
        called = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Straw"))
        {
            if (!called)        //gör att den inte kan skadas flera gånger av samma skott
            {
                HP -= PlayerController.damage * 5;
                called = true;
            }
        }
        if (collision.gameObject.CompareTag("FireBall"))
        {
            if (!called)        
            {
                HP -= PlayerController.damage;
                called = true;
            }
        }

    }
}
