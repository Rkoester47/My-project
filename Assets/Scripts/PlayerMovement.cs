using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float jumpSpeed = 15f;
    [SerializeField] private float speed;
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        body.linearVelocity = new Vector2(Input.GetAxis("Horizontal")*speed, body.linearVelocity.y);

        if(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
            body.linearVelocity = new Vector2(body.linearVelocity.x * speed, speed);


    }
}
