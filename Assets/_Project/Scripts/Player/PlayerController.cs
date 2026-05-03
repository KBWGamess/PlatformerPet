using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerStateMachine _stateMachine;

    private void Start()
    {
        _stateMachine = GetComponent<PlayerStateMachine>();
        _stateMachine.Initialize(new PlayerIdleState(_stateMachine));
    }
}