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
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            StateMachine.ChangeState(new PlayerIdleState(StateMachine));
            return;
        }

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