using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping_Landing : State
{
    private JumpingStuff data;

    public override void Enter()
    {
        base.Enter();
        data = stateMachine.variables.Get<JumpingStuff>("Data");
        data.stateText.text = "Landing";
        data.animator.SetTrigger("Landing");
        data.jumped = false;
    }

    public override void Update()
    {
        if (data.landAnimFinished)
            stateMachine.ChangeState(typeof(Jumping_IdleState));
    }

    public override void Exit()
    {
        base.Exit();
        data.landAnimFinished = false;
    }
}
