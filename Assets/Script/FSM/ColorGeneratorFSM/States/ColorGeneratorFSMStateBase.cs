using Bitcraft.StateMachine;

public abstract class ColorGeneratorFSMStateBase : StateBase {

	protected ColorGeneratorFSMStateBase(StateToken token) : base(token){

	}
    protected override void OnExit(StateExitEventArgs e){
        base.OnExit(e);
    }

    protected override void OnEnter(StateEnterEventArgs e)
    {
        base.OnEnter(e);
    }




}
