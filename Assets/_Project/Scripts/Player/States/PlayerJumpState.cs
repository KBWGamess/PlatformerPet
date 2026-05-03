using UnityEngine;

public class PlayerJumpState : PlayerBaseState
{

    public PlayerJumpState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        // Анимация Jump
        StateMachine.Rigidbody.linearVelocity = new Vector2(
            StateMachine.Rigidbody.linearVelocity.x,
            StateMachine.JumpForce
        );
    }

    public override void Tick(float deltaTime)
    {
        // двигаемся в воздухе с той же скоростью что и на земле
        float moveInput = Input.GetAxisRaw("Horizontal");
        StateMachine.Rigidbody.linearVelocity = new Vector2(
            moveInput * StateMachine.MoveSpeed,
            StateMachine.Rigidbody.linearVelocity.y
        );

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