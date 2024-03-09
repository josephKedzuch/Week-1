using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float movSpeed;
    float movSpeedX, movSpeedY;
    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movSpeedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        movSpeedY = Input.GetAxisRaw("Vertical") * movSpeed;
        body.velocity = new Vector2(movSpeedX, movSpeedY);
    }
}
