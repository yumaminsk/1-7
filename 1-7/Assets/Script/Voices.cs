using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voices : MonoBehaviour
{
    public float time;
    public List<AudioClip> VoicesSound;
    public AudioSource AudioVoice;
    // Start is called before the first frame update
    void Start()
    {
        time = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0)
        {
            time = Random.Range(10, 20);
            int a = Random.Range(0, 10); Debug.Log(a);
            AudioVoice.PlayOneShot(VoicesSound[a]);
        }
    }
}
