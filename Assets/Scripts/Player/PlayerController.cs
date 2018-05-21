using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public LayerMask MovementMask;

    private Camera cam;
    private PlayerMotor motor;

	private void Start ()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
	}

	private void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, MovementMask))
            {
                motor.MoveToPoint(hit.point);
                //Stop focussing any objects.
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                //Check if we hit an interactable
                //If we did set it as our focus
            }
        }
    }
}
