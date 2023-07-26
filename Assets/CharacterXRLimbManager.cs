using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
public class CharacterXRLimbManager : MonoBehaviour
{

    public TrackedPoseDriver head,left_hand,right_hand;
    public Camera main_camera;
    // Start is called before the first frame update
    public void AttachPlayer()
    {
        head.enabled = true;
        left_hand.enabled = true;
        right_hand.enabled = true;
        main_camera.enabled = true;
    }
    public void DetachPlayer()
    {
        head.enabled = false;
        left_hand.enabled = false;
        right_hand.enabled = false;
        main_camera.enabled = false;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
