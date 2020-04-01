using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawFactoryScript : MonoBehaviour
{
    int HP;
    // Start is called before the first frame update
    void Start()
    {
        HP = 50;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FireBall"))
        {
            HP--;
            if (HP <= 0)
            {
                SceneManagement.SaveWin();
            }
        }
    }
}
