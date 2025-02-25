using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Camera mainCamera;
    private InputHandler inputHandler;

    void Start() {
        mainCamera = Camera.main;
        inputHandler = FindFirstObjectByType<InputHandler>();
        // inputHandler.OnClick += OnClick;
    }

    void Update()
    {
        
    }

    public void Shoot(InputAction.CallbackContext context) {
        Debug.Log("clicked");
        // var rayHit1 = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(mousePosition));
        // var rayHit2 = mainCamera.ScreenPointToRay(mousePosition);
        // GameObject o = Instantiate(Resources.Load("Enemy") as GameObject);
        // o.transform.position = mousePosition;
        // Debug.DrawRay(rayHit2.origin, rayHit2.direction * 100, Color.white, 110.0f);
    }
}
