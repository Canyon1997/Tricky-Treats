using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingCandy : UniversalItemData
{
    private Rigidbody2D kingCandy_RB;

    [Header("King Candy Point Amount")]
    [SerializeField] private int kingCandy_Points = 20;


    //Setting Inherited Fields
    public override Rigidbody2D rigidbody2d
    {
        get
        {
            return kingCandy_RB;
        }
    }

    public override int points
    {
        get
        {
            return kingCandy_Points;
        }
    }


    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
