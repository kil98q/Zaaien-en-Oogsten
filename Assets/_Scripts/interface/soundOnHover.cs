using UnityEngine;
using System.Collections;

//plays the sound in the audiosource
public class soundOnHover : MonoBehaviour {

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// plays the sound in the audio source.
    /// </summary>
	public void PlaySound()
    {
        audioSource.Play();
    }
}
