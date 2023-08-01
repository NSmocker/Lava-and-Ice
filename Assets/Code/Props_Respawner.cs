using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Props_Respawner : MonoBehaviour
{
    public Vector3 respawn_position;
    void OnCollisionEnter(Collision touch)
    {
        if(touch.collider.name == "KilingFloor")
        {
            transform.position = respawn_position;
            touch.collider.attachedRigidbody.velocity = Vector3.zero;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        respawn_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
