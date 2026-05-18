using UnityEngine;
using UnityEngine.Audio;

public class Button : MonoBehaviour, IInteractables
{
    public string InteractMessage => objectInteractMessage;

    [SerializeField] private GameObject colourObject;
    [SerializeField] private Color32[] colours;
    [SerializeField] private AudioClip buttonAudio;
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private string objectInteractMessage;

    public void Interact()
    {
        ChangeColour();
        AudioManager.instance.PlaySound(buttonAudio);
    }

    void ChangeColour()
    {
        colourObject.GetComponent<Renderer>().material.color = colours[Random.Range(0, colours.Length)];
    }

    
}
