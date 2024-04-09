using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player player = other.gameObject.GetComponent<Player>();
            bool doesHaveKey = player.GetHasKey();
            if (doesHaveKey == true)
            {
                OpenDoor(player);
            }
            else if (doesHaveKey == false)
            {
                Debug.Log("You need a key");
            }

        }
    }
    void OpenDoor(Player player)
    {
        bool key = false;
        player.SetHasKey(key);
        Destroy(gameObject);
    }
}
