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
     XRDeviceInitializer xr_device;
    // Start is called before the first frame update


    [Header("XR Settings")]
     public TrackedPoseDriver head,left_hand,right_hand;
     public HandsLocomotion hand_locomotion;




    public void UseXR()
    {
        head.enabled = true;
        left_hand.enabled = true;
        right_hand.enabled = true;
        hand_locomotion.enabled= true;

    }

    public void AttachPlayer()
    {
        
        main_camera.enabled = true;
        movement_system.enabled= true;
        controller_link.enabled = true;
    }
    
    
    void Start()
    {   xr_device = GameObject.Find("XR Device Initializer").GetComponent<XRDeviceInitializer>();
        DontDestroyOnLoad(gameObject);
        if(IsOwner )
        {
            AttachPlayer();
            if(xr_device.OnXR){UseXR();}
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
