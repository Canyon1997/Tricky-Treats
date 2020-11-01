using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : UniversalPlayerItems
{
    private Rigidbody2D basket_RB;
    private Vector2 movement;

    [Header("Game Controller")]
    [SerializeField] private GameObject gameController;
    private GameController controller;

    [Header("Trick or Treats")]
    [SerializeField] private GameObject[] itemCollectables;
    private ItemScript itemID;

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
        //Accessing Components from objects

        //Rigidbody
        basket_RB = GetComponent<Rigidbody2D>();

        //GameController
        controller = gameController.GetComponent<GameController>();
    }


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

    }

    private void FixedUpdate()
    {
        basket_RB.MovePosition((Vector2)transform.position + movement * basket_MoveSpeed * Time.fixedDeltaTime);
    }

    //Adds or removes points based on the ItemID
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<ItemScript>().item == ItemScript.ItemID.LittleCandy)
        {
            controller.currentScore += 10;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.GetComponent<ItemScript>().item == ItemScript.ItemID.KingCandy)
        {
            controller.currentScore += 20;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.GetComponent<ItemScript>().item == ItemScript.ItemID.BakedCandy)
        {
            controller.currentScore += 40;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.GetComponent<ItemScript>().item == ItemScript.ItemID.ToothBrush)
        {
            controller.currentScore -= 10;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.GetComponent<ItemScript>().item == ItemScript.ItemID.Rock)
        {
            controller.currentScore -= 20;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.GetComponent<ItemScript>().item == ItemScript.ItemID.Pencil)
        {
            controller.currentScore -= 10;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.GetComponent<ItemScript>().item == ItemScript.ItemID.VampireTeeth)
        {
            controller.currentScore -= 20;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.GetComponent<ItemScript>().item == ItemScript.ItemID.SpiderRing)
        {
            controller.currentScore -= 10;
            Destroy(other.gameObject);
        }
    }
}
