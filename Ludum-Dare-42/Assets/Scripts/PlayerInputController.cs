using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    private PlayerMovementController movementController;

    private float horizontal;
    private float vertical;

    private void Start()
    {
        movementController = GetComponent<PlayerMovementController>();
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, vertical);

        movementController.MovePlayer(direction);
    }
}