using UnityEngine;

public class CubeRotate : RotateBob
{
    //[SerializeField] private float rotateSpeed = 50;

    // Update is called once per frame
    void Update()
    {
        Rotate3Axes(rotateSpeed, rotateSpeed, rotateSpeed);
        Bob(bobbingHeight, bobbingSpeed, yOffset);
    }
}