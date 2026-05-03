using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public PlayerIdleState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        // Анимация Idle
    }

    public override void Tick(float deltaTime)
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            StateMachine.ChangeState(new PlayerRunState(StateMachine));
        }

        if (Input.GetButtonDown("Jump"))
        {
            StateMachine.ChangeState(new PlayerJumpState(StateMachine));
        }
    }

    public override void Exit()
    {
        // Остановка анимации
    }
}