using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleCandy : UniversalItemData
{
    private Rigidbody2D littleCandy_RB;

    [Header("Item Point Amount")]
    [SerializeField] private int littleCandy_Points = 10;




    //Setting Inherited Member Variables

    public override Rigidbody2D rigidbody2d
    {
        get
        {
            return littleCandy_RB;
        }
    }

    public override int points
    {
        get
        {
            return littleCandy_Points;
        }
    }

    void Start()
    {
        littleCandy_RB = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        
    }
}
