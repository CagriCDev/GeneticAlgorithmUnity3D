using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSource : MonoBehaviour
{
    public AudioClip clip;
    AudioSource AudioSc;
    // Start is called before the first frame update
    void Start()
    {
        AudioSc = GetComponent<AudioSource>();
       // AudioSc.Play(clip.);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
