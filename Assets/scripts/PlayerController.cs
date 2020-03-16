using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3;
    public float jumpPower = 2;
    public Vector3 movementX;
    public bool right = true;
    public float xInput;
    public GameObject test;
    public static int weapon = 0;
    readonly int MaxWeapons = 2;
    public static int damage = 10;
    int HP = 5;
    private bool isJumping = false;
    FireScript myFireScript;
    public int[] ammo = { 50, 1 };
    public int[] ammoBase = { 50, 1 };
    float[] reloadTime = {15f , 20f};
    float[] reloadTimeBase = { 15f, 20f };
    // Start is called before the first frame update
    void Start()
    {
        myFireScript = GetComponentInChildren<FireScript>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        movementX = Vector3.right * xInput * speed * Time.deltaTime;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            isJumping = true;
            rb.AddForce(Vector3.up * jumpPower);
        }
        if (xInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            right = false;
        }
        else if (xInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            right = true;
        }
        transform.rotation = Quaternion.identity;
        transform.Translate(movementX);

        if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (ammo[weapon] > 0)
            {
                myFireScript.Fire(weapon, right);
                Debug.Log(ammo[weapon]);
                ammo[weapon]--;
            }
        }

        if (ammo[weapon] == 0)
        {
            reloadTime[weapon] -= Time.deltaTime;
            Debug.Log("reloading");
            if (reloadTime[weapon] <= 0)
            {
                Debug.Log("reloaded");
                ammo[weapon] = ammoBase[weapon];
                reloadTime[weapon] = reloadTimeBase[weapon];
            }
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            weapon++;
            if (weapon == MaxWeapons)
            {
                weapon = 0;
            }
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 6;
        }
        else
        {
            speed = 3;
        }
        if (HP <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
        if (collision.gameObject.CompareTag("DeathZone"))
        {
            Destroy(this.gameObject);
        }
    }
    public void Hurt(int dmg)
    {
        HP -= dmg;
        Debug.Log($"ow took {dmg} damage");
    }
}
