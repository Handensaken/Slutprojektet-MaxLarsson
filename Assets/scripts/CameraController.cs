using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y +3.65f, -10f); //gör att kameran flyttas tillsammans med spelaren 
    }
}
