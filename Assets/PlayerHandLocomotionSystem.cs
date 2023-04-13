using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerXRLocomotionSystem : MonoBehaviour
{

    public PlayerSystem master_system;

    [Header("Hands Movement")]
    public Transform left_hand_trackable;
    public Transform right_hand_trackable;
    public float left_hand_delta;
    public float right_hand_delta;
    public float middle_delta;
    public Vector3 old_right_local_pos, new_right_local_pos;
    public Vector3 old_left_local_pos, new_left_local_pos;
    public bool CanRun;
    public InputActionReference walk_reference;

    [Header("Head Jumping")]
    public Transform head_object;
    public float head_old_y, head_new_y;
    public float head_delta;
    public float minimum_delta_for_jump = 0.15f;

    [Header("Other")]
    public DirectionPointer direction_pointer;

    void CheckHeadJumping()
    {
        head_new_y = head_object.transform.localPosition.y;
        head_delta = (head_new_y - head_old_y) * 10;
        head_old_y = head_object.transform.localPosition.y; ;
        if (head_delta > minimum_delta_for_jump)
        {
            if (master_system.character_to_controll != null) 
            {
                master_system.character_to_controll.movement_system.MakeJump();
            } // MakeJump();
        }
    }
    void CheckArmSwingAmplitude()
    {
        CanRun = walk_reference.action.ReadValue<float>() == 1;
        new_left_local_pos = left_hand_trackable.localPosition;
        left_hand_delta = Vector3.Distance(old_left_local_pos, new_left_local_pos) * 100;
        old_left_local_pos = new_left_local_pos;

        new_right_local_pos = right_hand_trackable.localPosition;
        right_hand_delta = Vector3.Distance(old_right_local_pos, new_right_local_pos) * 100;
        old_right_local_pos = new_right_local_pos;

        middle_delta = (left_hand_delta + right_hand_delta) / 2;

        if (CanRun) 
        {
            if (master_system.character_to_controll != null) 
            {

                master_system.character_to_controll.movement_system.MakeStep(direction_pointer.transform.forward*middle_delta);
            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckArmSwingAmplitude();
        CheckHeadJumping();
    }
}
