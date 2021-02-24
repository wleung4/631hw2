using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialEffect : MonoBehaviour
{
    public  Behaviour h;
    public bool isOn = false;
    private CharacterController _charController;

    private void Start()
    {
         //Behaviour h = (Behaviour)GetComponent("Halo");
        _charController = GetComponent<CharacterController>();
    }
    



    void OnControllerColliderHit(ControllerColliderHit hit) {
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body != null && !body.isKinematic) {
            if(isOn==false){
                h.enabled =true;
                isOn=true;
            }
            else{
                h.enabled =false;;
                isOn=false;
            }
        }
    }
}

