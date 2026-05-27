using UnityEngine;

public class DoorTest : MonoBehaviour
{
    private Animation dooranimation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dooranimation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
            dooranimation.Play();
    }
}
