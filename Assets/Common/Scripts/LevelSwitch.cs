using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    public string nextLevel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            if (GameManager.instance.levelComplete)
            {
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
}
