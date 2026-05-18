using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Singleton Setup
    public static AudioManager instance = null;
    public AudioSource audioSource;

    // Awake Checks - Singleton setup
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
    }

    /// <summary>
    /// Plays an Audio Clip with pitch variance
    /// </summary>
    /// <param name="audioClip">Audio clip to be played</param>
    /// <param name="pitchVariance">how much the pitch of the audio played should be varied by</param>
    /// <param name="location">how much the pitch of the audio played should be varied by</param>
    public void PlaySound(AudioClip audioClip, float pitchVariance = 0.1f)
    {
        float randomPitch = Random.Range(1.0f - pitchVariance, 1.0f + pitchVariance);

        audioSource.clip = audioClip;
        audioSource.pitch = randomPitch;
        audioSource.PlayOneShot(audioClip);
    }    
}
