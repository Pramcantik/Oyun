using UnityEngine;

public class AttackAnimationExit : StateMachineBehaviour
{
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        /*var slime = animator.GetComponent<movement>();
        if (slime != null)
        {
            slime.DisableHitbox();
        }*/
    }
}
