
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float Radius = 3f;
    public Transform InteractionTransform;

    private bool isFocus = false;
    private Transform player;

    private bool hasInteracted = false;

    public virtual void Interact()
    {
        //This method is meant to be overwritten
        Debug.Log("Interaction with " + transform.name);
    }

    private void Update()
    {
        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(InteractionTransform.position, player.position);
            if (distance <= Radius)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }

    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = false;
    }

    public void OnDeFocused()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(InteractionTransform.position, Radius);
    }
}

