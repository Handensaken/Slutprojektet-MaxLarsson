using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleTankProjectileScript : MonoBehaviour
{
    int damage = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= 53)
        {
            this.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
    bool called = false;
    private void LateUpdate()
    {
        called = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Straw"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("FireBall"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!called)
            {
                collision.gameObject.GetComponent<PlayerController>().Hurt(damage);
                called = true;
            }
            Destroy(this.gameObject);
        }
    }
}
