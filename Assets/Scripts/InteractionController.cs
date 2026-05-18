using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionController : MonoBehaviour
{
    // The following code was taken from the following YouTube tutorial: https://www.youtube.com/watch?v=xQciOlbRtUQ

    [SerializeField] private Camera camera;
    [SerializeField] private TextMeshProUGUI interactionTxt;
    [SerializeField] private float interactionDistance = 5f;

    IInteractables currentTargetedInteractable;

    public void Update()
    {
        UpdateCurrentInteractable();

        UpdateInteractionTxt();

        CheckForInteractionInput();
    }

    private void UpdateCurrentInteractable()
    {
        Ray playerRay = camera.ViewportPointToRay(new Vector2(0.5f, 0.5f));

        Physics.Raycast(playerRay, out RaycastHit hit, interactionDistance);

        currentTargetedInteractable = hit.collider?.GetComponent<IInteractables>();
    }

    void UpdateInteractionTxt()
    {
        if (currentTargetedInteractable == null)
        {
            interactionTxt.text = string.Empty;
            return;
        }

        interactionTxt.text = currentTargetedInteractable.InteractMessage;
    }

    private void CheckForInteractionInput()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame && currentTargetedInteractable != null)
        {
            currentTargetedInteractable.Interact();
        }
    }
}
