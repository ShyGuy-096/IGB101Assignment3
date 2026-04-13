using UnityEngine;

public class PlaneRotate : RotateBob
{
    //[SerializeField] private float rotateSpeed = 50;

    // Update is called once per frame
    void Update()
    {
        Rotate3Axes(0, rotateSpeed, 0);
        Bob(bobbingHeight, bobbingSpeed, yOffset);
    }
}
