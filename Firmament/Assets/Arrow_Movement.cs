    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
     
    public class Movement : MonoBehaviour {
     
        public float speed = 0.1f;
        public float JumpHeight = 1f;
        public bool InAir = false;
     
        private Rigidbody2D rb2d;
     
        void Start() {
            rb2d = GetComponent<Rigidbody2D>();
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            InAir = false;
            Debug.Log("InAir false");
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            InAir = true;
            Debug.Log("InAir True");
        }
     
        void FixedUpdate() {
            Vector2 NoMovement = new Vector2(0f, 0f);
     
            float moveHorizontal = Input.GetAxis("Horizontal");
                if (moveHorizontal > 0)
                {
                    {
                        rb2d.velocity = new Vector2(5f, rb2d.velocity.y);
     
                    }
                }
                if (moveHorizontal < 0)
                {
                    rb2d.velocity = new Vector2(-5f, rb2d.velocity.y);
                }
            if (Input.GetAxis("Vertical") > 0.1){
                // if (InAir == false)
                // {
                    rb2d.AddForce(new Vector2(0, 100f));
                    Debug.Log("Iver");
              //  }
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
     
