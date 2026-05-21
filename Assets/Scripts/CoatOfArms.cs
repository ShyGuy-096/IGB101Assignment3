using UnityEngine;

public class CoatOfArms : RotateBob
{
    // Update is called once per frame
    void Update()
    {
        Bob(bobbingHeight, bobbingSpeed, yOffset);
    }
}
