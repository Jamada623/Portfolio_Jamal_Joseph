using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
        
    }
    void Start()
    {
        Play("BGM");
    }

    // Update is called once per frame
    public void Play (string name)
    {
        //loop throw the array of sounds in the controller and play the corresponding sound
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found.");
            return;
        }
        s.source.Play();
    }
}
