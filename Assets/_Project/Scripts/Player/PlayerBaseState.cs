public abstract class PlayerBaseState
{
    protected PlayerStateMachine StateMachine;

    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        StateMachine = stateMachine;
    }

    public abstract void Enter();
    public abstract void Tick(float deltaTime);
    public abstract void Exit();
}