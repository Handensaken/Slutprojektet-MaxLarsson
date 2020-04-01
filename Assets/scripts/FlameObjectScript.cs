using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameObjectScript : MonoBehaviour
{
    int damage;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        damage = 1;
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
            player.GetComponent<PlayerController>().Hurt(damage);
             Destroy(this.gameObject);
        }
    }
}
