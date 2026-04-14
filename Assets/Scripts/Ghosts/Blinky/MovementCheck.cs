using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCheck : MonoBehaviour
{
    bool CanMove(Vector2 direccion)
    {
        RaycastHit2D hit = new Physics2D.Raycast(transform.position, direccion, 0.6f, LayerMask.GetMask("Paredes"));
        return hit.collider == null;
    }
}
