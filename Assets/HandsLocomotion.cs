using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsLocomotion : MonoBehaviour
{

    public float right_hand_velocity, left_hand_velocity;
    

    Vector3 prev_right_hand_position,prev_left_hand_position;
    public Transform right_hand, left_hand;


    void CalculateVelocity()
    {
        
     right_hand_velocity = ((right_hand.transform.position - prev_right_hand_position).magnitude) / Time.deltaTime;
     prev_right_hand_position = right_hand.transform.position;

     left_hand_velocity = ((left_hand.transform.position - prev_left_hand_position).magnitude) / Time.deltaTime;
     prev_left_hand_position = left_hand.transform.position;

     

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
