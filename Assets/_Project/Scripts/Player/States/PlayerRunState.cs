using UnityEngine;

public class PlayerRunState : PlayerBaseState
{
    public PlayerRunState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        // Анимацию Run
    }

    public override void Tick(float deltaTime)
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput == 0)
        {
            StateMachine.ChangeState(new PlayerIdleState(StateMachine));
            return;
        }

        // двигаем через Rigidbody чтобы не конфликтовать с физикой
        StateMachine.Rigidbody.linearVelocity = new Vector2(
            moveInput * StateMachine.MoveSpeed,
            StateMachine.Rigidbody.linearVelocity.y
        );

        if (Input.GetButtonDown("Jump"))
        {
            StateMachine.ChangeState(new PlayerJumpState(StateMachine));
            return;
        }
    }

    public override void Exit()
    {
        // Остановка анимации
    }
}