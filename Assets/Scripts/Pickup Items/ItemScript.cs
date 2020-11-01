using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;

    public ItemID item;

    public enum ItemID
    {
        LittleCandy,
        KingCandy,
        BakedCandy,
        ToothBrush,
        Rock,
        Pencil,
        VampireTeeth,
        SpiderRing
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        switch(this.gameObject.tag)
        {
            case "LittleCandy":
                item = ItemID.LittleCandy;
                break;

            case "KingCandy":
                item = ItemID.KingCandy;
                break;

            case "BakedCandy":
                item = ItemID.BakedCandy;
                break;

            case "ToothBrush":
                item = ItemID.ToothBrush;
                break;

            case "Rock":
                item = ItemID.Rock;
                break;

            case "Pencil":
                item = ItemID.Pencil;
                break;

            case "VampireTeeth":
                item = ItemID.VampireTeeth;
                break;

            case "SpiderRing":
                item = ItemID.SpiderRing;
                break;

        }
    }
}
