using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
private Rigidbody2D rb2d;
private bool inAir = false; 
public Vector2 GravityForce = new Vector2(1f, 9.8f); 

void Start()
{
    rb2d = GetComponent<Rigidbody2D>();
}

void FixedUpdate() {
    rb2d.AddForce(GravityForce);
    // rb2d.velocity = new Vector2(rb2d.velocity.x * 0.7f, rb2d.velocity.y * 0.99f);
    // if (rb2d.velocity.x < 0.1) {
    //     rb2d.velocity = new Vector2(0, rb2d.velocity.y);
    // }
}


}