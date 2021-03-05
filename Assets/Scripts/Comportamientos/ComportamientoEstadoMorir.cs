using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoEstadoMorir : StateMachineBehaviour 
{
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Destruye el gameObject del estado
        Destroy(animator.gameObject);
    }

    
}
