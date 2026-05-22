using UnityEngine;

public class ExitSignRotate : RotateBob
{
    // Update is called once per frame
    void Update()
    {
        Rotate3Axes(transform.rotation.x, rotateSpeed, transform.rotation.z);
        transform.Rotate(-90, 0, 0); // Apply -90 rotation on x, since the exit sign model is rotated the wrong way by default
        Bob(bobbingHeight, bobbingSpeed, yOffset);
    }
}
