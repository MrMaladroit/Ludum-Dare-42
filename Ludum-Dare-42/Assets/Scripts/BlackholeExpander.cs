using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackholeExpander : MonoBehaviour
{
    [SerializeField]
    private float growthRate = 0.002f;

    private Transform blackholeGraphic;

    private void Start()
    {
        blackholeGraphic = GetComponentInChildren<Transform>();
    }

    private void FixedUpdate()
    {
        Vector3 blackholeScale = new Vector3(growthRate, growthRate);
        blackholeGraphic.transform.localScale += blackholeScale;
    }
}