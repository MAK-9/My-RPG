using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private ControlsManager controlsManager;
    public Transform target;

    public Vector3 offset;
    public float pitch = 2f;
    public float zoomSpeed = .05f;
    public float minZoom = 5f;
    public float maxZoom = 15f;
    private float currentZoom = 10f;
    public float yawSpeed = 100f;

    private float currentYaw = 0f;

    private void Awake()
    {
        controlsManager = GameObject.Find("ControlsManager").GetComponent<ControlsManager>();
    }

    private void Update()
    {
        currentZoom -= controlsManager.GetScrollWheelAxis() * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

        if (controlsManager.MouseMiddleClickIsBeingPressed())
        {
            currentYaw += controlsManager.GetYawAxis() * yawSpeed * Time.deltaTime;
        }
    }

    private void LateUpdate()
    {
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.up*pitch);
        
        transform.RotateAround(target.position, Vector3.up, currentYaw);
    }
}
