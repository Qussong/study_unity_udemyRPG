using UnityEngine;

public class EntityState
{
    protected StateMachine _stateMachine;

    // 생성자
    public EntityState(StateMachine stateMachine)
    {
        this._stateMachine = stateMachine;
    }

    public virtual void Enter()
    {
        
    }

    public virtual void Exit()
    {
        
    }
}
