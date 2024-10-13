using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform player;    
    
    
    void Update()
    {
        transform.position = new(player.position.x, player.position.y, transform.position.z);
    }
}
