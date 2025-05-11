using UnityEngine;

public class IdleState : IState
{
    public void Execute(StateContext context, StateManager manager)
    {
        manager.Test("IdleState");

        context.SetState(new ActiveState());

    }
}


public class ActiveState : IState
{
    public void Execute(StateContext context, StateManager manager)
    {
        manager.Test("ActiveState");
        context.SetState(new IdleState());
    }
}
