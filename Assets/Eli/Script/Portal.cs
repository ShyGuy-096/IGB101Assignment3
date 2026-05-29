using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject portal;

    private void Update()
    {
        if (GameManager.instance.levelComplete)
        {
           portal.SetActive(true);
        }
    }
}
