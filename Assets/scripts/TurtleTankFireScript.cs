using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class TurtleTankFireScript : MonoBehaviour
{
    public float[] timers = { 0.5f, 0.5f, 5f };
    float timer = 0f;
    int currentTimer = 0;
    public Rigidbody2D tankProjectile;
    public float projectileSpeed = 100;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timers[currentTimer])
        {
            Fire();
            timer = 0;
            currentTimer++;
            if(currentTimer >= timers.Length)
            {
                currentTimer = 0;
            }
        }
    }

    void Fire()
    {
        Rigidbody2D Straw;
        timer = 10f;
        Straw = Instantiate(tankProjectile, transform.position, Quaternion.identity);
        Straw.velocity = transform.TransformDirection(Vector3.left * projectileSpeed * Time.deltaTime);
    }
}
