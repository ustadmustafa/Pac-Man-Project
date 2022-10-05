using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1;
    public int score = 0; 

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0)  * Time.deltaTime * movementSpeed;

        var movement2 = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, movement2, 0) * Time.deltaTime * movementSpeed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Point")
        {
            score += 5;
            Destroy(collision.gameObject);
        }
        
    }
}
