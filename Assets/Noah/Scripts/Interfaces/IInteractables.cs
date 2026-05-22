using UnityEngine;

public interface IInteractables
{
    // The following code was taken from the following YouTube tutorial: https://www.youtube.com/watch?v=xQciOlbRtUQ

    public string InteractMessage { get; }
    public void Interact();
}
