using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D[] projectile;

    [SerializeField]
    float projectileSpeed;
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        projectileSpeed = 1000;
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
    public void Fire(int weaponIndex, bool right)
    {
        Rigidbody2D clone;
        clone = Instantiate(projectile[weaponIndex], transform.position, Quaternion.identity);
        clone.velocity = transform.TransformDirection(Vector3.right * projectileSpeed * Time.deltaTime);
        if (right)
        {
            clone.GetComponent<ProjectileController>().Flip();
        }
    }
    //^^skjuter en projektil
}
