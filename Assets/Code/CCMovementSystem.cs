using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class CCMovementSystem : MonoBehaviour
{
    public CharacterController hitbox;
    
    
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
        hitbox.center = Camera.main.transform.localPosition - new Vector3(0, hitbox.height/2 ,0);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        CheckArmSwingAmplitude();
        if (CanRun) hitbox.Move(Camera.main.transform.forward * middle_delta*Time.deltaTime);

       
    }
}
