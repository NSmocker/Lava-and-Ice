
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSystem : MonoBehaviour
{

    public ClassicLocomotion classic_locomotion;
    public HandsLocomotion hand_locomotion;
    public DirectionPointerFromCamera direction_pointer;
    public CharacterController controller_link;
    public Transform head;
    public bool move_by_hands;
    public float move_speed;
    public float custom_gravity_y;
    public float custom_gravity_scaler=1f;
    
    void UpdateHitboxInfo()
    {
        var new_center = head.transform.localPosition;
        new_center.y = 0;
        controller_link.center = new_center;
        controller_link.height = head.localPosition.y;

    }

    void CalculateGravity()
    {
        custom_gravity_y += Physics.gravity.y*Time.deltaTime*custom_gravity_scaler;
        if(custom_gravity_y<-5) custom_gravity_y = -5;
        var custom_gravity_vector = new Vector3(0,custom_gravity_y,0);
        controller_link.Move(custom_gravity_vector);
    }
    void MoveCharacter()
    {
        if(move_by_hands)
        {
            Vector3 move_vector = direction_pointer.transform.forward * move_speed*Time.deltaTime *  (hand_locomotion.left_hand_velocity + hand_locomotion.right_hand_velocity);
            controller_link.Move(move_vector);
        }
        else
        {
            Vector3 classic_device_vector = new Vector3(classic_locomotion.keyboard_and_analog.x,0,classic_locomotion.keyboard_and_analog.y);
            Vector3 move_vector = direction_pointer.transform.TransformDirection(classic_device_vector) * move_speed*Time.deltaTime;
            controller_link.Move(move_vector);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(move_by_hands) UpdateHitboxInfo();
        CalculateGravity();
        MoveCharacter();
    }
}
