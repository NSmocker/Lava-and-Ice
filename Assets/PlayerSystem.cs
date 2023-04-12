using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSystem : MonoBehaviour
{
    public Character character_to_controll;
    public PlayerXRLocomotionSystem player_xr_locomotion_system;
    public TrackablesLibrary trackables_library;
    public TrackableModelAttacherSystem model_attacher_system;






    // Start is called before the first frame update
    void Start()
    {
        model_attacher_system.character_avatar_system = character_to_controll.avatar_system;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        if(character_to_controll != null) 
        {
            transform.position = character_to_controll.transform.position;
            character_to_controll.RecenterHitBoxByXRPlayer(player_xr_locomotion_system.head_object.transform.localPosition);
            
        }
    }
}
