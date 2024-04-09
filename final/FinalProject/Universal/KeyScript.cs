using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Player player = other.GetComponent<Player>();
        if (other.gameObject.CompareTag("Player"))
        {
            bool key = true;
            player.SetHasKey(key);
            Debug.Log("Key Collected");
        }
        Destroy(gameObject);
    }
}
