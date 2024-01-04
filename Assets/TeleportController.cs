using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class TeleportController : MonoBehaviour
{
    public InputActionReference teleportActivationReference;
    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancel;

    private void Start()
    {
        teleportActivationReference.action.performed += TeleportModeActivate;
        teleportActivationReference.action.canceled += TeleportModeCancel;
    }

    private void TeleportModeActivate(InputAction.CallbackContext obj) => onTeleportActivate.Invoke();
    private void TeleportModeCancel(InputAction.CallbackContext obj) => Invoke(nameof(DeactivateTeleporter), 0.1f);
    private void DeactivateTeleporter() => onTeleportCancel.Invoke();
}
