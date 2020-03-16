using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponDisplayScript : MonoBehaviour
{
    public Sprite[] weaponSprites;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            this.GetComponent<Image>().sprite = weaponSprites[PlayerController.weapon];
    }
}
