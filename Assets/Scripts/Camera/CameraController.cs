using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Target;

    public Vector3 Offset;

    public float ZoomSpeed = 4f;
    public float MinZoom = 5f;
    public float MaxZoom = 15f;

    public float YawSpeed = 100f;

    public float Pitch = 2f;

    private float currentZoom = 10f;
    private float currentYaw = 0f;

    private void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * ZoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, MinZoom, MaxZoom);

        currentYaw -= Input.GetAxis("Horizontal") * YawSpeed * Time.deltaTime;
    }

    private void LateUpdate ()
    {
        transform.position = Target.position - Offset * currentZoom;
        transform.LookAt(Target.position + Vector3.up * Pitch);

        transform.RotateAround(Target.position, Vector3.up, currentYaw);
	}
}
