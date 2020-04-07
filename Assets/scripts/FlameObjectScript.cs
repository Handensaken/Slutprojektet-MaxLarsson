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
            Destroy(this.gameObject);       //försör elden om den når en viss punkt
        } 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "FlameTurret" && collision.gameObject.tag != "flame")
        {
            player.GetComponent<PlayerController>().Hurt(damage);
             Destroy(this.gameObject);
        } //^^förstör elden om den kolliderar med någonting annat än sig själv eller tornet som skjuter den
    }
}
