using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkyController : MonoBehaviour
{

    [SerializeField]
    float speed = 4;

    [SerializeField]
    GameObject target;

    Vector2 currentDirection;

    // Update is called once per frame
    void Update()
    {
        if (IsCentered())
        {
            ChooseDirection();
        }
        transform.Translate(currentDirection * speed * Time.deltaTime);
    }

    bool IsCentered()
    {
        return Mathf.Abs(transform.position.x - Mathf.Round(transform.position.x)) < 0.05f &&
            Mathf.Abs(transform.position.y - Mathf.Round(transform.position.y)) < 0.05f;
    }

    void ChooseDirection()
    {
        Vector2[] directions = { Vector2.up, Vector2.left, Vector2.down, Vector2.right };
        Vector2 bestDirection = currentDirection;
        float bestDistance = Mathf.Infinity;

        /*foreach (var d in dirs) 
        {

        }*/

    }
}
