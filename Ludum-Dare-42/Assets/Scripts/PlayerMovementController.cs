using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 10;
    private Transform player;


    private void Start()
    {
        player = this.gameObject.transform;
    }

    public void MovePlayer(Vector3 direction)
    {
        player.transform.position += direction * movementSpeed * Time.deltaTime;
    }
}