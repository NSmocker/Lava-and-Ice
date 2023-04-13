using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{


    void OnTriggerEnter(Collider touched_collider)
    {
        if(touched_collider.gameObject.name == "Respawn System")
        {
            touched_collider.gameObject.GetComponent<CharacterRespawnSystem>().Respawn();
        }
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
