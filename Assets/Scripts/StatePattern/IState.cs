using Unity.VisualScripting;
using UnityEngine;

public interface IState
{
    void Execute(StateContext context, StateManager manager);
}
