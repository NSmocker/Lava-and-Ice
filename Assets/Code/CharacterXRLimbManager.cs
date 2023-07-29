using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using Unity.Netcode;
using UnityEngine.XR.Management;
public class CharacterXRLimbManager : NetworkBehaviour
{

    [Header("Classic Settings")]
    public bool is_device_is_local_player;
    public CharacterController controller_link;
    public Camera main_camera;
    public ClassicLocomotion  classic_locomotion;
    public PlayerMovementSystem movement_system;
    // Start is called before the first frame update


    [Header("XR Settings")]
     public TrackedPoseDriver head,left_hand,right_hand;
     public HandsLocomotion hand_locomotion;




    public void UseXR()
    {
       //head.enabled = true;
       // left_hand.enabled = true;
       // right_hand.enabled = true;
       // hand_locomotion.enabled= true;

    }

    public void AttachPlayer()
    {
        
        main_camera.enabled = true;
        movement_system.enabled= true;
        controller_link.enabled = true;
    }
    public void DetachPlayer()
    {
        main_camera.enabled = false;
        movement_system.enabled= false;
    }
    
    void Start()
    {
       
        if(IsOwner )AttachPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
