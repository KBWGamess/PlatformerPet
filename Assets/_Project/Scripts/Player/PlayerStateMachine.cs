using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    public Rigidbody2D Rigidbody { get; private set; }

    private PlayerBaseState _currentState;

    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _jumpForce = 15f;

    public float MoveSpeed => _moveSpeed;
    public float JumpForce => _jumpForce;

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
        _currentState.Tick(Time.deltaTime);
    }
}