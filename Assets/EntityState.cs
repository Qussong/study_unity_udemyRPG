using UnityEngine;

public class EntityState
{
    protected StateMachine _stateMachine;
    protected string _stateName;

    // 생성자
    public EntityState(StateMachine stateMachine, string stateName)
    {
        this._stateMachine = stateMachine;
        _stateName = stateName;
    }

    public virtual void Enter()
    {
        // everytime state will be changed, enter will be called
        Debug.Log($"I enter {_stateName}");
    }

    public virtual void Update()
    {
        // we going to run logic of the state here
        Debug.Log($"I run update of {_stateName}");
    }

    public virtual void Exit()
    {
        // this will be called, everytime we exit state and change to a new one
        Debug.Log($"I exit {_stateName}");
    }
}
