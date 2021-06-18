using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public Interactable focus;
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
                RemoveFocus();
            }
        }
        if (controlsManager.MouseRightClickPressedThisFrame())
        {
            Ray ray = cam.ScreenPointToRay(controlsManager.GetMousePosition());
            RaycastHit hit;
            //check if we hit interactable
            if (Physics.Raycast(ray, out hit, 100))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                // set our focus to interactable
                if (interactable != null)
                {
                    SetFocus(interactable);
                }
            }
        }
    }

    void SetFocus(Interactable newFocus)
    {
        if (newFocus != focus)
        {
            if(focus != null)
                focus.OnDefocused();
            
            focus = newFocus;
            motor.FollowTarget(newFocus);
        }
        
        newFocus.OnFocused(transform);
    }

    void RemoveFocus()
    {
        if(focus != null)
            focus.OnDefocused();
        
        focus = null;
        motor.StopFollowingTarget();
    }
}
