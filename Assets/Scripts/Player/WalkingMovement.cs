using UnityEngine;

public class WalkingMovement : MonoBehaviour, IMovementStrategy
{
    private float speed = 5f;
    public void Move(Rigidbody2D rigidbody,Vector2 input,Animator animator)
    {
        if (input.magnitude > 0)
        {
            Vector3 movement = new Vector3(input.x, input.y, 0) * speed;
            animator.SetTrigger("Walk");
            rigidbody.linearVelocity = movement;
        }
        else
        {
            rigidbody.linearVelocity = Vector2.zero;
            animator.SetTrigger("Idle");
        }

    }
}
