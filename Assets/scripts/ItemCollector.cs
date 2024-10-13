using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int watermelonCount = 0;
    private bool keyCollected = false;
    [SerializeField]private GameObject key;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("watermelon"))
        {
            Destroy(collision.gameObject);
            watermelonCount++;
            if (watermelonCount == 20)
            {
                GameObject keyInstance = Instantiate(key, transform.position, Quaternion.identity);
            }
        }
        if(collision.gameObject.CompareTag("key"))
        {
            Destroy(collision.gameObject);
            keyCollected = true;
            Debug.Log("Game over!");
        }
    }
    
}
