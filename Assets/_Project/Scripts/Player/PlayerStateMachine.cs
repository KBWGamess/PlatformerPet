using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    public Rigidbody2D Rigidbody { get; private set; }

    private PlayerBaseState _currentState;

    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _jumpForce = 15f;
    [SerializeField] private float _coyoteTime = 0.2f;
    [SerializeField] private LayerMask _groundLayer;

    public float MoveSpeed => _moveSpeed;
    public float JumpForce => _jumpForce;
    public float CoyoteTime => _coyoteTime;
    public float CoyoteTimeCounter { get; set; }
    public bool IsGrounded { get; private set; }

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Initialize(PlayerBaseState startingState)
    {
        _currentState = startingState;
        _currentState.Enter();
    }

    public void ChangeState(PlayerBaseState newState)
    {
        _currentState.Exit();
        _currentState = newState;
        _currentState.Enter();
    }

    private void Update()
    {
        CheckGround();
        _currentState.Tick(Time.deltaTime);
    }
    private void CheckGround()
    {
        // пускаем короткий луч вниз от ног игрока
        IsGrounded = Physics2D.Raycast(
            transform.position,
            Vector2.down,
            1f,
            _groundLayer
        );
    }
    public void FlipPlayer(float moveInput)
    {
        if (moveInput > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (moveInput < 0)
            transform.localScale = new Vector3(-1, 1, 1);
    }
}