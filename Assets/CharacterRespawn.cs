using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRespawn : MonoBehaviour
{
    public Transform respawn_object;
    public Transform character_object;
    public AudioClip check_point_sfx;

    
    public void Respawn()
    {
        character_object.GetComponent<CharacterController>().enabled = false;
        character_object.position = respawn_object.position;
        character_object.GetComponent<CharacterController>().enabled = true;
    }

    public void ChangeRespawnObject(Transform object_to_set)
    {
        if(object_to_set!=respawn_object)
        {
            respawn_object = object_to_set;
            GetComponent<AudioSource>().PlayOneShot(check_point_sfx);
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
