using UnityEngine;

public class RotateBob: MonoBehaviour
{
    [SerializeField] protected float rotateSpeed = 50;

    [SerializeField] protected float bobbingHeight = 0.06f;
    [SerializeField] protected float bobbingSpeed = 3.5f;
    [SerializeField] protected float yOffset = 0.8f;

    private Vector3 currentVector;

    //// Update is called once per frame
    //void Update()
    //{
    //    Rotate3Axes(rotateSpeed, rotateSpeed, rotateSpeed);

    //}

    /// <summary>
    /// Rotates the object along the 3 axes at the specified speeds
    /// </summary>
    /// <param name="xRotateSpeed"></param>
    /// <param name="yRotateSpeed"></param>
    /// <param name="zRotateSpeed"></param>
    protected void Rotate3Axes(float xRotateSpeed = 20, float yRotateSpeed = 20, float zRotateSpeed = 20)
    {
        currentVector += new Vector3(xRotateSpeed * Time.deltaTime, yRotateSpeed * Time.deltaTime, zRotateSpeed * Time.deltaTime);
        this.transform.eulerAngles = currentVector;
    }

    protected void Bob(float bobHeight = 0.06f, float bobbingSpeed = 3.5f, float yOffset = 0.8f)
    {
        Vector2 bobbingVector = Vector3.up * Mathf.Cos(Time.time * bobbingSpeed) * bobHeight + new Vector3(0, yOffset, 0);
        transform.position = new Vector3(transform.position.x, bobbingVector.y, transform.position.z);
    }
}
