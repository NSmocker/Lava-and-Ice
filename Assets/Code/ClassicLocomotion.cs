using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicLocomotion : MonoBehaviour
{
    
    public Vector2 keyboard_and_analog;
    public Vector2 mouse_and_analog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        keyboard_and_analog.x = Input.GetAxis("Horizontal");
        keyboard_and_analog.y = Input.GetAxis("Vertical");
        mouse_and_analog.x = Input.GetAxis("Mouse X");
        mouse_and_analog.y = Input.GetAxis("Mouse Y");
        
        

        
    }
}
