using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]private GameObject gameObject;
    private GameObject newCube;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }
    
    void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(directionX * 8f , rb.velocity.y);
        float directionY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, directionY * 8f);

        if(Input.GetButtonDown("Jump"))
        {   
           GameObject newCube = Instantiate(gameObject, transform.position, Quaternion.identity);

           Rigidbody2D cubeRB = newCube.GetComponent<Rigidbody2D>();
           
           cubeRB.bodyType = RigidbodyType2D.Static;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "icecube")
        {
            if(Input.GetButtonDown("Jump"))
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
