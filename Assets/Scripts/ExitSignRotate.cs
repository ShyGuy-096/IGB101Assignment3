using UnityEngine;

public class ExitSignRotate : RotateBob
{
    // Update is called once per frame
    void Update()
    {
        Rotate3Axes(transform.rotation.x, transform.rotation.y, rotateSpeed);
        Bob(bobbingHeight, bobbingSpeed, yOffset);
    }

    protected void Rotate3Axes(float xRotateSpeed = 20, float yRotateSpeed = 20, float zRotateSpeed = 20)
    {
        currentVector += new Vector3(xRotateSpeed * Time.deltaTime, yRotateSpeed * Time.deltaTime, zRotateSpeed * Time.deltaTime);
        this.transform.eulerAngles = currentVector;
    }
}
