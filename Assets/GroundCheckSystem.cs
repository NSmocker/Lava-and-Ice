using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckSystem : MonoBehaviour
{
    public CharacterController hitbox;
    public Transform visual_model;
    public bool is_grounded;
    public Vector3 offset;
    public int layer_mask;
    public Transform hit_point;
    // Start is called before the first frame update
    void Start()
    {
        layer_mask = LayerMask.GetMask("Default");
    }


    public void RecenterGroundedSystem(Vector3 new_position) 
    {
        transform.position = new_position;
    }
    // Update is called once per frame
    void Update()
    {
       
        RaycastHit hit_info;
        is_grounded = Physics.SphereCast(transform.position + offset, hitbox.radius, Vector3.down, out hit_info, 1,layer_mask);
        hit_point.gameObject.SetActive(is_grounded);
        if (is_grounded) 
        {
            hit_point.position = hit_info.point;
            Debug.Log("Hited " + hit_info.collider.name);
        }
    }
     
}
