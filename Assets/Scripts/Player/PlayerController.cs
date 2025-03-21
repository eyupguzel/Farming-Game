using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private Rigidbody2D rigidbody2d;
    private IMovementStrategy movementStrategy;
    private IInputProvider inputProvider;

    private float lastDirection = 1f;

    private Vector2 input;

    private void Start()
    {
        movementStrategy = new WalkingMovement();
        inputProvider = new KeyboardInput();
        rigidbody2d = GetComponent<Rigidbody2D>();

    }
    private void Update()
    {
        input = inputProvider.GetInput();

        if (input.x > 0)
            lastDirection = 1f;
        else if(input.x < 0)
            lastDirection = -1f;

        if(input.magnitude > 0)
            transform.localScale = new Vector3(lastDirection, 1f, 1f);


    }
    private void FixedUpdate()
    {
        movementStrategy.Move(rigidbody2d, input,animator);
    }
    public void SetMovementStrategy(IMovementStrategy newStrategy)
    {
        movementStrategy = newStrategy;
    }
}
