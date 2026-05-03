using UnityEngine;

public class PlayerFallState : PlayerBaseState
{
    public PlayerFallState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        //  Анимация Fall
    }

    public override void Tick(float deltaTime)
    {
        // управление в воздухе пока падаем
        float moveInput = Input.GetAxisRaw("Horizontal");
        StateMachine.Rigidbody.linearVelocity = new Vector2(
            moveInput * StateMachine.MoveSpeed,
            StateMachine.Rigidbody.linearVelocity.y
        );

        if (StateMachine.Rigidbody.linearVelocity.y == 0)
        {
            StateMachine.ChangeState(new PlayerIdleState(StateMachine));
            return;
        }
    }

    public override void Exit()
    {
    }
}