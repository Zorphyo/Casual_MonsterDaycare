using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private bool isPlayingMenuMusic;
    private AudioSource menuTrack, shopTrack;

    public AudioClip menuMusic;
    public static AudioManager instance;

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        menuTrack = gameObject.AddComponent<AudioSource>();
        shopTrack = gameObject.AddComponent<AudioSource>();
        isPlayingMenuMusic = true;

        SwapTrack(menuMusic);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwapTrack(AudioClip clip)
    {
        if (isPlayingMenuMusic)
        {
            shopTrack.clip = clip;
            shopTrack.loop = true;
            shopTrack.Play();
            menuTrack.Stop();
        }

        else
        {
            menuTrack.clip = clip;
            menuTrack.loop = true;
            menuTrack.Play();
            shopTrack.Stop();
        }

        isPlayingMenuMusic = !isPlayingMenuMusic;
    }
}
