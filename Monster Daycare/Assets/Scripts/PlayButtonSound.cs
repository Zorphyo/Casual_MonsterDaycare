using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonSound : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip closeMenu;
    public AudioClip openMenu;
    public AudioClip highlightMenu;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayCloseMenu()
    {
        audioSource.PlayOneShot(closeMenu);
    }
    public void PlayOpenMenu()
    {
        audioSource.PlayOneShot(openMenu);
    }

    public void PlayHighlightMenu()
    {
        audioSource.PlayOneShot(highlightMenu);
    }
}
