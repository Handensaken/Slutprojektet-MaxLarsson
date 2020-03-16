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
            Destroy(this.gameObject);
        }
    }
    bool called = false;
    private void LateUpdate()
    {
        called = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Straw"))
        {
            HP -= PlayerController.damage * 5;
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
