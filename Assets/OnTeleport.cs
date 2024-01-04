using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class OnTeleport : MonoBehaviour
{
    public InputActionReference teleportActivationReference;

    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancel;
    // Start is called before the first frame update
    void Start()
    {
        teleportActivationReference.action.performed += TeleportModeActivate;
        teleportActivationReference.action.canceled += TeleportModeCancel;
    }

    private void TeleportModeActivate(InputAction.CallbackContext obj) => onTeleportActivate.Invoke();
    private void TeleportModeCancel(InputAction.CallbackContext obj) => onTeleportCancel.Invoke();
}
