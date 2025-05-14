using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float mapSpeed = 1f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");
 
        Vector3 getVel = new Vector3(xMove, yMove, 0) * movementSpeed;
        rb.velocity = getVel;
    }

    void FixedUpdate()
    {
        //rb.velocity = new Vector2(mapSpeed * -1, 0);
        rb.AddForce(new Vector2(mapSpeed * -1, 0),ForceMode2D.Force);
    }
}
