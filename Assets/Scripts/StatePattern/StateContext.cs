using UnityEngine;

public class StateContext : MonoBehaviour
{
    public StateManager stateManager;

    public IState curState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        curState = new IdleState();
    }

    public void Operate()
    {
        curState.Execute(this, stateManager);
    }

    public void SetState(IState newState)
    {
        curState = newState;
    }
}
