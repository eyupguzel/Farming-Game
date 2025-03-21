using UnityEngine;

public interface IMovementStrategy
{
    void Move(Rigidbody2D rigidbody,Vector2 input,Animator animator);
}
