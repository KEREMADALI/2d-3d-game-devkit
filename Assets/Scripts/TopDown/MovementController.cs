using UnityEngine;

public class Movement : MonoBehaviour
{
    #region Private & Const Variables
    protected Vector2 movement;
    private Rigidbody2D rb;
    private Animator animator;
    #endregion

    #region Public Variables
    public float speed = 5.0f;
    #endregion

    #region Public Methods

    #endregion

    #region Private Methods

    private void Awake()
    {
        movement = new Vector2();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    protected void UpdateAnimation()
    {
        // Update Animation variables
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetBool("isMoving", movement != Vector2.zero);
    }
    #endregion
}
