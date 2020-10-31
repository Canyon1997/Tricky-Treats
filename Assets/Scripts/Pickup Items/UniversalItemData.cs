using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UniversalItemData : MonoBehaviour
{
    public abstract Rigidbody2D rigidbody2d { get; }

    public abstract int points { get; }
}
