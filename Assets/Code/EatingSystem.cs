using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingSystem : MonoBehaviour
{
    public GemSystem gem_system;
    AudioSource source;
    public AudioClip eat_gem_clip, eat_apple_clip;
    // Start is called before the first frame update
    void Start()
    {
        gem_system = GameObject.Find("Gem System").GetComponent<GemSystem>();
        source = GetComponent<AudioSource>();   
    }

    public void OnTriggerEnter(Collider other)
    {
        if (gameObject.name.Contains("[Lava]") && other.name.Contains("Lava Gem"))
        {
            gem_system.lava_gems++;
            Destroy(other.gameObject);
            source.PlayOneShot(eat_gem_clip);
        }
        if (gameObject.name.Contains("[Ice]") && other.name.Contains("Ice Gem"))
        {
            gem_system.lava_gems++;
            Destroy(other.gameObject);
            source.PlayOneShot(eat_gem_clip);
        }
        if (other.name.Contains("Apple"))
        {
            
            Destroy(other.gameObject);
            source.PlayOneShot(eat_apple_clip);
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
