using UnityEngine;

public class TV : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

public GameObject reset;
void Start()
    {
        reset.SetActive(false);
    }
    public GameObject tvScreen;
    public GameObject tvSound;

    void OnTriggerEnter(Collider collider)
    {
        tvScreen.SetActive(true);
        tvSound.SetActive(true);

    }
}