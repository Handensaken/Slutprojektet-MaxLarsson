using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= -10)
        {
            Destroy(this.gameObject);
        } 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "FlameTurret" && collision.gameObject.tag != "flame")
        {
             Destroy(this.gameObject);
            Debug.Log("hit " + collision.gameObject.name);
        }
    }
}
