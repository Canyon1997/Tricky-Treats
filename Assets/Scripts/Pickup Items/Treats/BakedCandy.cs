using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakedCandy : UniversalItemData
{
    private Rigidbody2D bakedCandy_RB;

    [Header("Baked Candy Point Amount")]
    [SerializeField] private int bakedCandy_Points = 40;

    //Setting Inherited Fields
    public override Rigidbody2D rigidbody2d
    {
        get
        {
            return bakedCandy_RB;
        }
    }

    public override int points
    {
        get
        {
            return bakedCandy_Points;
        }
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
