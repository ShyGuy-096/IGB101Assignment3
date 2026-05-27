using UnityEngine;
using UnityEngine.UIElements;

public class FloatingText : MonoBehaviour
{
    Transform PlayerCamera;
    Transform unit;
    Transform ThisIsFineCanvas;

    public Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerCamera = Camera.main.transform;
        unit = transform.parent;
        GameObject targetCanvasObject = GameObject.Find("ThisIsFineCanvas");

        if (targetCanvasObject != null)
        {
            ThisIsFineCanvas = targetCanvasObject.transform;
            transform.SetParent(ThisIsFineCanvas);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (unit != null)
        {
            if (PlayerCamera != null)
            {
                transform.rotation = Quaternion.LookRotation(transform.position - PlayerCamera.transform.position);
            }
            transform.position = unit.position + offset;
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
