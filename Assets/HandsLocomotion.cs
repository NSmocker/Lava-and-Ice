using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandsLocomotion : MonoBehaviour
{

    public InputActionReference right_hand_can_go;
    public InputActionReference left_hand_can_go;
    bool read_right_hand;
    
    public float right_hand_velocity, left_hand_velocity;
    Vector3 prev_right_hand_position,prev_left_hand_position;
    public Transform right_hand, left_hand;


    void CalculateVelocity()
    {
        if(right_hand_can_go.action.ReadValue<float>() == 1)
        { 
            right_hand_velocity = ((right_hand.transform.position - prev_right_hand_position).magnitude) / Time.deltaTime*0.1f;
            prev_right_hand_position = right_hand.transform.position;
        }
        else
        {
            right_hand_velocity=0;
        } 


        if(left_hand_can_go.action.ReadValue<float>() == 1)
        {
            left_hand_velocity = ((left_hand.transform.position - prev_left_hand_position).magnitude) / Time.deltaTime*0.1f;
            prev_left_hand_position = left_hand.transform.position;
        }
        else
        {
            left_hand_velocity=0;
        } 

     

     

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateVelocity();
    }
}
