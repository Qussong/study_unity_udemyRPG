using UnityEngine;

public class EntityState
{
    protected StateMachine stateMachine;
    protected string stateName;

    public EntityState(StateMachine stateMachone, string stateName)
    {
        this.stateMachine = stateMachone;
        this.stateName = stateName;
    }

    public virtual void Enter()
    {
        // everytime state will be changed, enter will be called
        Debug.Log("I enter " + stateName);
    }

    public virtual void Update()
    {
        // we going to run logic of the state here
        Debug.Log("I run update of " + stateName);
    }

    public virtual void Exit()
    {
        // this will be called, everytime we exit state and changed to a new one 
        Debug.Log("I exit " + stateName);
    }
}
