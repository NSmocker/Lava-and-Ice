using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class GrabSystem : MonoBehaviour
{
    public GameObject grabed_item;

    public InputActionReference grab_reference;
    public GameObject hovered;

    private void OnEnable()
    {
        grab_reference.action.performed += TryGrabItem;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ForGrab") 
        {
            hovered = other.gameObject;
           // print("Hover on" + other.name);
        }    
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "ForGrab")
        {
           // print("Exit from" + other.name);
            if (hovered == other.gameObject) hovered = null;
        }
    }


    public void TryGrabItem(InputAction.CallbackContext obj) 
    {
        if (grabed_item == null) 
        {
            if (hovered != null) 
            {
                grabed_item = hovered;
                grabed_item.AddComponent(typeof(FixedJoint));
                grabed_item.GetComponent<Rigidbody>().isKinematic = false;
                var joint = grabed_item.GetComponent<FixedJoint>();
                joint.connectedBody = GetComponent<Rigidbody>();

            }
        }
        else 
        {
            PutDownItem();
        }
    }
    public void PutDownItem() 
    {
        
        Destroy(grabed_item.GetComponent<FixedJoint>());
        grabed_item = null;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
