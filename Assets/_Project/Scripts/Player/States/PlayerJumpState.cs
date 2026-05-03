using UnityEngine;

public class PlayerJumpState : PlayerBaseState
{
    private readonly float _jumpForce = 15f;

    public PlayerJumpState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        StateMachine.Rigidbody.linearVelocity = new Vector2(
            StateMachine.Rigidbody.linearVelocity.x,
            _jumpForce
        );
    }

    public override void Tick(float deltaTime)
    {
        if (StateMachine.Rigidbody.linearVelocity.y < 0)
        {
            StateMachine.ChangeState(new PlayerFallState(StateMachine));
            return;
        }
    }

    public override void Exit()
    {
    }
}