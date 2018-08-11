using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackholeCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}