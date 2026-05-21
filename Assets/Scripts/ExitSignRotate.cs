using UnityEngine;

public class ExitSignRotate : RotateBob
{
    // Update is called once per frame
    void Update()
    {
        Rotate3Axes(rotateSpeed, transform.rotation.y + 90, transform.rotation.z + 90);
        Bob(bobbingHeight, bobbingSpeed, yOffset);
    }
}
