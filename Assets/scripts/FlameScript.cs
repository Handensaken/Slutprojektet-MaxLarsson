using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class FlameScript : MonoBehaviour
{
    float timer = 15f;
    float timer2 = 0.1f;
    public GameObject projectile;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 433;
    }
    // Update is called once per frame
    void Update()
    {
        timer2 -= Time.deltaTime;
        timer -= Time.deltaTime;
        if (timer >= 10)
        {
            if (timer2 <= 0)
            {
                Fire();
                timer2 = 0.1f;
            }
        }
        else if (timer <= 0)
        {
            timer = 15f;
        }
    }

    void Fire()
    {
        //Debug.Log("Fired");
        GameObject clone;
        clone = Instantiate(projectile, transform.position, Quaternion.identity);
        clone.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(Vector3.up * speed * Time.deltaTime);
        Debug.Log(clone.GetComponent<Rigidbody2D>().velocity);

    }
}
