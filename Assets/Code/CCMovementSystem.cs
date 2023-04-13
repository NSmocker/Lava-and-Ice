using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class CCMovementSystem : MonoBehaviour
{
    [Header("Other Systems Links")]

    public CharacterController hitbox;
    public GroundCheckSystem ground_check;
    


    [Header("Statuses")]
    public float y_velocity;
    public float y_velocity_multipliyer;
    public float y_gravity;
    

    public float move_speed;
    public float jump_force;



  
 
   

    void ApplyGravity() 
    {
        if (y_velocity < -6) y_velocity = -6;
        y_velocity -= y_gravity * Time.deltaTime;
        hitbox.Move(new Vector3(0,y_velocity*y_velocity_multipliyer,0));
    }
   public void MakeJump() 
    {
        if (jump_force == 0) Debug.LogWarning("Jump force is zero. Cannot jump");
        if(ground_check.is_grounded) y_velocity = jump_force;
    }
   public void MakeStep(Vector3 direction)
    {
        if (move_speed == 0) Debug.LogWarning("Move speed is zero. Cannot run");
        hitbox.Move(direction * Time.deltaTime * move_speed); 
    }
    // Start is called before the first frame update
  
    
    void Start()
    {
        
    }

    // Update is called once per frame


    void Update()
    {

      
        
        
        ApplyGravity();
    
    }

}
