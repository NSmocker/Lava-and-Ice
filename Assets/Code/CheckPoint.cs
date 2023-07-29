using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public void OnTriggerEnter(Collider touched_collider)
    {
        if(touched_collider.gameObject.name == "Respawn System")
        {
            /*
            var respawn_link = touched_collider.gameObject.
            GetComponent<CharacterRespawnSystem>();
            respawn_link.ChangeRespawnObject(this.transform);
            */
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
