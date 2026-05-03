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