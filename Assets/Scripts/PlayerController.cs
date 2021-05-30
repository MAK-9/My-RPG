using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public LayerMask movementMask;
    private PlayerMotor motor;
    
    private Camera cam;
    public ControlsManager controlsManager;
    
    private void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    private void Update()
    {
        //cast a ray
        if (controlsManager.MouseLeftClickIsBeingPressedThisFrame())
        {
            Ray ray = cam.ScreenPointToRay(controlsManager.GetMousePosition());
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                // move player to hit location
                motor.MoveToPoint(hit.point);
                //stop focusing any object
            }
        }
        if (controlsManager.MouseRightClickPressedThisFrame())
        {
            Ray ray = cam.ScreenPointToRay(controlsManager.GetMousePosition());
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                //check if we hit interactable
            }
        }
    }
}
