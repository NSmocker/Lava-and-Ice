using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
public class CharacterXRLimbManager : MonoBehaviour
{

    public TrackedPoseDriver head,left_hand,right_hand;
    public CharacterController controller_link;
    public Camera main_camera;
    public HandsLocomotion hand_locomotion;
    public ClassicLocomotion  classic_locomotion;
    // Start is called before the first frame update
    public void AttachPlayer()
    {
        head.enabled = true;
        left_hand.enabled = true;
        right_hand.enabled = true;
        main_camera.enabled = true;
        hand_locomotion.enabled= true;
        classic_locomotion.enabled= true;
        controller_link.enabled = true;
    }
    public void DetachPlayer()
    {
        head.enabled = false;
        left_hand.enabled = false;
        right_hand.enabled = false;
        main_camera.enabled = false;
        hand_locomotion.enabled= false;
        classic_locomotion.enabled= false;
        controller_link.enabled = false;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
