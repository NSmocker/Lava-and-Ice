using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class VRButton : MonoBehaviour
{
    public UnityEvent on_button_touch;
    void OnTriggerEnter(Collider info)
    {
       
        if(info.gameObject.name=="Pointer" || info.gameObject.tag =="MainCamera" )
        {   
            on_button_touch.Invoke();
        }
         GetComponent<Collider>().enabled = false;
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
