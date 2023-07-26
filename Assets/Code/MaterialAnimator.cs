using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialAnimator : MonoBehaviour
{
    public Material material_to_animate;
    public Vector2 scroll_speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = Time.time * scroll_speed;
        material_to_animate.mainTextureOffset = offset;
    }
}
