using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MovementSpeed = 5f;
    public bool IsGrounded = false;
    [SerializeField] private float JumpDelay = 0.1f;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * MovementSpeed;
        rb.AddForce(new Vector2(0f, JumpDelay), ForceMode2D.Force);
    }

    private void Update()
    {
        Jump();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quit!");
            Application.Quit();
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded == true)
        {
            rb.AddForce(new Vector2(0f, 7f), ForceMode2D.Impulse);
            IsGrounded = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;
        }
        if (other.gameObject.CompareTag("MovePlatform"))
        {
            IsGrounded = true;
            player.transform.parent = other.gameObject.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("MovePlatform"))
        {
            player.transform.parent = null;
        }
    }
}