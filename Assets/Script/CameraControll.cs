using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        transform.position = Player.transform.position + new Vector3(0, 0, -10);
    }
}
