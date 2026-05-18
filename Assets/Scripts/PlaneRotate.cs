using UnityEngine;

public class PlaneRotate : RotateBob
{
    //[SerializeField] private float rotateSpeed = 50;

    // Update is called once per frame
    void Update()
    {
        Rotate3Axes(transform.rotation.x, rotateSpeed, transform.rotation.z);
        Bob(bobbingHeight, bobbingSpeed, yOffset);
    }
}
