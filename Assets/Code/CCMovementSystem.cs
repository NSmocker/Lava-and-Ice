using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class CCMovementSystem : MonoBehaviour
{
    [Header("Other Systems Links")]

    public CharacterController hitbox;
    public Transform head_trackable;
    public GroundCheckSystem ground_check;
    
    [Header("Hands Movement")]
    public Transform left_hand;
    public Transform right_hand;
    public float left_hand_delta;
    public float right_hand_delta;
    public float middle_delta;
    public Vector3 old_right_local_pos, new_right_local_pos;
    public Vector3 old_left_local_pos, new_left_local_pos;
    public bool CanRun;
    public InputActionReference walk_reference;


    [Header("Body Real Life Walking")]
    public Transform visual_model;

    [Header("Head Jumping")]
    public Transform head_object;
    public float head_old_y, head_new_y;
    public float head_delta;
    public float minimum_delta_for_jump=0.15f;






    [Header("Statuses")]
    public float y_velocity;
    public float y_velocity_multipliyer;
    public float y_gravity;
    

    public float move_speed;
    public float jump_force;



    void CheckHeadJumping() 
    {
        head_new_y = head_object.transform.localPosition.y;
        head_delta =  (head_new_y - head_old_y)*10;
        head_old_y = head_object.transform.localPosition.y; ;
        if (head_delta > minimum_delta_for_jump) 
        {
            MakeJump();
        }
    }
    void CheckArmSwingAmplitude()
    {
        CanRun = walk_reference.action.ReadValue<float>() == 1;
        new_left_local_pos = left_hand.localPosition;
        left_hand_delta = Vector3.Distance(old_left_local_pos, new_left_local_pos)*100;
        old_left_local_pos = new_left_local_pos;

        new_right_local_pos = right_hand.localPosition;
        right_hand_delta = Vector3.Distance(old_right_local_pos, new_right_local_pos)*100;
        old_right_local_pos = new_right_local_pos;

        middle_delta = (left_hand_delta + right_hand_delta) / 2;
       // hitbox.center = Camera.main.transform.localPosition - new Vector3(0, hitbox.height/2 ,0);
        MakeStep();

    }
    void RecenterHitboxByHeadTrackable() 
    {
        var offset = new Vector3(head_trackable.localPosition.x,0, head_trackable.localPosition.z);
        visual_model.transform.localPosition = offset+new Vector3(0,hitbox.height/2,0);
        hitbox.center = offset;
    }

    void ApplyGravity() 
    {
        if (y_velocity < -6) y_velocity = -6;
        y_velocity -= y_gravity * Time.deltaTime;
        hitbox.Move(new Vector3(0,y_velocity*y_velocity_multipliyer,0));
    }
    void MakeJump() 
    {
        if (jump_force == 0) Debug.LogWarning("Jump force is zero. Cannot jump");
        if(ground_check.is_grounded) y_velocity = jump_force;
    }
    void MakeStep()
    {
        if (move_speed == 0) Debug.LogWarning("Move speed is zero. Cannot run");
        if (CanRun) hitbox.Move(Camera.main.transform.forward * middle_delta * Time.deltaTime * move_speed); 
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
        
        ApplyGravity();
      //  RecenterHitboxByHeadTrackable();
    }

}
