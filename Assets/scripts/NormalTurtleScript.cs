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

            }
        }
        if (transform.position.x >= 15)
        {
            if (direction > 0)
            {
                direction *= -1;
                transform.localScale = new Vector3(1, 1, 1);
            }
        }
        transform.Translate(movement);

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
            HP = 0;
        }
        if (collision.gameObject.CompareTag("FireBall"))
        {
            if (!called)
            {
                HP -= PlayerController.damage;
                called = true;
            }
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!called)
            {
                collision.gameObject.GetComponent<PlayerController>().Hurt(damage);
                called = true;
            }
        }
    }
}