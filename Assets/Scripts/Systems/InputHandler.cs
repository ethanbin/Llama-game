using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// This class will allow extra custom functionality of Input Actions. 
/// For example, getting an input value on frame instead of on Event:
///     Debug.Log(playerInput.currentActionMap.FindAction("Move").ReadValue<Vector2>().normalized);
/// </summary>
public class InputHandler : MonoBehaviour
{
    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }
}
