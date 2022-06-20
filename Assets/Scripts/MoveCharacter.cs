using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    private Rigidbody2D rb;
    private float deltaX, deltaY, characterSpeed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        characterSpeed = 1f;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 Touchpos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    deltaX = characterSpeed * Touchpos.x - transform.position.x;
                    deltaY = characterSpeed * Touchpos.y - transform.position.y;
                    break;
                
                case TouchPhase.Moved:
                    rb.MovePosition(new Vector2(characterSpeed * Touchpos.x - deltaX, characterSpeed * Touchpos.y - deltaY));
                    break;

                case TouchPhase.Ended:
                    rb.velocity= Vector2.zero;
                    break;  
            }
        }
    }
}
