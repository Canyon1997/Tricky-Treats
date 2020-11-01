using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : UniversalPlayerItems
{
    private Rigidbody2D basket_RB;
    private Vector2 movement;

    [Header("Basket Speed")]
    public float basket_MoveSpeed;

    //Setting Inherited Fields
    public override Rigidbody2D Rigidbody
    {
        get
        {
            return basket_RB;
        }
    }

    public override float Speed
    {
        get
        {
            return basket_MoveSpeed;
        }
    }


    void Start()
    {
        basket_RB = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        basket_RB.MovePosition((Vector2)transform.position + movement * basket_MoveSpeed * Time.fixedDeltaTime);
    }
}
