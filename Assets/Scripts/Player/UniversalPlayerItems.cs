using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UniversalPlayerItems : MonoBehaviour
{
  public abstract Rigidbody2D Rigidbody { get; }

  public abstract float Speed { get; }
}
