using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlsManager : MonoBehaviour
{
    public static ControlsManager instance;

    private Controls controls;

    private void Awake()
    {
        controls = new Controls();
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    public bool MouseLeftClickIsBeingPressedThisFrame()
    {
        return controls.Mouse.LeftClick.phase == InputActionPhase.Started;
    }

    public bool MouseRightClickPressedThisFrame()
    {
        return controls.Mouse.RightClick.triggered;
    }

    public Vector2 GetMousePosition()
    {
        return controls.Mouse.CursorPosition.ReadValue<Vector2>();
    }

    public float GetScrollWheelAxis()
    {
        return controls.Mouse.ScrollWheel.ReadValue<float>();
    }

    public float GetYawAxis()
    {
        return controls.Mouse.Yaw.ReadValue<float>();
    }

    public bool MouseMiddleClickIsBeingPressed()
    {
        return controls.Mouse.MiddleClick.phase == InputActionPhase.Started;
    }

    public bool InventoryToggled()
    {
        return controls.Keyboard.InventoryToggle.triggered;
    }
}
