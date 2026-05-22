using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            GameManager.instance.currentPickups += 1;
            Destroy(this.gameObject);
        }
    }
}
