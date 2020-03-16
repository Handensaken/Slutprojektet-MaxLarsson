using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleTankFireScript : MonoBehaviour
{
    public float timer = 10f;
    public Rigidbody2D tankProjectile;
    public float projectileSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0.0f)
        {
            Fire();
        }
    }
    void Fire()
    {
        timer = 10f;
        Rigidbody2D Straw;
        Straw = Instantiate(tankProjectile, transform.position, Quaternion.identity);
        Straw.velocity = transform.TransformDirection(Vector3.left * projectileSpeed * Time.deltaTime);
    }
}
