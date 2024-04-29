using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandlerManual : MonoBehaviour
{
    private InputAction m_moveAction;

    private void Awake()
    {
        m_moveAction = InputSystem.actions.FindAction("Move");
    }

    private void OnEnable()
    {
        // m_moveAction.Enable();  // Not needed if uisng defualt Input Action Asset
        m_moveAction.started += OnMoveStarted;
        // m_moveAction.performed += OnMove;
        m_moveAction.canceled += OnMoveCanceled;
    }
    
    private void OnDisable()
    {
        // m_moveAction.Disable();  // Not needed if uisng defualt Action Asset
        m_moveAction.started -= OnMoveStarted;
        // m_moveAction.performed -= OnMove;
        m_moveAction.canceled -= OnMoveCanceled;
    }
    
    private void OnMoveStarted(InputAction.CallbackContext context)
    {
        Debug.Log("Move Started");
        Vector2 input = context.ReadValue<Vector2>();
        Debug.Log("Move: " + input);
    }
    
    private void OnMoveCanceled(InputAction.CallbackContext context)
    {
        Debug.Log("Move Canceled");
        Vector2 input = context.ReadValue<Vector2>();
        Debug.Log("Move: " + input);
    }
}
