    using System;
    using System.Collections.Generic;
    using UnityEngine;
     
    public class Movement : MonoBehaviour {
     
        private bool InAir = false;
        private Rigidbody2D rb2d;
        private int TimeInAir = 0;
        private Vector2 GravityForce;
        public double angle;
     
        void Start() {
            rb2d = GetComponent<Rigidbody2D>();
            
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            InAir = false;
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            InAir = true;
        }
        
        void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                angle = Math.Atan2(mousePos.y - rb2d.position.y, mousePos.x - rb2d.position.x);
                angle = (angle * (180/3.13159) + 180);
                rb2d.rotation = (float)angle;
                Debug.Log(rb2d.position);
                Debug.Log(mousePos);
                Debug.Log((angle * (180/3.14159)) + 180);
        }
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, 4f);

        rb2d.AddRelativeForce(movement * 5f);
        if (Input.GetAxis("Vertical") > 0.1){
                if (TimeInAir < 10)
                {
                rb2d.AddForce(new Vector2(0, 50f));
            }
        }
            if (InAir) {
                TimeInAir++;

            }
            else {
                TimeInAir = 0;
            }
            // if (InAir == false)
            // {
            //     rb2d.velocity = new Vector2(rb2d.velocity.x * 0.98f, rb2d.velocity.y);
            // }
            // if ( rb2d.velocity.x < 0.1 ) {
            //     rb2d.velocity = new Vector2(0f, rb2d.velocity.y);
            // }
        }
     
    }
     
