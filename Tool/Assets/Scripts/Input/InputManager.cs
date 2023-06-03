using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance
    {
        get;
        private set;
    }

    private PlayerInputAction playerInputAction;

    private void Awake() 
    {
        Instance = this;

        playerInputAction = new PlayerInputAction();    
        playerInputAction.Player.Enable();
    }

    public Vector2 GetMovementInput()
    {
        Vector2 inputVector = playerInputAction.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;

        return inputVector;
    }
}
