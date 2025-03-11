using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Flip(false); // Odbicie w lewo
            animator.SetTrigger("move");
            if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)))
            {
                animator.SetTrigger("Jump");
                animator.ResetTrigger("move");
            }
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Flip(true); // Odbicie w prawo
            animator.SetTrigger("move");
            if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)))
            {
                animator.SetTrigger("Jump");
                animator.ResetTrigger("move");
            }
        }
        else if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)))
        {
            animator.SetTrigger("Jump");
        }
    }
    void Flip(bool facingRight)
    {
        Vector3 newScale = transform.localScale;
        newScale.x = facingRight ? Mathf.Abs(newScale.x) : -Mathf.Abs(newScale.x);
        transform.localScale = newScale;
    }
}