using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandlerMessage : MonoBehaviour
{
    void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        Debug.Log("Move: " + input);
    }
}
