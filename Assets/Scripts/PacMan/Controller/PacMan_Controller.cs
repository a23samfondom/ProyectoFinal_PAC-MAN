using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PacMan_Controller : MonoBehaviour
{
    [SerializeField] float speed;

    Vector2 moveInput;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();


        if (moveInput.x != 0 && moveInput.y != 0)
        {
            moveInput.x = 0;
        }

        RotatePacMan();
        
    }

    void RotatePacMan()
    {
        if (moveInput == Vector2.right)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        else if(moveInput == Vector2.left)
        {
            transform.rotation = Quaternion.Euler(0,0,180);
        }
        else if (moveInput == Vector2.up)
        {
            transform.rotation = Quaternion.Euler(0,0,90);
        }
        else if (moveInput == Vector2.down)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = moveInput * speed;

    }
}