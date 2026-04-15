using UnityEngine;
using UnityEngine.InputSystem;

public class PacMan_ : MonoBehaviour
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
            Debug.Log("Diagonal");

        }
        
    }

    private void FixedUpdate()
    {
        rb.velocity = moveInput * speed;
    }
}