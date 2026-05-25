using System.Linq;
using UnityEngine;

public class ExitSign : MonoBehaviour
{
    [SerializeField] private Material GreenSignMaterial;

    // Update is called once per frame
    void Update()
    {
        UpdateSignColour();
    }

    void UpdateSignColour()
    {
        if (GameManager.instance.levelComplete)
        {
            GetComponent<Renderer>().material = GreenSignMaterial;
        }
    }
}
