using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //Singleton Setup
    public static GameManager instance = null;

    [Header("Level Progression")]
    public int currentPickups = 0;
    public int maxPickups = 9;
    public bool levelComplete = false;
    public Text pickupText;
    
    [Header("Object References")]
    public GameObject player;

    //Audio Proximity Logic
    public AudioSource[] audioSources;
    public float audioProximity = 5.0f;

    // Awake Checks - Singleton setup
    private void Awake()
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

    private void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
        PlayAudioSamples();
    }

    private void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
        {
            levelComplete = true;
        }
        else
        {
            levelComplete = false;
        }
    }

    private void UpdateGUI()
    {
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
    }

    private void PlayAudioSamples() 
    {
        for (int i = 0; i < audioSources.Length; i++)
        {
            if (audioSources[i] == null) continue;
            if (Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity)
            {
                if (!audioSources[i].isPlaying)
                {
                    audioSources[i].Play();
                }
            }
        }
    }

}