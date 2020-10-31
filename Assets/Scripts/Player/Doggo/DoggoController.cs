using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoggoController : UniversalPlayerItems
{
    private Rigidbody2D doggo_RB;

    private Vector2 movement;

    [Header("Doggo Move Speed!")]
    public float doggo_MoveSpeed;

    //Setting Inherited Fields
    public override Rigidbody2D Rigidbody
    {
        get
        {
            return doggo_RB;
        }
    }

    public override float Speed
    {
        get
        {
            return doggo_MoveSpeed;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        doggo_RB = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        //Input for movement
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }


    void FixedUpdate()
    {
        //Rigidbody movement
        Rigidbody.MovePosition((Vector2) transform.position + movement * doggo_MoveSpeed * Time.fixedDeltaTime);
    }
}
