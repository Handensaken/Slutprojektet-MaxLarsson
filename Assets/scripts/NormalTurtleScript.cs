using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalTurtleScript : MonoBehaviour
{
    Vector3 movement;
    public int speed;
    int direction = -1;
    int HP = 100;
    readonly int damage = 1;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        movement = Vector3.right * speed * direction * Time.deltaTime;
        if (transform.position.x <= 5)
        {
            if (direction < 0)
            {
                direction *= -1;
                transform.localScale = new Vector3(-1, 1, 1);
                //^^vänder objektet
            }
        }
        if (transform.position.x >= 15)
        {
            if (direction > 0)
            {
                direction *= -1;
                transform.localScale = new Vector3(1, 1, 1);
            }//^^vänder objektet
        }
        transform.Translate(movement);          //flyttar objektet

        if (HP <= 0)
        {
            Destroy(this.gameObject);       //dödar motståndaren
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
            HP = 0;     //dödar motståndaren direkt om den träffas av ett sugrör
        }
        if (collision.gameObject.CompareTag("FireBall"))
        {
            if (!called)
            {
                HP -= PlayerController.damage;
                called = true;
                //^^skadar den om den träffas av ett eldklot
            }
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!called)
            {
                collision.gameObject.GetComponent<PlayerController>().Hurt(damage);
                called = true;
            }
        }//^^skadar spelaren om den går in i motståndaren
    }
}