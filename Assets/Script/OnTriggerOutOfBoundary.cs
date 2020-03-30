using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerOutOfBoundary : MonoBehaviour
{
    GameControll gameControll;
    // Start is called before the first frame update
    void Start()
    {
        gameControll = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControll>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag != "Player")
        {
            return;
        }
        else
        {
            gameControll.GameOver();
        }
    }
}
