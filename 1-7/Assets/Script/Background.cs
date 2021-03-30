using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public List<AudioClip> AudioBackground;
    public AudioSource SourceBackground;
    public int audioCount = 0;
    void Start()
    {
        SourceBackground.PlayOneShot(AudioBackground[audioCount]);
    }

    // Update is called once per frame
    void Update()
    {
        if (SourceBackground.isPlaying == false)
        {
            if(audioCount == 3)
            {
                audioCount = 0;
            }
            if(audioCount <= 2)
            {
                SourceBackground.PlayOneShot(AudioBackground[audioCount]);
                audioCount++;
            }
        }
    }
}
