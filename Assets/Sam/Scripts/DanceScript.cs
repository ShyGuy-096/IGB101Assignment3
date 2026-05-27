using UnityEngine;

public class DanceScript : MonoBehaviour
{
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null) Debug.LogError("Missing Animator on this Object");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.Play("Dance");
            //Debug.Log("R Key was pressed");
            //animator.SetBool("Dance", true);
        }
        //else if (Input.GetKeyUp(KeyCode.R))
        {
            //Debug.Log("R Key was released");
            //animator.SetBool("Dance", false);
        }
    }
}
