using UnityEngine;

public class BallController : MonoBehaviour
{
    public float ballSpeed;
    public float JumpForce;

    public Rigidbody2D rb;
    public FinishBehaviour finish;
    public PlayerKiller killer;
    public JumpTrigger jumpTrigger;

    public bool isEnabled;
    private bool isPressed;

    private void Start()
    {
        Time.timeScale = 1;
    }
    private void FixedUpdate()
    {

        if (isPressed && !finish.IsWin)
        {
            rb.AddForce(Vector2.up * JumpForce);

            isPressed = false;
        }
        
        rb.velocity = new Vector2(0, rb.velocity.y);

        var Controll = Input.GetAxis("Horizontal");
        if (!finish.IsWin)
        {
            rb.AddForce(new Vector2(Controll * ballSpeed, 0), 0);
            //transform.Translate(new Vector2(Controll * ballSpeed * Time.deltaTime, 0));
        }
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Finish " + finish.IsWin);

        if (jumpTrigger.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                isPressed = true;
            }
        }        
    }
}
