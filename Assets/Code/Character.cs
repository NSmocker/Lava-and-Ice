using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterController hitbox;
    public CCMovementSystem movement_system;
    public GroundCheckSystem ground_check_system;
    public CharacterRespawnSystem respawn_system;
    public CharacterAvatarSystem avatar_system;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void RecenterHitBoxByXRPlayer(Vector3 new_hitbox_center) 
    {
        hitbox.center = new_hitbox_center;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
