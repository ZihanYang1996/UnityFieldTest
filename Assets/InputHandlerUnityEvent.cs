using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandlerUnityEvents: MonoBehaviour
{
    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Move Started");
            Vector2 input = context.ReadValue<Vector2>();
            Debug.Log("Move: " + input);
        }
        else if (context.performed)
        {
            Debug.Log("Move Performed");
            Vector2 input = context.ReadValue<Vector2>();
            Debug.Log("Move: " + input);
        }
        else if (context.canceled)
        {
            Debug.Log("Move Canceled");
            Vector2 input = context.ReadValue<Vector2>();
            Debug.Log("Move: " + input);
        }
        
    }
}
